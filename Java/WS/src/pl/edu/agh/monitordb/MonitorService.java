package pl.edu.agh.monitordb;

import java.util.Date;

import javax.jws.WebService;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;
import org.hibernate.service.*;

import pl.edu.agh.monitordb.Values;

@WebService(targetNamespace="http://MonitorDB.agh.edu.pl", name="MonitorService")
public class MonitorService implements IMonitorService {

	@SuppressWarnings("deprecation")
	@Override
	public void addData(Integer year, Integer month, Integer day, Integer hour,
			Integer min, Float sec, String computer, String counter, Float value) {
		
		Values newValue = new Values();
		newValue.setComputer(computer);
		newValue.setCounter(counter);
		newValue.setCounterValue(value);
		newValue.setTime(new Date(year, month, day, hour, min, sec.intValue()));
		Configuration configuration = new Configuration().configure();
		ServiceRegistry serviceRegistry = (ServiceRegistry) new ServiceRegistryBuilder().applySettings(configuration.getProperties()).buildServiceRegistry();
		SessionFactory sessionFactory = configuration.buildSessionFactory(serviceRegistry);
		
		Session session = sessionFactory.openSession();
		session.beginTransaction();
		session.save(newValue);
		session.getTransaction().commit();
		
		
	}

}
