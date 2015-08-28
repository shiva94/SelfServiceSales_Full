package com.suspendRestore;

import java.io.Serializable;

public class GetCustomerInfoBean implements Serializable{
	private int customer_id;
	private String service_id;
	private String service_name;
	private String service_current_status;
	private String order_type;
	public GetCustomerInfoBean(String service_id, String service_name, String service_current_status){
		
	}
	public GetCustomerInfoBean() {
		// TODO Auto-generated constructor stub
	}
	public int getCustomer_id() {
		return customer_id;
	}
	public void setCustomer_id(int customer_id) {
		this.customer_id = customer_id;
	}
	public String getService_id() {
		return service_id;
	}
	public void setService_id(String service_id) {
		this.service_id = service_id;
	}
	public String getService_current_status() {
		return service_current_status;
	}
	public void setService_current_status(String service_current_status) {
		this.service_current_status = service_current_status;
	}
	public String getOrder_type() {
		return order_type;
	}
	public void setOrder_type(String order_type) {
		this.order_type = order_type;
	}
	public String getService_name() {
		return service_name;
	}
	public void setService_name(String service_name) {
		this.service_name = service_name;
	}
	
}
