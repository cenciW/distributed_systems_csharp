<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeInfo.aspx.cs" Inherits="EmployeeInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Employee Information</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="Label1" Font-Bold="true" runat="server" Text="Honest John Software Developers"
                    Font-Names="Arial Black"
                    Height="36"
                    Width="700"
                    Font-Size="X-Large" align="center"></asp:Label>

            </div>

            <table align="left">
                <tr>
                    <td class="col1">
                        <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="FirstName" runat="server" Height="24px" Width="230px"></asp:TextBox>
                    </td>
                    <td class="col4">
                        <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td class="col5">
                        <asp:TextBox ID="LastName" runat="server" Height="24px" Width="230px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:RequiredFieldValidator runat="server"
                            ErrorMessage="You must enter a first name"
                            ControlToValidate="FirstName"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td></td>
                    <td>
                        <asp:RequiredFieldValidator runat="server"
                            ErrorMessage="You must enter a last name"
                            ControlToValidate="LastName"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>


                <tr>
                    <td class="col1">
                        <asp:Label ID="Label4" runat="server" Text="Employee ID"></asp:Label>
                    </td>
                    <td class="col2">
                        <asp:TextBox ID="EmployeeID" runat="server" Height="24px" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Panel runat="server" Height="20">
                            <asp:RangeValidator runat="server"
                                ID="RangeValidator1"
                                ErrorMessage="ID must be between 1 and 5000"
                                ControlToValidate="EmployeeID"
                                MinimumValue="1"
                                MaximumValue="5000"
                                ForeColor="Red"
                                Type="Integer"
                                Display="Dynamic"></asp:RangeValidator>

                            <asp:RequiredFieldValidator runat="server"
                                ID="RequiredFieldValidator1"
                                ErrorMessage="Employee ID is required"
                                ControlToValidate="EmployeeID"
                                ForeColor="Red"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                        </asp:Panel>
                    </td>
                    <td></td>
                    <td></td>
                </tr>

                <tr>
                    <td class="col1">
                        <asp:Label ID="Label5" runat="server" Text="Position:"></asp:Label>
                    </td>
                    <td></td>
                    <td></td>
                    <td class="col4">
                        <asp:Label ID="Label6" runat="server" Text="Role"></asp:Label>
                    </td>
                    <td class="col5">
                        <asp:DropDownList ID="PositionRole" runat="server" Width="230px" Height="24px"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="radioBut" colspan="2">
                        <asp:RadioButton ID="WorkerButton" runat="server" Text="Worker"
                            TextAlign="Left"
                            GroupName="PositionGroup"
                            Checked="true" AutoPostBack="true" OnCheckedChanged="WorkerChecked" />
                    </td>
                </tr>
                <tr>
                    <td class="radioBut" colspan="2">
                        <asp:RadioButton ID="BossButton" runat="server" Text="Boss"
                            TextAlign="Left"
                            GroupName="PositionGroup" AutoPostBack="true" OnCheckedChanged="BossChecked" />
                    </td>
                </tr>
                <tr>
                    <td class="radioBut" colspan="2">
                        <asp:RadioButton ID="VPButton" runat="server" Text="Vice President"
                            TextAlign="Left"
                            GroupName="PositionGroup" AutoPostBack="true" OnCheckedChanged="VPChecked" />
                    </td>
                </tr>
                <tr>
                    <td class="radioBut" colspan="2">
                        <asp:RadioButton ID="PresidentButton" runat="server" Text="President"
                            TextAlign="Left"
                            GroupName="PositionGroup" AutoPostBack="true" OnCheckedChanged="PresidentChecked" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td align="center" class="col3">
                        <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveForm" />
                    </td>
                    <td align="center" class="col4">
                        <asp:Button ID="ClearButton" runat="server" Text="Clear" OnClick="ClearForm" CausesValidation="False" />
                    </td>
                    <td></td>
                </tr>

                <tr>
                    <td colspan="5">
                        <asp:Label ID="InfoLabel" runat="server"
                            Text="_"
                            Height="48px"
                            Width="680px"></asp:Label>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
