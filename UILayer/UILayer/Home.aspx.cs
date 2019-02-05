using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Xml;
using System.Text;

namespace UILayer
{
    public partial class Home : System.Web.UI.Page
    {
        string studentid;
        string password;
        protected void Page_Load(object sender, EventArgs e)
        {
            string isRegistrationSuccessful = Request.QueryString["registrartionsuccessful"];
            if (isRegistrationSuccessful == "true")
            {
                Label1.Visible = true;
            }
            
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
            serviceRequest.Headers.Add(@"SOAPAction:ServiceReference/ValidateLogin");
            return serviceRequest;
        }
        protected void Login_Click(object sender, EventArgs e)
        {
            bool loginSuccessful = false;

            try
            {
                HttpWebRequest request = CreateSOAPWebRequest();
                XmlDocument SOAPReqBody = new XmlDocument();
                //SOAP Body Request   
                studentid = TextBox1.Text;
                password = TextBox2.Text;
                if (TextBox1.Text == "" || TextBox1.Text.Length != 6)
                {
                       MessageBox.Show("Incorrect Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (TextBox2.Text == "")
                {
                      MessageBox.Show("Enter password to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SOAPReqBody.LoadXml(@"<?xml version = ""1.0"" encoding = ""utf-8"" ?> <soap:Envelope xmlns:xsi = ""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd = ""http://www.w3.org/2001/XMLSchema"" xmlns:soap = ""http://schemas.xmlsoap.org/soap/envelope/""> <soap:Body> <ValidateLogin xmlns = ""ServiceReference""> <student_id>" + studentid + @" </student_id> <password>"+password + @" </password> </ValidateLogin> </soap:Body> </soap:Envelope>");
                    request.SendChunked = true;
                    using (Stream stream = request.GetRequestStream())
                    {
                        SOAPReqBody.Save(stream);
                    }

                    using (WebResponse response = request.GetResponse())
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(response.GetResponseStream());


                        XmlNodeList elemList = xmlDoc.GetElementsByTagName("ValidateLoginResult");
                        loginSuccessful = Boolean.Parse(elemList[0].InnerText);

                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            if (loginSuccessful)
            {
                Response.Redirect("~/LandingPage.aspx?studentid=" + studentid);
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}