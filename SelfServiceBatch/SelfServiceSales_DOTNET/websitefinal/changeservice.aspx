<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="changeservice.aspx.cs" Inherits="websitefinal.changeservice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--<div class="wrapper">
    <div class="h_iframe">
        <!-- a transparent image is preferable -->
       
       <iframe frameborder='0' height='500px' width='1000px' scrolling='no' src="changeserviced.aspx" frameborder="0" allowfullscreen></iframe>
    </div>
</div> --%>
   <div class="vzresponsive-container" >
    <iframe  src="changeservicefinal.aspx" width="1000" height="500" align="middle" 
        frameborder="0" scrolling="no"   >Add Service</iframe>
        </div>
</asp:Content>
