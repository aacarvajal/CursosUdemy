import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.Properties;

public class EjemplosAsignarPropiedadesDeSistema {
    public static void main(String[] args) {

        try {

            FileInputStream archivo = new FileInputStream("src/config.properties");

            Properties p = new Properties(System.getProperties());
            p.load(archivo);
            p.setProperty("mi.propiedad.personalizada","Valor guardado");

            System.setProperties(p);
            Properties ps = System.getProperties();
            ps.list(System.out);

        } catch (FileNotFoundException e) {
            System.err.println("No existe el archivo " + e);
        } catch (IOException e) {
            System.err.println(e);
        }

    }
}
