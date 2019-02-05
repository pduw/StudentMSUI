using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.IO;

namespace UILayer
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

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
            serviceRequest.Headers.Add(@"SOAPAction:ServiceReference/SignUp");
            return serviceRequest;
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            {
                string studentid, firstname, lastname, password;
                bool SignUpSuccessful = false;
                try
                {
                    if (TextBox1.Text.Length != 6)
                    {
                        MessageBox.Show("Enter 6 digit student ID","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                    }
                    HttpWebRequest request = CreateSOAPWebRequest();
                    XmlDocument SOAPReqBody = new XmlDocument();
                    studentid = TextBox1.Text;
                    firstname = TextBox2.Text;
                    lastname = TextBox3.Text;
                    password = TextBox4.Text;
                    SOAPReqBody.LoadXml(@"<?xml version = ""1.0"" encoding = ""utf-8"" ?> <soap:Envelope xmlns:xsi = ""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd = ""http://www.w3.org/2001/XMLSchema"" xmlns:soap = ""http://schemas.xmlsoap.org/soap/envelope/""> <soap:Body> <SignUp xmlns = ""ServiceReference""> <first_name>" + firstname + @" </first_name> <last_name>" + lastname + @" </last_name> <student_id>" + studentid + @" </student_id> <password>" + password + @" </password> </SignUp> </soap:Body> </soap:Envelope>");
                    request.SendChunked = true;
                    using (Stream stream = request.GetRequestStream())
                    {
                        SOAPReqBody.Save(stream);
                    }

                    using (WebResponse response = request.GetResponse())
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(response.GetResponseStream());

                        XmlNodeList elemList = xmlDoc.GetElementsByTagName("SignUpResult");
                        SignUpSuccessful = Boolean.Parse(elemList[0].InnerText);                       
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                if (SignUpSuccessful)
                {
                    Response.Redirect("~/Home.aspx?registrartionsuccessful=true");
                }
                else
                {
                    MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}