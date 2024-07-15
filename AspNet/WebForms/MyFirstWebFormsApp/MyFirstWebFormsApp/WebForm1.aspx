<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MyFirstWebFormsApp.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My first ASP.NET WebForms Application</title>
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style2
        /*{*/
            margin-left: 0px;
        }
        .auto-style3
        {
            width: 121px;
        }
        
    </style>
</head>
<body bgcolor = 'green'>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <p align='center' style='color:white; font-size:xx-large';>
                Hurrah, my first ASP.NET Web Forms Application!!!
            </p> 
            <br />
            <br />
            <div align="center">
                <h2>Provide the Following Details: </h2>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label1" runat="server" Text="User Name">
                            </asp:Label>   
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2">

                            </asp:TextBox> 
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Upload a File">

                            </asp:Label> 
                        </td>
                        <td>
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </td>
                    </tr>            
                </table>
            </div>          
        </div>

    </form>
</body>
</html>
