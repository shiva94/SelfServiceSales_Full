<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="displayproductmore.aspx.cs" Inherits="websitefinal.WebForm6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <%-- <link href="styles/styles.css" rel="stylesheet" type="text/css" />--%>
<title></title>
<style type="text/css">
       
        
.vzbtnmedium {
	padding: 6px 12px;
margin-bottom: 0px;
font-size: 14px;
font-weight: 400;
line-height: 1.42857;
text-align: center;
white-space: nowrap;
vertical-align: middle;
cursor: pointer;
-moz-user-select: none;
background-image: none;
border: 1px solid transparent;
border-radius: 4px;
  -webkit-border-radius: 4;
  -moz-border-radius: 4;
  
   

  font-family: Arial;
  color: #ffffff;
  
  background: #d51e27;
  
  text-decoration: none;
}
.vzh2
{
	font-family:arial;
	font-style:bold;
	font-size:24px;
	color:#B00000;
}
.vztable {
	margin:0px;padding:0px;
	width:100%;
	border:1px solid #000000;
	
	-moz-border-radius-bottomleft:6px;
	-webkit-border-bottom-left-radius:6px;
	border-bottom-left-radius:6px;
	
	-moz-border-radius-bottomright:6px;
	-webkit-border-bottom-right-radius:6px;
	border-bottom-right-radius:6px;
	
	-moz-border-radius-topright:6px;
	-webkit-border-top-right-radius:6px;
	border-top-right-radius:6px;
	
	-moz-border-radius-topleft:6px;
	-webkit-border-top-left-radius:6px;
	border-top-left-radius:6px;
}
.Grid {background-color: #fff; margin: 5px 0 10px 0; border: solid 1px #000000; border-collapse:collapse; font-family:Calibri; color: #080808;}
.Grid td {
      padding: 2px;
      border: solid 1px #000000; }
.Grid th  {
      padding : 4px 2px;
      color: #fff;
      background: #595a5d url(Images/grid-header.png) repeat-x top;
      border-left: solid 1px #525252;
      font-size: 0.9em; }
.Grid .alt {
      background: #ecedee ; }
  

</style>
<script language="javascript" type="text/javascript">
    function SelectSingleRadiobutton(rdbtnid) {
        var rdBtn = document.getElementById(rdbtnid);
        var rdBtnList = document.getElementsByTagName("input");
        for (i = 0; i < rdBtnList.length; i++) {
            if (rdBtnList[i].type == "radio" && rdBtnList[i].id != rdBtn.id) {
                rdBtnList[i].checked = false;
            }
        }
    }
</script>
</head>
<body>
<form id="form1" runat="server">
<div style="position: fixed; top: 15px; left: 10px; width: 726px;"  >
<asp:GridView ID="gvdata"  runat="server" class="Grid"
        AutoGenerateColumns="false" DataKeyNames="Product_Id" 
       
        GridLines="None" Width="720px">
<Columns>
<asp:TemplateField>
<ItemTemplate>
<asp:RadioButton id="rdbUser" runat="server" OnClick="javascript:SelectSingleRadiobutton(this.id)" />
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField DataField="Product_id" HeaderText="Sno" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Product_name" HeaderText="Product Name" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField ="Product_desc" HeaderText="Product description"  ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField ="Prod_eff_date" HeaderText=" Start Date"  ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField ="Prod_end_date" HeaderText="End DATE"  ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField ="Rate" HeaderText="Rate (in $)"  ItemStyle-HorizontalAlign="Center" />

</Columns>
</asp:GridView>
</div>
<div style="position: fixed; top: 70px; left: 856px;"  >
<asp:button ID="Button1" runat="server" class="vzbtnmedium" text="Update"  onclick="Button1_Click" />
</div>
</form>
</body>
</html>
