public class EjemploMatricesStringFor2 {
    public static void main(String[] args) {

        String[][] nombres = {{"a1","a2"},{"b1","b2"},{"c1","c2"}};

        System.out.println("iterando con foreach");

        for(String[] fila: nombres){
            for(String nombre: fila){
                System.out.print(nombre + "\t");
            }
            System.out.println();
        }

    }
}
