package agh.toik;



import java.sql.Timestamp;
import java.util.Date;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

import agh.toik.model.Testowanie;
import agh.toik.model.Testowaniex;
import agh.toik.model.Values;

public class WebServiceApp {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		Values value = new Values();
		//value.setId(4);
		value.setTime(new Date());
		value.setComputer("Localhost 3");
		value.setCounter("3");
		value.setCounterValue(55);
		
		/*
		Testowanie value = new Testowanie();
		value.setId(1);
		value.setText("Pierwszy test");
		value.setAddress("Ul. Maja 23");
		value.setBirthDate(new Date());
		value.setDescription("Tu i tam");
		*/
		/*
		Testowaniex value = new Testowaniex();
		value.setId(1);
		value.setTime(new Timestamp(new Date().getTime()));
		value.setComputer("Localhost");
		value.setCounter("1");
		value.setCounterValue(22);
		*/
		
		
		SessionFactory sessionFactory = new Configuration().configure().buildSessionFactory();
		Session session = sessionFactory.openSession();
		session.beginTransaction();
		session.save(value);
		session.getTransaction().commit();
		
		
	}

}
