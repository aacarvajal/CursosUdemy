import java.util.Scanner;

public class OperadoresLogicosLogin {
    public static void main(String[] args) {

        /*String[] usernames = new String[2];
        String[] passwords = new String[2];
        //String user1="adrian";
        usernames[0]="adrian";
        //String password = "12345";
        passwords[0] = "12345";

        //String user2 = "admin";
        usernames[1] = "admin";
        //String password2 = "123456";
        passwords[1] = "123456";*/

        String[] usernames = {"admin", "adrian"};
        String[] passwords = {"123456", "12345"};

        Scanner sc = new Scanner(System.in);

        System.out.println("Nombre de usuario");
        String usuario = sc.next();

        System.out.println("Password");
        String pass = sc.next();

        boolean auth = false;

        for (int i = 0; i < usernames.length; i++) {

            auth = (usernames[i].equals(usuario) && passwords[i].equals(pass)) ? true : auth;

            /*if(usernames[i].equals(usuario) && passwords[i].equals(pass)){
                auth = true;
                break;
            }*/

        }

        /*if((user1.equals(usuario) && password.equals(pass)) ||
                (user2.equals(usuario) && password2.equals(pass))){
            auth = true;
        }else{
            System.out.println("mal puesto");
        }*/

        String mensaje = auth ? "me sirve ".concat(usuario) : "mal puesto\nVa a ser que no";
        System.out.println(mensaje);

        /*if (auth) {
            System.out.println("me sirve ".concat(usuario));
        } else {
            System.out.println("mal puesto");
            System.out.println("Va a ser que no");
        }*/

    }
}
