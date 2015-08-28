package com.suspendRestore;

import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class SuspendDAOImpl implements SuspendDAO {
	private Connection connection;
	private PreparedStatement statement;
	private ResultSet result;
	int status;
	/*private Date sysdate;
	private Date date;*/
	@Override
	public void getDBConnection() {
		try{
			Class.forName("oracle.jdbc.OracleDriver");
			String url="jdbc:oracle:thin:@localhost:1521:orcl";
			connection=DriverManager.getConnection(url,"scott","tiger");
			//connection.setAutoCommit(false);
		}catch(ClassNotFoundException | SQLException e){
			e.printStackTrace();
		}	
	}
	@Override
	public void closeDBConnection() {
		try {
			connection.close();
		} catch (SQLException e) {
			e.printStackTrace();
		}	
	}
	@Override
	public List<GetCustomerInfoBean> getServices(int customerID) {
		getDBConnection();
		GetCustomerInfoBean bean;
		List<GetCustomerInfoBean> infols= new ArrayList<GetCustomerInfoBean>(customerID);
		try {
			statement=connection.prepareStatement("select s.service_id, sd.service_name, s.service_current_status from customer_services s,service_description sd where s.customer_id="+customerID+" and s.service_id=sd.service_id and (s.service_current_status='Active' or s.service_current_status='Suspended')");
			result=statement.executeQuery();
			while(result.next()){
				bean=new GetCustomerInfoBean();
				bean.setService_id(result.getString("service_id"));
				System.out.println(bean.getService_id());
				bean.setService_name(result.getString("service_name"));
				bean.setService_current_status(result.getString("service_current_status"));
				infols.add(bean);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		finally{
			closeDBConnection();
		}
		System.out.println("connection closed");
		return infols;
	}
	
	@Override
	public int changeStatus_customer(int custID, String serviceID, String current_status) {
		
		getDBConnection();
		try {
			statement=connection.prepareStatement("update customer_services set service_current_status='"+current_status+"'"+"where service_id='"+serviceID+"' and customer_id='"+custID+"'" );
			status=statement.executeUpdate();
			if(status>0){
				connection.commit();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		finally{
			closeDBConnection();
		}
		return status;
	}
	@Override
	public int changeStatus_order(int custID,String order_type) {
		System.out.println(custID + " "+ order_type);
		//setSysDate();
		getDBConnection();
		try {
			statement=connection.prepareStatement("insert into customer_orders(customer_id,order_id,order_status,order_negotiation_date,order_due_date,order_type)values(?,order_sequence.nextval,'BR',sysdate,sysdate+7,?)");
			statement.setInt(1,custID);
			//statement.setDate(2, date);
			//statement.setDate(3, date);
			statement.setString(2,order_type);
			status=statement.executeUpdate();
			if(status>0){
				connection.commit();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		finally{
			closeDBConnection();
		}
		return status;
	}
}
