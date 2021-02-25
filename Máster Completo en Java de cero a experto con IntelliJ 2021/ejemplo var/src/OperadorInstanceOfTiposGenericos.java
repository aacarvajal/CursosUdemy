public class OperadorInstanceOfTiposGenericos {
    public static void main(String[] args) {

        Object texto = "asfasdasd";

        Number num = 7;

        //con instanceof se valida el tipo de una clase
        boolean b1 = texto instanceof String;
        System.out.println("tipo string = " + b1);

        b1 = num instanceof Integer;
        System.out.println("tipo integer = " + b1);

    }
}
