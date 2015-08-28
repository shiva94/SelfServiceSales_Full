<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="websitefinal.WebForm5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml&#8221;" >
<head runat="server">
<title>Untitled Page</title>
</head>
<body>
<form id="form1" runat="server">

<asp:GridView ID="GridView1" runat="server" 

HeaderStyle-BackColor = "green"

AutoGenerateColumns = "false" Font-Names = "Arial" 



Font-Size = "11pt" AlternatingRowStyle-BackColor = "#BFE4FF" >

<Columns>

<asp:TemplateField>

<ItemTemplate>

    <asp:RadioButton ID="RadioButton1" runat="server" 

        OnClick = "RadioCheck(this);"/>

        <asp:HiddenField ID="HiddenField1" runat="server" 

        Value = '<%#Eval("Product_Id")%>' />

</ItemTemplate> 

</asp:TemplateField> 
<asp:BoundField ItemStyle-Width="150px" DataField="Product_Id" 

    HeaderText="Product_Id"  />
<asp:BoundField ItemStyle-Width="150px" DataField="Product_Name" 

    HeaderText="Product_Name"  />
<asp:BoundField ItemStyle-Width="150px" DataField="Product_Desc" 

    HeaderText="Product_Desc"  />
    <asp:BoundField ItemStyle-Width="150px" DataField="Prod_eff_Date" 

    HeaderText="Prod_eff_Date"  />


<asp:BoundField ItemStyle-Width="150px" DataField="Prod_end_Date" 

    HeaderText="Prod_end_Date" />

</Columns> 

</asp:GridView>



<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
    style="height: 26px" Text="Button" />



</form>
</body>
</html>