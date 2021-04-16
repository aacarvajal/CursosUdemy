public class EjemploMatrices {
    public static void main(String[] args) {

        int[][] numeros = new int[2][4];

        numeros[0][0] = 1;
        numeros[0][1] = 2;
        numeros[0][2] = 3;
        numeros[0][3] = 4;

        numeros[1][0] = 11;
        numeros[1][1] = 12;
        numeros[1][2] = 13;
        numeros[1][3] = 14;

        System.out.println("numero de filas " + numeros.length);
        System.out.println("numero de columnas " + numeros[0].length);
        System.out.println("primer elemento de la matriz " + numeros[0][0]);
        System.out.println("ultimo elemento: " + numeros[numeros.length -1][numeros.length -1]);

        int n1 = numeros[0][0];
        int n2 = numeros[0][1];
        int n3 = numeros[0][2];
        int n4 = numeros[0][3];
        int n5 = numeros[1][0];
        int n6 = numeros[1][1];
        int n7 = numeros[1][2];
        int n8 = numeros[1][3];

        System.out.println("n1 = " + n1);
        System.out.println("n2 = " + n2);
        System.out.println("n3 = " + n3);
        System.out.println("n4 = " + n4);
        System.out.println("n5 = " + n5);
        System.out.println("n6 = " + n6);
        System.out.println("n7 = " + n7);
        System.out.println("n8 = " + n8);

    }
}
