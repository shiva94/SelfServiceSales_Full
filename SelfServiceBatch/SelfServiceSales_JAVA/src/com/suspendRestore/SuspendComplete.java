package com.suspendRestore;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletContext;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 * Servlet implementation class SuspendComplete
 */
@WebServlet("/SuspendComplete")
public class SuspendComplete extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String message;
		String str =request.getParameter("services");
		System.out.println(str);
		HttpSession session=request.getSession(false);
		SuspendDAO dao=new SuspendDAOImpl();
		ServletContext sc=request.getServletContext();
		int custId=(Integer)sc.getAttribute("customerID");
		GetCustomerInfoBean gcib = new GetCustomerInfoBean();
		try{
			Class.forName("oracle.jdbc.OracleDriver");
			String url="jdbc:oracle:thin:@localhost:1521:orcl";
			Connection connection=DriverManager.getConnection(url,"scott","tiger");
			
			//int custId=((Integer)session.getAttribute("customerID"));
			//System.out.println("Complete"+custId);
		//	System.out.println(request.getParameter("V1"));
			//int custId=Integer.parseInt(request.getParameter("S"));
			//int custId=2;
			System.out.println("SuspendComplete" +custId);
			String services=request.getParameter("services");//("customerID");
			
			System.out.println(services);
			//PreparedStatement statement=connection.prepareStatement("select service_current_status from customer_services where customer_id="+((Integer)(session.getAttribute("customerID")))+"and service_id='"+request.getParameter("services")+"'");
			PreparedStatement statement=connection.prepareStatement("select service_current_status from customer_services where customer_id=? and service_id=?");
			statement.setInt(1,custId);
			statement.setString(2,services);
			ResultSet result=statement.executeQuery();
			if(result.next()){
				System.out.println("inside while");
				if((result.getString(1)).equals("Suspended")){
					dao.changeStatus_order(custId,"R");
					//dao.changeStatus_order(custId,"r");
					System.out.println("inside if");
					gcib.setOrder_type("R");
					dao.changeStatus_customer(custId, str,"Active");
					//dao.changeStatus_customer(custId, str, "active");
					message="activated";
					request.setAttribute("msg", message);
					
				}
				else{
					dao.changeStatus_order(custId,"S");
					//dao.changeStatus_order(custId, "s");
					gcib.setOrder_type("S");
					dao.changeStatus_customer(custId, str,"Suspended");
					//dao.changeStatus_customer(custId,str,"suspended");
					message="suspended";
					request.setAttribute("msg", message);
					
				}
			}
		}catch(ClassNotFoundException | SQLException e){
			e.printStackTrace();
		}
		
		RequestDispatcher rd= request.getRequestDispatcher("Message.jsp");
		rd.forward(request, response);
	}
}