import java.util.Locale;

public class EjemploStringValidar {

    public static void main(String[] args) {

        String curso = null;

        boolean esNulo = curso == null;

        System.out.println("esNulo = " + esNulo);

        if(esNulo){

            curso = "asdasd";

        }

        boolean esVacio = curso.length() == 0;
        boolean esVacio2 = curso.isEmpty();
        boolean esVacio3 = curso.isBlank();//si hay espacios

        if(!esVacio) {

            System.out.println(curso.toUpperCase());
            System.out.println("asfsdfds ".concat(curso));

        }
    }

}
