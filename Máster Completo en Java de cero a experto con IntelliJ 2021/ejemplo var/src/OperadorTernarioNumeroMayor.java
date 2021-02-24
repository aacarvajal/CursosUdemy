import java.util.Scanner;

public class OperadorTernarioNumeroMayor {
    public static void main(String[] args) {

        int max = 0;

        Scanner sc = new Scanner(System.in);

        System.out.println("Numero 1");
        int n1 = sc.nextInt();

        System.out.println("Numero 2");
        int n2 = sc.nextInt();

        System.out.println("Numero 3");
        int n3 = sc.nextInt();

        System.out.println("Numero 4");
        int n4 = sc.nextInt();

        max = (n1 > n2) ? n1 : n2;
        max = (max > n3) ? max : n3;
        max = (max > n4) ? max : n4;

        System.out.println("n1 = " + n1);
        System.out.println("n2 = " + n2);
        System.out.println("n3 = " + n3);
        System.out.println("numero mayor = " + max);

    }
}
