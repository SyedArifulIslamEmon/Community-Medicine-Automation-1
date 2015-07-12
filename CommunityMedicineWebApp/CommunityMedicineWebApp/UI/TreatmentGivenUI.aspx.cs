using System;
using System.Collections.Generic;
using System.Linq;
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
    public partial class TreatmentGivenUI : System.Web.UI.Page
    {
        TreatmentGivenManager aTreatmentGivenManager = new TreatmentGivenManager();
        TreatmentGiven aTreatmentGiven = new TreatmentGiven();
        MedicineManager aMedicineManager = new MedicineManager();
        public int p = 0;
        

        private const string treatmentlist = "treatmentlist";

        public List<TreatmentGiven> treatmentList
        {
            get
            {
                if (!(ViewState[treatmentlist] is List<TreatmentGiven>))
                {

                    ViewState[treatmentlist] = new List<TreatmentGiven>();
                }

                return (List<TreatmentGiven>)ViewState[treatmentlist];
            }
        }
        

        protected void Page_Load(object sender, EventArgs e)
        {
            string center = Session["Center"].ToString();
            string thana = Session["Thana"].ToString();
            string district = Session["District"].ToString();

            centerLabel.Text = center + ", " + thana + ", " + district ;

            if (!IsPostBack)
            {
                doctorDropDownList.DataSource = aTreatmentGivenManager.LoadDoctor(center, thana, district);
                doctorDropDownList.DataTextField = "Name";
                doctorDropDownList.DataValueField = "ID";
                doctorDropDownList.DataBind();

                diseaseDropdownList.DataSource = aTreatmentGivenManager.LoaDiseases();
                diseaseDropdownList.DataTextField = "diseaseName";
                diseaseDropdownList.DataValueField = "id";
                diseaseDropdownList.DataBind();

                medicineDropDownList.DataSource = aTreatmentGivenManager.LoadMedicines(center, thana, district);
                medicineDropDownList.DataTextField = "Medicine";
                medicineDropDownList.DataValueField = "ID";
                medicineDropDownList.DataBind();

                doseDropDownList.DataSource = aTreatmentGivenManager.LoaDoses();
                doseDropDownList.DataTextField = "DoseName";
                doseDropDownList.DataValueField = "ID";
                doseDropDownList.DataBind();
            }
            
            if (p == 1)
            {
                showLabel.Text = "Treatment Saved.";
            }
           
            
        }

        public int checkService()
        {
            string voterID = voterIDTextBox.Text;
            return aTreatmentGivenManager.GetServiceNumber(voterID);
        }

        protected void showDetailsButton_Click(object sender, EventArgs e)
        {
            string center = Session["Center"].ToString();
            string thana = Session["Thana"].ToString();
            string district = Session["District"].ToString();

            string voterID = voterIDTextBox.Text;

            string jsonString = "[{\"id\":\"5644309456813\",\"name\":\"Rimi Khanom\",\"address\":\"House no: 12. Road no: 14. Dhanmondi, Dhaka\",\"date_of_birth\":\"1979-01-15\"},{\"id\":\"9509623450915\",\"name\":\"Asif Latif\",\"address\":\"House no: 98. Road no: 14. Katalgonj, Chittagong\",\"date_of_birth\":\"1988-07-11\"},{\"id\":\"1098789543218\",\"name\":\"Rakib Hasan\",\"address\":\"Vill. Shantinagar. Thana: Katalgonj, Faridpur\",\"date_of_birth\":\"1982-04-12\"},{\"id\":\"7865409458659\",\"name\":\"Rumon Sarker\",\"address\":\"Kishorginj\",\"date_of_birth\":\"1970-12-02\"},{\"id\":\"8909854343334\",\"name\":\"Gaji Salah Uddin\",\"address\":\"Chittagong\",\"date_of_birth\":\"1965-06-16\"}]";
            JavaScriptSerializer aJavaScriptSerializer = new JavaScriptSerializer();
            List<Voter> voterList = (List<Voter>)aJavaScriptSerializer.Deserialize(jsonString, typeof(List<Voter>));
            string dateofBirth = string.Empty;


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
                    dateofBirth = aVoter.date_of_birth.Substring(0,4);
                    int age = 2015 - int.Parse(aVoter.date_of_birth.Substring(0, 4));
                    ageTextBox.Text = age.ToString();
                    break;

                }

            }

            servicegivenTextBox.Text = checkService().ToString();
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session["Center"] = null;
            Session["Thana"] = null;
            Session["District"] = null;
            Response.Redirect("CenterLoginUI.aspx");
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string center = Session["Center"].ToString();
            string thana = Session["Thana"].ToString();
            string district = Session["District"].ToString();


            int districtID = aMedicineManager.GetIDByDistrictName(district);
            int thanaID = aMedicineManager.GetIDByThanaName(thana);
            int centerID = aMedicineManager.GetIDByCenterName(center);


            aTreatmentGiven.Disease = diseaseDropdownList.SelectedItem.ToString();
            aTreatmentGiven.Medicine = medicineDropDownList.SelectedItem.ToString();
            aTreatmentGiven.Dose = doseDropDownList.SelectedItem.ToString();
            if (beforeMealRadioButton.Checked)
            {
                aTreatmentGiven.Meal = beforeMealRadioButton.Text;
            }
            else if (afterRadioButton.Checked)
            {
                aTreatmentGiven.Meal = afterRadioButton.Text;
            }

            //aTreatmentGiven.Quantity = int.Parse(quantityTextBox.Text);
            //aTreatmentGiven.Note = noteTextBox.Text;

            //treatmentList.Add(aTreatmentGiven);
            //treatmentGridView.AutoGenerateColumns = false;
            //treatmentGridView.DataSource = treatmentList;
            //treatmentGridView.DataBind();

            if (aMedicineManager.PreviousQuantity(districtID, thanaID, centerID, aTreatmentGiven.Medicine) >
                int.Parse(quantityTextBox.Text))
            {
                aTreatmentGiven.Quantity = int.Parse(quantityTextBox.Text);

                aTreatmentGiven.Note = noteTextBox.Text;

                treatmentList.Add(aTreatmentGiven);
                treatmentGridView.AutoGenerateColumns = false;
                treatmentGridView.DataSource = treatmentList;
                treatmentGridView.DataBind();

                int currentQuantity =
                    aMedicineManager.PreviousQuantity(districtID, thanaID, centerID, aTreatmentGiven.Medicine) -
                    int.Parse(quantityTextBox.Text);
                aMedicineManager.updateQuantity(districtID, thanaID, centerID, aTreatmentGiven.Medicine, currentQuantity);
                addLabel.Text = "";
            }
            else
            {
                addLabel.Text = "This center has only " +
                                aMedicineManager.PreviousQuantity(districtID, thanaID, centerID,
                                    aTreatmentGiven.Medicine) + " pc " + aTreatmentGiven.Medicine;
            }

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string center = Session["Center"].ToString();
            string thana = Session["Thana"].ToString();
            string district = Session["District"].ToString();
            int result = 0;
            int serviceNumber = int.Parse(servicegivenTextBox.Text) + 1;

            foreach (TreatmentGiven givenTreatment in treatmentList)
            {
                TreatmentGiven anotherTreatmentGiven = new TreatmentGiven();

                anotherTreatmentGiven.VoterID = voterIDTextBox.Text;
                anotherTreatmentGiven.ServiceGiven = serviceNumber;
                anotherTreatmentGiven.Observation = observationTextBox.Text;
                DateTime date = dateCalender.SelectedDate;
                string day = date.Day.ToString();
                string month = date.Month.ToString();
                string year = date.Year.ToString();
                string datetoSave = year + "/" + month + "/" + day;
                anotherTreatmentGiven.Date = datetoSave;
                anotherTreatmentGiven.Doctor = doctorDropDownList.SelectedItem.ToString();

                anotherTreatmentGiven.Disease = givenTreatment.Disease;
                anotherTreatmentGiven.Medicine = givenTreatment.Medicine;
                anotherTreatmentGiven.Dose = givenTreatment.Dose;
                anotherTreatmentGiven.Meal = givenTreatment.Meal;
                anotherTreatmentGiven.Quantity = givenTreatment.Quantity;
                anotherTreatmentGiven.Note = givenTreatment.Note;
                anotherTreatmentGiven.CenterID = aTreatmentGivenManager.GetIDByCenter(center);
                anotherTreatmentGiven.ThanaID = aTreatmentGivenManager.GetIDByThanaName(thana);
                anotherTreatmentGiven.DistrictID = aTreatmentGivenManager.GetIDByDistrictName(district);

                result = aTreatmentGivenManager.SaveTreatmentGiven(anotherTreatmentGiven);
            }

            if (result != 0)
            {
                showLabel.Text = "Treatment saved successfully";
            }
            else
            {
                showLabel.Text = "Treatment not saved.";
            }
            
            


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

            Paragraph nationalID = new Paragraph(voterIDLabel.Text + " : " + voterIDTextBox.Text);
            Paragraph name = new Paragraph("Name : " + nameTextBox.Text);
            //Paragraph centerName = new Paragraph(newCenter.Name);
            Paragraph address = new Paragraph("Address : " + addressTextBox.Text);
            Paragraph age = new Paragraph("Age : " + ageTextBox.Text);
            Paragraph dates = new Paragraph("Date : " + dateCalender.SelectedDate.ToString());
            Paragraph doctor = new Paragraph("Doctor : " + doctorDropDownList.SelectedItem.ToString());
            Paragraph service = new Paragraph("Service Given : " + servicegivenTextBox.Text + " times.\n\n\n\n\n");
            Paragraph observation = new Paragraph("Observation : " + observationTextBox.Text);

            document.Open();
            document.Add(nationalID);
            document.Add(name);
            document.Add(address);
            //document.Add(centerName);
            document.Add(dates);
            document.Add(doctor);
            document.Add(observation);


            document.Add(age);
            document.Add(service);



            document.Add(pdfPTable);
            document.Close();

            Response.ContentType = "Application";
            Response.AppendHeader("content-disposition", "attachment;filename=PatientInfo.pdf");
            Response.Write(document);
            Response.Flush();
            Response.End();
            document.Close();


            treatmentList.RemoveAll(t => t.VoterID.Equals(voterIDTextBox.Text));

            Response.Redirect(Request.Path);
            Response.Redirect(Request.RawUrl);
            Response.Redirect(Request.Url.ToString());
           

        }

        protected void showAllHistoryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowAllHistory.aspx");
        }

        protected void menuButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CenterMenu.aspx");
        }

        //protected void pdfButton_Click(object sender, EventArgs e)
        //{
        //    //PdfPTable pdfPTable = new PdfPTable(treatmentGridView.HeaderRow.Cells.Count);

        //    //foreach (TableCell headerCell in treatmentGridView.HeaderRow.Cells)
        //    //{
        //    //    PdfPCell pdfCell = new PdfPCell(new Phrase(headerCell.Text));
        //    //    pdfPTable.AddCell(pdfCell);
        //    //}

        //    //foreach (GridViewRow gridViewRow in treatmentGridView.Rows)
        //    //{
        //    //    foreach (TableCell tableCell in gridViewRow.Cells)
        //    //    {
        //    //        PdfPCell pdfCell = new PdfPCell(new Phrase(tableCell.Text));
        //    //        pdfPTable.AddCell(pdfCell);
        //    //    }

        //    //}

        //    //Document document = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
        //    //PdfWriter.GetInstance(document, Response.OutputStream);
        //    ////PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("test.pdf", FileMode.Create));

        //    //Paragraph nationalID = new Paragraph(voterIDLabel.Text+" : "+voterIDTextBox.Text);
        //    //Paragraph name = new Paragraph("Name : "+nameTextBox.Text);
        //    ////Paragraph centerName = new Paragraph(newCenter.Name);
        //    //Paragraph address = new Paragraph("Address : "+addressTextBox.Text);
        //    //Paragraph age = new Paragraph("Age : "+ageTextBox.Text);
        //    //Paragraph date = new Paragraph("Date : "+dateCalender.SelectedDate.ToString());
        //    //Paragraph doctor = new Paragraph("Doctor : "+doctorDropDownList.SelectedItem.ToString());
        //    //Paragraph service = new Paragraph("Service Given : "+servicegivenTextBox.Text+" times.\n\n\n\n\n");
        //    //Paragraph observation = new Paragraph("Observation : "+observationTextBox.Text);

        //    //document.Open();
        //    //document.Add(nationalID);
        //    //document.Add(name);
        //    //document.Add(address);
        //    ////document.Add(centerName);
        //    //document.Add(date);
        //    //document.Add(doctor);
        //    //document.Add(observation);


        //    //document.Add(age);
        //    //document.Add(service);



        //    //document.Add(pdfPTable);
        //    //document.Close();

        //    //Response.ContentType = "Application";
        //    //Response.AppendHeader("content-disposition", "attachment;filename=PatientInfo.pdf");
        //    //Response.Write(document);
        //    //Response.Flush();
        //    //Response.End();
        //    //document.Close();
        //}
    }
}