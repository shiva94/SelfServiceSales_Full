<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getOrderStatus.aspx.cs" Inherits="websitefinal.getOrderStatus" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="styles/styles.css" rel="stylesheet" type="text/css" />
    <link href="styles/theme.css" rel="stylesheet" type="text/css" />
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: fixed; top: 51px; left: 431px;">
    <div class="vzh2">
        Order Status
        <br />
    </div>
    <asp:Label class="vz-standard-font" ID="Label1" runat="server"></asp:Label>
    <br />
    <br />
    <br />
        
    <div>
    
        <asp:GridView class="Grid" AlternatingRowStyle-CssClass="alt" ID="GridView1" runat="server" EnableModelValidation="True" 
            Height="211px" Width="275px" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </div>
    </form>
</body>
</html>
