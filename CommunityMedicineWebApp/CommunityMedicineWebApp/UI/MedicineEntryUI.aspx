<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicineEntryUI.aspx.cs" Inherits="CommunityMedicineWebApp.UI.MedicineEntryUI" MasterPageFile="Site.Master"%>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>--%>
<asp:Content ID="Content1" ContentPlaceHolderID = "ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" style="height: 446px; width: 959px">
        <strong>
        <br class="auto-style1" />
        <span class="auto-style1">Medicine Entry</span></strong><br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Name of Medicine with mg/ml"></asp:Label>
        <asp:TextBox ID="medicineNameTextBox" runat="server" Height="45px" Width="227px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
&nbsp;&nbsp;
        <asp:Label ID="showLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:GridView ID="medicineGridView" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnPageIndexChanging="medicineGridView_PageIndexChanging" PageSize="5">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="Serial" SortExpression="ID" />
                <asp:BoundField DataField="MedicineName" HeaderText="Medicine Name" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
            
        </asp:GridView>
        <br />
        <br />
        <br />
    </form>
    </asp:Content>
<%--</body>
</html>--%>
