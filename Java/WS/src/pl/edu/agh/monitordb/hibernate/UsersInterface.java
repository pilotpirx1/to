package pl.edu.agh.monitordb.hibernate;

public interface UsersInterface {
	
	public Integer getId();
	
	public void setId(Integer id);
	
	public String getNameUser();
	
	public void setNameUser(String nameUser);
  
	public String getPassUser();
	
	public void setPassUser(String passUser);
	
}
