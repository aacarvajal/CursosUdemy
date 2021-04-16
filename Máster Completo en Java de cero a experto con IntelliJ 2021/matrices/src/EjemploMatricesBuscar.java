public class EjemploMatricesBuscar {
    public static void main(String[] args) {

        int[][] matrizEnteros = {
                {12,13,14},
                {1,2,3},
                {21,31,41}
        };

        int elementoBuscar = 13;
        boolean encontrado = false;
        int i;
        int j = 0;

        buscar: for( i = 0; i < matrizEnteros.length; i++){
            for(j = 0; j < matrizEnteros[i].length; j++){
                if(matrizEnteros[i][j] == elementoBuscar){
                    encontrado = true;
                    break buscar;
                }
            }
        }

        if(encontrado){
            System.out.println("Encontrado " + elementoBuscar + " en la posicion " + i + ", " + j);
        }else{
            System.out.println("nada");
        }

    }
}
