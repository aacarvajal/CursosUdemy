public class EjemploMatricesStringFor {
    public static void main(String[] args) {

        String[][] nombres = new String[3][2];
        nombres[0][0] = "a1";
        nombres[0][1] = "a2";
        nombres[1][0] = "b1";
        nombres[1][1] = "b2";
        nombres[2][0] = "c1";
        nombres[2][1] = "c2";

        System.out.println("iterando con for");
        for(int i = 0; i < nombres.length; i++){

            for(int j = 0; j < nombres[i].length; j++){

                System.out.print(nombres[i][j]+"\t");

            }

            System.out.println();

        }

        System.out.println("iterando con foreach");

        for(String[] fila: nombres){
            for(String nombre: fila){
                System.out.print(nombre + "\t");
            }
            System.out.println();
        }

    }
}
