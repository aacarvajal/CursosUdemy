public class PrimitivosFloat {

    //static float varFlotante;

    public static void main(String[] args) {

        //float realFloat = 2120f;
        //float realFloat = 2.12e3f;//2120
        //float realFloat = 1.52e4f;//15000

        //float
        System.out.println("Float");

        float numFloat = 3.4028235E38F;

        System.out.println("numFloat = " + numFloat);
        System.out.println("float byte: "+ Float.BYTES);
        System.out.println("float bites: "+ Float.SIZE);
        System.out.println("max float: "+ Float.MAX_VALUE);
        System.out.println("min float:" + Float.MIN_VALUE);

        //float
        System.out.println("\nDouble");

        double numDouble = 1.7976931348623157E308;

        System.out.println("numDouble = " + numDouble);
        System.out.println("Double byte: "+ Double.BYTES);
        System.out.println("Double bites: "+ Double.SIZE);
        System.out.println("max double: "+ Double.MAX_VALUE);
        System.out.println("min double:" + Double.MIN_VALUE);

        //varFlotante
        var varFlotante = 3.1416f;
        System.out.println("varFlotante = " + varFlotante);

    }

}
