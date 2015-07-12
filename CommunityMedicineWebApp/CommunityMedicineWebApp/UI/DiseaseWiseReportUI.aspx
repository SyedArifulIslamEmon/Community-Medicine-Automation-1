<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiseaseWiseReportUI.aspx.cs" Inherits="CommunityMedicineWebApp.UI.DiseaseWiseReportUI" MasterPageFile="Site.Master"%>

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
    <form id="form1" runat="server">
    <div>
    
        <span style="font-size: x-large">&nbsp;&nbsp;<br />
&nbsp; </span> <span class="auto-style1"><strong><em><span style="font-size: x-large">Disease wise Report :</span></em></strong></span><br />
        <br />
&nbsp; Select Disease&nbsp;&nbsp;
        <asp:DropDownList ID="diseaseDropDownList" runat="server">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="pdfButton" runat="server" OnClick="pdfButton_Click" Text="Pdf" Width="49px" />
        &nbsp;&nbsp;
        <asp:Button ID="menuButton" runat="server" OnClick="menuButton_Click" style="font-weight: 700" Text="Menu" />
        <br />
        <br />
&nbsp; Date between&nbsp;&nbsp;
        <asp:TextBox ID="firstDateTextBox" runat="server" TextMode="Date"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; and&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="secondDateTextBox" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;<asp:GridView ID="reportGridView" runat="server" CellPadding="4" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" Font-Names="Cambria" style="text-align: center">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="District Name" />
                <asp:BoundField DataField="NumberOfPatient" HeaderText="Total Patients" />
                <asp:BoundField DataField="OverPopulation" HeaderText="% Over Population" />
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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
    </asp:Content>
<%--</body>
</html>--%>
