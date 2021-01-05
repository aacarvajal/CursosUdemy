public class Primitivos {

    public static void main(String[] args) {

        //byte
        System.out.println("BYTE");
        byte numByte = 127;

        System.out.println("numByte = " + numByte);
        System.out.println("byte: "+ Byte.BYTES);
        System.out.println("bites: "+ Byte.SIZE);
        System.out.println("max byte: "+ Byte.MAX_VALUE);
        System.out.println("min byte:" + Byte.MIN_VALUE);

        //short
        System.out.println("\nSHORT");

        short numShort = 32767;

        System.out.println("numShort = " + numShort);
        System.out.println("short byte: "+ Short.BYTES);
        System.out.println("short bites: "+ Short.SIZE);
        System.out.println("max short: "+ Short.MAX_VALUE);
        System.out.println("min short:" + Short.MIN_VALUE);

        //int
        System.out.println("\nInteger/int");

        int numInt = 2147483647;

        System.out.println("numInt = " + numInt);
        System.out.println("int byte: "+ Integer.BYTES);
        System.out.println("int bites: "+ Integer.SIZE);
        System.out.println("max int: "+ Integer.MAX_VALUE);
        System.out.println("min int:" + Integer.MIN_VALUE);

        //long
        System.out.println("\nLong");

        long numLong = 9223372036854775807L;

        System.out.println("numLong = " + numLong);
        System.out.println("long byte: "+ Long.BYTES);
        System.out.println("long bites: "+ Long.SIZE);
        System.out.println("max long: "+ Long.MAX_VALUE);
        System.out.println("min long:" + Long.MIN_VALUE);

        //var
        System.out.println("\nVar");

        var numVar = 127;

    }

}
