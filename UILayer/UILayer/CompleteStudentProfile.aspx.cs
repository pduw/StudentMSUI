using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Windows.Forms;

namespace UILayer
{
    public partial class CompleteStudentProfile : System.Web.UI.Page
    {
        string firstName, lastName, studentID;
        protected void Page_Load(object sender, EventArgs e)
        {
            firstName = Request.QueryString["fn"];
            lastName = Request.QueryString["ln"];
            studentID = Request.QueryString["sid"];
            StudentID.Text = studentID;
        }

        public HttpWebRequest CreateSOAPWebRequest()
        {

            HttpWebRequest serviceRequest = (HttpWebRequest)WebRequest.Create("https://adc558.azurewebsites.net/BLayer.asmx");
            serviceRequest.Method = "POST";
            serviceRequest.Host = "adc558.azurewebsites.net";
            serviceRequest.ContentType = "text/xml; charset=utf-8";
            //serviceRequest.Timeout = (60 * 60 * 1000);
            //serviceRequest.ContentLength = 363;
            serviceRequest.KeepAlive = false;
            serviceRequest.ServicePoint.ConnectionLimit = 100;
            serviceRequest.Headers.Add(@"SOAPAction:ServiceReference/completeProfile");
            return serviceRequest;
        }

        protected void UpdateProfile_Click(object sender, EventArgs e)
        {
            string emailid, phonenumber, address, city, state, country, emerphone, emerrelationship;
            bool ProfileUpdateSuccessful = false;
            emailid = TextBox1.Text;
            phonenumber = TextBox2.Text;
            address = TextBox3.Text;
            city = TextBox4.Text;
            state = TextBox5.Text;
            country = TextBox6.Text;
            emerphone = TextBox7.Text;
            emerrelationship = TextBox8.Text;
            try
            {
                HttpWebRequest request = CreateSOAPWebRequest();
                XmlDocument SOAPReqBody = new XmlDocument();
                //SOAP Body Request   
                SOAPReqBody.LoadXml(@"<?xml version = ""1.0"" encoding = ""utf-8"" ?> <soap:Envelope xmlns:xsi = ""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd = ""http://www.w3.org/2001/XMLSchema"" xmlns:soap = ""http://schemas.xmlsoap.org/soap/envelope/""> <soap:Body> <completeProfile xmlns = ""ServiceReference""> <phone_no>" + phonenumber + @" </phone_no> <address>" + address + @" </address> <city>" + city + @" </city> <country>" + country + @" </country> <state>" + state + @" </state> <emergency_contact>" + emerphone + @" </emergency_contact> <relationship>" + emerrelationship + @" </relationship> <email_id>" + emailid + @" </email_id> <student_id>" + studentID + @" </student_id> </completeProfile> </soap:Body> </soap:Envelope>");
                request.SendChunked = true;
                using (Stream stream = request.GetRequestStream())
                {
                    SOAPReqBody.Save(stream);
                }

                using (WebResponse response = request.GetResponse())
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(response.GetResponseStream());

                    XmlNodeList elemList = xmlDoc.GetElementsByTagName("completeProfileResult");
                    ProfileUpdateSuccessful = Boolean.Parse(elemList[0].InnerText);

                    if (ProfileUpdateSuccessful)
                    {
                        DialogResult result = MessageBox.Show("Successfully updated Profile!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        if (result == DialogResult.OK)
                        {
                            Response.Redirect("~/LandingPage.aspx?studentid=" + studentID);
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}