<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="payBill.aspx.cs" Inherits="mywebsite.payBill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/styles.css" rel="stylesheet" type="text/css" /> 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 97%;">
        <tr>
            <td class="vzh2">
                Payment Portal</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="vzh4">
                Card No</td>
            <td class="style3">
                <asp:TextBox class="vztext" ID="txtCard" runat="server" AutoPostBack="True" ForeColor="Black" 
                    ontextchanged="TextBox1_TextChanged" Width="369px"></asp:TextBox>
                &nbsp;<asp:Image ID="Image1" runat="server" style="margin-right: 0px" 
                    Width="34px" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtCard" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" 
                    ControlToValidate="txtCard" ErrorMessage="*Invalid Card Number" 
                    Font-Size="Small" onservervalidate="CustomValidator1_ServerValidate" 
                    SetFocusOnError="True"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
            </td>
            <td class="style3">
            </td>
        </tr>
        <tr>
            <td class="vzh4">
                Expiry Date</td>
            <td class="vzh5">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="23px">
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
                <asp:DropDownList ID="DropDownList2" runat="server" Height="23px">
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
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="vzh4">
                CVV No         </td>
                <td>
                <asp:TextBox ID="txtCvv" runat="server" TextMode="Password" Width="122px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtCvv" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtCvv" ErrorMessage="*Incorrect CVV" Font-Size="Small" 
                    ValidationExpression="\d{3}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
            </td>
            <td class="style3">
            </td>
        </tr>
        <tr>
            <td class="vzh4">
                Amount to Pay</td>
            <td class="style3">
                <asp:TextBox class="vztext" ID="txtAmt" runat="server" Height="22px" Width="83px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtAmt" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtAmt" ErrorMessage="*Enter Valid Amount" Font-Size="Small" 
                    ValidationExpression="\d{1,}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1" colspan="2">
                <asp:Button ID="btnPay" runat="server" Text="Click to Proceed" 
                    onclick="btnPay_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
