package com.suspendRestore.Test;

import static org.junit.Assert.*;

import java.util.ArrayList;
import java.util.List;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.Test;

import com.suspendRestore.GetCustomerInfoBean;
import com.suspendRestore.SuspendDAOImpl;

public class DAOImplTest {
	SuspendDAOImpl dao;
	int input1=2;
	int actual;
	@Before
	public void initEnvironment()//SETS UP TESTING ENVIRONMENT
	{
		dao=new SuspendDAOImpl();
		System.out.println("creating test environment");
	}
	@Test
	public void testSelect() {
		int input1=2;
		GetCustomerInfoBean g1=new GetCustomerInfoBean("a","fiostv","suspended");
		GetCustomerInfoBean g2=new GetCustomerInfoBean("b","enterprise","restored");
		GetCustomerInfoBean g3=new GetCustomerInfoBean("c","wireline","restored");
		List<GetCustomerInfoBean> list= new ArrayList<GetCustomerInfoBean>();
		list.add(g1);
		list.add(g2);
		list.add(g3);
		List<GetCustomerInfoBean> expected=list;
		SuspendDAOImpl dao=new SuspendDAOImpl();
		List<GetCustomerInfoBean> actual=dao.getServices(input1);
		assertTrue(expected, actual);
	}
	private void assertTrue(List<GetCustomerInfoBean> expected, List<GetCustomerInfoBean> actual) {
		// TODO Auto-generated method stub
		
	}
	@Test
	public void testInsert(){
		SuspendDAOImpl dao=new SuspendDAOImpl();
		actual=dao.changeStatus_order(input1, "r");
		assertEquals(actual, 1);
	}
	@Test
	public void testUpdate(){
		SuspendDAOImpl dao=new SuspendDAOImpl();
		actual=dao.changeStatus_customer(input1, "a", "restored");
		assertEquals(actual, 1);
	}
	@After
	public void clear()//RELEASES TESTING ENVIRONMENT
	{
		System.out.println("cleaning test environment");
	}
}
