import javax.swing.*;

public class OperadorAritmetico {
    public static void main(String[] args) {

        int i = 5, j = 4, suma = i + j;

        System.out.println("suma = " + suma);
        System.out.println("i+j = " + (i + j));

        int resta = i - j;
        System.out.println("resta = " + resta);
        System.out.println("(i-j) = " + (i - j));

        int mult = i * j;
        System.out.println("mult = " + mult);

        int div = i / j;
        float div2 = (float) i / j;
        System.out.println("div = " + div);
        System.out.println("div2 = " + div2);

        int resto = i % j;
        System.out.println("resto = " + resto);

        int n = Integer.parseInt(JOptionPane.showInputDialog("Numero"));
        if(n % 2 == 0){
            System.out.println("Es par");
        }else{
            System.out.println("Impar");
        }

    }
}
