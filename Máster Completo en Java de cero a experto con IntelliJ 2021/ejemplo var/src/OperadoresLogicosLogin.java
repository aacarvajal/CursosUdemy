import java.util.Scanner;

public class OperadoresLogicosLogin {
    public static void main(String[] args) {

        String user1="adrian";
        String password = "12345";

        String user2 = "admin";
        String password2 = "123456";

        Scanner sc = new Scanner(System.in);

        System.out.println("Nombre de usuario");
        String usuario = sc.next();

        System.out.println("Password");
        String pass = sc.next();

        boolean auth = false;

        if((user1.equals(usuario) && password.equals(pass)) ||
                (user2.equals(usuario) && password2.equals(pass))){
            auth = true;
        }else{
            System.out.println("mal puesto");
        }

        if(auth){
            System.out.println("me sirve ".concat(usuario));
        }else{
            System.out.println("Va a ser que no");
        }

    }
}
