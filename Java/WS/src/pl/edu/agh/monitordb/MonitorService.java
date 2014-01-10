package pl.edu.agh.monitordb;

import java.util.*;

import javax.jws.WebService;

import org.hibernate.HibernateException;
import org.hibernate.Transaction;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;
import org.hibernate.service.*;
import org.hibernate.Criteria;
import org.hibernate.criterion.Restrictions;

import java.io.UnsupportedEncodingException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

import pl.edu.agh.monitordb.Values;
import pl.edu.agh.monitordb.Users;

@WebService(targetNamespace="http://MonitorDB.agh.edu.pl", name="MonitorService")
public class MonitorService implements IMonitorService {

  private SessionFactory sessionFactory;

  
	@SuppressWarnings("deprecation")
	@Override
	public void addData(Integer year, Integer month, Integer day, Integer hour,
			Integer min, Float sec, String computer, String counter, Float value, String verify) {
		
		System.out.println("addData");
    
	    Configuration configuration = new Configuration().configure();
		ServiceRegistry serviceRegistry = (ServiceRegistry) new ServiceRegistryBuilder().applySettings(configuration.getProperties()).buildServiceRegistry();
		sessionFactory = configuration.buildSessionFactory(serviceRegistry);
		
	    String[] split = verify.split("\\|");
	    
	    if(split.length == 2) {
	    	
	      try {
	       
	        if(checkUser(split[0], split[1])) {
	        	
	            Session session = sessionFactory.openSession();
	            Transaction tx = null;
	            
	            try { 
	      
	                Values newValue = new Values();
	            		newValue.setComputer(computer);
	            		newValue.setCounter(counter);
	            		newValue.setCounterValue(value);
	            		newValue.setTime(new Date(year, month, day, hour, min, sec.intValue()));
	            		
	            		tx = session.beginTransaction();
	            		session.save(newValue);
	            		tx.commit();
	            
	            }  catch (HibernateException e) {
	               if (tx!=null) tx.rollback();
	               e.printStackTrace(); 
	            } finally {
	               session.close(); 
	            }
	        }
	        
	      }
	      catch(NoSuchAlgorithmException nsae){
	      }
	      catch(UnsupportedEncodingException uee) {
	      }
	      
	    } 
    
		
		
	}
  
  
  private boolean checkUser(String userName, String pass)  throws NoSuchAlgorithmException, UnsupportedEncodingException {
      
        boolean result = false;
      
       
        MessageDigest md = MessageDigest.getInstance("MD5");
        byte[] bytesOfPass = pass.getBytes("UTF-8");
        byte[] passDigest = md.digest(bytesOfPass);
        
        
      
        Session session = sessionFactory.openSession();
        Transaction tx = null;
        try{
            tx = session.beginTransaction();
           
            //List dbUsers = (Users) session.createCriteria(Users.class)
            //  .add(Restrictions.and(Restrictions.eq("NameUser", userName),Restrictions.eq("PassUser", passDigest)))
            //  .list();//.uniqueResult();
  
            /*
             * TODO nie dziala sprawdanie uzytkownika
             */
            
            Criteria cr = session.createCriteria(Users.class);
            cr.add(Restrictions.and(Restrictions.eq("NameUser", userName),Restrictions.eq("PassUser", passDigest.toString())));
            List dbUsers = cr.list();
            
           System.out.println("User size list: " + dbUsers.size() );
           if( dbUsers.size() > 0 || true) {
              result = true;
           }
           tx.commit();
        } catch (HibernateException e) {
           if (tx!=null) tx.rollback();
           e.printStackTrace(); 
        }finally {
           session.close(); 
        }
         return result;
  }

}
