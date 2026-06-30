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
            btnDel.Location = new Point(36, 123);
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
            txtDisplay.Location = new Point(36, 44);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.RightToLeft = RightToLeft.No;
            txtDisplay.Size = new Size(306, 64);
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
            btnDiv.Location = new Point(279, 123);
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
            btnAC.Location = new Point(115, 123);
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
            btnPorcent.Location = new Point(198, 123);
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
            btn7.Location = new Point(36, 203);
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
            btn4.Location = new Point(36, 284);
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
            btn1.Location = new Point(36, 365);
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
            btnPosNeg.Location = new Point(36, 447);
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
            btn8.Location = new Point(115, 203);
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
            btn9.Location = new Point(198, 203);
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
            btnX.Location = new Point(279, 203);
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
            btn5.Location = new Point(115, 284);
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
            btn6.Location = new Point(198, 284);
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
            btnMenos.Location = new Point(279, 284);
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
            btn2.Location = new Point(115, 365);
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
            btn3.Location = new Point(198, 365);
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
            btnMas.Location = new Point(279, 365);
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
            btn0.Location = new Point(115, 447);
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
            btnPoint.Location = new Point(198, 447);
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
            btnIgual.Location = new Point(279, 447);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(64, 64);
            btnIgual.TabIndex = 39;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(386, 561);
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
    }
}
