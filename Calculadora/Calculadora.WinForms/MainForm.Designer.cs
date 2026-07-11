namespace Calculadora.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDel = new CircularButton();
            txtDisplay = new TextBox();
            btnDiv = new CircularButton();
            btnAC = new CircularButton();
            btnPorcent = new CircularButton();
            btn7 = new CircularButton();
            btn4 = new CircularButton();
            btn1 = new CircularButton();
            btnPosNeg = new CircularButton();
            btn8 = new CircularButton();
            btn9 = new CircularButton();
            btnX = new CircularButton();
            btn5 = new CircularButton();
            btn6 = new CircularButton();
            btnMenos = new CircularButton();
            btn2 = new CircularButton();
            btn3 = new CircularButton();
            btnMas = new CircularButton();
            btn0 = new CircularButton();
            btnPoint = new CircularButton();
            btnIgual = new CircularButton();
            btnPi = new CircularButton();
            btnParenthesis = new CircularButton();
            btnMC = new CircularButton();
            btnMR = new CircularButton();
            btnMPlus = new CircularButton();
            btnMMinus = new CircularButton();
            btnSquare = new CircularButton();
            btnLn = new CircularButton();
            btnLog = new CircularButton();
            btnInverse = new CircularButton();
            btnPower = new CircularButton();
            btnSqrt = new CircularButton();
            btnTan = new CircularButton();
            btnCos = new CircularButton();
            btnSin = new CircularButton();
            btnEuler = new CircularButton();
            btnAtan = new CircularButton();
            btnAcos = new CircularButton();
            btnAsin = new CircularButton();
            btnAngleMode = new CircularButton();
            SuspendLayout();
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ControlDark;
            btnDel.BackgroundImageLayout = ImageLayout.Stretch;
            btnDel.Cursor = Cursors.Hand;
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(36, 315);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(64, 64);
            btnDel.TabIndex = 12;
            btnDel.Text = "⌫";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.Desktop;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.Menu;
            txtDisplay.Location = new Point(36, 36);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.RightToLeft = RightToLeft.No;
            txtDisplay.Size = new Size(304, 64);
            txtDisplay.TabIndex = 20;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.ActiveCaption;
            btnDiv.BackgroundImageLayout = ImageLayout.Stretch;
            btnDiv.Cursor = Cursors.Hand;
            btnDiv.FlatAppearance.BorderSize = 0;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(279, 315);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(64, 64);
            btnDiv.TabIndex = 21;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            // 
            // btnAC
            // 
            btnAC.BackColor = SystemColors.ControlDark;
            btnAC.BackgroundImageLayout = ImageLayout.Stretch;
            btnAC.Cursor = Cursors.Hand;
            btnAC.FlatAppearance.BorderSize = 0;
            btnAC.FlatStyle = FlatStyle.Flat;
            btnAC.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAC.Location = new Point(115, 315);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(64, 64);
            btnAC.TabIndex = 22;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = false;
            // 
            // btnPorcent
            // 
            btnPorcent.BackColor = SystemColors.ControlDark;
            btnPorcent.BackgroundImageLayout = ImageLayout.Stretch;
            btnPorcent.Cursor = Cursors.Hand;
            btnPorcent.FlatAppearance.BorderSize = 0;
            btnPorcent.FlatStyle = FlatStyle.Flat;
            btnPorcent.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPorcent.Location = new Point(198, 315);
            btnPorcent.Name = "btnPorcent";
            btnPorcent.Size = new Size(64, 64);
            btnPorcent.TabIndex = 23;
            btnPorcent.Text = "%";
            btnPorcent.UseVisualStyleBackColor = false;
            btnPorcent.Click += button3_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlDarkDark;
            btn7.BackgroundImageLayout = ImageLayout.Stretch;
            btn7.Cursor = Cursors.Hand;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(36, 395);
            btn7.Name = "btn7";
            btn7.Size = new Size(64, 64);
            btn7.TabIndex = 24;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDarkDark;
            btn4.BackgroundImageLayout = ImageLayout.Stretch;
            btn4.Cursor = Cursors.Hand;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(36, 476);
            btn4.Name = "btn4";
            btn4.Size = new Size(64, 64);
            btn4.TabIndex = 25;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlDarkDark;
            btn1.BackgroundImageLayout = ImageLayout.Stretch;
            btn1.Cursor = Cursors.Hand;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(36, 557);
            btn1.Name = "btn1";
            btn1.Size = new Size(64, 64);
            btn1.TabIndex = 26;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btnPosNeg
            // 
            btnPosNeg.BackColor = SystemColors.ControlDarkDark;
            btnPosNeg.BackgroundImageLayout = ImageLayout.Stretch;
            btnPosNeg.Cursor = Cursors.Hand;
            btnPosNeg.FlatAppearance.BorderSize = 0;
            btnPosNeg.FlatStyle = FlatStyle.Flat;
            btnPosNeg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPosNeg.Location = new Point(36, 639);
            btnPosNeg.Name = "btnPosNeg";
            btnPosNeg.Size = new Size(64, 64);
            btnPosNeg.TabIndex = 27;
            btnPosNeg.Text = "+/-";
            btnPosNeg.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlDarkDark;
            btn8.BackgroundImageLayout = ImageLayout.Stretch;
            btn8.Cursor = Cursors.Hand;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(115, 395);
            btn8.Name = "btn8";
            btn8.Size = new Size(64, 64);
            btn8.TabIndex = 28;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlDarkDark;
            btn9.BackgroundImageLayout = ImageLayout.Stretch;
            btn9.Cursor = Cursors.Hand;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(198, 395);
            btn9.Name = "btn9";
            btn9.Size = new Size(64, 64);
            btn9.TabIndex = 29;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            btnX.BackColor = SystemColors.ActiveCaption;
            btnX.BackgroundImageLayout = ImageLayout.Stretch;
            btnX.Cursor = Cursors.Hand;
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnX.Location = new Point(279, 395);
            btnX.Name = "btnX";
            btnX.Size = new Size(64, 64);
            btnX.TabIndex = 30;
            btnX.Text = "×";
            btnX.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlDarkDark;
            btn5.BackgroundImageLayout = ImageLayout.Stretch;
            btn5.Cursor = Cursors.Hand;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(115, 476);
            btn5.Name = "btn5";
            btn5.Size = new Size(64, 64);
            btn5.TabIndex = 31;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlDarkDark;
            btn6.BackgroundImageLayout = ImageLayout.Stretch;
            btn6.Cursor = Cursors.Hand;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(198, 476);
            btn6.Name = "btn6";
            btn6.Size = new Size(64, 64);
            btn6.TabIndex = 32;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btnMenos
            // 
            btnMenos.BackColor = SystemColors.ActiveCaption;
            btnMenos.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenos.Cursor = Cursors.Hand;
            btnMenos.FlatAppearance.BorderSize = 0;
            btnMenos.FlatStyle = FlatStyle.Flat;
            btnMenos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenos.Location = new Point(279, 476);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(64, 64);
            btnMenos.TabIndex = 33;
            btnMenos.Text = "−";
            btnMenos.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlDarkDark;
            btn2.BackgroundImageLayout = ImageLayout.Stretch;
            btn2.Cursor = Cursors.Hand;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(115, 557);
            btn2.Name = "btn2";
            btn2.Size = new Size(64, 64);
            btn2.TabIndex = 34;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlDarkDark;
            btn3.BackgroundImageLayout = ImageLayout.Stretch;
            btn3.Cursor = Cursors.Hand;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(198, 557);
            btn3.Name = "btn3";
            btn3.Size = new Size(64, 64);
            btn3.TabIndex = 35;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btnMas
            // 
            btnMas.BackColor = SystemColors.ActiveCaption;
            btnMas.BackgroundImageLayout = ImageLayout.Stretch;
            btnMas.Cursor = Cursors.Hand;
            btnMas.FlatAppearance.BorderSize = 0;
            btnMas.FlatStyle = FlatStyle.Flat;
            btnMas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMas.Location = new Point(279, 557);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(64, 64);
            btnMas.TabIndex = 36;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlDarkDark;
            btn0.BackgroundImageLayout = ImageLayout.Stretch;
            btn0.Cursor = Cursors.Hand;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(115, 639);
            btn0.Name = "btn0";
            btn0.Size = new Size(64, 64);
            btn0.TabIndex = 37;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btnPoint
            // 
            btnPoint.BackColor = SystemColors.ControlDarkDark;
            btnPoint.BackgroundImageLayout = ImageLayout.Stretch;
            btnPoint.Cursor = Cursors.Hand;
            btnPoint.FlatAppearance.BorderSize = 0;
            btnPoint.FlatStyle = FlatStyle.Flat;
            btnPoint.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPoint.Location = new Point(198, 639);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(64, 64);
            btnPoint.TabIndex = 38;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = false;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.ActiveCaption;
            btnIgual.BackgroundImageLayout = ImageLayout.Stretch;
            btnIgual.Cursor = Cursors.Hand;
            btnIgual.FlatAppearance.BorderSize = 0;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(279, 639);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(64, 64);
            btnIgual.TabIndex = 39;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            // 
            // btnPi
            // 
            btnPi.BackColor = SystemColors.ControlDarkDark;
            btnPi.BackgroundImageLayout = ImageLayout.Stretch;
            btnPi.Cursor = Cursors.Hand;
            btnPi.FlatAppearance.BorderSize = 0;
            btnPi.FlatStyle = FlatStyle.Flat;
            btnPi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPi.Location = new Point(36, 262);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(56, 43);
            btnPi.TabIndex = 45;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            // 
            // btnParenthesis
            // 
            btnParenthesis.BackColor = SystemColors.ControlDarkDark;
            btnParenthesis.BackgroundImageLayout = ImageLayout.Stretch;
            btnParenthesis.Cursor = Cursors.Hand;
            btnParenthesis.FlatAppearance.BorderSize = 0;
            btnParenthesis.FlatStyle = FlatStyle.Flat;
            btnParenthesis.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnParenthesis.Location = new Point(98, 262);
            btnParenthesis.Name = "btnParenthesis";
            btnParenthesis.Size = new Size(56, 43);
            btnParenthesis.TabIndex = 46;
            btnParenthesis.Text = "( )";
            btnParenthesis.UseVisualStyleBackColor = false;
            // 
            // btnMC
            // 
            btnMC.BackColor = SystemColors.ControlDarkDark;
            btnMC.BackgroundImageLayout = ImageLayout.Stretch;
            btnMC.Cursor = Cursors.Hand;
            btnMC.FlatAppearance.BorderSize = 0;
            btnMC.FlatStyle = FlatStyle.Flat;
            btnMC.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMC.Location = new Point(160, 262);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(56, 43);
            btnMC.TabIndex = 47;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = false;
            // 
            // btnMR
            // 
            btnMR.BackColor = SystemColors.ControlDarkDark;
            btnMR.BackgroundImageLayout = ImageLayout.Stretch;
            btnMR.Cursor = Cursors.Hand;
            btnMR.FlatAppearance.BorderSize = 0;
            btnMR.FlatStyle = FlatStyle.Flat;
            btnMR.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMR.Location = new Point(222, 262);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(56, 43);
            btnMR.TabIndex = 48;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = false;
            // 
            // btnMPlus
            // 
            btnMPlus.BackColor = SystemColors.ControlDarkDark;
            btnMPlus.BackgroundImageLayout = ImageLayout.Stretch;
            btnMPlus.Cursor = Cursors.Hand;
            btnMPlus.FlatAppearance.BorderSize = 0;
            btnMPlus.FlatStyle = FlatStyle.Flat;
            btnMPlus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMPlus.Location = new Point(284, 262);
            btnMPlus.Name = "btnMPlus";
            btnMPlus.Size = new Size(56, 43);
            btnMPlus.TabIndex = 49;
            btnMPlus.Text = "M+";
            btnMPlus.UseVisualStyleBackColor = false;
            // 
            // btnMMinus
            // 
            btnMMinus.BackColor = SystemColors.ControlDarkDark;
            btnMMinus.BackgroundImageLayout = ImageLayout.Stretch;
            btnMMinus.Cursor = Cursors.Hand;
            btnMMinus.FlatAppearance.BorderSize = 0;
            btnMMinus.FlatStyle = FlatStyle.Flat;
            btnMMinus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMMinus.Location = new Point(284, 213);
            btnMMinus.Name = "btnMMinus";
            btnMMinus.Size = new Size(56, 43);
            btnMMinus.TabIndex = 50;
            btnMMinus.Text = "M-";
            btnMMinus.UseVisualStyleBackColor = false;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = SystemColors.ControlDarkDark;
            btnSquare.BackgroundImageLayout = ImageLayout.Stretch;
            btnSquare.Cursor = Cursors.Hand;
            btnSquare.FlatAppearance.BorderSize = 0;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSquare.Location = new Point(284, 164);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(56, 43);
            btnSquare.TabIndex = 51;
            btnSquare.Text = "x²";
            btnSquare.UseVisualStyleBackColor = false;
            // 
            // btnLn
            // 
            btnLn.BackColor = SystemColors.ControlDarkDark;
            btnLn.BackgroundImageLayout = ImageLayout.Stretch;
            btnLn.Cursor = Cursors.Hand;
            btnLn.FlatAppearance.BorderSize = 0;
            btnLn.FlatStyle = FlatStyle.Flat;
            btnLn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLn.Location = new Point(222, 213);
            btnLn.Name = "btnLn";
            btnLn.Size = new Size(56, 43);
            btnLn.TabIndex = 52;
            btnLn.Text = "ln";
            btnLn.UseVisualStyleBackColor = false;
            // 
            // btnLog
            // 
            btnLog.BackColor = SystemColors.ControlDarkDark;
            btnLog.BackgroundImageLayout = ImageLayout.Stretch;
            btnLog.Cursor = Cursors.Hand;
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLog.Location = new Point(160, 213);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(56, 43);
            btnLog.TabIndex = 53;
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = false;
            // 
            // btnInverse
            // 
            btnInverse.BackColor = SystemColors.ControlDarkDark;
            btnInverse.BackgroundImageLayout = ImageLayout.Stretch;
            btnInverse.Cursor = Cursors.Hand;
            btnInverse.FlatAppearance.BorderSize = 0;
            btnInverse.FlatStyle = FlatStyle.Flat;
            btnInverse.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInverse.Location = new Point(98, 213);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(56, 43);
            btnInverse.TabIndex = 54;
            btnInverse.Text = "1/x";
            btnInverse.UseVisualStyleBackColor = false;
            // 
            // btnPower
            // 
            btnPower.BackColor = SystemColors.ControlDarkDark;
            btnPower.BackgroundImageLayout = ImageLayout.Stretch;
            btnPower.Cursor = Cursors.Hand;
            btnPower.FlatAppearance.BorderSize = 0;
            btnPower.FlatStyle = FlatStyle.Flat;
            btnPower.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPower.Location = new Point(36, 213);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(56, 43);
            btnPower.TabIndex = 55;
            btnPower.Text = "xʸ";
            btnPower.UseVisualStyleBackColor = false;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = SystemColors.ControlDarkDark;
            btnSqrt.BackgroundImageLayout = ImageLayout.Stretch;
            btnSqrt.Cursor = Cursors.Hand;
            btnSqrt.FlatAppearance.BorderSize = 0;
            btnSqrt.FlatStyle = FlatStyle.Flat;
            btnSqrt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSqrt.Location = new Point(222, 164);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(56, 43);
            btnSqrt.TabIndex = 56;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            // 
            // btnTan
            // 
            btnTan.BackColor = SystemColors.ControlDarkDark;
            btnTan.BackgroundImageLayout = ImageLayout.Stretch;
            btnTan.Cursor = Cursors.Hand;
            btnTan.FlatAppearance.BorderSize = 0;
            btnTan.FlatStyle = FlatStyle.Flat;
            btnTan.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTan.Location = new Point(160, 164);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(56, 43);
            btnTan.TabIndex = 57;
            btnTan.Text = "Tan";
            btnTan.UseVisualStyleBackColor = false;
            // 
            // btnCos
            // 
            btnCos.BackColor = SystemColors.ControlDarkDark;
            btnCos.BackgroundImageLayout = ImageLayout.Stretch;
            btnCos.Cursor = Cursors.Hand;
            btnCos.FlatAppearance.BorderSize = 0;
            btnCos.FlatStyle = FlatStyle.Flat;
            btnCos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCos.Location = new Point(98, 164);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(56, 43);
            btnCos.TabIndex = 58;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = false;
            // 
            // btnSin
            // 
            btnSin.BackColor = SystemColors.ControlDarkDark;
            btnSin.BackgroundImageLayout = ImageLayout.Stretch;
            btnSin.Cursor = Cursors.Hand;
            btnSin.FlatAppearance.BorderSize = 0;
            btnSin.FlatStyle = FlatStyle.Flat;
            btnSin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSin.Location = new Point(36, 164);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(56, 43);
            btnSin.TabIndex = 59;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = false;
            btnSin.Click += circularButton9_Click;
            // 
            // btnEuler
            // 
            btnEuler.BackColor = SystemColors.ControlDarkDark;
            btnEuler.BackgroundImageLayout = ImageLayout.Stretch;
            btnEuler.Cursor = Cursors.Hand;
            btnEuler.FlatAppearance.BorderSize = 0;
            btnEuler.FlatStyle = FlatStyle.Flat;
            btnEuler.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEuler.Location = new Point(36, 115);
            btnEuler.Name = "btnEuler";
            btnEuler.Size = new Size(56, 43);
            btnEuler.TabIndex = 60;
            btnEuler.Text = "e";
            btnEuler.UseVisualStyleBackColor = false;
            // 
            // btnAtan
            // 
            btnAtan.BackColor = SystemColors.ControlDarkDark;
            btnAtan.BackgroundImageLayout = ImageLayout.Stretch;
            btnAtan.Cursor = Cursors.Hand;
            btnAtan.FlatAppearance.BorderSize = 0;
            btnAtan.FlatStyle = FlatStyle.Flat;
            btnAtan.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtan.Location = new Point(98, 115);
            btnAtan.Name = "btnAtan";
            btnAtan.Size = new Size(56, 43);
            btnAtan.TabIndex = 61;
            btnAtan.Text = "Tan⁻¹";
            btnAtan.UseVisualStyleBackColor = false;
            // 
            // btnAcos
            // 
            btnAcos.BackColor = SystemColors.ControlDarkDark;
            btnAcos.BackgroundImageLayout = ImageLayout.Stretch;
            btnAcos.Cursor = Cursors.Hand;
            btnAcos.FlatAppearance.BorderSize = 0;
            btnAcos.FlatStyle = FlatStyle.Flat;
            btnAcos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcos.Location = new Point(160, 115);
            btnAcos.Name = "btnAcos";
            btnAcos.Size = new Size(56, 43);
            btnAcos.TabIndex = 62;
            btnAcos.Text = "Cos⁻¹";
            btnAcos.UseVisualStyleBackColor = false;
            // 
            // btnAsin
            // 
            btnAsin.BackColor = SystemColors.ControlDarkDark;
            btnAsin.BackgroundImageLayout = ImageLayout.Stretch;
            btnAsin.Cursor = Cursors.Hand;
            btnAsin.FlatAppearance.BorderSize = 0;
            btnAsin.FlatStyle = FlatStyle.Flat;
            btnAsin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsin.Location = new Point(222, 115);
            btnAsin.Name = "btnAsin";
            btnAsin.Size = new Size(56, 43);
            btnAsin.TabIndex = 63;
            btnAsin.Text = "Sin⁻¹";
            btnAsin.UseVisualStyleBackColor = false;
            // 
            // btnAngleMode
            // 
            btnAngleMode.BackColor = SystemColors.ControlDarkDark;
            btnAngleMode.BackgroundImageLayout = ImageLayout.Stretch;
            btnAngleMode.Cursor = Cursors.Hand;
            btnAngleMode.FlatAppearance.BorderSize = 0;
            btnAngleMode.FlatStyle = FlatStyle.Flat;
            btnAngleMode.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAngleMode.Location = new Point(284, 115);
            btnAngleMode.Name = "btnAngleMode";
            btnAngleMode.Size = new Size(56, 43);
            btnAngleMode.TabIndex = 64;
            btnAngleMode.Text = "DEG";
            btnAngleMode.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(384, 719);
            Controls.Add(btnAngleMode);
            Controls.Add(btnAsin);
            Controls.Add(btnAcos);
            Controls.Add(btnAtan);
            Controls.Add(btnEuler);
            Controls.Add(btnSin);
            Controls.Add(btnCos);
            Controls.Add(btnTan);
            Controls.Add(btnSqrt);
            Controls.Add(btnPower);
            Controls.Add(btnInverse);
            Controls.Add(btnLog);
            Controls.Add(btnLn);
            Controls.Add(btnSquare);
            Controls.Add(btnMMinus);
            Controls.Add(btnMPlus);
            Controls.Add(btnMR);
            Controls.Add(btnMC);
            Controls.Add(btnParenthesis);
            Controls.Add(btnPi);
            Controls.Add(btnIgual);
            Controls.Add(btnPoint);
            Controls.Add(btn0);
            Controls.Add(btnMas);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnMenos);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btnX);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btnPosNeg);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btnPorcent);
            Controls.Add(btnAC);
            Controls.Add(btnDiv);
            Controls.Add(txtDisplay);
            Controls.Add(btnDel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            Text = "Calculadora";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CircularButton btnDel;
        private TextBox txtDisplay;
        private CircularButton btnDiv;
        private CircularButton btnAC;
        private CircularButton btnPorcent;
        private CircularButton btn7;
        private CircularButton btn4;
        private CircularButton btn1;
        private CircularButton btnPosNeg;
        private CircularButton btn8;
        private CircularButton btn9;
        private CircularButton btnX;
        private CircularButton btn5;
        private CircularButton btn6;
        private CircularButton btnMenos;
        private CircularButton btn2;
        private CircularButton btn3;
        private CircularButton btnMas;
        private CircularButton btn0;
        private CircularButton btnPoint;
        private CircularButton btnIgual;
        private CircularButton btnPi;
        private CircularButton btnParenthesis;
        private CircularButton btnMC;
        private CircularButton btnMR;
        private CircularButton btnMPlus;
        private CircularButton btnMMinus;
        private CircularButton btnSquare;
        private CircularButton btnLn;
        private CircularButton btnLog;
        private CircularButton btnInverse;
        private CircularButton btnPower;
        private CircularButton btnSqrt;
        private CircularButton btnTan;
        private CircularButton btnCos;
        private CircularButton btnSin;
        private CircularButton btnEuler;
        private CircularButton btnAtan;
        private CircularButton btnAcos;
        private CircularButton btnAsin;
        private CircularButton btnAngleMode;
    }
}
