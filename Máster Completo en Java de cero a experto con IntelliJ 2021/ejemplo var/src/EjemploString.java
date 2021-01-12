public class EjemploString {

    public static void main(String[] args) {

        String curso = "asd";
        String s = new String("asd");

        boolean c2 = curso == s;

        System.out.println("c2 = " + c2);

        c2 = curso.equals(s);

    }

}
