import org.hyperic.sigar.*;

import java.net.InetAddress;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.UnknownHostException;
import java.util.Date;

public class mainClass {

	 private static Sigar sigar;
	/**
	 * @param args
	 * @throws SigarException 
	 * @throws InterruptedException 
	 * @throws MalformedURLException 
	 */
	@SuppressWarnings("deprecation")
	public static void main(String[] args) throws SigarException, InterruptedException, MalformedURLException {
		String hostname = "Unknown";

		try
		{
		    InetAddress addr;
		    addr = InetAddress.getLocalHost();
		    hostname = addr.getHostName();
		}
		catch (UnknownHostException ex)
		{
		    System.out.println("Hostname can not be resolved");
		}
		sigar = new Sigar();
		CpuPerc cpu = sigar.getCpuPerc();
		MonitorServiceClient svc = new MonitorServiceClient(new URL("http://localhost:8080/WS/MonitorServiceServlet/MonitorDBService?wsdl"),MonitorServiceClient.SERVICE);
		IMonitorService srv =  svc.getBasicHttpBindingIMonitorService();
		
		while(true) {
			Date d = new Date();
			srv.addData(d.getYear(),d.getMonth(),d.getDay(),d.getHours(),d.getMinutes(), (float)d.getSeconds(), hostname, "CPU", (float) cpu.getCombined());
			System.out.println(cpu.getCombined());
			Thread.sleep(1000);

		}
	}

}
