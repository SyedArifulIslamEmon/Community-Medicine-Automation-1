<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CenterMenu.aspx.cs" Inherits="CommunityMedicineWebApp.UI.CenterMenu" MasterPageFile="Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID = "ContentPlaceHolder1" runat="server">
                <div id="sidebar">
			<ul>
				
				<li>
					<a class="about" href="DoctorEntryUI.aspx">Doctor Entry</a>
				</li>
                
                <li>
					<a class="about" href="MedicineStockReport.aspx">Medicine Stock </a>&nbsp;

                </li>
                <li>
					<a class="about" href="TreatmentGivenUI.aspx">Give Treatment </a>&nbsp;

                </li>
				<li>
				    
					<a class="about" href="DiseaseWiseReportUI.aspx">Disease wise Report</a>
				</li>
                <li>
					<a class="about" href="DiseaseDemogReport.aspx">Demographic Report</a>
				</li>
                <li>
					<a class="about" href="AlldiseasesBarChart.aspx">Disese Barchart</a>
				</li>
			</ul>
			
		</div>
		</asp:Content>
