package com.suspendRestore;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletContext;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 * Servlet implementation class Suspend
 */
@WebServlet("/Suspend")
public class Suspend extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
				SuspendDAO dao=new SuspendDAOImpl();
				List<GetCustomerInfoBean> infolist= new ArrayList<GetCustomerInfoBean>();
				//int custid=2;
				int custid=Integer.parseInt(request.getParameter("V1"));
				System.out.println(custid);
				//System.out.println("----"+request.getQueryString());
				//System.out.println(request.getParameterNames());
				
				//int custid=Integer.parseInt(request.getParameter("customerID"));
				//int custid=22;
				GetCustomerInfoBean gcib=new GetCustomerInfoBean();
				gcib.setCustomer_id(custid);
				infolist=dao.getServices(custid);
				//HttpSession session=request.getSession();
				//session.setAttribute("customerID", custid);
				ServletContext sc=request.getServletContext();
				sc.setAttribute("customerID", custid);
				request.setAttribute("infols", infolist);
				//response.sendRedirect("Display.jsp");
				//System.out.println("sessionid"+session.getAttribute("customerID"));
				RequestDispatcher rd= request.getRequestDispatcher("Display.jsp");
				rd.forward(request, response);
	}
}
