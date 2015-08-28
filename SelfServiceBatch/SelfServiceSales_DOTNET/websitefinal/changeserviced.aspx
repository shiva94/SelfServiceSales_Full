<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="changeserviced.aspx.cs" Inherits="websitefinal.addserviced" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="styles/styles.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="styles/theme.css"/>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
   
         <style type="text/css">
        .style1
        {
            width: 205px;
        }
        .style2
        {
            width: 279px;
        }
        #form1
        {
            height: 1008px;
            width: 1259px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: fixed; top: 34px; left: 24px; width: 584px; height: 272px;"  >
    
        <asp:Label  ID="Label1" class="vzh2" runat="server" Text="These are Your Exsisting Services"></asp:Label>
        <br />
        <br />
        <br />
        
     <br />
        <asp:GridView ID="GridView1" runat="server" class="Grid" >
        </asp:GridView>
        <br />
        <br />
 <asp:Label  ID="Label2" class="vzh6" runat="server" Text="To change your exsisting Services Please enter Service_id ,Zipcode and click Change"></asp:Label>
  <br />
        <br />
<asp:Label  ID="Label3" class="vzh6" runat="server" Text="Enter Service_id"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox1" class="vztext" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label  ID="Label4" class="vzh6" runat="server" Text="Choose zipcode"></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" class="vztext"  runat="server">
            <asp:ListItem>10001</asp:ListItem>
            <asp:ListItem>10002</asp:ListItem>
            <asp:ListItem>10003</asp:ListItem>
            <asp:ListItem>35004</asp:ListItem>
            <asp:ListItem>35005</asp:ListItem>
            <asp:ListItem>35006</asp:ListItem>
        </asp:DropDownList>
</br>
</br>
<asp:Button ID="Button1" class="vzbtn" runat="server" Text="Change" 
            Width="94px" onclick="Button1_Click" />

    </div>
    
    </form>
 
</body>
</html>
