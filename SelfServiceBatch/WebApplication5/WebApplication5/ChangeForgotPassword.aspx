<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeForgotPassword.aspx.cs" Inherits="websitefinal.ChangeForgotPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Change Password</title>
 <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="Styles/progress.css" rel="stylesheet" type="text/css" />
    <link href="Styles/select.css" rel="stylesheet" type="text/css" />
    <link href="Styles/styles.css" rel="stylesheet" type="text/css" />
    <link href="Styles/theme.css" rel="stylesheet" type="text/css" />
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
  <script>
  </script>
</head>
<body style="background-color:#ecedee;">
<div  style="   
    position: fixed;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    width: 50%;
    height: 50%;
    margin: auto;">
<div class="container-fluid"> 
	<div class="well well-lg">
	<div class="vzlogoContainer" >  <img src='Images/logo.png' alt=''/></div>
  <h2>
   <form id="form1" runat="server">
       <center><strong>Change Your Password<asp:Label ID="Label1" runat="server"></asp:Label>
       </center></strong></h2>
       <div class="form-group">
       <asp:Label class="vzh4" ID="Label2" runat="server" Text="New Password"></asp:Label>
      <asp:TextBox class="form-control" ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Dont Leave Balnk"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
       <asp:Label class="vzh4" ID="Label3" runat="server">Confirm New Password</asp:Label>
     <asp:TextBox class="form-control" ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="TextBox1" ControlToValidate="TextBox2" 
            ErrorMessage="*It Should be Same as New Password"></asp:CompareValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="Dont Leave Blank"></asp:RequiredFieldValidator>
    </div>
   
    <asp:Button class="vzbtnmedium" ID="Button1" runat="server" Text="Ok" onclick="Button1_Click" />
	    <br />
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
	</form>
</div>
</div>
</div>

</body>
</html>
