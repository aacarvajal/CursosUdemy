import java.text.SimpleDateFormat;
import java.util.Date;

public class EjemploJavaUtilDate {
    public static void main(String[] args) {

        Date fecha = new Date();

        System.out.println("fecha = " + fecha);

        SimpleDateFormat sdf = new SimpleDateFormat("dd MMMM, yyyy");

        String fechaStr = sdf.format(fecha);

        System.out.println("fechaStr = " + fechaStr);

    }
}
