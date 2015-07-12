using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityMedicineWebApp.BLL;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CommunityMedicineWebApp.UI
{
    public partial class DiseaseWiseReportUI : System.Web.UI.Page
    {
        DiseaseWiseReportManager aDiseaseWiseReportManager = new DiseaseWiseReportManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                diseaseDropDownList.DataSource = aDiseaseWiseReportManager.LoadDiseases();
                diseaseDropDownList.DataTextField = "diseaseName";
                diseaseDropDownList.DataValueField = "id";
                diseaseDropDownList.DataBind();
            }
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            reportGridView.AutoGenerateColumns = false;
            reportGridView.DataSource = aDiseaseWiseReportManager.getreportInfoList(firstDateTextBox.Text,secondDateTextBox.Text, diseaseDropDownList.SelectedItem.ToString());
            reportGridView.DataBind();

        }

        protected void pdfButton_Click(object sender, EventArgs e)
        {
            PdfPTable pdfPTable = new PdfPTable(reportGridView.HeaderRow.Cells.Count);

            foreach (TableCell headerCell in reportGridView.HeaderRow.Cells)
            {
                PdfPCell pdfCell = new PdfPCell(new Phrase(headerCell.Text));
                pdfPTable.AddCell(pdfCell);
            }

            foreach (GridViewRow gridViewRow in reportGridView.Rows)
            {
                foreach (TableCell tableCell in gridViewRow.Cells)
                {
                    PdfPCell pdfCell = new PdfPCell(new Phrase(tableCell.Text));
                    pdfPTable.AddCell(pdfCell);
                }

            }

            Document document = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter.GetInstance(document, Response.OutputStream);
            //PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("test.pdf", FileMode.Create));

            //Paragraph nationalID = new Paragraph("Voter ID : " + " : " + nationalIDTextBox.Text);
            //Paragraph name = new Paragraph("Name : " + nameTextBox.Text);
            ////Paragraph centerName = new Paragraph(newCenter.Name);
            //Paragraph address = new Paragraph("Address : " + addressTextBox.Text);
            //Paragraph center = new Paragraph("Age : " + centerNameTextBox.Text);
            //Paragraph dates = new Paragraph("Date : " + dateTextBox.Text);
            //Paragraph doctor = new Paragraph("Doctor : " + doctorTextBox.Text);
            //Paragraph observation = new Paragraph("Observation : " + observationTextBox.Text);

            document.Open();
            //document.Add(nationalID);
            //document.Add(name);
            //document.Add(address);
            ////document.Add(centerName);
            //document.Add(dates);
            //document.Add(doctor);
            //document.Add(observation);


            document.Add(pdfPTable);
            document.Close();

            Response.ContentType = "Application";
            Response.AppendHeader("content-disposition", "attachment;filename= History.pdf");
            Response.Write(document);
            Response.Flush();
            Response.End();
            document.Close();
        }

        protected void menuButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CenterMenu.aspx");
        }
    }
}