<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="displayproductchange.aspx.cs" Inherits="websitefinal.displayproductchange" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="styles/styles.css" rel="stylesheet" type="text/css" />
     <link rel="stylesheet" href="styles/theme.css">
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: fixed; top: 53px; left: 21px;">
        <%-- <asp:Label  ID="Label2" class="vzh6" runat="server" Text="To change your exsisting Services Please Enter the Serviceid,Zipcode and click Change"></asp:Label>
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
</br>--%>
            </br>&nbsp;<asp:GridView class="Grid" ID="GridView1" runat="server" 
            AutoGenerateColumns="False">
            <Columns>
                  <asp:TemplateField>
                <ItemTemplate>
                <asp:RadioButton ID="Products" runat="server"/>
                </ItemTemplate>
                </asp:TemplateField>
        
                <asp:BoundField DataField="Product_Id" HeaderText="Product_Id" />
                <asp:BoundField DataField="Product_name" HeaderText="Product_name" />
                <asp:BoundField DataField="Product_desc" HeaderText="Product_desc" />
                <asp:BoundField DataField="Prod_eff_Date" HeaderText="Prod_eff_Date" />
                <asp:BoundField DataField="Prod_End_Date" HeaderText="Prod_End_Date" />
                <asp:BoundField DataField="Rate" HeaderText="Rate" />
                
                
                
            </Columns>
        </asp:GridView>
  
  
  

<%--<asp:GridView ID="GridView1" runat="server"
HeaderStyle-BackColor = "green"
AutoGenerateColumns = "false" Font-Names = "Arial"
OnPageIndexChanging = "OnPaging"
Font-Size = "11pt" AlternatingRowStyle-BackColor = "#C2D69B"
AllowPaging = "true">
<Columns>
<asp:TemplateField>
<ItemTemplate>
    <asp:RadioButton ID="RadioButton1" runat="server"
        onclick = "RadioCheck(this);"/>
    <asp:HiddenField ID="HiddenField1" runat="server"
        Value = '<%#Eval("Product_Id")%>' />
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField ItemStyle-Width="150px" DataField="Product_Id"
    HeaderText="Product_Id"  />
<asp:BoundField ItemStyle-Width="150px" DataField="Product_name"
    HeaderText="Product_name" />
<asp:BoundField ItemStyle-Width="150px" DataField="Product_desc"
    HeaderText="Product_desc"/>
</Columns>
</asp:GridView>


--%>

  
  
  
  
  
          <br />
        <br />
<asp:Label  ID="Label3" class="vzh6" runat="server" Text="Enter Product_id"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="product_id" class="vztext" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button12" class="vzbtn" runat="server" Text="Update" 
            Width="94px" onclick="Button1_Click" />
            </br>
    </div>
    
    </form>
</body>
</html>
