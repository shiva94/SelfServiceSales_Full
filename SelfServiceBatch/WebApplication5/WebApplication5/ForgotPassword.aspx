<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="websitefinal.ForgotPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
  <title>Change Password</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
   <link rel="stylesheet" type="text/css" href="Styles/styles.css">
    <link href="Styles/progress.css" rel="stylesheet" type="text/css" />
    <link href="Styles/select.css" rel="stylesheet" type="text/css" />
  <link rel="stylesheet" href="Styles/theme.css">
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
  <h2><center><strong>Forgot Your Password??<asp:Label class="vzh4" ID="Label1" 
            runat="server"></asp:Label></center></strong></h2>
    <form id="form1" runat="server">
       <div class="form-group">
      <asp:Label class="vzh4" ID="Label2" runat="server">User Name</asp:Label>
     <asp:TextBox class="form-control" ID="Username" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="Username" ErrorMessage="Dont Leave Balnk"></asp:RequiredFieldValidator>
    </div>
    <div>
     <asp:Label class="vzh4" ID="Label3" runat="server" Text="Security Question"></asp:Label>
     <asp:DropDownList  class="select-style" ID="DropDownList1" runat="server">
        <asp:ListItem>What is Your Pets Name</asp:ListItem>
        <asp:ListItem>Childhood Friend</asp:ListItem>
        <asp:ListItem>What is Your Pet Name</asp:ListItem>
    </asp:DropDownList>
    </div>
   <div class="form-group">
      <asp:Label class="vzh4" ID="Label4" runat="server">Answer</asp:Label>
    <asp:TextBox class="form-control" ID="Answer" runat="server" 
                        style="margin-left: 0px"></asp:TextBox>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
           ControlToValidate="Answer" ErrorMessage="Dont Leave Blank"></asp:RequiredFieldValidator>
    </div>
    <asp:Button class="vzbtnmedium" ID="Button1" runat="server" Text="Ok" onclick="Button1_Click" />
	
	    <br />
        <br />
        <asp:Label ID="Label5" runat="server"></asp:Label>
        </form>
</div>
</div>
</div>
