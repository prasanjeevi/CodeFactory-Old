<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="EASApp._Default" ValidateRequest="false" %>

<!DOCTYPE html>

<html lang="en-us">
<head runat="server">
    <title>EAS Web Client</title>
    <style type="text/css">
    body
    {
    	font-family:Segoe UI Light;    	
    }
    </style>
</head>
<body>
    <form id="frmMain" runat="server">   
     
    <div id="mailbox">    
    <label>Domain\Username</label><br />
    <asp:TextBox ID="txtMBDomainUser" runat="server" /><br />
    <label>Password</label><br />
    <asp:TextBox ID="txtMBPassword" runat="server" /><br />
    <label>Server</label><br />
    <asp:TextBox ID="txtMBServer" runat="server" /><br />
    <label>Authentication</label><br />
    <asp:CheckBox ID="chkMBBasic" Text="Basic" runat="server" /><br />
    <asp:CheckBox ID="chkMBCert" Text="Certificate" runat="server" />&nbsp;
    <asp:FileUpload ID="fupMBCert" runat="server" /><br />
    <br />    

    </div><br />
    <div id="device">
    <label>Device Id</label><br />
    <asp:TextBox ID="txtDDeviceId" runat="server" /><br />
    <label>Device Type</label><br />
    <asp:TextBox ID="txtDDeviceType" runat="server" /><br /> 
    <label>Device Model</label><br />
    <asp:TextBox ID="txtDDeviceModel" runat="server" /><br />
    <label>Device OS</label><br />
    <asp:TextBox ID="txtDDeviceOS" runat="server" /><br />    
    <label>User Agent</label><br />
    <asp:TextBox ID="txtDUserAgent" runat="server" /><br />
    <label>IMEI</label><br />
    <asp:TextBox ID="txtDIMEI" runat="server" /><br />    
    <label>Device Friendly Name</label><br />
    <asp:TextBox ID="txtDDeviceFriendlyName" runat="server" /><br />  
    <label>Phone No</label><br />
    <asp:TextBox ID="txtDPhoneNo" runat="server" /><br /> 
    <label>OS Language</label><br />
    <asp:TextBox ID="txtDOSLanguage" runat="server" /><br /> 
    <asp:CheckBox ID="chkDOutBoundSMS" Text="Out Bound SMS" runat="server" /><br />    
    </div>    
    <div>
    <asp:Button ID="btnProvision" runat="server" Text="Init Provision" OnClick="btnProvision_Click" /><br />
    <label>Response</label><br />    
    <asp:TextBox ID="txtResponse" runat="server" TextMode="MultiLine" style="width:800px;height:600px;"/><br />
    <label>Temp Policy Key</label><br />
    <asp:TextBox ID="txtTempPolicyKey" runat="server" /><asp:Label ID="lblStatus" runat="server" /><br /> 
    <asp:Button ID="btnProvisionAck" runat="server" Text="Provision Ack" OnClick="btnProvisionAck_Click" /><br />
    <label>Permanent Policy Key</label><br />
    <asp:TextBox ID="txtPolicyKey" runat="server" Text="000" /><br /> 
    <asp:Button ID="btnFolderSync" runat="server" Text="Folder Sync" OnClick="btnFolderSync_Click" /><br />
    <label>Folder ServerId</label><br />
    <asp:TextBox ID="txtServerId" runat="server" /><br /> 
    <asp:Button ID="btnSync" runat="server" Text="Init Sync" OnClick="btnSync_Click" /><br />
    <label>Sync Key</label><br />
    <asp:TextBox ID="txtSyncKey" runat="server" /><asp:TextBox ID="txtFileRef" runat="server" /><br /> 
    <asp:Button ID="btnSync2" runat="server" Text="Sync2" OnClick="btnSync2_Click" /><br />
    <asp:Button ID="btnSync3" runat="server" Text="Sync3" OnClick="btnSync3_Click" /><br />
    
    <label>Send Mail</label><br />    
    <asp:TextBox ID="txtTo"  style="width:800px;" runat="server" /><br /> 
    <asp:TextBox ID="txtCC"  style="width:800px;" runat="server" /><br /> 
    <asp:TextBox ID="txtSubject"  style="width:800px;" runat="server" /><br /> 
    <asp:TextBox ID="txtCompose" TextMode="MultiLine" style="width:800px;height:300px;" runat="server" /><br /> 
    <asp:Button ID="btnSendMail" runat="server" Text="Send Mail" OnClick="btnSendMail_Click" /><br />  
    <asp:Button ID="btnParseDeviceInfo" runat="server" Text="Parse Device Info" OnClick="btnParseDeviceInfo_Click" /><br />
    GALSearch<asp:TextBox ID="txtQuery" runat="server" OnTextChanged="txtQuery_OnTextChanged" AutoPostBack="true" /> 
    <asp:TextBox ID="txtResponseWbxml" runat="server" TextMode="MultiLine" style="width:800px;height:200px;" /><br />    
    <asp:Button ID="btnPing" runat="server" Text="Ping" OnClick="btnPing_Click" /><br />  
    <asp:Button ID="btnSettings" runat="server" Text="Settings" OnClick="btnSettings_Click" /><br />
    </div>
    </form>
</body>
</html>
