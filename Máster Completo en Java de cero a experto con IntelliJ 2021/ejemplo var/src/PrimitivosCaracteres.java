public class PrimitivosCaracteres {

    public static void main(String[] args) {

        char caracter = '\u0040';
        char decimal = 64;

        System.out.println("caracter = " + caracter);
        System.out.println("decimal = " + decimal);
        System.out.println("decimal + caracter= " + (decimal == caracter));

        char simbolo = '@';
        System.out.println("simbolo = " + simbolo);
        System.out.println("simbolo + caracter= " + (simbolo == caracter));

        char espacio = ' ';
        char retroceso = '\b';
        char tab = '\t';
        char nuevaLinea = '\n';
        char retornoCarro = '\r';
        System.getProperty("line.separator");//salto de linea

        System.out.println("Character byte: "+ Character.BYTES);
        System.out.println("Character bites: "+ Character.SIZE);
        System.out.println("max Character: "+ Character.MAX_VALUE);
        System.out.println("min Character:" + Character.MIN_VALUE);

    }

}
