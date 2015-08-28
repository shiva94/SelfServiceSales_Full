<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@ taglib prefix="sd"  uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" type="text/css" href="styles.css">
<script language="javascript" type="text/javascript">
function go()
{
	window.location="N.jsp";
	}
	
</script>	
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>

<link rel="stylesheet" type="text/css" href="styles.css">
<script type="text/javascript">
	function validate(){
		console.log(document.getElementByName('pid'));
		if(document.forms["myform"]["pid"].value=="")
		{
			alert("Please select a product");
			return false;
		}
		else
			{
			alert("hai");
			}
	}
</script>
</head>

<body>

<%-- <%
String t=request.getParameter("serid");
%>  --%>
<form name="myform" action="AddProducts" onsubmit="return validate();">
<h1 align="center" class="vzh1">View Our Products</h1>
<table align="center"  class="vztable1">
	<tr>
		<td></td><td><B>Product Name</B></td><td><B>Product Description</B></td><td><B>Product Effective Date</B></td><td><B>Product End Date</B></td><td><B>Product Rate</B></td>
	</tr>
	<sd:forEach var="ser" items="${Lkey}">
		<tr>
			<td><input type="radio" id="${ser.productID}" name="pid" value="${ser.productID }" required>
			<label for="${ser.productID }"></label>
			</td>
			<td><sd:out value="${ser.productName}"></sd:out></td>
			<td><sd:out value="${ser.productDesc}"></sd:out></td>
			<td><sd:out  value="${ser.prodEffDate}"></sd:out></td>
			<td><sd:out value="${ser.prodEndDate}" ></sd:out></td>
			<td><sd:out value="$${ser.rate}"></sd:out></td>


</sd:forEach>

<%-- <sd:forEach var="ser" items="${Lkey}">
<tr> <td><b>PRODUCT ID:</b></td><td><b>${ser.productID}</b></td> </tr>
<tr><td>Product Name:</td> <td>${ser.productName}</td> </tr>
<tr><td>Product Description:</td> <td>${ser.productDesc}</td> </tr>
<tr> <td>Product Effective Date:</td><td>${ser.prodEffDate}</td> </tr>
<tr><td>Product End Date:</td> <td>${ser.prodEndDate}</td> </tr>
<tr><td>Product Rate:</td> <td>${ser.rate}</td> </tr>

</sd:forEach> --%>

 </table><br>
 
 <table align="center" class="vztable1">
<!-- <tr><td>Customer id:</td><td><input type="hidden" name="V2" class="vztextarea" value="t"></td></tr> -->
<input type="hidden" value="${k} " name="Service_id"/>
<input type="hidden" value="${pid}"  name="Product_id"/>
</table>
<center>
<input type="submit" value="Add Product"  name="Add Product" class="vzbtn">
<input type="reset" value="Back"  name="Back" class="vzbtn" onclick="go();"><br>
</center>
</form>
</body>
</html>