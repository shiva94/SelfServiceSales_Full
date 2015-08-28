<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="payBillFinal.aspx.cs" Inherits="websitefinal.payBillFinal" %>
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

    <style type="text/css">
        .style1
        {
            height: 23px;
        }
        .style2
        {
            font-family: arial;
            font-style: bold;
            font-size: 16px;
            color: #333333;
            height: 41px;
        }
        .style3
        {
            height: 41px;
        }
    </style>

    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
             
        <tr>
            <td class="vzh2">
                Payment Portal</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Image class=" vzlogoContainer" ID="Image1" ImageUrl="Images/credit_card3-512.png"   runat="server" style="margin-right: 0px" 
                    Width="34px" Height="37px" />

                </td>
        </tr>
        <tr>
            <td class="vzh5" align="left">
                Card No</td>
            <td class="style6">
                <asp:TextBox class="vztext" ID="txtCard" runat="server" AutoPostBack="True" ForeColor="Black" 
                    ontextchanged="TextBox1_TextChanged" MaxLength="16"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtCard" ErrorMessage="*Required field"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" 
                    ControlToValidate="txtCard" ErrorMessage="*Invalid Card Number" 
                    Font-Size="Small" onservervalidate="CustomValidator1_ServerValidate" 
                    SetFocusOnError="True"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="style1" >
            </td>
            <td class="style1" >
                </td>
        </tr>
        <tr>
            <td class="vzh5" align="left">Card Type</td>
            <td  >
                
               
                
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Value="CreditCard">Credit Card</asp:ListItem>
                    <asp:ListItem Value="DebitCard">Debit Card</asp:ListItem>
                </asp:RadioButtonList>
               
                
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td class="vzh5" align="left">
                Expiry Date</td>
            <td >
                <asp:DropDownList class="select-style" ID="DropDownList1" runat="server" Height="23px">
                    <asp:ListItem Selected="True">mm</asp:ListItem>
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
&nbsp;
                <asp:DropDownList class="select-style" ID="DropDownList2" runat="server" Height="23px">
                    <asp:ListItem Selected="True">yyyy</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                    <asp:ListItem>2022</asp:ListItem>
                    <asp:ListItem>2023</asp:ListItem>
                    <asp:ListItem>2024</asp:ListItem>
                    <asp:ListItem>2025</asp:ListItem>
                    <asp:ListItem>2026</asp:ListItem>
                    <asp:ListItem>2027</asp:ListItem>
                    <asp:ListItem>2028</asp:ListItem>
                    <asp:ListItem>2029</asp:ListItem>
                    <asp:ListItem>2030</asp:ListItem>
                    <asp:ListItem>2031</asp:ListItem>
                    <asp:ListItem>2032</asp:ListItem>
                    <asp:ListItem>2033</asp:ListItem>
                    <asp:ListItem>2034</asp:ListItem>
                    <asp:ListItem>2035</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="vzh5" align="left">
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td class="vzh5" align="left">
                CVV No         </td>
                <td>
                <asp:TextBox class="vztext" ID="txtCvv" runat="server" TextMode="Password" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtCvv" ErrorMessage="*Required field"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtCvv" ErrorMessage="*Incorrect CVV" Font-Size="Small" 
                    ValidationExpression="\d{3}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" align="left">
                Amount to Pay</td>
            <td class="style3" >
                <asp:TextBox class="vztext" ID="txtAmt" runat="server" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtAmt" ErrorMessage="*Required field"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtAmt" ErrorMessage="*Enter Valid Amount" Font-Size="Small" 
                    ValidationExpression="^\d+(\.\d\d)?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td>
                <asp:Button class="vzbtnmedium" ID="btnPay" runat="server" Text="Click to Proceed" 
                    onclick="btnPay_Click" Width="170px" />
            &nbsp;&nbsp;
            <asp:Button class="vzbtn1medium" ID="btnCancel" runat="server" Text="Cancel" 
                    onclick="btnCancel_Click" Width="170px" /></td>
        </tr>
        <tr>
            <td class="vz-standard-font" colspan="2">
                &nbsp;</td>
        </tr>
    </table>
        
    
    </div>
    </form>
</body>
</html>
