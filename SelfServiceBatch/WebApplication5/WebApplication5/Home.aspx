<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="websitefinal.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <link href="Styles/styles.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 class="vzh1">
    Welcome  
    <asp:Label ID="Label1" runat="server"></asp:Label></h1>
    </div>
    <div>
        <asp:Button class="vzbtn" ID="Button1" runat="server" Text="Logout" 
            onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>