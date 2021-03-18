public class WrapperInteger {
    public static void main(String[] args) {

        int intPrimitivo = 321;
        Integer intObjeto = Integer.valueOf(intPrimitivo);//valor unboxing - explicita
        Integer intObjeto2 = intPrimitivo;//valor autoboxing
        System.out.println("intObjeto = " + intObjeto);

        int num = intObjeto;
        System.out.println("num = " + num);
        int num2 = intObjeto.intValue();
        System.out.println("num2 = " + num2);

        String valor = "67";
        Integer val = Integer.valueOf(valor);
        System.out.println("val = " + val);

        Short shortObj = intObjeto.shortValue();
        System.out.println("shortObj = " + shortObj);

    }
}
