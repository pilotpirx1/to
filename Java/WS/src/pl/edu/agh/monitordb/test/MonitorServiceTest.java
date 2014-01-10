package pl.edu.agh.monitordb.test;


import static org.junit.Assert.*;

import java.util.Iterator;
import java.util.List;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import pl.edu.agh.monitordb.MonitorService;
import pl.edu.agh.monitordb.Values;

import org.hibernate.HibernateException;
import org.hibernate.Transaction;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;
import org.hibernate.service.*;
import org.hibernate.Criteria;
import org.hibernate.criterion.Restrictions;

import com.sun.msv.driver.textui.Debug;


public class MonitorServiceTest {

	private SessionFactory sessionFactory;
	private Session session;
	
	@Before
	public void before() {
		sessionFactory = createSessionFactory();
		session = sessionFactory.openSession();
		//Transaction transaction = session.beginTransaction();
	}
	
	@After
	public void after() {
		session.close();
		sessionFactory.close();
	}
	
	@Test
	public void testAddData() {
		
		Integer y = new Integer(2013);
		Integer m = new Integer(12);
		Integer d = new Integer(24); 
		Integer h = new Integer(18); 
		Integer min = new Integer(20); 
		Float s = new Float(45.45); 
		String comp = new String("TestComputer"); 
		String counter = new String("CPUTest");
		Float val = new Float(44.44444);
		String verify = new String("wsuser|wsuser");
		
		MonitorService monitorService = new MonitorService();
		
		monitorService.addData(y, m, d, h, min, s, comp, counter, val, verify);
		
		Transaction transaction = session.beginTransaction();
        List<Values> values = session.createQuery("FROM Values WHERE Computer = 'TestComputer'").list(); 
        System.out.println(values.size());
        //for (Iterator iterator = values.iterator(); iterator.hasNext();)
        //{
        //	Values value = (Values) iterator.next();  
        //}
        assertNotNull(values);
        assertEquals(1, values.size());
        transaction.commit();
	 
		
	}
	
	
	private SessionFactory createSessionFactory() {
		Configuration configuration = new Configuration().configure();
		ServiceRegistry serviceRegistry = (ServiceRegistry) new ServiceRegistryBuilder().applySettings(configuration.getProperties()).buildServiceRegistry();
		sessionFactory = configuration.buildSessionFactory(serviceRegistry);
		return sessionFactory;
	}
	
	
	
}
