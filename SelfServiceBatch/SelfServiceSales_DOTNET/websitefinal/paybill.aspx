<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="paybill.aspx.cs" Inherits="websitefinal.paybill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--<div >
    <iframe  src="" width="1000" height="500" align="middle" 
        frameborder="0" scrolling="auto"  >PayBill</iframe>
        </div>--%>
         <iframe  id="I4" width="1000" height="500" align="middle" 
        frameborder="0" scrolling="auto" runat="server" >PayBill</iframe>
</asp:Content>
