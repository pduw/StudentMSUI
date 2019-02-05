<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Async="true" Inherits="UILayer.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <caption class="style1">
                    <strong>Student Login </strong>
                </caption>
                <tr>
                    <td class="style2"></td>
                </tr>
                <tr>
                    <td class="style2"></td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Registration Successful!" ForeColor="Maroon" Visible="false"
></asp:Label>                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="style2">Student ID:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Please Enter Your Student ID!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">Password:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="TextBox2" ErrorMessage="Please Enter Your Password!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2"></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="style2"></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Log In" OnClick="Login_Click" />
                        &nbsp; Not a registered student? &nbsp;
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="../RegistrationForm.aspx">Register</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
