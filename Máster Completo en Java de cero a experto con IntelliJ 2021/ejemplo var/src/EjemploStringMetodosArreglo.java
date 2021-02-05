public class EjemploStringMetodosArreglo {

    public static void main(String[] args) {

        String str = "asdfdsa";
        System.out.println("str.toCharArray() = " + str.toCharArray());//convierte el string en un array de caracteres

        char[] arrayy = str.toCharArray();
        int largo = arrayy.length;
        System.out.println("largo = " + largo);
        for (int i = 0; i < largo; i++) {

            System.out.println("arrayy[i] = " + arrayy[i]);

        }
        System.out.println();
        System.out.println("str.split(\"a\") = " + str.split("a"));

        String[] arrayy2 = str.split("a");
        int l = arrayy2.length;
        for (int j = 0; j < l; j++) {

            System.out.println(arrayy2[j]);

        }

        String archivo = "asdfdsa.pdf";
        String[] arch = archivo.split("\\.");
        l = arch.length;
        for (int k = 0; k < l; k++) {

            System.out.println(arch[k]);

        }
        System.out.println("extension = " + arch[l-1]);

    }

}
