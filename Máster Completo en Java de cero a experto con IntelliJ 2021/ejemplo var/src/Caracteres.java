public class Caracteres {

    public static void main(String[] args) {

        char caracter = '\u0040';
        char decimal = 64;

        System.out.println("caracter = " + caracter);
        System.out.println("decimal = " + decimal);
        System.out.println("decimal + caracter= " + (decimal == caracter));

        char simbolo = '@';
        System.out.println("simbolo = " + simbolo);
        System.out.println("simbolo + caracter= " + (simbolo == caracter));

        System.out.println("Character byte: "+ Character.BYTES);
        System.out.println("Character bites: "+ Character.SIZE);
        System.out.println("max Character: "+ Character.MAX_VALUE);
        System.out.println("min Character:" + Character.MIN_VALUE);

    }

}
