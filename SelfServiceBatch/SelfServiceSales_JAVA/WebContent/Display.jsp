<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<link rel="stylesheet" type="text/css" href="styles.css">
<title>Insert title here</title>
<script>
	function validate() {
		
		//console(document.forms["myform"]["services"].value);
		
		//if(document.getElementsByName('services').value=="")
		if ((document.forms["myform"]["services"].value == "")||(document.forms["myform"]["services"].value == null)) {
			alert("Please select a service");
			return false;
		} else {
			return true;
		}
	}
</script>
</head>
<body>
	<form name="myform" action="SuspendComplete"
		onsubmit="return validate()">
		<table class="vztable">
			<tr>
				<td></td>
				<td>Service Name</td>
				<td>Service Current Status</td>
			</tr>
			<c:forEach var="e" items="${infols}">
				<tr>
					<td><input type="radio" id="${e.service_name}" name="services"
						value="${e.service_id}" required> <label for="${e.service_name}"></label>
					</td>
					<%-- <td><c:out value="${e.service_id}"></c:out> </td> --%>
					<td><c:out value="${e.service_name}"></c:out></td>
					<td><c:out value="${e.service_current_status}"></c:out></td>
				</tr>
			</c:forEach>
		</table>
		<center>
			<br> <input type="submit" value="Submit" name="Suspend"
				class="vzbtn">
		</center>
	</form>
</body>
</html>