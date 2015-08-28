
package org.tempuri;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="product_serviceResult" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "productServiceResult"
})
@XmlRootElement(name = "product_serviceResponse")
public class ProductServiceResponse {

    @XmlElement(name = "product_serviceResult")
    protected int productServiceResult;

    /**
     * Gets the value of the productServiceResult property.
     * 
     */
    public int getProductServiceResult() {
        return productServiceResult;
    }

    /**
     * Sets the value of the productServiceResult property.
     * 
     */
    public void setProductServiceResult(int value) {
        this.productServiceResult = value;
    }

}
