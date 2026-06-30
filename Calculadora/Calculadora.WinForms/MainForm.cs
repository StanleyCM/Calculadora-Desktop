using System.Globalization;
using Calculadora.Core;

namespace Calculadora.WinForms;

public partial class MainForm : Form
{
    private readonly CalculatorService _calculator = new();
    private decimal _leftOperand;
    private decimal _repeatOperand;
    private CalculatorOperation? _pendingOperation;
    private CalculatorOperation? _repeatOperation;
    private bool _startNewEntry = true;
    private bool _hasError;
    private float _displayMaximumFontSize;

    private const float DisplayReducedFontSize = 19f;

    public MainForm()
    {
        InitializeComponent();
        ConfigureCalculator();
        ClearCalculator();
    }

    private void ConfigureCalculator()
    {
        txtDisplay.ReadOnly = true;
        txtDisplay.ShortcutsEnabled = false;
        txtDisplay.TabStop = false;
        _displayMaximumFontSize = txtDisplay.Font.Size;
        txtDisplay.TextChanged += textBox1_TextChanged;

        foreach (Button numberButton in new[]
                 {
                     btn0, btn1, btn2, btn3, btn4,
                     btn5, btn6, btn7, btn8, btn9
                 })
        {
            numberButton.Click += NumberButton_Click;
        }

        btnPoint.Click += PointButton_Click;
        btnAC.Click += ClearButton_Click;
        btnPosNeg.Click += ToggleSignButton_Click;
        btnIgual.Click += EqualsButton_Click;

        btnMas.Click += OperationButton_Click;
        btnMenos.Click += OperationButton_Click;
        btnX.Click += OperationButton_Click;
        btnDiv.Click += OperationButton_Click;

        KeyPreview = true;
        KeyDown += MainForm_KeyDown;
    }

    private void NumberButton_Click(object? sender, EventArgs e)
    {
        if (sender is Button button)
        {
            EnterDigit(button.Text);
        }
    }

    private void EnterDigit(string digit)
    {
        if (_hasError)
        {
            ClearCalculator();
        }

        if (_startNewEntry)
        {
            txtDisplay.Text = digit;
            _startNewEntry = false;

            if (_pendingOperation is null)
            {
                _repeatOperation = null;
            }

            return;
        }

        if (txtDisplay.Text == "0")
        {
            txtDisplay.Text = digit;
        }
        else if (txtDisplay.Text.Length < 29)
        {
            txtDisplay.AppendText(digit);
        }
    }

    private void PointButton_Click(object? sender, EventArgs e) => EnterDecimalPoint();

    private void EnterDecimalPoint()
    {
        if (_hasError)
        {
            ClearCalculator();
        }

        if (_startNewEntry)
        {
            txtDisplay.Text = "0.";
            _startNewEntry = false;

            if (_pendingOperation is null)
            {
                _repeatOperation = null;
            }

            return;
        }

        if (!txtDisplay.Text.Contains('.'))
        {
            txtDisplay.AppendText(".");
        }
    }

    private void OperationButton_Click(object? sender, EventArgs e)
    {
        if (sender == btnMas)
        {
            SelectOperation(CalculatorOperation.Add);
        }
        else if (sender == btnMenos)
        {
            SelectOperation(CalculatorOperation.Subtract);
        }
        else if (sender == btnX)
        {
            SelectOperation(CalculatorOperation.Multiply);
        }
        else if (sender == btnDiv)
        {
            SelectOperation(CalculatorOperation.Divide);
        }
    }

    private void SelectOperation(CalculatorOperation operation)
    {
        if (_hasError)
        {
            return;
        }

        decimal currentValue = ReadDisplay();

        if (_pendingOperation is not null && !_startNewEntry)
        {
            if (!TryCalculate(_leftOperand, currentValue, _pendingOperation.Value, out decimal result))
            {
                return;
            }

            _leftOperand = result;
            ShowValue(result);
        }
        else if (_pendingOperation is null)
        {
            _leftOperand = currentValue;
        }

        _pendingOperation = operation;
        _repeatOperation = null;
        _startNewEntry = true;
    }

    private void EqualsButton_Click(object? sender, EventArgs e) => CalculateResult();

    private void CalculateResult()
    {
        if (_hasError)
        {
            return;
        }

        decimal currentValue = ReadDisplay();

        if (_pendingOperation is not null)
        {
            CalculatorOperation operation = _pendingOperation.Value;
            decimal rightOperand = _startNewEntry ? _leftOperand : currentValue;

            if (!TryCalculate(_leftOperand, rightOperand, operation, out decimal result))
            {
                return;
            }

            ShowValue(result);
            _repeatOperation = operation;
            _repeatOperand = rightOperand;
            _pendingOperation = null;
            _startNewEntry = true;
            return;
        }

        if (_repeatOperation is not null &&
            TryCalculate(currentValue, _repeatOperand, _repeatOperation.Value, out decimal repeatedResult))
        {
            ShowValue(repeatedResult);
            _startNewEntry = true;
        }
    }

