public class EjemploStringInmutable {

    public static void main(String[] args) {

        String curso = "asd";
        String s = "asd2";

        String res = curso.transform(c -> {

            return c + " " + s;

        });

        System.out.println("res = " + res);

        String res2 = res.replace("a", "A");

        System.out.println("res2 = " + res2);

    }

}
