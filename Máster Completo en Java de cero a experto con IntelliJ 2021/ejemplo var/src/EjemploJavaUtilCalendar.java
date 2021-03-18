import java.util.Calendar;
import java.util.Date;

public class EjemploJavaUtilCalendar {
    public static void main(String[] args) {

        Calendar calendario = Calendar.getInstance();

        //calendario.set(2021,2,18);
        calendario.set(Calendar.YEAR, 2021);
        calendario.set(Calendar.MONTH, Calendar.MARCH);
        calendario.set(Calendar.DAY_OF_MONTH, 18);
        Date fecha = calendario.getTime();

        System.out.println("calendario = " + fecha);

    }
}
