import javax.swing.*;

public class SistemaNumericos {

    public static void main(String[] args) {

        /*int numDec = 500;
        System.out.println("numDec = " + numDec);

        System.out.println("Numero binario de " + numDec + " = " + Integer.toBinaryString(numDec));

        int numBin = 0b111110100;
        System.out.println("numBin = " + numBin);

        System.out.println("numero octal de " + numDec + " = " + Integer.toOctalString(numBin));

        int numOctal = 0764;
        System.out.println("numOctal = " + numOctal);

        System.out.println("numero hexadecimal de " + numDec + " = " + Integer.toHexString(numDec));

        int numHex = 0x1f4;
        System.out.println("numHex = " + numHex);*/

        String numStr = JOptionPane.showInputDialog(null,"Numero entero");

        int numDec = 0;

        try {

            numDec = Integer.parseInt(numStr);

        }catch (NumberFormatException e){

            JOptionPane.showMessageDialog(null, "Un entero matao");
            main(args);//se vuelve a ejecutar
            System.exit(0);

        }


        System.out.println("numDec = " + numDec);

        String mensBin = "Numero binario de " + numDec + " = " + Integer.toBinaryString(numDec);
        System.out.println(mensBin);

        int numBin = 0b111110100;
        System.out.println("numBin = " + numBin);

        String mensOctal = "numero octal de " + numDec + " = " + Integer.toOctalString(numDec);
        System.out.println(mensOctal);

        int numOctal = 0764;
        System.out.println("numOctal = " + numOctal);

        String mensHex = "numero hexadecimal de " + numDec + " = " + Integer.toHexString(numDec);
        System.out.println(mensHex);

        int numHex = 0x1f4;
        System.out.println("numHex = " + numHex);

        String mensaje = mensBin;
        mensaje += "\n"+mensOctal;
        mensaje += "\n"+mensHex;
        JOptionPane.showMessageDialog(null, mensaje);

    }

}
