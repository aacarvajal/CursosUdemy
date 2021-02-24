import java.util.Scanner;

public class OperadorTernario {
    public static void main(String[] args) {

        //variable = condicion ?  si es verdadero : si es falso;
        String variable = 7 == 7 ? "si es verdadero" : "si es falso";
        System.out.println("variable = " + variable);

        String estado = "";
        double promedio = 6.2;
        /*estado = promedio >= 5.49 ? "Aprobado" : "Rechazado";
        System.out.println("promedio = " + promedio);*/

        /*if(promedio >= 5.49){
            estado="aprobado";
        }else{
            estado="rechazado";
        }*/
        double prom = 6.2;
        double matematicas = 0.0;
        double ciencias = 0.0;
        double historia = 0.0;

        Scanner sc = new Scanner(System.in);

        System.out.println("Numero entre 2.0 y 7.0 - Matematicas");
        matematicas = sc.nextDouble();

        System.out.println("Numero entre 2.0 y 7.0 - Ciencias");
        ciencias = sc.nextDouble();

        System.out.println("Numero entre 2.0 y 7.0 - Historia");
        historia = sc.nextDouble();

        prom = (matematicas + ciencias + historia) / 3;

        System.out.println("prom = " + prom);
        estado = prom >= 5.49 ? "Aprobado" : "Rechazado";
        System.out.println("estado = " + estado);

    }
}
