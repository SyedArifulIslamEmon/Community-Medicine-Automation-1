<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CenterCreateUI.aspx.cs" Inherits="CommunityMedicineWebApp.UI.CenterCreateUI" MasterPageFile="Site.Master"%>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #000000;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            font-size: x-large;
        }
    </style>
</head>
<body style="height: 323px">--%>
<asp:Content ID="Content1" ContentPlaceHolderID = "ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="auto-style2">
    
        &nbsp;<br />
        <span class="auto-style3">&nbsp;</span><span class="auto-style1"><strong><em><span class="auto-style3">Create new Center</span><br />
        </em></strong></span>
        <br />
&nbsp; Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="centerNameTextBox" runat="server" Height="18px" Width="218px"></asp:TextBox>
        <br />
        <br />
&nbsp; District&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="districtDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="districtDropDownList_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;
        <br />
        <br />
&nbsp; Thana&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="thanaDropDownList" runat="server">
        </asp:DropDownList>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="showLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
    
    </div>
    </form>
    </asp:Content>
<%--</body>
</html>--%>
