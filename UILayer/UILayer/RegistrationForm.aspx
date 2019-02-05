<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="UILayer.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%">
                <caption class="style1">
                    <strong>Student Registration </strong>
                </caption>
                <tr>
                    <td class="style2"></td>
                    <td></td>
                    <td></td>
                </tr>
                 <tr>
                    <td class="style2">Student ID:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>                                         
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Value cannot be empty!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">First Name:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>                    
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Value cannot be empty!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">Last Name:</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                    </td>
                                        
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Value cannot be empty!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
               
                <tr>
                    <td class="style2">Password:</td>
                    <td>
                        <asp:TextBox ID="TextBox4" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                                        
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Value cannot be empty!"
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
                        <asp:Button ID="Button1" runat="server" Text="Sign Up" OnClick="SignUp_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
