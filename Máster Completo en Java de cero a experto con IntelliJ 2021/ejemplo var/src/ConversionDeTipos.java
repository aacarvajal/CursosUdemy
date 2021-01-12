public class ConversionDeTipos {

    public static void main(String[] args) {

        String numeroStr = "50";

        int numInt = Integer.parseInt(numeroStr);

        System.out.println("numInt = " + numInt);

        String realStr = "987456.43e-3";
        double realDouble = Double.parseDouble(realStr);

        System.out.println("realDouble = " + realDouble);

        String logicoStr = "true";
        boolean logicoBool = Boolean.parseBoolean(logicoStr);

        System.out.println("logicoBool = " + logicoBool);

        int n = 100;

        String s = Integer.toString(n);
        s = String.valueOf(n);

        int i = 10000;
        short sh = (short) i;

    }

}
