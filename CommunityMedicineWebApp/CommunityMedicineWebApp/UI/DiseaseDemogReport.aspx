<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiseaseDemogReport.aspx.cs" Inherits="CommunityMedicineWebApp.UI.DiseaseDemogReport" %>

<%@ Register Assembly="EGIS.Web.Controls" Namespace="EGIS.Web.Controls" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Easy GIS .NET Web Example 1</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <div>
        &nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; From&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="fromTextBox" runat="server" TextMode="Date"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; To&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="toTextBox" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Disease&nbsp;&nbsp;
        <asp:DropDownList ID="diseaseDropDownList" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="showButton" runat="server" Text="Show" />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Width="175px">
            <asp:ListItem>Please Select..</asp:ListItem>
            <asp:ListItem>Population Density</asp:ListItem>
         
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate Map"
            Width="103px" /><br />
                     
    <cc1:SFMap ID="SFMap1" runat="server" Height="964px" Width="861px" ProjectName="~/bangladesh.egp" style="border-right: gray thin dashed; border-top: gray thin dashed; border-left: gray thin dashed; border-bottom: gray thin dashed" MaxZoomLevel="1000" MinZoomLevel="0.5"   CacheOnClient="false" />    
    <cc1:MapPanControl ID="MapPanControl1" runat="server"  MapReferenceId="SFMap1" style="z-index: 100; left: 20px; position: absolute; top: 200px; text-align: center" />        
    </div>

    </form>
</body>
</html>
