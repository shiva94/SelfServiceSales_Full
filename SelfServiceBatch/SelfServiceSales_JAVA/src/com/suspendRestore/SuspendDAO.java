package com.suspendRestore;

import java.util.List;

public interface SuspendDAO {
	public void getDBConnection();
	public void closeDBConnection();
	List<GetCustomerInfoBean> getServices(int customerID);
	public int changeStatus_customer(int custID, String serviceID, String current_status);
	public int changeStatus_order(int custID, String order_type);
}
