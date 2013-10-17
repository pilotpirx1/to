
package pl.edu.agh.monitordb;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the pl.edu.agh.monitordb package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _AddDataComputer_QNAME = new QName("http://MonitorDB.agh.edu.pl", "computer");
    private final static QName _AddDataCounter_QNAME = new QName("http://MonitorDB.agh.edu.pl", "counter");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: pl.edu.agh.monitordb
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link AddDataResponse }
     * 
     */
    public AddDataResponse createAddDataResponse() {
        return new AddDataResponse();
    }

    /**
     * Create an instance of {@link AddData }
     * 
     */
    public AddData createAddData() {
        return new AddData();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://MonitorDB.agh.edu.pl", name = "computer", scope = AddData.class)
    public JAXBElement<String> createAddDataComputer(String value) {
        return new JAXBElement<String>(_AddDataComputer_QNAME, String.class, AddData.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://MonitorDB.agh.edu.pl", name = "counter", scope = AddData.class)
    public JAXBElement<String> createAddDataCounter(String value) {
        return new JAXBElement<String>(_AddDataCounter_QNAME, String.class, AddData.class, value);
    }

}
