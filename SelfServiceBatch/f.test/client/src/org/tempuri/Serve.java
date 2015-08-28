package org.tempuri;

import java.util.List;

public class Serve {
public static void main(String[] args) {
	GetAllProducts p=new GetAllProducts();
GetAllProductsSoap p1=p.getGetAllProductsSoap();

ArrayOfProductClass a=p1.getProductsByZipAndServiceID("6",10001);
List<ProductClass> l=a.getProductClass();
	for(ProductClass t:l){
		System.out.println(t.getProductDesc());
	}
}
}
