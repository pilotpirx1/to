package pl.edu.agh.monitordb.test;

import java.io.UnsupportedEncodingException;
import java.security.NoSuchAlgorithmException;
import java.util.List;

import org.hibernate.Criteria;
import org.hibernate.criterion.Restrictions;
import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.apache.commons.codec.digest.DigestUtils;
import org.easymock.EasyMock;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import pl.edu.agh.monitordb.MonitorService;
import pl.edu.agh.monitordb.hibernate.Users;
import pl.edu.agh.monitordb.hibernate.UsersInterface;
import pl.edu.agh.monitordb.hibernate.Values;

public class MonitorServiceMockTest {
	
	private SessionFactory sessionFactory;
	private Session session;
	private Criteria criteria;
	
	@Before
	public void before() {
		
		sessionFactory = EasyMock.createMock(SessionFactory.class);
	    session = EasyMock.createMock(Session.class);
	    criteria = EasyMock.createMock(Criteria.class);
	}
	
	@Test
	public void testAddData() {
		
		
		
	}
	
	@Test
	public void testCheckUser() throws NoSuchAlgorithmException, UnsupportedEncodingException, HibernateException {

		String userName = "wsuser";
		String pass = "wsuser";
		String passHash = DigestUtils.md5Hex(pass);
		
		Users user = new Users();
		user.setNameUser(userName);
		user.setPassUser(passHash);
		
		EasyMock.expect(sessionFactory.getCurrentSession()).andReturn(session);
		EasyMock.expect(session.createCriteria(UsersInterface.class)).andReturn(criteria);
		EasyMock.expect(criteria.add(Restrictions.eq("NameUser", userName))).andReturn(criteria);
		EasyMock.expect(criteria.add(Restrictions.eq("PassUser", passHash))).andReturn(criteria);
		EasyMock.expect(criteria.uniqueResult()).andReturn(user);
		
		//criteria.add(
		//		Restrictions.and(Restrictions.eq("NameUser", userName),
		//				Restrictions.eq("PassUser", passDigest))
		//);
        //List<Users> dbUsers = criteria.list();
		EasyMock.replay(sessionFactory, session, criteria);
		
		
		
	}
	
	
	@After
	public void after() {
		//session.close();
		//sessionFactory.close();
	}
	
}