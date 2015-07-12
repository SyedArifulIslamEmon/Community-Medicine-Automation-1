using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityMedicineWebApp.BLL;
using CommunityMedicineWebApp.DAL.DAO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CommunityMedicineWebApp.UI
{
    public partial class ShowAllHistory : System.Web.UI.Page
    {
        ShowAllHistoryManager allHistoryManager = new ShowAllHistoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string jsonString = "[{\"id\":\"5644309456813\",\"name\":\"Rimi Khanom\",\"address\":\"House no: 12. Road no: 14. Dhanmondi, Dhaka\",\"date_of_birth\":\"1979-01-15\"},{\"id\":\"9509623450915\",\"name\":\"Asif Latif\",\"address\":\"House no: 98. Road no: 14. Katalgonj, Chittagong\",\"date_of_birth\":\"1988-07-11\"},{\"id\":\"1098789543218\",\"name\":\"Rakib Hasan\",\"address\":\"Vill. Shantinagar. Thana: Katalgonj, Faridpur\",\"date_of_birth\":\"1982-04-12\"},{\"id\":\"7865409458659\",\"name\":\"Rumon Sarker\",\"address\":\"Kishorginj\",\"date_of_birth\":\"1970-12-02\"},{\"id\":\"8909854343334\",\"name\":\"Gaji Salah Uddin\",\"address\":\"Chittagong\",\"date_of_birth\":\"1965-06-16\"}]";
            JavaScriptSerializer aJavaScriptSerializer = new JavaScriptSerializer();
            List<Voter> voterList = (List<Voter>)aJavaScriptSerializer.Deserialize(jsonString, typeof(List<Voter>));
            string dateofBirth = string.Empty;

            string voterID = nationalIDTextBox.Text;
            foreach (Voter aVoter in voterList)
            {
                //Response.Write("ID : "+aVoter.id+ "</br>");
                //Response.Write("Name : " + aVoter.name + "</br>");
                //Response.Write("Address : " + aVoter.address + "</br>");
                //Response.Write("Date of Birth : " + aVoter.date_of_birth + "</br></br>");

                if (voterList.Any(T => aVoter.id == voterID))
                {
                    //Response.Write("Name = " + aVoter.name + "</br>");
                    //Response.Write("Name = " + aVoter.address + "</br>");
                    //Response.Write("Name = " + aVoter.date_of_birth + "</br>");

                    nameTextBox.Text = aVoter.name;
                    addressTextBox.Text = aVoter.address;
                    
                    break;

                }

            }

            int totalService = allHistoryManager.GetServiceNumber(voterID);

            if (totalService == 0)
            {
                ShowLabel.Text = "This patient did not take any service before.";
            }
            for (int i = 1; i <= totalService; i++)
            {
                if (i == 1)
                {

                    treatmentLabel1.Visible = true;
                    centerNameLabel1.Visible = true;
                    centerNameTextBox.Visible = true;
                    dateLabel1.Visible = true;
                    dateTextBox.Visible = true;
                    doctorLabel1.Visible = true;
                    doctorTextBox.Visible = true;
                    ObservationLabel1.Visible = true;
                    observationTextBox.Visible = true;
                    treatmentGridView.Visible = true;
                    LoadGeneralData(voterID, i);
                    treatmentGridView.AutoGenerateColumns = false;
                    treatmentGridView.DataSource = allHistoryManager.LoadGriddata(nationalIDTextBox.Text, i);
                    treatmentGridView.DataBind();
                    
                    
                }
                if (i == 2)
                {
                    treatmentLabel2.Visible = true;
                    centerNameLabel2.Visible = true;
                    centerNameTextBox2.Visible = true;
                    dateLabel2.Visible = true;
                    dateTextBox2.Visible = true;
                    doctorLabel2.Visible = true;
                    doctorTextBox2.Visible = true;
                    ObservationLabel2.Visible = true;
                    observationTextBox2.Visible = true;
                    treatmentGridView2.Visible = true;
                    LoadGeneralData2(voterID,i);
                    treatmentGridView2.AutoGenerateColumns = false;
                    treatmentGridView2.DataSource = allHistoryManager.LoadGriddata(nationalIDTextBox.Text, i);
                    treatmentGridView2.DataBind();
                }

                if (i == 3)
                {
                    treatmentLabel3.Visible = true;
                    centerNameLabel3.Visible = true;
                    centerNameTextBox3.Visible = true;
                    dateLabel3.Visible = true;
                    dateTextBox3.Visible = true;
                    doctorLabel3.Visible = true;
                    doctorTextBox3.Visible = true;
                    ObservationLabel3.Visible = true;
                    observationTextBox3.Visible = true;
                    treatmentGridView3.Visible = true;
                    LoadGeneralData3(voterID, i);
                    treatmentGridView3.AutoGenerateColumns = false;
                    treatmentGridView3.DataSource = allHistoryManager.LoadGriddata(nationalIDTextBox.Text, i);
                    treatmentGridView3.DataBind();
                }

                if (i == 4)
                {
                    treatmentLabel4.Visible = true;
                    centerNameLabel4.Visible = true;
                    centerNameTextBox4.Visible = true;
                    dateLabel4.Visible = true;
                    dateTextBox4.Visible = true;
                    doctorLabel4.Visible = true;
                    doctorTextBox4.Visible = true;
                    observationLabel4.Visible = true;
                    observationTextBox4.Visible = true;
                    treatmentGridView4.Visible = true;
                    LoadGeneralData4(voterID, i);
                    treatmentGridView4.AutoGenerateColumns = false;
                    treatmentGridView4.DataSource = allHistoryManager.LoadGriddata(nationalIDTextBox.Text, i);
                    treatmentGridView4.DataBind();
                }

                if (i == 5)
                {
                    treatmentLabel5.Visible = true;
                    centerNameLabel5.Visible = true;
                    centerNameTextBox5.Visible = true;
                    dateLabel5.Visible = true;
                    dateTextBox5.Visible = true;
                    doctorLabel5.Visible = true;
                    doctorTextBox5.Visible = true;
                    observationTextBox5.Visible = true;
                    treatmentGridView5.Visible = true;
                    LoadGeneralData5(voterID, i);
                    treatmentGridView5.AutoGenerateColumns = false;
                    treatmentGridView5.DataSource = allHistoryManager.LoadGriddata(nationalIDTextBox.Text, i);
                    treatmentGridView5.DataBind();
                }
               
                    
                
            }

            //LoadGeneralData(voterID,totalService);
            //treatmentGridView.AutoGenerateColumns = false;
            //treatmentGridView.DataSource = allHistoryManager.LoadGriddata(nationalIDTextBox.Text,totalService);
            //treatmentGridView.DataBind();


        }

        public void LoadGeneralData(string voterID, int totalService)
        {
            
            //string voterID = nationalIDTextBox.Text;
            List<TreatmentGiven> generaList = allHistoryManager.LoadGeneralData(voterID,totalService);
            foreach (TreatmentGiven aTreatmentGiven in generaList)
            {
                //centerNameTextBox.Text = aTreatmentGiven.CenterID.ToString();
                centerNameTextBox.Text = allHistoryManager.GetCenterNameByID(aTreatmentGiven.CenterID);
                dateTextBox.Text = aTreatmentGiven.Date;
                doctorTextBox.Text = aTreatmentGiven.Doctor;
                observationTextBox.Text = aTreatmentGiven.Observation;
                
            }
            
        }
        public void LoadGeneralData2(string voterID, int totalService)
        {

            //string voterID = nationalIDTextBox.Text;
            List<TreatmentGiven> generaList = allHistoryManager.LoadGeneralData(voterID, totalService);
            foreach (TreatmentGiven aTreatmentGiven in generaList)
            {
                //centerNameTextBox2.Text =  aTreatmentGiven.CenterID.ToString();
                centerNameTextBox2.Text = allHistoryManager.GetCenterNameByID(aTreatmentGiven.CenterID);
                dateTextBox2.Text = aTreatmentGiven.Date;
                doctorTextBox2.Text = aTreatmentGiven.Doctor;
                observationTextBox2.Text = aTreatmentGiven.Observation;

            }

        }

        public void LoadGeneralData3(string voterID, int totalService)
        {

            //string voterID = nationalIDTextBox.Text;
            List<TreatmentGiven> generaList = allHistoryManager.LoadGeneralData(voterID, totalService);
            foreach (TreatmentGiven aTreatmentGiven in generaList)
            {
                //centerNameTextBox2.Text =  aTreatmentGiven.CenterID.ToString();
                centerNameTextBox3.Text = allHistoryManager.GetCenterNameByID(aTreatmentGiven.CenterID);
                dateTextBox3.Text = aTreatmentGiven.Date;
                doctorTextBox3.Text = aTreatmentGiven.Doctor;
                observationTextBox3.Text = aTreatmentGiven.Observation;

            }

        }

        public void LoadGeneralData4(string voterID, int totalService)
        {

            //string voterID = nationalIDTextBox.Text;
            List<TreatmentGiven> generaList = allHistoryManager.LoadGeneralData(voterID, totalService);
            foreach (TreatmentGiven aTreatmentGiven in generaList)
            {
                //centerNameTextBox2.Text =  aTreatmentGiven.CenterID.ToString();
                centerNameTextBox4.Text = allHistoryManager.GetCenterNameByID(aTreatmentGiven.CenterID);
                dateTextBox4.Text = aTreatmentGiven.Date;
                doctorTextBox4.Text = aTreatmentGiven.Doctor;
                observationTextBox4.Text = aTreatmentGiven.Observation;

            }

        }

        public void LoadGeneralData5(string voterID, int totalService)
        {

            //string voterID = nationalIDTextBox.Text;
            List<TreatmentGiven> generaList = allHistoryManager.LoadGeneralData(voterID, totalService);
            foreach (TreatmentGiven aTreatmentGiven in generaList)
            {
                //centerNameTextBox2.Text =  aTreatmentGiven.CenterID.ToString();
                centerNameTextBox5.Text = allHistoryManager.GetCenterNameByID(aTreatmentGiven.CenterID);
                dateTextBox5.Text = aTreatmentGiven.Date;
                doctorTextBox5.Text = aTreatmentGiven.Doctor;
                observationTextBox5.Text = aTreatmentGiven.Observation;

            }

        }

        protected void pdfButton_Click(object sender, EventArgs e)
        {
            PdfPTable pdfPTable = new PdfPTable(treatmentGridView.HeaderRow.Cells.Count);

            foreach (TableCell headerCell in treatmentGridView.HeaderRow.Cells)
            {
                PdfPCell pdfCell = new PdfPCell(new Phrase(headerCell.Text));
                pdfPTable.AddCell(pdfCell);
            }

            foreach (GridViewRow gridViewRow in treatmentGridView.Rows)
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

            Paragraph nationalID = new Paragraph("Voter ID : " + " : " + nationalIDTextBox.Text);
            Paragraph name = new Paragraph("Name : " + nameTextBox.Text);
            //Paragraph centerName = new Paragraph(newCenter.Name);
            Paragraph address = new Paragraph("Address : " + addressTextBox.Text);
            Paragraph center = new Paragraph("Age : " + centerNameTextBox.Text);
            Paragraph dates = new Paragraph("Date : " + dateTextBox.Text);
            Paragraph doctor = new Paragraph("Doctor : " + doctorTextBox.Text);
            Paragraph observation = new Paragraph("Observation : " + observationTextBox.Text);

            document.Open();
            document.Add(nationalID);
            document.Add(name);
            document.Add(address);
            //document.Add(centerName);
            document.Add(dates);
            document.Add(doctor);
            document.Add(observation);


            document.Add(pdfPTable);
            document.Close();

            Response.ContentType = "Application";
            Response.AppendHeader("content-disposition", "attachment;filename= History.pdf");
            Response.Write(document);
            Response.Flush();
            Response.End();
            document.Close();
        }
    }
}