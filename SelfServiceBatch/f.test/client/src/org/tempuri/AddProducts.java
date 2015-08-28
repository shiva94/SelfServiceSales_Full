package org.tempuri;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletContext;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.xml.bind.ParseConversionEvent;

/**
 * Servlet implementation class AddProducts
 */
@WebServlet("/AddProducts")
public class AddProducts extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		/*HttpSession hs1=request.getSession(true);
		int e=(int)hs1.getAttribute("Customerid");*/
		ServletContext application=getServletContext();
		
	
		//System.out.println("addServ-------------------"+application.getAttribute("custKey1"));
		int custID=(Integer)application.getAttribute("custKey1");
		
		//System.out.println("Add Product"+custID);
		
		//int custid=0;
		/*HttpSession session=request.getSession();
		if(!session.isNew())
		{
			String sRef=(String)session.getAttribute("V2");
			custid=Integer.parseInt(sRef);
		}*/
		//int k=Integer.getInteger((request.getParameter("V2")));
	
//int custid=Integer.parseInt(request.getParameter("t"));
		
//	String id=	request.getSession().getAttribute("V2").toString();
//	int custid=Integer.parseInt("id");
		
		//int custid=k;
		String serid=request.getParameter("Service_id");
	//String serid=request.getParameter("Service_id");
	
	//System.out.println("addprod servi"+serid);
	String proid=request.getParameter("Product_id");
	//System.out.println(proid);
	
	
//System.out.println(custID+"HAIII");
//System.out.println(serid+"b");
//System.out.println(proid+"c");
	PrintWriter out=response.getWriter();
	Service1 s=new Service1();
	Service1Soap p=s.getService1Soap();
	int ps=p.productService(serid,proid,custID);
	//System.out.println("hh"+serid);
	//System.out.println("ppp"+proid);
	//System.out.println("ccc"+custID);
	//System.out.println("ADV WEBSERVICEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE"+ps);
	if(ps==1)
	{
		System.out.println("if");
		
		
		response.sendRedirect("Success.jsp");
				
	}
	
	else
	{
		response.sendRedirect("Fail.jsp");
		System.out.println("else");
		//out.println("Sorry!!!!Server is under maintainence.Please try again..");
	}
	

	}

}
