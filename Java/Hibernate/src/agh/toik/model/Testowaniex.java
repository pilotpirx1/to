package agh.toik.model;

import java.sql.Timestamp;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Testowaniex {
	
	@Id
	private int Id;
	private Timestamp Time;
	private String Computer;
	private String Counter;
	private float CounterValue;
	
	
	public int getId() {
		return Id;
	}
	public void setId(int id) {
		Id = id;
	}
	
	public Timestamp getTime() {
		return Time;
	}
	public void setTime(Timestamp time) {
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
	public void setCounterValue(float counterValue) {
		CounterValue = counterValue;
	}
	
	
}
