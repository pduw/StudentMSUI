<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CompleteStudentProfile.aspx.cs" Inherits="UILayer.CompleteStudentProfile" %>

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
                    <strong>Complete Profile </strong>
                </caption>
                <tr>
                    <td class="style2"></td>
                </tr>
                <tr>
                    <td class="style2">Student ID:</td>
                    <td>
                        <asp:Label ID="StudentID" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="style2">Email ID:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>                    
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Value cannot be empty!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">Phone Number:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>                    
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Value cannot be empty!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">Address:</td>
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
                    <td class="style2">City:</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>                    
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Value cannot be empty!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">State:</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>                    
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Value cannot be empty!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">Country:</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>                    
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Value cannot be empty!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">Emergency Contact Details:</td>

                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td class="style2">Phone Number:</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>                    
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Value cannot be empty!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td class="style2">Relationship:</td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>                    
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"
                            ControlToValidate="TextBox1" ErrorMessage="Value cannot be empty!"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="style2"></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Update Profile" OnClick="UpdateProfile_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
