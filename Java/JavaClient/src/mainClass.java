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
    float valCPU = 0; 
    
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
      valCPU = (float) cpu.getCombined();
			srv.addData(d.getYear(),d.getMonth(),d.getDay(),d.getHours(),d.getMinutes(), (float)d.getSeconds(), hostname, "CPU", valCPU);
			System.out.println("CPU: " + valCPU);
      
      System.out.println("User Time....." + CpuPerc.format(cpu.getUser()));
      System.out.println("Sys Time......" + CpuPerc.format(cpu.getSys()));
      System.out.println("Idle Time....." + CpuPerc.format(cpu.getIdle()));
      System.out.println("Wait Time....." + CpuPerc.format(cpu.getWait()));
      System.out.println("Nice Time....." + CpuPerc.format(cpu.getNice()));
      System.out.println("Combined......" + CpuPerc.format(cpu.getCombined()));
      System.out.println("Irq Time......" + CpuPerc.format(cpu.getIrq()));
      System.out.println("------------------------------------------");
            
			Thread.sleep(1000);

		}
	}

}
