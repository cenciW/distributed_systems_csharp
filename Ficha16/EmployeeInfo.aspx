﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeInfo.aspx.cs" Inherits="EmployeeInfo" %>

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
                <asp:Label ID="Label1" runat="server" Text="Honest John Software Developers"
                    Font-Bold="true" Height="36" Width="700"
                    Font-Size="X-Large" align="Center" Font-Names="Arial Black"></asp:Label>
            </div>
            <table align="left">
                <tr>
                    <td class="col1">
                        <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="FirstName" runat="server" Height="24px"
                            Width="230px"></asp:TextBox>
                    </td>
                    <td class="col4">
                        <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td class="col5">
                        <asp:TextBox ID="LastName" runat="server" Height="24px"
                            Width="230px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="col1">
                        <asp:Label ID="Label4" runat="server" Text="Employee ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="EmployeeID" runat="server"
                            Height="24px" Width="100px"></asp:TextBox>
                    </td>
                    <td class="col3"></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="col1">
                        <asp:Label ID="Label5" runat="server" Text="Position:"></asp:Label>
                    </td>
                    <td class="col2"></td>
                    <td></td>
                    <td class="col4">
                        <asp:Label ID="Label6" runat="server" Text="Role"></asp:Label>
                    </td>
                    <td class="col5">
                        <asp:DropDownList ID="PositionRole" runat="server"
                            Width="230px" Height="24px"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="radioBut" colspan="2">
                        <asp:RadioButton ID="WorkerButton" runat="server" Text="Worker"
                           GroupName="PositionGroup" Checked="true" TextAlign="Left"
                            AutoPostBack="true" OnCheckedChanged="WorkerChecked"/>
                    </td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="radioBut" colspan="2">
                        <asp:RadioButton ID="BossButton" runat="server" Text="Boss"
                           GroupName="PositionGroup" TextAlign="Left"
                            AutoPostBack="true" OnCheckedChanged="BossChecked"/>
                    </td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="radioBut" colspan="2">
                        <asp:RadioButton ID="VPButton" runat="server" Text="Vice President"
                           GroupName="PositionGroup" TextAlign="Left"
                            AutoPostBack="true" OnCheckedChanged="VPChecked"/>
                    </td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="radioBut" colspan="2">
                        <asp:RadioButton ID="PresidentButton" runat="server" Text="President"
                           GroupName="PositionGroup" TextAlign="Left"
                            AutoPostBack="true" OnCheckedChanged="PresidentChecked"/>
                    </td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
