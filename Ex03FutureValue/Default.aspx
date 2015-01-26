<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Replace with appropriate title</title>
</head>
<body>
    <header>
        <img id="logo" alt="Murach logo" src="Images/MurachLogo.jpg"/>
    </header>
    <section>
        <form id="form1" runat="server">
            <h1>401K Future Value Calculator</h1>
            <label>Monthly investment:</label>
            <asp:DropDownList ID="ddlMonthlyInvestment" runat="server"></asp:DropDownList>
            <label>Annual interest rate:</label>
            <asp:TextBox ID="txtInterestRate" runat="server">6.0</asp:TextBox>
            <label>Number of years:</label>
            <asp:TextBox ID="txtYears" runat="server">10</asp:TextBox>
            <label>Future value:</label>
            <asp:Label ID="lblFutureValue" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" 
                onclick="btnCalculate_Click"/>
            <asp:Button ID="btnClear" runat="server" Text="Clear" 
                onclick="btnClear_Click" CausesValidation="False" />
        </form>
    </section>    
</body>
</html>
