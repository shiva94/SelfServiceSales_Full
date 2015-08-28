package org.tempuri;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletContext;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class CustId
 */
@WebServlet("/CustId")
public class CustId extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//System.out.println(request.getParameter("V2"));
	int custID=Integer.parseInt(request.getParameter("V2"));
		//Integer custID=22;
		ServletContext application=getServletContext();
		application.setAttribute("custKey1",custID);
		//System.out.println("custID---------------------"+application.getAttribute("custKey1"));
		//response.sendRedirect("N.jsp");
		RequestDispatcher rd=request.getRequestDispatcher("N.jsp");
		rd.forward(request, response);
	}

}
