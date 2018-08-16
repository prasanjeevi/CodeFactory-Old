using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using EAS;
using System.Collections.Generic;
using System.Xml;
namespace EASApp
{
    //public class Student
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public List<Subject> subjedomain { get; set; }
    //}
    //public class Subject
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //}
    //public class Dept
    //{
    //   public List<Student> students { get; set; }
    //}

    public partial class _Default : System.Web.UI.Page
    {
       

        string protocolVersion = "14.1";
        //string protocolVersion = "12.1";

        string url = "https://web.com/Microsoft-Server-ActiveSync/default.eas?User=domain%userid&DeviceId=androidc1503748351&DeviceType=Android&Cmd=";
        string strRawCredentials = "domain\\userid:#include3";

        public class CACertificate
        {
            int m_EmailRevokeRequestID;
            int m_EmailRevokeRequestStatus;
            int m_EmailRequestStatusInput;
            string m_EmailRevokeComment;

            #region "Unused variables"
            string m_SerialNumber;
            string m_ThumbPrint;
            string m_DomainName;
            string m_UserName;
            string m_LDAPUserID;
            #endregion

            public int EmailRevokeRequestID
            {
                get { return m_EmailRevokeRequestID; }
                set { m_EmailRevokeRequestID = value; }
            }
            public int EmailRevokeRequestStatus
            {
                get { return m_EmailRevokeRequestStatus; }
                set { m_EmailRevokeRequestStatus = value; }
            }
            public int EmailRequestStatusInput
            {
                get { return m_EmailRequestStatusInput; }
                set { m_EmailRequestStatusInput = value; }
            }
            public string EmailRevokeComment
            {
                get { return m_EmailRevokeComment; }
                set { m_EmailRevokeComment = value; }
            }


            public string SerialNumber
            {
                get { return m_SerialNumber; }
                set { m_SerialNumber = value; }
            }
            public string ThumbPrint
            {
                get { return m_ThumbPrint; }
                set { m_ThumbPrint = value; }
            }
            public string DomainName
            {
                get { return m_DomainName; }
                set { m_DomainName = value; }
            }
            public string UserName
            {
                get { return m_UserName; }
                set { m_UserName = value; }
            }

            public string LDAPUserID
            {
                get { return m_LDAPUserID; }
                set { m_LDAPUserID = value; }
            }

