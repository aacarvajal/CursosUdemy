public class SentenciasBucleEtiquetasBuscar {
    public static void main(String[] args) {

        String frase = "adsdsdsd1 adsdsdsd1 asddsddsd";
        String palabra = "adsdsdsd1";

        int maxFrase = frase.length();
        int maxPalabra = palabra.length();

        int cantidad = 0;

        buscar:
        for (int i = 0; i < maxFrase; i++) {
            int k = i;
            for (int j = 0; j < maxPalabra; j++) {
                if (frase.charAt(k++) != palabra.charAt(j)) {
                    continue buscar;
                }

            }
            cantidad++;
        }
        System.out.println("cantidad = " + cantidad);

    }
}
