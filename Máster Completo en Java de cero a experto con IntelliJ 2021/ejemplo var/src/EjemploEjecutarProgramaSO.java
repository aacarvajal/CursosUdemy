import java.io.IOException;
import java.util.Locale;

public class EjemploEjecutarProgramaSO {
    public static void main(String[] args) {

        Runtime rt = Runtime.getRuntime();
        Process prc;

        try {
            if (System.getProperty("os.name").toLowerCase().startsWith("windows")) {

                prc = rt.exec("notepad");

            }else if (System.getProperty("os.name").toLowerCase().startsWith("mac")){

                prc = rt.exec("textedit");

            }else if (System.getProperty("os.name").toLowerCase().contains("nux") ||
                    System.getProperty("os.name").toLowerCase().contains("nix")){

                prc = rt.exec("textedit");

            }else{

                prc = rt.exec("gedit");

            }

            prc.waitFor();

        } catch (IOException | InterruptedException e) {
            System.out.println("Comando desconocido" + e.getMessage());
        }

        System.out.println("Editor cerrado");
        System.exit(0);

    }
}