            public void ClearUserInfo()
            {
                m_EmailRevokeRequestID = 0;
                m_EmailRevokeRequestStatus = 0;
                m_SerialNumber = String.Empty;
                m_ThumbPrint = String.Empty;
                m_UserName = String.Empty;
                m_LDAPUserID = string.Empty;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            //string strResponse = "{\"appstore_information\":[{\"audit_comment\":null,\"certificate_request_id\":0,\"device_id\":null,\"email_request_status\":0,\"email_revoke_request_id\":621,\"email_revoke_request_status\":8,\"enrollment_request_id\":60,\"ldap_user_id\":\"username\",\"mdm_push_ws_response\":null,\"pfx_base64_filestring\":null,\"pfx_repository_path\":null,\"private_key_password\":\"pass\",\"serial_number\":\"235A9C9600000000003C\",\"thumbprint\":\"953366BC3CD2C1A62D8D657B40FED579B9D094F2\",\"user_id\":null,\"user_name\":\"username\"}],\"appstore_request\":null,\"display_message\":\"Success.\",\"message_status\":\"Success.\"}";
            //var CACert = new CACertificate();
            //if (!strResponse.Contains("error"))
            //{
            //    string[] CACertInfo = strResponse.Replace("appstore_information", "").Replace("{", "").Replace("[", "").Replace("\"", "").Replace("}", "").Replace("]", "").Remove(0, 1).Split(','); //[0].Split(':')[1];

            //    for (int i = 0; i < CACertInfo.Length; i++)
            //    {
            //        //Response string format
            //        //{"appstore_information":[{"certificate_request_id":54,"device_id":null,"email_request_status":0,"email_revoke_request_id":0,"email_revoke_request_status":0,"enrollment_request_id":0,"ldap_user_id":"viji","mdm_push_ws_response":null,"pfx_base64_filestring":null,"pfx_repository_path":null,"private_key_password":null,"serial_number":null,"thumbprint":null,"user_id":"viji","user_name":"viji"}],"appstore_request":null,"display_message":"Success.","message_status":"Success."}
            //        switch (CACertInfo[i].Split(':')[0])
            //        {
            //            case "email_revoke_request_id":
            //                CACert.EmailRevokeRequestID = Convert.ToInt32(CACertInfo[i].Split(':')[1]);
            //                break;
            //            case "user_name":
            //                CACert.UserName = CACertInfo[i].Split(':')[1];
            //                break;
            //            case "serial_number":
            //                CACert.SerialNumber = CACertInfo[i].Split(':')[1];
            //                break;
            //            case "thumbprint":
            //                CACert.ThumbPrint = CACertInfo[i].Split(':')[1];
            //                break;
            //            case "ldap_user_id":
            //                CACert.LDAPUserID = CACertInfo[i].Split(':')[1];
            //                break;
            //            case "email_revoke_request_status":
            //                CACert.EmailRequestStatusInput = Convert.ToInt32(CACertInfo[i].Split(':')[1]);
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //}

            //Dept d = new Dept();
            
            //Student s = new Student();
            //s.subjedomain.Add(new Subject());
            //s.subjedomain.Add(new Subject());

            //    Student s1 = new Student();
            //    s1.subjedomain.Add(new Subject());

            //d.students.Add(s);
            // d.students.Add(s1);

            //d.students[0].subjedomain[0].ID=

            //getTime();
           
            //string strRawCredentials = "domain\\username:password-1";
            //string strRawCredentials = "domain\\userid:#include4";

            //ParseAutoDiscoveryRequest(GenerateAutoDiscoverResponse(""));
            //return;
            //Filling/Set MailBox
            //MailBox mb = new MailBox()
            //{
            //    DomainUser = "domain\\username",
            //    Password = "password-7",
            //    Server = "domain.company.com"
            //};
            //MailBox mb = new MailBox()
            //{
            //    DomainUser = "securecontain\\selva",
            //    Password = "password-2",
            //    Server = "securecontain.com"
            //};

            //MailBox mb = new MailBox()
            //{
            //    DomainUser = "domain\\o365testuser",
            //    Password = "Password-8",
            //    Server = "m.outlook.com"
            //};

            //MailBox mb = new MailBox()
            //{
            //    DomainUser = "hostedlab\\DIVIDE2007-01",
            //    Password = "VZWtest135#",
            //    Server = "webmail07.hostedlab.wds.vzw.com"
            //};

            MailBox mb = new MailBox()
            {
                DomainUser = "domain\\userid",
                Password = "#include3",
                Server = "web.com"
            };
            //MailBox mb = new MailBox()
            //{
            //    DomainUser = "domain\\username",
            //    Password = "password-7",
            //    Server = "domain.company.com"
            //};
            
            
            //txtPolicyKey.Text = "2178738510";
            if(mb != null)
            {
                //Fill
                txtMBDomainUser.Text = mb.DomainUser;
                txtMBPassword.Text = mb.Password;
                txtMBServer.Text = mb.Server;                
            }
            else
            {
                //Set
                //mb = txt
            }

            //Filling/Set Device //DeviceID = "androidc1503748351",
            Device d = new Device()
            {
                DeviceID = "androidc1503748351",
                DeviceType = "Android",
                Model = "ST15i",
                OperatingSystem = "Android 4.0.4",
                UserAgent = "Android/4.0.4-EAS-1.3"
            };

            //Device d = new Device()
            //{
            //    DeviceID = "SAMSUNG01626959393",
            //    DeviceType = "SAMSUNGGTP7500",
            //    Model = "GT-P7500",
            //    OperatingSystem = "Android",
            //    IMEI="358534045311210",
            //    MobileOperator="airtel",
            //    UserAgent = "SAMSUNG-GT-P7500/100.40004"
            //};

            //Device d = new Device()
            //{
            //    DeviceID = "ApplDMPL69PZF18P",
            //    DeviceType = "iPad",
            //    Model = "iPad3C6",
            //    OperatingSystem = "iOS 7.0.2 11A501",
            //    OperatingSystemLanguage = "en-GB",
            //    UserAgent = "iOS/7.0.2 (11A501) dataaccessd/1.0",
            //    FriendlyName = "Black iPad"
            //};

            if (d != null)
            {
                //Fill
                txtDDeviceId.Text = d.DeviceID;
                txtDDeviceType.Text = d.DeviceType;

                txtDDeviceModel.Text = d.Model;
                txtDDeviceOS.Text = d.OperatingSystem;
                txtDUserAgent.Text = d.UserAgent;
            }
            else
            {
                //Set
                //d=txt
            }

            //System.Net.ServicePointManager.ServerCertificateValidationCallback =
            //delegate(object sender2, X509Certificate certificate, X509Chain chain,
            //SslPolicyErrors sslPolicyErrors)
            //{ return true; };
                        
            //var webRequest = System.Net.WebRequest.Create(url) as HttpWebRequest;

            //if (webRequest != null)
            //{
            //    webRequest.Method = "POST";
            //    webRequest.ServicePoint.Expect100Continue = false;
            //    webRequest.Timeout = 2000000;
            //    webRequest.ContentType = "application/vnd.ms-sync.wbxml";                
            //    //webRequest.Proxy = new WebProxy("http://proxy.company.com:1234/");
             
            //    webRequest.Headers.Add("Authorization", "Basic " + "");
            //    webRequest.Headers.Add("MS-ASProtocolVersion", "14.1");
            //    webRequest.UserAgent = "Android/4.0.4-EAS-1.3";
            //    webRequest.Headers.Add("X-MS-PolicyKey", "0"); //Initial
            //    //webRequest.Headers.Add("X-MS-PolicyKey", "1961726074"); //Temp
            //    //webRequest.Headers.Add("X-MS-PolicyKey", "1984334933"); //Permanent

            //    //byte[] wbReqData = WBXML.Manager.EncodeXMLString(Provision2()); //Ack
            //    //byte[] wbReqData = WBXML.Manager.EncodeXMLString(FolderSync());
            //    //byte[] wbReqData = WBXML.Manager.EncodeXMLString(Sync("0", "6"));                
            //    //byte[] wbReqData = WBXML.Manager.EncodeXMLString(Sync2("1724699591", "6"));
            //    //byte[] wbReqData = WBXML.Manager.EncodeXMLString(Settings());

            //    if(wbReqData != null)
            //        webRequest.ContentLength = wbReqData.Length;
            //    else
            //        webRequest.ContentLength = 0;


            //    //POST the data.   
            //    //using (requestWriter = new StreamWriter(webRequest.GetRequestStream()))
            //    //{
            //    //    requestWriter.Write(wbReqData);
            //    //}
            //    Stream sw = webRequest.GetRequestStream();
            //    sw.Write(wbReqData, 0, wbReqData.Length);
            //    sw.Close();

            //    //X509Certificate cert = X509Certificate.CreateFromCertFile("D:\\userid\\EASApp\\EASApp\\username.cer");
            //    //webRequest.ClientCertificates.Add(cert);

            //    HttpWebResponse resp = (HttpWebResponse)webRequest.GetResponse();
            //    string res = ASCommandResponse(resp);
            //    int status = SetStatus(res);
            //    //Stream resStream = resp.GetResponseStream();
            //    //StreamReader reader = new StreamReader(resStream);
            //    //string responseBody = reader.ReadToEnd();
            //    //Byte[] byteResp = System.Text.Encoding.UTF8.GetBytes(responseBody);
            //    //string res = WBXML.Manager.DecodeWBXML(byteResp);                                
            //}
        }
        protected void btnProvision_Click(object sender, EventArgs e)
        {
            byte[] wbReqData1 = EAS.Manager.EncodeXMLString(Provision1()); //Initial
            string res1 = EASRequest("Provision", wbReqData1,"0");
            txtResponse.Text = res1;
        }
        protected void btnSettings_Click(object sender, EventArgs e)
        {
            byte[] wbReqData1 = EAS.Manager.EncodeXMLString(Settings()); //Initial
            string policyKey = txtPolicyKey.Text;
            string res1 = EASRequest("Settings", wbReqData1, policyKey);
            txtResponse.Text = res1;
        }
        protected void btnProvisionAck_Click(object sender, EventArgs e)
        {
            string tempPolicyKey = txtTempPolicyKey.Text;
            byte[] wbReqData2 = EAS.Manager.EncodeXMLString(Provision2(tempPolicyKey)); //Initial
            string res2 = EASRequest("Provision", wbReqData2,"0");
            txtResponse.Text = res2;
        }
        protected void btnFolderSync_Click(object sender, EventArgs e)
        {
            string policyKey = txtPolicyKey.Text;
            byte[] wbReqData3 = EAS.Manager.EncodeXMLString(FolderSync()); //Initial
            string res3 = EASRequest("FolderSync", wbReqData3, policyKey);
            txtResponse.Text = res3;
        }
        protected void btnSync_Click(object sender, EventArgs e)
        {
            string policyKey = txtPolicyKey.Text;
            string collectionId = txtServerId.Text;
            byte[] wbReqData4 = EAS.Manager.EncodeXMLString(Sync("0",collectionId)); //Initial
            string res4 = EASRequest("Sync", wbReqData4, policyKey);
            txtResponse.Text = res4;
        }
        protected void btnSync2_Click(object sender, EventArgs e)
        {
            string policyKey = txtPolicyKey.Text;
            string collectionId = txtServerId.Text;
            string syncKey = txtSyncKey.Text;
            byte[] wbReqData5 = EAS.Manager.EncodeXMLString(Sync2(syncKey, collectionId)); //Initial
            string res5 = EASRequest("Sync", wbReqData5, policyKey);
            txtResponse.Text = res5;
        }
        protected void btnSync3_Click(object sender, EventArgs e)
        {
            string policyKey = txtPolicyKey.Text;
            string collectionId = txtServerId.Text;
            string syncKey = txtSyncKey.Text;
            byte[] wbReqData5 = EAS.Manager.EncodeXMLString(Sync3(syncKey, collectionId));
            string res5 = EASRequest("Sync", wbReqData5, policyKey);
            txtResponse.Text = res5;
        }
        protected void btnPing_Click(object sender, EventArgs e)
        {
            string policyKey = txtPolicyKey.Text;         
            byte[] wbReqData5 = EAS.Manager.EncodeXMLString(Ping());
            string res5 = EASRequest("Ping", wbReqData5, policyKey);
            txtResponse.Text = res5;
        }
        void Connect(string server, string user, string deviceId, string deviceType, string cmd)
        {
            string url = server + "//Microsoft-Server-ActiveSync//default.eas?User=" + user + "&DeviceId=" + deviceId + "&DeviceType=" + deviceType + "&Cmd=" + cmd;
        }
        string FolderSync()
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<folderhierarchy:FolderSync xmlns:folderhierarchy=\"FolderHierarchy\">";
            reqXml += "<folderhierarchy:SyncKey>0</folderhierarchy:SyncKey>";
            reqXml += "</folderhierarchy:FolderSync>";
            return reqXml;
        }
        string Provision1()
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<provision:Provision xmlns:provision=\"Provision\">";

