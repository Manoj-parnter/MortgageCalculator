namespace MortgageCalculator.Desktop
{
    partial class MortgageCalculatorApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtLoanDuration;
        private System.Windows.Forms.ComboBox cmbMortgageType;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalRepayment;
        private System.Windows.Forms.Label lblTotalInterest;

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
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanDuration = new System.Windows.Forms.TextBox();
            this.cmbMortgageType = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalRepayment = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblnterestRate = new System.Windows.Forms.Label();
            this.lblLoanDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(269, 18);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(193, 27);
            this.txtLoanAmount.TabIndex = 0;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(269, 64);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(193, 27);
            this.txtInterestRate.TabIndex = 1;
            // 
            // txtLoanDuration
            // 
            this.txtLoanDuration.Location = new System.Drawing.Point(269, 117);
            this.txtLoanDuration.Name = "txtLoanDuration";
            this.txtLoanDuration.Size = new System.Drawing.Size(193, 27);
            this.txtLoanDuration.TabIndex = 2;
            // 
            // cmbMortgageType
            // 
            this.cmbMortgageType.FormattingEnabled = true;
            this.cmbMortgageType.Location = new System.Drawing.Point(269, 185);
            this.cmbMortgageType.Name = "cmbMortgageType";
            this.cmbMortgageType.Size = new System.Drawing.Size(193, 27);
            this.cmbMortgageType.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(438, 235);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 41);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalRepayment
            // 
            this.lblTotalRepayment.AutoSize = true;
            this.lblTotalRepayment.Location = new System.Drawing.Point(434, 309);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.Size = new System.Drawing.Size(122, 19);
            this.lblTotalRepayment.TabIndex = 5;
            this.lblTotalRepayment.Text = "Total Repayment:";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(253, 309);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(99, 19);
            this.lblTotalInterest.TabIndex = 6;
            this.lblTotalInterest.Text = "Total Interest:";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(169, 18);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(94, 19);
            this.lblLoanAmount.TabIndex = 7;
            this.lblLoanAmount.Text = "Loan Amount";
            // 
            // lblnterestRate
            // 
            this.lblnterestRate.AutoSize = true;
            this.lblnterestRate.Location = new System.Drawing.Point(169, 72);
            this.lblnterestRate.Name = "lblnterestRate";
            this.lblnterestRate.Size = new System.Drawing.Size(93, 19);
            this.lblnterestRate.TabIndex = 8;
            this.lblnterestRate.Text = "Interest Rate";
            // 
            // lblLoanDuration
            // 
            this.lblLoanDuration.AutoSize = true;
            this.lblLoanDuration.Location = new System.Drawing.Point(169, 125);
            this.lblLoanDuration.Name = "lblLoanDuration";
            this.lblLoanDuration.Size = new System.Drawing.Size(100, 19);
            this.lblLoanDuration.TabIndex = 9;
            this.lblLoanDuration.Text = "Loan Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mortgage Type";
            // 
            // MortgageCalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoanDuration);
            this.Controls.Add(this.lblnterestRate);
            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.lblTotalInterest);
            this.Controls.Add(this.lblTotalRepayment);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbMortgageType);
            this.Controls.Add(this.txtLoanDuration);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtLoanAmount);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MortgageCalculatorApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MortgageCalculatorApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblnterestRate;
        private System.Windows.Forms.Label lblLoanDuration;
        private System.Windows.Forms.Label label1;
    }
}