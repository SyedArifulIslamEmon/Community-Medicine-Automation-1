<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HeadOfficeMenu.aspx.cs" Inherits="CommunityMedicineWebApp.UI.TestWebForm" MasterPageFile="Site.Master" %>

<%--<!DOCTYPE html>
<!-- Website template by freewebsitetemplates.com -->
<html>
<head>
	<meta charset="UTF-8">
	<title>Denim Jeans Website Template</title>
	<link href="../css/style.css" rel="stylesheet" />
</head>
<body>
	<div id="header">
		<div>
			
           <h1 style="color: yellow"><b>Community Medicine Web Application</b></h1>
		</div>
	</div>
	<div id="body">--%>
            <asp:Content ID="Content1" ContentPlaceHolderID = "ContentPlaceHolder1" runat="server">
                <div id="sidebar">
			<ul>
				<li class="current">
					<a class="home" href="MedicineEntryUI.aspx">Medicine Entry</a>
				</li>
				<li>
					<a class="about" href="DiseaseEntry.aspx">Disease Entry</a>
				</li>
                <li>
					<a class="about" href="CenterCreateUI.aspx">Create New Center</a>
				</li>
				<li>
					<a class="about" href="SendMedicineUI.aspx">Send Medicine</a>
				</li>
			</ul>
			
		</div>
		</asp:Content>
	<%--</div>
	<div id="footer">
	</div>
</body>
</html>--%>
