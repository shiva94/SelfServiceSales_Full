package tests;

import java.util.ArrayList;
import java.util.List;

import org.junit.Test;
import org.tempuri.ArrayOfProductClass;
import org.tempuri.GetAllProducts;
import org.tempuri.GetAllProductsSoap;
import org.tempuri.ProductClass;

public class ConTest
{
	
	public void test()
	{
	String input1="2";
	String input2="10003";
	GetAllProducts p=new GetAllProducts();
	GetAllProductsSoap p1=p.getGetAllProductsSoap();

	ArrayOfProductClass a=p1.getProductsByZipAndServiceID("2", 10003);
	ArrayList<ProductClass> l=(ArrayList<ProductClass>)a.getProductClass();
	int a1=l.size();
/*List<ProductClass> l1=new List<ProductClass>();*/
	



}}
