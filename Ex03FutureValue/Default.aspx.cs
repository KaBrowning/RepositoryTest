using System;


public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if (IsPostBack)
            return;

        for (var i = 50; i <= 500; i += 50)
            this.ddlMonthlyInvestment.Items.Add(i.ToString());
    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            var monthlyInvestment = Convert.ToInt32(this.ddlMonthlyInvestment.SelectedValue);
            var yearlyInterestRate = Convert.ToDecimal(this.txtInterestRate.Text);
            var years = Convert.ToInt32(this.txtYears.Text);

            var futureValue = this.CalculateFutureValue(monthlyInvestment,
                yearlyInterestRate, years);

            this.lblFutureValue.Text = futureValue.ToString("c");
        }
    }

    protected decimal CalculateFutureValue(int monthlyInvestment,
    decimal yearlyInterestRate, int years)
    {
        var months = years * 12;
        var monthlyInterestRate = yearlyInterestRate / 12 / 100;
        decimal futureValue = 0;
        for (var i = 0; i < months; i++)
        {
            futureValue = (futureValue + monthlyInvestment)
                * (1 + monthlyInterestRate);
        }
        return futureValue;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.ddlMonthlyInvestment.SelectedIndex = 0;
        this.txtInterestRate.Text = "";
        this.txtYears.Text = "";
        this.lblFutureValue.Text = "";
    }
}