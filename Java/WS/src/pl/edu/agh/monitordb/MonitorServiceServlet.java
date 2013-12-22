package pl.edu.agh.monitordb;

import javax.servlet.ServletConfig;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.xml.ws.Endpoint;


/**
 * Servlet implementation class MonitorServiceServlet
 */
@WebServlet("/MonitorServiceServlet")
public class MonitorServiceServlet extends org.apache.cxf.transport.servlet.CXFNonSpringServlet {
	private static final long serialVersionUID = 1L;
       
	@Override
    public void loadBus(ServletConfig servletConfig) {
        super.loadBus(servletConfig);        
        
        Endpoint.publish("/MonitorDBService", new MonitorService());
    }

}
