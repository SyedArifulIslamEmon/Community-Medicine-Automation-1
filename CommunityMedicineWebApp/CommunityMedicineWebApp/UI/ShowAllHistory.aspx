<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllHistory.aspx.cs" Inherits="CommunityMedicineWebApp.UI.ShowAllHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp; Show All history
        <br />
        <br />
&nbsp; National ID&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nationalIDTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp; Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="pdfButton" runat="server" OnClick="pdfButton_Click" Text="Pdf" Width="52px" />
        <br />
        <br />
&nbsp; Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="ShowLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="treatmentLabel1" runat="server" Text="Treatment 1:" Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp; 
        <asp:Label ID="centerNameLabel1" runat="server" Text="Center Name" Visible="False"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="centerNameTextBox" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;
        <asp:Label ID="dateLabel1" runat="server" Text="Date" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="dateTextBox" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp; 
        <asp:Label ID="doctorLabel1" runat="server" Text="Doctor" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="doctorTextBox" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:Label ID="ObservationLabel1" runat="server" Text="Observation" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="observationTextBox" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:GridView ID="treatmentGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Visible="False">
            <Columns>
                <asp:BoundField DataField="Disease" HeaderText="Disease" />
                <asp:BoundField DataField="Medicine" HeaderText="Medicine" />
                <asp:BoundField DataField="Dose" HeaderText="Dose" />
                <asp:BoundField DataField="Meal" HeaderText="Befoer/After Meal" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="Note" HeaderText="Note" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <br />
        <br />
&nbsp;
        <asp:Label ID="treatmentLabel2" runat="server" Text="Treatment 2:" Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;<br />
&nbsp; 
        <asp:Label ID="centerNameLabel2" runat="server" Text="Center Name" Visible="False"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="centerNameTextBox2" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp; 
        <asp:Label ID="dateLabel2" runat="server" Text="Date" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="dateTextBox2" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp; 
        <asp:Label ID="doctorLabel2" runat="server" Text="Doctor" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="doctorTextBox2" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:Label ID="ObservationLabel2" runat="server" Text="Observation" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="observationTextBox2" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;<br />
&nbsp; <asp:GridView ID="treatmentGridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Visible="False">
            <Columns>
                <asp:BoundField DataField="Disease" HeaderText="Disease" />
                <asp:BoundField DataField="Medicine" HeaderText="Medicine" />
                <asp:BoundField DataField="Dose" HeaderText="Dose" />
                <asp:BoundField DataField="Meal" HeaderText="Befoer/After Meal" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="Note" HeaderText="Note" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <br />
        <br />
        <br />
&nbsp;<asp:Label ID="treatmentLabel3" runat="server" Text="Treatment 3:" Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;<br />
&nbsp; 
        <asp:Label ID="centerNameLabel3" runat="server" Text="Center Name" Visible="False"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="centerNameTextBox3" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;
        <asp:Label ID="dateLabel3" runat="server" Text="Date" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="dateTextBox3" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp; 
        <asp:Label ID="doctorLabel3" runat="server" Text="Doctor" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="doctorTextBox3" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:Label ID="ObservationLabel3" runat="server" Text="Observation" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="observationTextBox3" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;<br />
&nbsp; <asp:GridView ID="treatmentGridView3" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Visible="False">
            <Columns>
                <asp:BoundField DataField="Disease" HeaderText="Disease" />
                <asp:BoundField DataField="Medicine" HeaderText="Medicine" />
                <asp:BoundField DataField="Dose" HeaderText="Dose" />
                <asp:BoundField DataField="Meal" HeaderText="Befoer/After Meal" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="Note" HeaderText="Note" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <br />
        <br />
        <br />
&nbsp;<asp:Label ID="treatmentLabel4" runat="server" Text="Treatment 4:" Visible="False"></asp:Label>
        <br />
        <br />
        &nbsp;
        <asp:Label ID="centerNameLabel4" runat="server" Text="Center Name" Visible="False"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="centerNameTextBox4" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp; 
        <asp:Label ID="dateLabel4" runat="server" Text="Date" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="dateTextBox4" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp; 
        <asp:Label ID="doctorLabel4" runat="server" Text="Doctor" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="doctorTextBox4" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;
        <asp:Label ID="observationLabel4" runat="server" Text="Observation" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="observationTextBox4" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;<br />
&nbsp; <asp:GridView ID="treatmentGridView4" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Visible="False">
            <Columns>
                <asp:BoundField DataField="Disease" HeaderText="Disease" />
                <asp:BoundField DataField="Medicine" HeaderText="Medicine" />
                <asp:BoundField DataField="Dose" HeaderText="Dose" />
                <asp:BoundField DataField="Meal" HeaderText="Befoer/After Meal" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="Note" HeaderText="Note" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <br />
        <br />
        &nbsp; <asp:Label ID="treatmentLabel5" runat="server" Text="Treatment 5:" Visible="False"></asp:Label>
        <br />
&nbsp;<br />
        &nbsp;
        <asp:Label ID="centerNameLabel5" runat="server" Text="Center Name" Visible="False"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="centerNameTextBox5" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp; 
        <asp:Label ID="dateLabel5" runat="server" Text="Date" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="dateTextBox5" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp; 
        <asp:Label ID="doctorLabel5" runat="server" Text="Doctor" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="doctorTextBox5" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;
        <asp:Label ID="observationLabel5" runat="server" Text="Observation" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="observationTextBox5" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
&nbsp;<br />
&nbsp; <asp:GridView ID="treatmentGridView5" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Visible="False">
            <Columns>
                <asp:BoundField DataField="Disease" HeaderText="Disease" />
                <asp:BoundField DataField="Medicine" HeaderText="Medicine" />
                <asp:BoundField DataField="Dose" HeaderText="Dose" />
                <asp:BoundField DataField="Meal" HeaderText="Befoer/After Meal" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="Note" HeaderText="Note" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
