<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowCenterUI.aspx.cs" Inherits="CommunityMedicineWebApp.UI.ShowCenterUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Center Created.<br />
        <br />
&nbsp;Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="nameLabel" runat="server"></asp:Label>
        <br />
        <br />
        Code :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="codeLabel" runat="server"></asp:Label>
        <br />
        <br />
        Password :&nbsp;&nbsp;
        <asp:Label ID="passwordLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
