<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BmiCalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
    
    <head runat="server">
        <title>Bmi Calculator Page</title>
        <style>
            .center 
            {
                width: 30%;
                margin: 32px auto auto auto;
                padding: 90px;
                border: 2px solid darkblue;
                height: 191px;
            }
        </style>
    </head>
    <body>
        <form id="form1" runat="server">
        
            <div class="center"> 

                <h1><b>BMI Calculator</b></h1>
            
                Your Height&nbsp;&nbsp; (In Inches): 
                <asp:TextBox ID="UsersHeight" runat="server" Height="22px" BackColor="#FFFFCC"></asp:TextBox>
                <br />
                <br />
                Your Weight (In Pounds):
                <asp:TextBox ID="UsersWeight" runat="server" Height="22px" BackColor="#FFFFCC"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="CalculateBmi" runat="server" Text="Submit" BackColor="#99CCFF" />
            </div>
        
        </form>
    </body>
</html>
