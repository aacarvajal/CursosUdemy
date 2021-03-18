import java.lang.reflect.Method;

public class EjemploMetodoGetClass {
    public static void main(String[] args) {

        String texto = "asd";

        Class strClass = texto.getClass();

        System.out.println("strClass = " + strClass.getName());
        System.out.println("strClass = " + strClass.getSimpleName());
        System.out.println("strClass = " + strClass.getPackageName());
        System.out.println("strClass = " + strClass);

        for(Method metodo: strClass.getMethods()){
            System.out.println("metodo = " + metodo.getName());
        }

    }
}
