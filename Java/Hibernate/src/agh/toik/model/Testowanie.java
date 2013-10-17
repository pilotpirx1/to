package agh.toik.model;

import java.util.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;
import javax.persistence.Transient;

@Entity 
@Table (name="Test_Owanie")
public class Testowanie {
	
	@Id
	private int Id;
	
	private String Text;
	
	@Temporal (TemporalType.TIMESTAMP)
	private Date BirthDate;

	//@Transient
	private String Address;
	
	private String Description;
	
	
	public Date getBirthDate() {
		return BirthDate;
	}
	public void setBirthDate(Date birthDate) {
		BirthDate = birthDate;
	}
	public String getAddress() {
		return Address;
	}
	public void setAddress(String address) {
		Address = address;
	}
	public String getDescription() {
		return Description;
	}
	public void setDescription(String description) {
		Description = description;
	}
	
	
	//@Id
	//@Column (name="id_test")
	public int getId() {
		return Id;
	}
	public void setId(int id) {
		Id = id;
	}
	
	//@Column(name="content")
	public String getText() {
		return Text + " from getter";
	}
	public void setText(String text) {
		Text = text;
	}
	
	
}
