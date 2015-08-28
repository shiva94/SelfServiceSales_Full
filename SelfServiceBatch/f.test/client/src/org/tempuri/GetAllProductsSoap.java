
package org.tempuri;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;

import com.sun.org.apache.xalan.internal.utils.ObjectFactory;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.4-b01
 * Generated source version: 2.2
 * 
 */
@WebService(name = "GetAllProductsSoap", targetNamespace = "http://tempuri.org/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface GetAllProductsSoap {


    /**
     * 
     * @return
     *     returns org.tempuri.ArrayOfProductClass
     */
    @WebMethod(operationName = "GetAllProductsList", action = "http://tempuri.org/GetAllProductsList")
    @WebResult(name = "GetAllProductsListResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "GetAllProductsList", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetAllProductsList")
    @ResponseWrapper(localName = "GetAllProductsListResponse", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetAllProductsListResponse")
    public ArrayOfProductClass getAllProductsList();

    /**
     * 
     * @param serviceid
     * @return
     *     returns org.tempuri.ArrayOfProductClass
     */
    @WebMethod(operationName = "GetProductsByServiceID", action = "http://tempuri.org/GetProductsByServiceID")
    @WebResult(name = "GetProductsByServiceIDResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "GetProductsByServiceID", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetProductsByServiceID")
    @ResponseWrapper(localName = "GetProductsByServiceIDResponse", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetProductsByServiceIDResponse")
    public ArrayOfProductClass getProductsByServiceID(
        @WebParam(name = "serviceid", targetNamespace = "http://tempuri.org/")
        String serviceid);

    /**
     * 
     * @param zip
     * @param serviceid
     * @return
     *     returns org.tempuri.ArrayOfProductClass
     */
    @WebMethod(operationName = "GetProductsByZipAndServiceID", action = "http://tempuri.org/GetProductsByZipAndServiceID")
    @WebResult(name = "GetProductsByZipAndServiceIDResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "GetProductsByZipAndServiceID", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetProductsByZipAndServiceID")
    @ResponseWrapper(localName = "GetProductsByZipAndServiceIDResponse", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetProductsByZipAndServiceIDResponse")
    public ArrayOfProductClass getProductsByZipAndServiceID(
        @WebParam(name = "serviceid", targetNamespace = "http://tempuri.org/")
        String serviceid,
        @WebParam(name = "zip", targetNamespace = "http://tempuri.org/")
        int zip);

    /**
     * 
     * @param zip
     * @param stateCode
     * @return
     *     returns org.tempuri.ArrayOfProductClass
     */
    @WebMethod(operationName = "GetEnterpriseProducts", action = "http://tempuri.org/GetEnterpriseProducts")
    @WebResult(name = "GetEnterpriseProductsResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "GetEnterpriseProducts", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetEnterpriseProducts")
    @ResponseWrapper(localName = "GetEnterpriseProductsResponse", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetEnterpriseProductsResponse")
    public ArrayOfProductClass getEnterpriseProducts(
        @WebParam(name = "state_code", targetNamespace = "http://tempuri.org/")
        String stateCode,
        @WebParam(name = "zip", targetNamespace = "http://tempuri.org/")
        int zip);

}