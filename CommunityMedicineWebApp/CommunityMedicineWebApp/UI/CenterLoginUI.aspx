<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CenterLoginUI.aspx.cs" Inherits="CommunityMedicineWebApp.UI.CenterLoginUI" MasterPageFile="Site.Master"%>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 150px;
            text-align: right;
        }
        .auto-style3 {
            width: 237px;
        }
        .auto-style4 {
            color: #FF0000;
        }
        .auto-style5 {
            font-size: x-large;
        }
        .auto-style6 {
            width: 150px;
            text-align: right;
            height: 23px;
        }
        .auto-style7 {
            width: 237px;
            height: 23px;
        }
        .auto-style8 {
            height: 23px;
        }
    </style>
</head>
<body>
    --%>
<asp:Content ID="Content1" ContentPlaceHolderID = "ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">

    <div>
    
    &nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style5"><strong>Center Login</strong></span><br />
&nbsp;<br />
        <table class="auto-style1" style="height: 166px; width: 551px; font-size: large">
            <tr>
                <td class="auto-style2" style="color: #FFFFFF">Center Code</td>
                <td class="auto-style3">
                    <asp:TextBox ID="codeTextBox" runat="server" Width="158px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="codeTextBox" CssClass="auto-style4" ErrorMessage="Center Code is Required" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="color: #FFFFFF">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" Width="155px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passwordTextBox" CssClass="auto-style4" ErrorMessage="Password is Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Login" Width="59px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="showLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    
    </div>
    
    </form>
    </asp:Content>
<%--
</body>
</html>--%>
