<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiseaseEntry.aspx.cs" Inherits="CommunityMedicineWebApp.UI.DiseaseEntry" MasterPageFile="Site.Master"%>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>--%>

<asp:Content ID="Content1" ContentPlaceHolderID = "ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" style="width: 621px; height: 587px">
    <div>
    
        Disease Entry<br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="diseaseNameTextBox" runat="server" Width="246px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="diseaseDescriptionTextBox" runat="server" Width="246px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Treatment"></asp:Label>
        <asp:TextBox ID="diseaseTreatmentTextBox" runat="server" Width="246px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Procedure"></asp:Label>
        <asp:TextBox ID="diseaseProcedureTextBox" runat="server" Width="246px"></asp:TextBox>
        <asp:Button ID="diseaseSaveButton" runat="server" OnClick="diseaseSaveButton_Click" style="height: 26px" Text="Save" />
        <asp:Label ID="showLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="diseaseEntryGridView" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnPageIndexChanging="diseaseEntryGridView_PageIndexChanging" PageSize="5">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Serial" SortExpression="id" />
                <asp:BoundField DataField="diseaseName" HeaderText="Disease Name" SortExpression="diseaseName" />
                <asp:BoundField DataField="diseaseDescription" HeaderText="Description" SortExpression="diseaseDescription" />
                <asp:BoundField DataField="diseaseTreatment" HeaderText="Treatment" SortExpression="diseaseTreatment" />
                <asp:BoundField DataField="diseaseProcedure" HeaderText="Procedure" SortExpression="diseaseProcedure" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
    
    </div>
    </form>
    </asp:Content>
<%--</body>
</html>--%>