    private void ClearButton_Click(object? sender, EventArgs e) => ClearCalculator();

    private void ClearCalculator()
    {
        _leftOperand = 0m;
        _repeatOperand = 0m;
        _pendingOperation = null;
        _repeatOperation = null;
        _startNewEntry = true;
        _hasError = false;
        txtDisplay.Text = "0";
    }

    private void btnDel_Click(object sender, EventArgs e) => DeleteLastDigit();

    private void DeleteLastDigit()
    {
        if (_hasError)
        {
            ClearCalculator();
            return;
        }

        if (_startNewEntry)
        {
            return;
        }

        string display = txtDisplay.Text;
        display = display.Length > 1 ? display[..^1] : "0";

        if (display is "" or "-")
        {
            display = "0";
        }

        txtDisplay.Text = display;
        _startNewEntry = display == "0";
    }

    private void ToggleSignButton_Click(object? sender, EventArgs e)
    {
        if (_hasError)
        {
            ClearCalculator();
            return;
        }

        ShowValue(_calculator.ToggleSign(ReadDisplay()));
        _startNewEntry = false;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (_hasError)
        {
            return;
        }

        try
        {
            decimal percentage = _calculator.Percentage(ReadDisplay());

            if (_pendingOperation is CalculatorOperation.Add or CalculatorOperation.Subtract)
            {
                percentage = _calculator.Multiply(_leftOperand, percentage);
            }

            ShowValue(percentage);
            _startNewEntry = false;
        }
        catch (OverflowException)
        {
            ShowError();
        }
    }

    private bool TryCalculate(
        decimal firstNumber,
        decimal secondNumber,
        CalculatorOperation operation,
        out decimal result)
    {
        try
        {
            result = _calculator.Calculate(firstNumber, secondNumber, operation);
            return true;
        }
        catch (DivideByZeroException)
        {
            result = 0m;
            ShowError();
            return false;
        }
        catch (OverflowException)
        {
            result = 0m;
            ShowError();
            return false;
        }
    }

    private decimal ReadDisplay() =>
        decimal.TryParse(
            txtDisplay.Text,
            NumberStyles.Number,
            CultureInfo.InvariantCulture,
            out decimal value)
            ? value
            : 0m;

    private void ShowValue(decimal value)
    {
        txtDisplay.Text = value.ToString("G29", CultureInfo.InvariantCulture);
    }

    private void ShowError()
    {
        _leftOperand = 0m;
        _repeatOperand = 0m;
        _pendingOperation = null;
        _repeatOperation = null;
        _startNewEntry = true;
        _hasError = true;
        txtDisplay.Text = "SINTAXERROR";
    }

    private void MainForm_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode is >= Keys.D0 and <= Keys.D9)
        {
            EnterDigit(((int)e.KeyCode - (int)Keys.D0).ToString(CultureInfo.InvariantCulture));
        }
        else if (e.KeyCode is >= Keys.NumPad0 and <= Keys.NumPad9)
        {
            EnterDigit(((int)e.KeyCode - (int)Keys.NumPad0).ToString(CultureInfo.InvariantCulture));
        }
        else
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    SelectOperation(CalculatorOperation.Add);
                    break;
                case Keys.Subtract:
                    SelectOperation(CalculatorOperation.Subtract);
                    break;
                case Keys.Multiply:
                    SelectOperation(CalculatorOperation.Multiply);
                    break;
                case Keys.Divide:
                    SelectOperation(CalculatorOperation.Divide);
                    break;
                case Keys.Decimal:
                case Keys.OemPeriod:
                    EnterDecimalPoint();
                    break;
                case Keys.Enter:
                    CalculateResult();
                    break;
                case Keys.Back:
                    DeleteLastDigit();
                    break;
                case Keys.Escape:
                case Keys.Delete:
                    ClearCalculator();
                    break;
                default:
                    return;
            }
        }

        e.SuppressKeyPress = true;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
    }

    private void textBox1_TextChanged(object? sender, EventArgs e)
    {
        AdjustDisplayFontSize();
    }

    private void AdjustDisplayFontSize()
    {
        int digitCount = txtDisplay.Text.Count(char.IsDigit);
        float targetSize = digitCount > 8
            ? Math.Min(_displayMaximumFontSize, DisplayReducedFontSize)
            : _displayMaximumFontSize;

        if (Math.Abs(txtDisplay.Font.Size - targetSize) < 0.1f)
        {
            return;
        }

        Font previousFont = txtDisplay.Font;
        txtDisplay.Font = new Font(
            previousFont.FontFamily,
            targetSize,
            previousFont.Style,
            GraphicsUnit.Point);
        previousFont.Dispose();
    }
}
