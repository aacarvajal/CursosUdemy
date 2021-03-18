public class SentenciasBucleEtiquetas {
    public static void main(String[] args) {

        bucle://etiqueta
        for (int i = 0; i < 5; i++) {

            System.out.println();
            for (int j = 0; j < 5; j++) {
                if (i == 2) {
                    continue bucle;//referencia a un bucle en el que se especifico la etiqueta
                }
                System.out.print("[i = " + i + ", j" + j + "],");
            }
        }

        System.out.println("\n-----------------------------------------------------------");
        etiqueta://etiqueta
        for (int i = 0; i < 5; i++) {

            System.out.println();
            for (int j = 0; j < 5; j++) {
                if (i == 2) {
                    continue etiqueta;//referencia a un bucle en el que se especifico la etiqueta
                }
                System.out.print("[i = " + i + ", j" + j + "],");
            }
        }

    }
}
