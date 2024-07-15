<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="AnotherWebFormsApp.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <style>
        .bodybkgd
            {
                background-image: url(./Content/Images/backgroundimage.jpg);
                background-repeat: no-repeat;
                background-size: cover;
            }
        .center 
            {
                width: 400px;
                height: 160px;
                margin: 80px auto auto auto;
                padding-top: 45px;
                padding-left: 100px;
                border: 2px solid darkblue;                
                background-color: teal;                              
            }
        h2
            {
                text-align:center;
            }
    </style>
</head>
<body class="bodybkgd">
    <h2>Registration Form</h2>
    <hr />
    <form id="form1" autocomplete="off" runat="server" >
        <div class="center">
            
            <br />

            <asp:Label ID="LblFName" 
                Text="First Name: " 
                runat="server" /><br />

            <asp:TextBox ID="TxtBxFName" 
                autocomplete="off" 
                columns="40" 
                maxlength="40" 
                runat="server" 
                OnTextChanged="TxtBxFName_TextChanged" /><br />

            <asp:Label ID="LblLName" 
                Text="Last Name: " 
                runat="server" /><br />

            <asp:TextBox ID="TxtBxLName" 
                autocomplete="off" 
                columns="40" 
                maxlength="40" 
                runat="server" 
                OnTextChanged="TxtBxLName_TextChanged" /><br /><br />

            <asp:button id="BtnSubmit" 
                Text="Submit" 
                runat="server" 
                OnClick="BtnSubmit_Click" /><br />

            <asp:Label ID="LblWelcome" 
                runat="server" 
                Font-Size="Large" 
                ForeColor="Black" 
                Visible="False" Font-Bold="True" /><br />

            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator1"
                ControlToValidate="TxtBxFName"
                ErrorMessage="Enter your first name please.<br />"
                Display="Dynamic"
                Runat="server" ForeColor="Red" Font-Italic="True" />

            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator2"
                ControlToValidate="TxtBxLName"
                ErrorMessage="Enter your last name please.<br />"
                Display="Dynamic"
                Runat="server" ForeColor="Red" Font-Italic="True" />  
        </div>
    </form>
</body>
</html>
