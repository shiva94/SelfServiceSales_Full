<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myprofiled.aspx.cs" Inherits="websitefinal.myprofiled" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #form1
        {
            height: 581px;
        }
        .style1
        {
        }
        .style2
        {
            width: 397px;
        }
        .style3
        {
            width: 243px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
    <div style="position: fixed; top: 83px; left: 503px;"  >
    </div>
    <div style="position: fixed; top: 138px; left: 415px; width: 405px;">
        <table class="vztable" style="width: 100%;" frame="border">
            <tr>
                <td class="style1" colspan="2">
    <asp:Label ID="Label5"  runat="server" Text="My Profile Information" ForeColor="White"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label  class="vzh5" ID="Label1" runat="server" Text="First Name"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;
                    <asp:TextBox ID="TextBox1" class="vztext" runat="server" style="margin-left: 0px" 
                        Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label class="vzh5" ID="Label2"  runat="server" Text="Last Name"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;
                    <asp:TextBox ID="TextBox2" class="vztext" runat="server" Width="191px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label class="vzh5" ID="Label3" runat="server"  Text="Mobile Number"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;
                    <asp:TextBox ID="TextBox3" class="vztext" runat="server" Width="188px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label4" class="vzh5" runat="server"  Text="Email"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;&nbsp;<asp:TextBox ID="TextBox4" class="vztext" runat="server" Width="180px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    
    </div>



    </form>
</body>
</html>
