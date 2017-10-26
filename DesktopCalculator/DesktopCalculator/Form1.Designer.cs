namespace DesktopCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.inptResult = new System.Windows.Forms.TextBox();
            this.inptSecondNumber = new System.Windows.Forms.NumericUpDown();
            this.inptFirstNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inptSecondNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptFirstNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(283, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "(+) Zbroji";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(283, 75);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(120, 30);
            this.btnSubstract.TabIndex = 1;
            this.btnSubstract.Text = "(-) Oduzmi";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(283, 128);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(120, 30);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "(*) Pomnozi";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(283, 182);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(120, 30);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "(/) Podijeli";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(21, 30);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(54, 13);
            this.Number.TabIndex = 4;
            this.Number.Text = "Prvi broj : ";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(21, 84);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(61, 13);
            this.lblSecondNumber.TabIndex = 5;
            this.lblSecondNumber.Text = "Drugi broj : ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(21, 165);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Rezultat : ";
            // 
            // inptResult
            // 
            this.inptResult.Enabled = false;
            this.inptResult.Location = new System.Drawing.Point(88, 162);
            this.inptResult.Name = "inptResult";
            this.inptResult.Size = new System.Drawing.Size(130, 20);
            this.inptResult.TabIndex = 7;
            // 
            // inptSecondNumber
            // 
            this.inptSecondNumber.Location = new System.Drawing.Point(88, 82);
            this.inptSecondNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inptSecondNumber.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.inptSecondNumber.Name = "inptSecondNumber";
            this.inptSecondNumber.Size = new System.Drawing.Size(130, 20);
            this.inptSecondNumber.TabIndex = 8;
            // 
            // inptFirstNumber
            // 
            this.inptFirstNumber.Location = new System.Drawing.Point(88, 28);
            this.inptFirstNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inptFirstNumber.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.inptFirstNumber.Name = "inptFirstNumber";
            this.inptFirstNumber.Size = new System.Drawing.Size(130, 20);
            this.inptFirstNumber.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 261);
            this.Controls.Add(this.inptFirstNumber);
            this.Controls.Add(this.inptSecondNumber);
            this.Controls.Add(this.inptResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inptSecondNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptFirstNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox inptResult;
        private System.Windows.Forms.NumericUpDown inptSecondNumber;
        private System.Windows.Forms.NumericUpDown inptFirstNumber;
    }
}

