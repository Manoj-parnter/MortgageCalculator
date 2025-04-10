using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MortgageCalculator.Desktop
{
    public partial class MortgageCalculatorApp : Form
    {
        public MortgageCalculatorApp()
        {
            InitializeComponent();
            LoadMortgageTypes();
        }
        private void LoadMortgageTypes()
        {
            var mortgageTypes = new Dictionary<int, string>
            {
                { 0, "Select Mortgage Type" },
                { 1, "Fixed" },
                { 2, "Variable" },
                { 3, "Adjustable" }
            };

            cmbMortgageType.DataSource = new BindingSource(mortgageTypes, null);
            cmbMortgageType.DisplayMember = "Value";
            cmbMortgageType.ValueMember = "Key";
            cmbMortgageType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMortgageType.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal loanAmount = decimal.Parse(txtLoanAmount.Text);
                decimal interestRate = decimal.Parse(txtInterestRate.Text);
                int loanDurationInMonths = int.Parse(txtLoanDuration.Text) * 12;

                var calculator = new MortgageCalculator();
                decimal totalRepayment = calculator.CalculateTotalRepayment(loanAmount, interestRate, loanDurationInMonths);
                decimal totalInterest = calculator.CalculateTotalInterest(loanAmount, totalRepayment);

                lblTotalRepayment.Text = $"Total Repayment: {totalRepayment:C}";
                lblTotalInterest.Text = $"Total Interest: {totalInterest:C}";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public class MortgageCalculator
        {
            public decimal CalculateTotalRepayment(decimal loanAmount, decimal interestRate, int loanDurationInMonths)
            {
                decimal monthlyRate = interestRate / 12 / 100;
                decimal monthlyPayment = loanAmount * monthlyRate / (1 - (decimal)Math.Pow((double)(1 + monthlyRate), -loanDurationInMonths));
                return monthlyPayment * loanDurationInMonths;
            }

            public decimal CalculateTotalInterest(decimal loanAmount, decimal totalRepayment)
            {
                return totalRepayment - loanAmount;
            }
        }
    }
}
