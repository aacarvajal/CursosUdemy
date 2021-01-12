public class EjemploStringConcatenacion {

    public static void main(String[] args) {

        String curso = "asd";

        String profesor = "asd";

        String s = curso + " dasdasdsa " + profesor;

        int i1 = 10;
        int i2 = 12;

        System.out.println(s + (i1 + i2));

        String s2 = curso.concat(" ").concat(profesor);

        System.out.println("s2 = " + s2);

    }

}