            if (protocolVersion == "14.1")
            {
                reqXml += "<settings:DeviceInformation xmlns:settings=\"Settings\">";
                reqXml += "<settings:Set>";

                reqXml += "<settings:Model>ST15i</settings:Model>";
                reqXml += "<settings:OS>Android 4.0.4</settings:OS>";
                reqXml += "<settings:UserAgent>Android/4.0.4-EAS-1.3</settings:UserAgent>";

                //reqXml += "<settings:Model>iPad3C6</settings:Model>";
                //reqXml += "<settings:UserAgent>iOS/7.0.2 (11A501) dataaccessd/1.0</settings:UserAgent>";
                //reqXml += "<settings:OS>iOS 7.0.2 11A501</settings:OS>";
                //reqXml += "<settings:OSLanguage>en-GB</settings:OSLanguage>";
                //reqXml += "<settings:FriendlyName>Black iPad</settings:FriendlyName>";

                reqXml += "</settings:Set>";
                reqXml += "</settings:DeviceInformation>";
            }
            reqXml += "<provision:Policies>";
            reqXml += "<provision:Policy>";
            reqXml += "<provision:PolicyType>MS-EAS-Provisioning-WBXML</provision:PolicyType>";
            reqXml += "</provision:Policy>";
            reqXml += "</provision:Policies>";
            reqXml += "</provision:Provision>";
            return reqXml;
        }
        string Provision12()
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<provision:Provision xmlns:provision=\"Provision\">";           
            reqXml += "<provision:Policies>";
            reqXml += "<provision:Policy>";
            reqXml += "<provision:PolicyType>MS-EAS-Provisioning-WBXML</provision:PolicyType>";
            reqXml += "</provision:Policy>";
            reqXml += "</provision:Policies>";
            reqXml += "</provision:Provision>";
            return reqXml;
        }
        string Provision2(string tempPolicyKey)
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<provision:Provision xmlns:provision=\"Provision\">";
            reqXml += "<provision:Policies>";
            reqXml += "<provision:Policy>";
            reqXml += "<provision:PolicyType>MS-EAS-Provisioning-WBXML</provision:PolicyType>";
            reqXml += "<provision:PolicyKey>" + tempPolicyKey + "</provision:PolicyKey>";
            reqXml += "<provision:Status>1</provision:Status>";
            reqXml += "</provision:Policy>";
            reqXml += "</provision:Policies>";
            reqXml += "</provision:Provision>";
            return reqXml;

        }
        string Sync(string syncKey, string collectionId)
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<airsync:Sync xmlns:airsync=\"AirSync\">";
            reqXml += "<airsync:Collections>";
            reqXml += "<airsync:Collection>";
            reqXml += "<airsync:SyncKey>" + syncKey + "</airsync:SyncKey>";
            reqXml += "<airsync:CollectionId>" + collectionId + "</airsync:CollectionId>";
            reqXml += "</airsync:Collection>";
            reqXml += "</airsync:Collections>";
            reqXml += "</airsync:Sync>";
            return reqXml;
        }
        string Sync2(string syncKey, string collectionId)
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<airsync:Sync xmlns:airsync=\"AirSync\" xmlns:rightsmanagement=\"RightsManagement\" >";
            reqXml += "<airsync:Collections>";
            reqXml += "<airsync:Collection>";
            reqXml += "<airsync:SyncKey>" + syncKey + "</airsync:SyncKey>";
            reqXml += "<airsync:CollectionId>" + collectionId + "</airsync:CollectionId>";
            //reqXml += "<airsync:ConversationMode>1</airsync:ConversationMode>";

            reqXml += "<airsync:DeletesAsMoves>1</airsync:DeletesAsMoves>";
            reqXml += "<airsync:GetChanges />";
            //<airsync:WindowSize>5</airsync:WindowSize>

            
            reqXml += "<airsync:Options>";
            reqXml += "<rightsmanagement:RightsManagementSupport>1</rightsmanagement:RightsManagementSupport> ";
            reqXml += "<airsyncbase:BodyPreference xmlns:airsyncbase=\"AirSyncBase\">";
            reqXml += "<airsyncbase:Type>1</airsyncbase:Type>";
            //reqXml += "<airsyncbase:TruncationSize>200000</airsyncbase:TruncationSize>";
            reqXml += "<airsyncbase:TruncationSize>5120</airsyncbase:TruncationSize>";
            //reqXml += "<airsyncbase:Preview>100</airsyncbase:Preview>";
            reqXml += "</airsyncbase:BodyPreference>";
            reqXml += "</airsync:Options>";

           

            reqXml += "</airsync:Collection>";
            reqXml += "</airsync:Collections>";
            reqXml += "</airsync:Sync>";
            return reqXml;
        }
        string Sync3(string syncKey, string collectionId)
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<airsync:Sync xmlns:airsync=\"AirSync\" xmlns:rightsmanagement=\"RightsManagement\" >";
            reqXml += "<airsync:Collections>";
            reqXml += "<airsync:Collection>";
            reqXml += "<airsync:SyncKey>" + syncKey + "</airsync:SyncKey>";
            reqXml += "<airsync:CollectionId>" + collectionId + "</airsync:CollectionId>";
            reqXml += "<airsync:GetChanges>0</airsync:GetChanges>";
            reqXml += "<airsync:Options>";
            reqXml += "<airsync:FilterType>3</airsync:FilterType>";
            reqXml += "<airsync:MIMESupport>2</airsync:MIMESupport>";
            reqXml += "<rightsmanagement:RightsManagementSupport>1</rightsmanagement:RightsManagementSupport> ";
            reqXml += "<airsyncbase:BodyPreference xmlns:airsyncbase=\"AirSyncBase\">";
            reqXml += "<airsyncbase:Type>4</airsyncbase:Type>";
            reqXml += "<airsyncbase:TruncationSize>32768</airsyncbase:TruncationSize>";
            reqXml += "</airsyncbase:BodyPreference>";
            reqXml += "</airsync:Options>";

            if (!string.IsNullOrEmpty(txtFileRef.Text))
            {
                reqXml += "<airsync:Commands>";
                reqXml += "<airsync:Fetch>";
                reqXml += "<airsync:ServerId>" + txtFileRef.Text + "</airsync:ServerId>";
                reqXml += "</airsync:Fetch>";
                reqXml += "</airsync:Commands>";
            }


            reqXml += "</airsync:Collection>";
            reqXml += "</airsync:Collections>";
            reqXml += "</airsync:Sync>";

            return reqXml;
        }
        string Settings()
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<settings:Settings xmlns:settings=\"Settings\">";
            //reqXml += "<settings:RightsManagementInformation>";
            //reqXml += "<settings:Get/>";
            //reqXml += "</settings:RightsManagementInformation>";
            reqXml += "<settings:UserInformation>";
            reqXml += "<settings:Get/>";
            reqXml += "</settings:UserInformation>";
            reqXml += "</settings:Settings>";
            return reqXml;

            /*<!--Response-->
            <?xml version="1.0" encoding="utf-8"?>
            <settings:Settings xmlns:settings="Settings">
              <settings:Status>1</settings:Status>
              <settings:RightsManagementInformation>
                <settings:Status>168</settings:Status>
                <settings:Get>
                  <rightsmanagement:RightsManagementTemplates xmlns:rightsmanagement="RightsManagement" />
                </settings:Get>
              </settings:RightsManagementInformation>
            </settings:Settings>
            */

            /*<!--Response-->
            <?xml version="1.0" encoding="utf-8"?>
            <settings:Settings xmlns:settings="Settings">
              <settings:Status>1</settings:Status>
              <settings:RightsManagementInformation>
                <settings:Status>1</settings:Status>
                <settings:Get>
                  <rightsmanagement:RightsManagementTemplates xmlns:rightsmanagement="RightsManagement">
                    <rightsmanagement:RightsManagementTemplate>
                      <rightsmanagement:TemplateID>cf5cf348-a8d7-40d5-91ef-a600b88a395d</rightsmanagement:TemplateID>
                      <rightsmanagement:TemplateName>Do Not Forward</rightsmanagement:TemplateName>
                      <rightsmanagement:TemplateDescription>Recipients can read this message, but they can't forward, print, or copy content. The conversation owner has full permission to their message and all replies.</rightsmanagement:TemplateDescription>
                    </rightsmanagement:RightsManagementTemplate>
                    <rightsmanagement:RightsManagementTemplate>
                      <rightsmanagement:TemplateID>0a2e6137-ff6a-4baa-b62f-c3fb65252692</rightsmanagement:TemplateID>
                      <rightsmanagement:TemplateName>company Confidential_Do not Edit</rightsmanagement:TemplateName>
                      <rightsmanagement:TemplateDescription>Recipients can read forward, print, Reply, Reply All this message, but cannot edit or copy the content. The Conversation owner has full permission to their message and all replies.</rightsmanagement:TemplateDescription>
                    </rightsmanagement:RightsManagementTemplate>
                    <rightsmanagement:RightsManagementTemplate>
                      <rightsmanagement:TemplateID>61cb543f-9acc-42c8-8992-28400dd6ab1a</rightsmanagement:TemplateID>
                      <rightsmanagement:TemplateName>company Confidential_View Only</rightsmanagement:TemplateName>
                      <rightsmanagement:TemplateDescription>Recipients can read this message, but cannot edit, print, or copy content. The conversation owner has full permission to the message and all replies</rightsmanagement:TemplateDescription>
                    </rightsmanagement:RightsManagementTemplate>
                    <rightsmanagement:RightsManagementTemplate>
                      <rightsmanagement:TemplateID>de2a0c52-2643-483e-a5ea-1e332ea202fb</rightsmanagement:TemplateID>
                      <rightsmanagement:TemplateName>company General_Do Not Reply All</rightsmanagement:TemplateName>
                      <rightsmanagement:TemplateDescription>Recipients can read forward, Reply, print this message, but cannot Reply all or copy the content. The Conversation owner has full permission to their message and all replies.</rightsmanagement:TemplateDescription>
                    </rightsmanagement:RightsManagementTemplate>
                  </rightsmanagement:RightsManagementTemplates>
                </settings:Get>
              </settings:RightsManagementInformation>
            </settings:Settings>
             */
        }
        string GALSearch(string query)
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<search:Search xmlns:search=\"Search\">";
            reqXml += "<search:Store>";
            reqXml += "<search:Name>GAL</search:Name>";
            reqXml += "<search:Query>"+query+"</search:Query>";
            reqXml += "<search:Options>";
            reqXml += "<search:Range>0-19</search:Range>";
            reqXml += "<search:Picture>";
            reqXml += "<search:MaxSize>102400</search:MaxSize>";
            reqXml += "<search:MaxPictures>20</search:MaxPictures>";
            reqXml += "</search:Picture>";
            reqXml += "</search:Options>";
            reqXml += "</search:Store>";
            reqXml += "</search:Search>";
            return reqXml;
        }
        string Ping()
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<ping:Ping xmlns:ping=\"Ping\">";
            reqXml += "<ping:HeartbeatInterval>900</ping:HeartbeatInterval>";
            reqXml += "<ping:Folders>";
            //reqXml += "<ping:Folder>";
            //reqXml += "<ping:Id>1</ping:Id>";
            //reqXml += "<ping:Class>Calendar</ping:Class>";
            //reqXml += "</ping:Folder>";
            //reqXml += "<ping:Folder>";
            //reqXml += "<ping:Id>2</ping:Id>";
            //reqXml += "<ping:Class>Contadomain</ping:Class>";
            //reqXml += "</ping:Folder>";
            //reqXml += "<ping:Folder>";
            //reqXml += "<ping:Id>11</ping:Id>";
            //reqXml += "<ping:Class>Tasks</ping:Class>";
            //reqXml += "</ping:Folder>";
            reqXml += "<ping:Folder>";
            reqXml += "<ping:Id>5</ping:Id>";
            reqXml += "<ping:Class>Email</ping:Class>";
            reqXml += "</ping:Folder>";
            reqXml += "</ping:Folders>";
            reqXml += "</ping:Ping>";
            return reqXml;
        }
        public string SendMail()
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<composemail:SendMail xmlns:composemail=\"ComposeMail\">";            
            reqXml += "<composemail:ClientId>" + Guid.NewGuid().ToString().Replace("-", "") +"</composemail:ClientId>";            
            reqXml += "<composemail:SaveInSentItems />";
            reqXml += "<composemail:Mime>";
            string boundary = getTime().ToString();
            string mailTimeStamp = DateTime.Now.ToString("ddd, dd MMM yyyy HH':'mm':'ss '+0530'"); // Sat, 21 Jul 2007 15:12:16 GMT
            reqXml += "<![CDATA[Date: " + mailTimeStamp + "\r\n";
            reqXml += "Date: " + mailTimeStamp + "\r\n";
            reqXml += "Subject: " + txtSubject.Text + "\r\n";
            reqXml += "To: " + txtTo.Text + "\r\n";
            reqXml += "MIME-Version: 1.0" + "\r\n";
            reqXml += "Content-Type: multipart/alternative; boundary=\"--_com.android.email_" + boundary + "\"" + "\r\n";
            reqXml += "\r\n";
            reqXml += "----_com.android.email_" + boundary + "\r\n"; ;
            reqXml += "Content-Type: text/plain; charset=utf-8" + "\r\n"; ;
            reqXml += "Content-Transfer-Encoding: base64" + "\r\n"; ;
            reqXml += "\r\n";
            //reqXml += "V2hlbjogQXVnIDcsIDIwMTMgKGFsbCBkYXkpCldoZXJlOiBDaGVubmFpCi0tCkRlc2NyaXB0aW9u";
            //reqXml += "IGFidCBldmVudCBlZGl0ZWQ=" + "\r\n";
            reqXml += "----_com.android.email_" + boundary + "\r\n";
            //reqXml += "Content-Type: text/calendar; method=REQUEST;" + "\r\n";
            //reqXml += " name=\"invite.ics\"" + "\r\n";
            //reqXml += "Content-Transfer-Encoding: base64" + "\r\n";
            //reqXml += "\r\n";
            //reqXml += "QkVHSU46VkNBTEVOREFSDQpNRVRIT0Q6UkVRVUVTVA0KUFJPRElEOkFuZHJvaWRFbWFpbA0KVkVS";
            //reqXml += "U0lPTjoyLjANCkJFR0lOOlZFVkVOVA0KVUlEOmYyNWE4YmI4LTg0MzAtNGQyMS04NDY1LThhYzEw";
            //reqXml += "ZTIzMzRkNw0KRFRTVEFNUDoyMDEzMDgwNlQwNjQxNTlaDQpEVFNUQVJUO1ZBTFVFPURBVEU6MjAx";
            //reqXml += "MzA4MDcNCkRURU5EO1ZBTFVFPURBVEU6MjAxMzA4MDgNCkxPQ0FUSU9OOkNoZW5uYWkNClNVTU1B";
            //reqXml += "Ulk6VGVzdCBBZGQgRXZlbnQgRWRpdGVkDQpERVNDUklQVElPTjpXaGVuOiBBdWcgN1wsIDIwMTMg";
            //reqXml += "KGFsbCBkYXkpXG5XaGVyZTogQ2hlbm5haVxuLS1cbkRlc2NyaXB0aW8NCgluIGFidCBldmVudCBl";
            //reqXml += "ZGl0ZWQNClgtTUlDUk9TT0ZULUNETy1BTExEQVlFVkVOVDpUUlVFDQpBVFRFTkRFRTtST0xFPVJF";
            //reqXml += "US1QQVJUSUNJUEFOVDtQQVJUU1RBVD1ORUVEUy1BQ1RJT047UlNWUD1UUlVFOk1BSUxUTzphamkN";
            //reqXml += "Cgl0aEB0cnVib3htZG1kZXYuY29tDQpPUkdBTklaRVI6TUFJTFRPOnNhbmplZXZpQHRydWJveG1k";
            //reqXml += "bWRldi5jb20NCkNMQVNTOlBVQkxJQw0KU1RBVFVTOkNPTkZJUk1FRA0KVFJBTlNQOk9QQVFVRQ0K";
            //reqXml += "UFJJT1JJVFk6NQ0KU0VRVUVOQ0U6MQ0KRU5EOlZFVkVOVA0KRU5EOlZDQUxFTkRBUg0K" + "\r\n";
            reqXml += "\r\n\r\n";
            reqXml += "----_com.android.email_" + boundary  + "--" + "\r\n"; 
            reqXml += "]]>";
            reqXml += "</composemail:Mime>";
            reqXml += "</composemail:SendMail>";
            return reqXml;

        }
        private static DateTime JanFirst1970 = new DateTime(1970, 1, 1);
        public static long getTime()
        {
            //DateTime dt = DateTime.Parse("Tue, 06 Aug 2013 12:11:59 +0530");
            //return (long)((dt.ToUniversalTime() - JanFirst1970).TotalMilliseconds + 0.5);
            return (long)((DateTime.Now.ToUniversalTime() - JanFirst1970).TotalMilliseconds + 0.5);
        }
        public string EventMail()
        {
            string reqXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            reqXml += "<composemail:SendMail xmlns:composemail=\"ComposeMail\">";
            //reqXml += "<composemail:ClientId>SendMail-79840817759985</composemail:ClientId>";
            //reqXml += "<composemail:ClientId>" + Guid.NewGuid().ToString().Replace("-", "") +"</composemail:ClientId>";
            reqXml += "<composemail:ClientId>" + "2690423678c9411dae93049e1e3bf227" + "</composemail:ClientId>";
            reqXml += "<composemail:SaveInSentItems />";
            reqXml += "<composemail:Mime>";
            reqXml += "<![CDATA[Hello\r\nWorld";
            //reqXml += "<![CDATA[Date: Tue, 06 Aug 2013 12:11:59 +0530" + "\r\n";
            ////reqXml += "Date: Tue, 06 Aug 2013 12:11:59 +0530" + "\r\n";
            //reqXml += "Subject: Updated: Test Add Event Edited" + "\r\n";
            //reqXml += "To: ajith@domain.com" + "\r\n";
            //reqXml += "MIME-Version: 1.0" + "\r\n";
            //reqXml += "Content-Type: multipart/alternative; boundary=\"--_com.android.email_798407923388421\"" + "\r\n";
            //reqXml += "\r\n";
            //reqXml += "----_com.android.email_798407923388421" + "\r\n"; ;
            //reqXml += "Content-Type: text/plain; charset=utf-8" + "\r\n"; ;
            //reqXml += "Content-Transfer-Encoding: base64" + "\r\n"; ;
            //reqXml += "\r\n";
            //reqXml += "V2hlbjogQXVnIDcsIDIwMTMgKGFsbCBkYXkpCldoZXJlOiBDaGVubmFpCi0tCkRlc2NyaXB0aW9u";
            //reqXml += "IGFidCBldmVudCBlZGl0ZWQ=" + "\r\n";
            //reqXml += "----_com.android.email_798407923388421" + "\r\n";
            //reqXml += "Content-Type: text/calendar; method=REQUEST;" + "\r\n";
            //reqXml += " name=\"invite.ics\"" + "\r\n";
            //reqXml += "Content-Transfer-Encoding: base64" + "\r\n";
            //reqXml += "\r\n";
            //reqXml += "QkVHSU46VkNBTEVOREFSDQpNRVRIT0Q6UkVRVUVTVA0KUFJPRElEOkFuZHJvaWRFbWFpbA0KVkVS";
            //reqXml += "U0lPTjoyLjANCkJFR0lOOlZFVkVOVA0KVUlEOmYyNWE4YmI4LTg0MzAtNGQyMS04NDY1LThhYzEw";
            //reqXml += "ZTIzMzRkNw0KRFRTVEFNUDoyMDEzMDgwNlQwNjQxNTlaDQpEVFNUQVJUO1ZBTFVFPURBVEU6MjAx";
            //reqXml += "MzA4MDcNCkRURU5EO1ZBTFVFPURBVEU6MjAxMzA4MDgNCkxPQ0FUSU9OOkNoZW5uYWkNClNVTU1B";
            //reqXml += "Ulk6VGVzdCBBZGQgRXZlbnQgRWRpdGVkDQpERVNDUklQVElPTjpXaGVuOiBBdWcgN1wsIDIwMTMg";
            //reqXml += "KGFsbCBkYXkpXG5XaGVyZTogQ2hlbm5haVxuLS1cbkRlc2NyaXB0aW8NCgluIGFidCBldmVudCBl";
            //reqXml += "ZGl0ZWQNClgtTUlDUk9TT0ZULUNETy1BTExEQVlFVkVOVDpUUlVFDQpBVFRFTkRFRTtST0xFPVJF";
            //reqXml += "US1QQVJUSUNJUEFOVDtQQVJUU1RBVD1ORUVEUy1BQ1RJT047UlNWUD1UUlVFOk1BSUxUTzphamkN";
            //reqXml += "Cgl0aEB0cnVib3htZG1kZXYuY29tDQpPUkdBTklaRVI6TUFJTFRPOnNhbmplZXZpQHRydWJveG1k";
            //reqXml += "bWRldi5jb20NCkNMQVNTOlBVQkxJQw0KU1RBVFVTOkNPTkZJUk1FRA0KVFJBTlNQOk9QQVFVRQ0K";
            //reqXml += "UFJJT1JJVFk6NQ0KU0VRVUVOQ0U6MQ0KRU5EOlZFVkVOVA0KRU5EOlZDQUxFTkRBUg0K" + "\r\n";
            //reqXml += "\r\n\r\n";
            //reqXml += "----_com.android.email_798407923388421--" + "\r\n"; 
            reqXml +="]]>";
            reqXml +="</composemail:Mime>";
            reqXml += "</composemail:SendMail>";

            return reqXml;
        }
        public string ASCommandResponse(HttpWebResponse httpResponse)
        {
            //httpStatus = httpResponse.StatusCode;

            Stream responseStream = httpResponse.GetResponseStream();
            List<byte> bytes = new List<byte>();
            byte[] byteBuffer = new byte[256];
            int count = 0;

            // Read the WBXML data from the response stream
            // 256 bytes at a time.
            count = responseStream.Read(byteBuffer, 0, 256);
            while (count > 0)
            {
                // Add the 256 bytes to the List
                bytes.AddRange(byteBuffer);

                if (count < 256)
                {
                    // If the last read did not actually read 256 bytes
                    // remove the extra.
                    int excess = 256 - count;
                    bytes.RemoveRange(bytes.Count - excess, excess);
                }

                // Read the next 256 bytes from the response stream
                count = responseStream.Read(byteBuffer, 0, 256);
            }

            byte[] wbxmlBytes = bytes.ToArray();

            //string inp = "";
            //foreach (byte b in wbxmlBytes)
            //{
            //    inp += b.ToString() + " "; // "\",@\"";
            //    //inp += String.Format("{0:X2}", b) + " "; // "\",@\"";
            //}
            //txtResponseWbxml.Text = inp.Trim();
            

            // Decode the WBXML
            return EAS.Manager.DecodeWBXML(wbxmlBytes);
        }
        public int SetStatus(string xmlResponse)
        {
            XmlDocument responseXml = new XmlDocument();
            responseXml.LoadXml(xmlResponse);
            
            XmlNamespaceManager xmlNsMgr = new XmlNamespaceManager(responseXml.NameTable);
            xmlNsMgr.AddNamespace("provision", "Provision");

            XmlNode provisionNode = responseXml.SeledomainingleNode(".//provision:Provision", xmlNsMgr);
            XmlNode statusNode = null;
            if (provisionNode != null)
                statusNode = provisionNode.SeledomainingleNode(".//provision:Status", xmlNsMgr);

            if (statusNode != null)
                return XmlConvert.ToInt32(statusNode.InnerText);
            else
                return -1;
        }
        public string EASRequest(string cmd,byte[] wbReqData,string policyKey)
        {            

            var webRequest = System.Net.WebRequest.Create(url+cmd+"&Source=SafeSpace") as HttpWebRequest;

            if (webRequest != null)
            {
                webRequest.Method = "POST";
                webRequest.ServicePoint.Expect100Continue = false;
                webRequest.Timeout = 2000000;
                webRequest.ContentType = "application/vnd.ms-sync.wbxml";
                
                //webRequest.Proxy = new WebProxy("http://proxy.company.com:1234/");
                //webRequest.Proxy = new WebProxy("10.1.1.1:1234", false);
                webRequest.Credentials = new NetworkCredential("userid", "#include3", "domain"); 

                
                //webRequest.Headers.Add("Authorization", "Basic " + Utilities.Basic64Credentials(strRawCredentials));
                //X509Certificate clientCert = new X509Certificate("D:\\userid\\EASApp\\EASApp\\username_nov15.pfx", "pass");
                //X509Certificate2 clientCert2 = new X509Certificate2("D:\\userid\\Certificates\\username_nov15.pfx", "pass");
                //X509Certificate2 clientCert3 = new X509Certificate2("D:\\userid\\Certificates\\username_userid.pfx", "company");
                X509Certificate clientCert = new X509Certificate("D:\\userid\\Certificates\\username_userid.pfx", "company");
                //X509Certificate clientCert = new X509Certificate("D:\\userid\\Certificates\\username_2003_Dec17.pfx", "pass");
                //IsValidClientCertificate(clientCert3);
                webRequest.ClientCertificates.Add(clientCert);
                webRequest.Headers.Add("MS-ASProtocolVersion", protocolVersion);
                //webRequest.Headers.Add("MS-ASProtocolVersion", "12.1");
                //webRequest.UserAgent = "Android/4.0.4-EAS-1.3";
                webRequest.UserAgent = "usernameApp";
                webRequest.Headers.Add("X-MS-PolicyKey", policyKey); //Initial
                //webRequest.Headers.Add("X-MS-PolicyKey", "1961726074"); //Temp
                //webRequest.Headers.Add("X-MS-PolicyKey", "1984334933"); //Permanent


                //byte[] wbReqData = EAS.Manager.EncodeXMLString(Provision1()); //Initial
                //byte[] wbReqData = WBXML.Manager.EncodeXMLString(Provision2()); //Ack
                //byte[] wbReqData = WBXML.Manager.EncodeXMLString(FolderSync());
                //byte[] wbReqData = WBXML.Manager.EncodeXMLString(Sync("0", "6"));                
                //byte[] wbReqData = WBXML.Manager.EncodeXMLString(Sync2("1724699591", "6"));
                //byte[] wbReqData = WBXML.Manager.EncodeXMLString(Settings());

                if (wbReqData != null)
                    webRequest.ContentLength = wbReqData.Length;
                else
                    webRequest.ContentLength = 0;


                //POST the data.   
                //using (requestWriter = new StreamWriter(webRequest.GetRequestStream()))
                //{
                //    requestWriter.Write(wbReqData);
                //}

                Stream sw = webRequest.GetRequestStream();
                sw.Write(wbReqData, 0, wbReqData.Length);
                sw.Close();

                //X509Certificate cert = X509Certificate.CreateFromCertFile("D:\\userid\\Certificates\\raghav.pfx");
                //webRequest.ClientCertificates.Add(cert);

                //HttpWebResponse resp = (HttpWebResponse)webRequest.GetResponse();
                //string res = ASCommandResponse(resp);
                string res = "";
                try
                {
                    HttpWebResponse resp = (HttpWebResponse)webRequest.GetResponse();
                    res = ASCommandResponse(resp);
                }
                catch (WebException ex)
                {
                    StreamReader read = new StreamReader(ex.Response.GetResponseStream());
                    String data = read.ReadToEnd();
                    string x = ex.Message;
                }
                catch (Exception ex)
                {
                    string x = ex.Message;
                }

                return res;

                //int status = SetStatus(res);
                //Stream resStream = resp.GetResponseStream();
                //StreamReader reader = new StreamReader(resStream);
                //string responseBody = reader.ReadToEnd();
                //Byte[] byteResp = System.Text.Encoding.UTF8.GetBytes(responseBody);
                //string res = WBXML.Manager.DecodeWBXML(byteResp);                                
            }
            else
                return string.Empty;

        }
        protected void btnSendMail_Click(object sender, EventArgs e)
        {
           

            /*
            #region "Two bits string to byte[]"
            string data="03 01 6a 00 00 15 45 51 03 32 36 39 30 34 32 33 36 37 38 63 39 34 31 31 64 61 65 39 33 30 34 39 65 31 65 33 62 66 32 32 37 00 01 08 50 c3 8b 2e 44 61 74 65 3a 20 54 75 65 2c 20 30 36 20 41 75 67 20 32 30 31 33 20 31 32 3a 31 31 3a 35 39 20 2b 30 35 33 30 0d 0a 53 75 62 6a 65 63 74 3a 20 55 70 64 61 74 65 64 3a 20 54 65 73 74 20 41 64 64 20 45 76 65 6e 74 20 45 64 69 74 65 64 0d 0a 54 6f 3a 20 61 6a 69 74 68 40 74 72 75 62 6f 78 6d 64 6d 64 65 76 2e 63 6f 6d 0d 0a 4d 49 4d 45 2d 56 65 72 73 69 6f 6e 3a 20 31 2e 30 0d 0a 43 6f 6e 74 65 6e 74 2d 54 79 70 65 3a 20 6d 75 6c 74 69 70 61 72 74 2f 61 6c 74 65 72 6e 61 74 69 76 65 3b 20 62 6f 75 6e 64 61 72 79 3d 22 2d 2d 5f 63 6f 6d 2e 61 6e 64 72 6f 69 64 2e 65 6d 61 69 6c 5f 37 39 38 34 30 37 39 32 33 33 38 38 34 32 31 22 0d 0a 0d 0a 2d 2d 2d 2d 5f 63 6f 6d 2e 61 6e 64 72 6f 69 64 2e 65 6d 61 69 6c 5f 37 39 38 34 30 37 39 32 33 33 38 38 34 32 31 0d 0a 43 6f 6e 74 65 6e 74 2d 54 79 70 65 3a 20 74 65 78 74 2f 70 6c 61 69 6e 3b 20 63 68 61 72 73 65 74 3d 75 74 66 2d 38 0d 0a 43 6f 6e 74 65 6e 74 2d 54 72 61 6e 73 66 65 72 2d 45 6e 63 6f 64 69 6e 67 3a 20 62 61 73 65 36 34 0d 0a 0d 0a 56 32 68 6c 62 6a 6f 67 51 58 56 6e 49 44 63 73 49 44 49 77 4d 54 4d 67 4b 47 46 73 62 43 42 6b 59 58 6b 70 43 6c 64 6f 5a 58 4a 6c 4f 69 42 44 61 47 56 75 62 6d 46 70 43 69 30 74 43 6b 52 6c 63 32 4e 79 61 58 42 30 61 57 39 75 49 47 46 69 64 43 42 6c 64 6d 56 75 64 43 42 6c 5a 47 6c 30 5a 57 51 3d 0d 0a 2d 2d 2d 2d 5f 63 6f 6d 2e 61 6e 64 72 6f 69 64 2e 65 6d 61 69 6c 5f 37 39 38 34 30 37 39 32 33 33 38 38 34 32 31 0d 0a 43 6f 6e 74 65 6e 74 2d 54 79 70 65 3a 20 74 65 78 74 2f 63 61 6c 65 6e 64 61 72 3b 20 6d 65 74 68 6f 64 3d 52 45 51 55 45 53 54 3b 0d 0a 20 6e 61 6d 65 3d 22 69 6e 76 69 74 65 2e 69 63 73 22 0d 0a 43 6f 6e 74 65 6e 74 2d 54 72 61 6e 73 66 65 72 2d 45 6e 63 6f 64 69 6e 67 3a 20 62 61 73 65 36 34 0d 0a 0d 0a 51 6b 56 48 53 55 34 36 56 6b 4e 42 54 45 56 4f 52 45 46 53 44 51 70 4e 52 56 52 49 54 30 51 36 55 6b 56 52 56 55 56 54 56 41 30 4b 55 46 4a 50 52 45 6c 45 4f 6b 46 75 5a 48 4a 76 61 57 52 46 62 57 46 70 62 41 30 4b 56 6b 56 53 55 30 6c 50 54 6a 6f 79 4c 6a 41 4e 43 6b 4a 46 52 30 6c 4f 4f 6c 5a 46 56 6b 56 4f 56 41 30 4b 56 55 6c 45 4f 6d 59 79 4e 57 45 34 59 6d 49 34 4c 54 67 30 4d 7a 41 74 4e 47 51 79 4d 53 30 34 4e 44 59 31 4c 54 68 68 59 7a 45 77 5a 54 49 7a 4d 7a 52 6b 4e 77 30 4b 52 46 52 54 56 45 46 4e 55 44 6f 79 4d 44 45 7a 4d 44 67 77 4e 6c 51 77 4e 6a 51 78 4e 54 6c 61 44 51 70 45 56 46 4e 55 51 56 4a 55 4f 31 5a 42 54 46 56 46 50 55 52 42 56 45 55 36 4d 6a 41 78 4d 7a 41 34 4d 44 63 4e 43 6b 52 55 52 55 35 45 4f 31 5a 42 54 46 56 46 50 55 52 42 56 45 55 36 4d 6a 41 78 4d 7a 41 34 4d 44 67 4e 43 6b 78 50 51 30 46 55 53 55 39 4f 4f 6b 4e 6f 5a 57 35 75 59 57 6b 4e 43 6c 4e 56 54 55 31 42 55 6c 6b 36 56 47 56 7a 64 43 42 42 5a 47 51 67 52 58 5a 6c 62 6e 51 67 52 57 52 70 64 47 56 6b 44 51 70 45 52 56 4e 44 55 6b 6c 51 56 45 6c 50 54 6a 70 58 61 47 56 75 4f 69 42 42 64 57 63 67 4e 31 77 73 49 44 49 77 4d 54 4d 67 4b 47 46 73 62 43 42 6b 59 58 6b 70 58 47 35 58 61 47 56 79 5a 54 6f 67 51 32 68 6c 62 6d 35 68 61 56 78 75 4c 53 31 63 62 6b 52 6c 63 32 4e 79 61 58 42 30 61 57 38 4e 43 67 6c 75 49 47 46 69 64 43 42 6c 64 6d 56 75 64 43 42 6c 5a 47 6c 30 5a 57 51 4e 43 6c 67 74 54 55 6c 44 55 6b 39 54 54 30 5a 55 4c 55 4e 45 54 79 31 42 54 45 78 45 51 56 6c 46 56 6b 56 4f 56 44 70 55 55 6c 56 46 44 51 70 42 56 46 52 46 54 6b 52 46 52 54 74 53 54 30 78 46 50 56 4a 46 55 53 31 51 51 56 4a 55 53 55 4e 4a 55 45 46 4f 56 44 74 51 51 56 4a 55 55 31 52 42 56 44 31 4f 52 55 56 45 55 79 31 42 51 31 52 4a 54 30 34 37 55 6c 4e 57 55 44 31 55 55 6c 56 46 4f 6b 31 42 53 55 78 55 54 7a 70 68 61 6d 6b 4e 43 67 6c 30 61 45 42 30 63 6e 56 69 62 33 68 74 5a 47 31 6b 5a 58 59 75 59 32 39 74 44 51 70 50 55 6b 64 42 54 6b 6c 61 52 56 49 36 54 55 46 4a 54 46 52 50 4f 6e 4e 68 62 6d 70 6c 5a 58 5a 70 51 48 52 79 64 57 4a 76 65 47 31 6b 62 57 52 6c 64 69 35 6a 62 32 30 4e 43 6b 4e 4d 51 56 4e 54 4f 6c 42 56 51 6b 78 4a 51 77 30 4b 55 31 52 42 56 46 56 54 4f 6b 4e 50 54 6b 5a 4a 55 6b 31 46 52 41 30 4b 56 46 4a 42 54 6c 4e 51 4f 6b 39 51 51 56 46 56 52 51 30 4b 55 46 4a 4a 54 31 4a 4a 56 46 6b 36 4e 51 30 4b 55 30 56 52 56 55 56 4f 51 30 55 36 4d 51 30 4b 52 55 35 45 4f 6c 5a 46 56 6b 56 4f 56 41 30 4b 52 55 35 45 4f 6c 5a 44 51 55 78 46 54 6b 52 42 55 67 30 4b 0d 0a 0d 0a 0d 0a 2d 2d 2d 2d 5f 63 6f 6d 2e 61 6e 64 72 6f 69 64 2e 65 6d 61 69 6c 5f 37 39 38 34 30 37 39 32 33 33 38 38 34 32 31 2d 2d 0d 0a 01 01";

            string[] wbxml = data.Trim().Split(' ');
            byte[] wbReqData3 = new byte[wbxml.Length];
            for (int i = 0; i < wbxml.Length; i++)
            {
                try
                {
                    wbReqData3[i] = byte.Parse(Convert.ToInt32(wbxml[i], 16).ToString());
                }
                catch (Exception ex)
                {
                    
                }
            }
            #endregion

            //byte[] wbReqData3 = EAS.Manager.EncodeXMLString(EventMail()); //Initial

            if (wbReqData3 != null)
            {
                string inp = "";
                #region "Print byte array to two bits string"
                //foreach (byte b in wbReqData3)
                //{
                //    inp += String.Format("{0:X2}", b) + " "; // "\",@\"";
                //}
                #endregion

                //#region "Print byte array to four bits string"
                //int i = 0;
                //foreach (byte b in wbReqData3)
                //{

                //    inp += String.Format("{0:X2}", b);
                //    i++;
                //    if (i % 4 == 0)
                //    {
                //        inp += " "; // "\",@\"";
                //    }
                //    //inp += String.Format("{0:X2}", b) + " "; // "\",@\"";

                //    //inp += b.ToString() + ", "; // "\",@\"";

                //}
                //#endregion
                txtResponse.Text = inp.Trim();
            }
            //string s = EAS.Manager.DecodeWBXML(wbReqData3);
             string res3 = EASRequest("SendMail", wbReqData3, policyKey);
            */

            byte[] wbReqData1 = EAS.Manager.EncodeXMLString(SendMail()); //Initial
            string policyKey = txtPolicyKey.Text;
            string res1 = EASRequest("SendMail", wbReqData1, policyKey);
            txtResponse.Text = res1;            
        }
        protected void btnParseDeviceInfo_Click(object sender, EventArgs e)
        {
            string provisionXml = Provision1();
            ParseProvisonRequest(provisionXml);

            string provision2Xml = Provision2("12");
            ParseProvisonRequest(provision2Xml);
        }
        protected void txtQuery_OnTextChanged(object sender, EventArgs e)
        {
            string query = txtQuery.Text;
            if (!string.IsNullOrEmpty(query))
            {
                string policyKey = txtPolicyKey.Text;

                byte[] wbReqData6 = EAS.Manager.EncodeXMLString(GALSearch(query));
                string res6 = EASRequest("Search", wbReqData6, policyKey);
                txtResponse.Text = res6;
            }
            
        }        
        public bool ParseProvisonRequest(string policyXml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            Device device = new Device();
            try
            {
                xmlDoc.LoadXml(policyXml);

                XmlNamespaceManager xmlNsMgr = new XmlNamespaceManager(xmlDoc.NameTable);
                xmlNsMgr.AddNamespace("provision", "Provision");
                xmlNsMgr.AddNamespace("settings", "Settings");
         
                XmlNode provisionNode = xmlDoc.SeledomainingleNode(".//provision:Provision", xmlNsMgr);

                if (provisionNode != null)
                {
                    //Initial Provision Request

                    XmlNode deviceInfoNode = xmlDoc.SeledomainingleNode(".//settings:DeviceInformation", xmlNsMgr);

                    if (deviceInfoNode != null)
                    {
                        XmlNode osNode = provisionNode.SeledomainingleNode(".//settings:OS", xmlNsMgr);
                        if (osNode != null)
                            device.OperatingSystem = osNode.InnerText;

                        XmlNode modelNode = provisionNode.SeledomainingleNode(".//settings:Model", xmlNsMgr);
                        if (modelNode != null)
                            device.Model = modelNode.InnerText;

                        XmlNode userAgentNode = provisionNode.SeledomainingleNode(".//settings:UserAgent", xmlNsMgr);
                        if (userAgentNode != null)
                            device.UserAgent = userAgentNode.InnerText;

                        XmlNode imeiNode = provisionNode.SeledomainingleNode(".//settings:IMEI", xmlNsMgr);
                        if (imeiNode != null)
                            device.IMEI = imeiNode.InnerText;
                    }
                    else
                    {
                        //Provision Acknowledge Request
                        XmlNode tempPolicyKeyNode = xmlDoc.SeledomainingleNode(".//provision:PolicyKey", xmlNsMgr);
                        if (tempPolicyKeyNode != null)
                        {
                            //txtTempPolicyKey.Text = tempPolicyKeyNode.InnerText;
                        }

                        //XmlNode statusNode = provisionNode.SeledomainingleNode(".//provision:Status", xmlNsMgr);
                        //if (statusNode != null)
                        //    lblStatus.Text = statusNode.InnerText;

                        //XmlNode remoteWipe = provisionNode.SeledomainingleNode(".//provision:RemoteWipe", xmlNsMgr);
                        //if (remoteWipe != null)
                        //{
                        //}                        
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public string GenerateAutoDiscoverResponse(string requestRelationUUID)
        {
//            string responseXml = string.Empty;
//            responseXml += "<s:Envelope xmlns:a=\"http://www.w3.org/2005/08/addressing\" xmlns:s=\"http://www.w3.org/2003/05/soap-envelope\">";
//            responseXml += "<s:Header>";
//        responseXml += "<a:Action s:mustUnderstand=\"1\">http://schemas.microsoft.com/windows/management/2012/01/enrollment/IDiscoveryService/Discover</a:Action>";
//        responseXml += "<a:MessageID>urn:uuid:748132ec-a575-4329-b01b-6171a9cf8478</a:MessageID>";
//        responseXml += "<a:ReplyTo>";
//            responseXml += "<a:Address>http://www.w3.org/2005/08/addressing/anonymous</a:Address>";
//        responseXml += "</a:ReplyTo>";
//        responseXml += "<a:To s:mustUnderstand=\"1\">https://domain.company.com:443/wp8/default.aspx</a:To>";
//    responseXml += "</s:Header>";
//    responseXml += "<s:Body>";
//        responseXml += "<Discover xmlns=\"http://schemas.microsoft.com/windows/management/2012/01/enrollment\">";
//            responseXml += "<request xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\">";
//                responseXml += "<EmailAddress>username@domain.com</EmailAddress>";
//                responseXml += "<RequestVersion>1.0</RequestVersion>";
//            responseXml += "</request>";
//        responseXml += "</Discover>";
//    responseXml += "</s:Body>";
//responseXml += "</s:Envelope>";
//            return responseXml;

string xml ="<s:Envelope xmlns:a=\"http://www.w3.org/2005/08/addressing\" xmlns:s=\"http://www.w3.org/2003/05/soap-envelope\">";
xml +="<s:Header>";
xml +="<a:Action s:mustUnderstand=\"1\">";
xml +="http://schemas.microsoft.com/windows/management/2012/01/enrollment/IDiscoveryService/Discover";
xml +="</a:Action>";
xml +="<a:MessageID>urn:uuid:748132ec-a575-4329-b01b-6171a9cf8478</a:MessageID>";
xml +="<a:ReplyTo>";
xml +="<a:Address>http://www.w3.org/2005/08/addressing/anonymous</a:Address>";
xml +="</a:ReplyTo>";
xml +="<a:To s:mustUnderstand=\"1\">https://domain.company.com:443/wp8/Default.aspx</a:To>";
xml +="</s:Header>";
xml +="<s:Body>";
xml +="<Discover xmlns=\"http://schemas.microsoft.com/windows/management/2012/01/enrollment\">";
xml +="<request xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\">";
xml += "<EmailAddress>username@domain.com</EmailAddress>";
xml +="<RequestVersion>1.0</RequestVersion>";
xml +="</request>";
xml +="</Discover>";
xml +="</s:Body>";
xml +="</s:Envelope>";
return xml;
        }
        public string ParseAutoDiscoveryRequest(string policyXml)
        {
            string requestRelationUUID = string.Empty;
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.LoadXml(policyXml);

                XmlNamespaceManager xmlNsMgr = new XmlNamespaceManager(xmlDoc.NameTable);
                xmlNsMgr.AddNamespace("a", "http://www.w3.org/2005/08/addressing");
                xmlNsMgr.AddNamespace("s", "http://www.w3.org/2003/05/soap-envelope");

                XmlNode provisionNode = xmlDoc.SeledomainingleNode(".//a:MessageID", xmlNsMgr);

                if (provisionNode != null)
                {
                    requestRelationUUID = provisionNode.InnerText;
                }
            }
            catch (Exception)
            {
                return "";
            }
            return requestRelationUUID;
        }

        bool IsValidClientCertificate(X509Certificate2 certificate)
        {
            bool isValid = true;
            var chain = new X509Chain();
            chain.Build(certificate);
            chain.ChainPolicy.RevocationMode = X509RevocationMode.Online;
            chain.ChainPolicy.RevocationFlag = X509RevocationFlag.EntireChain;
            chain.ChainPolicy.UrlRetrievalTimeout = new TimeSpan(1000);
            chain.ChainPolicy.VerificationTime = DateTime.Now;

            if (chain.ChainElements.Count == 0)
            {
                return false;
            }

            foreach (var element in chain.ChainElements)
            {
                //If any ChainElement Verification is False, overall result will be False
                isValid = isValid && element.Certificate.Verify();
            }

            return isValid;
        }
    }
}
