import javax.swing.*;
import java.util.Scanner;

public class SistemaNumericosScanner {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Mete un numero ");

        //String numStr = sc.nextLine();

        int numDec = 0;

        try {

            //numDec = Integer.parseInt(numStr);
            numDec = sc.nextInt();

        }catch (Exception e){

            System.out.println("un entero");
            main(args);//se vuelve a ejecutar
            System.exit(0);

        }


        System.out.println("numDec = " + numDec);

        String mensBin = "Numero binario de " + numDec + " = " + Integer.toBinaryString(numDec);

        String mensOctal = "numero octal de " + numDec + " = " + Integer.toOctalString(numDec);

        String mensHex = "numero hexadecimal de " + numDec + " = " + Integer.toHexString(numDec);

        String mensaje = mensBin;
        mensaje += "\n"+mensOctal;
        mensaje += "\n"+mensHex;
        System.out.println(mensaje);

    }

}
