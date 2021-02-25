import java.util.Scanner;

public class SetenciaSwitchCase {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        String mes = sc.nextLine();

        switch (mes){

            case "Enero":
                System.out.println("Enero");
                break;
            case "Febrero":
                System.out.println("Febrero");
                break;
            case "Marzo":
                System.out.println("Marzo");
                break;
            case "Abril":
                System.out.println("Abril");
                break;
            case "Mayo":
                System.out.println("Mayo");
                break;
            case "Junio":
                System.out.println("Junio");
                break;
            default:
                System.out.println("nada");

        }

        int num = 2;
        switch (num){

            case 0:
                System.out.println("0");
                break;
            case 1:
                System.out.println("1");
                break;
            case 2:
                System.out.println("2");
                break;
            default:
                System.out.println("nada");

        }

    }
}
