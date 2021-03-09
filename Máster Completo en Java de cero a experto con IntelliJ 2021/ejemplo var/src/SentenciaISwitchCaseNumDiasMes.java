import java.util.Scanner;

public class SentenciaISwitchCaseNumDiasMes {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        System.out.println("Mes");
        int mes = sc.nextInt();

        //int mes = 9;
        int numDias = 0;
        //int anio = 2020;
        System.out.println("año");
        int anio = sc.nextInt();;

        switch (mes){

            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                numDias = 12;
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                numDias = 30;
                break;

            case 2:
                if(anio % 400 == 0 || ((anio % 4 == 0) && !(anio % 100 == 0))){

                    numDias = 29;

                }else{

                    numDias = 28;

                }
                break;

            default:
                numDias = 0;

        }

        System.out.println("dias = " + numDias);

    }
}
