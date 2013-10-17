package agh.toik.model;



import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

@Entity 
@Table (name="ValuesTable")
public class Values {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer Id;
	
	@Temporal (TemporalType.TIMESTAMP)
	private Date Time;
	
	private String Computer;
	
	private String Counter;
	
	private Float CounterValue;
	
	
	
	public Integer getId() {
		return Id;
	}
	public void setId(Integer id) {
		Id = id;
	}
	
	public Date getTime() {
		return Time;
	}
	public void setTime(Date time) {
		Time = time;
	}
	public String getComputer() {
		return Computer;
	}
	public void setComputer(String computer) {
		Computer = computer;
	}
	public String getCounter() {
		return Counter;
	}
	public void setCounter(String counter) {
		Counter = counter;
	}
	public float getCounterValue() {
		return CounterValue;
	}
	public void setCounterValue(float value) {
		CounterValue = value;
	}
	
	
	
}
