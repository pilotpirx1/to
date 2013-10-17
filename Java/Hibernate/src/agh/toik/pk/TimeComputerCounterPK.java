package agh.toik.pk;

import java.io.Serializable;
import java.sql.Date;

public class TimeComputerCounterPK implements Serializable {
    
	protected Date Time;
    protected String Computer;
    protected String Counter;

    public TimeComputerCounterPK() {}

    public TimeComputerCounterPK(Date time, String computer, String counter) {
        this.Time = time;
        this.Computer = computer;
        this.Counter = counter;
    }

}
