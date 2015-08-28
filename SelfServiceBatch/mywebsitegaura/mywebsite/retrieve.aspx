<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="retrieve.aspx.cs" Inherits="mywebsite.retrieve" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style/styles.css" rel="stylesheet" type="text/css" /><meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 169px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 599px">
    
        <table  class="vztable1" style="width:100%;">
            <tr>
                <td >
                    <asp:GridView   ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
