package pl.edu.agh.monitordb.hibernate;

import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity 
@Table (name="UsersTable")
public class Users implements UsersInterface {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer Id;
	
	private String NameUser;
	
	private String PassUser;
	
	
	public Integer getId() {
		return Id;
	}
	public void setId(Integer id) {
		Id = id;
	}
	
	public String getNameUser() {
		return NameUser;
	}
  public void setNameUser(String nameUser) {
		NameUser = nameUser;
	}
  
  public String getPassUser() {
		return PassUser;
	}
	public void setPassUser(String passUser) {
		PassUser = passUser;
	}
	
	
	
	
}
