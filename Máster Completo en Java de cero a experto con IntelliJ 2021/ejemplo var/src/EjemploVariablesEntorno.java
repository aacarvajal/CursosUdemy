import java.util.Map;

public class EjemploVariablesEntorno {
    public static void main(String[] args) {

        Map<String, String> varEnv = System.getenv();
        System.out.println("varEnv = " + varEnv);

        String userName = System.getenv("USERNAME");
        System.out.println("userName = " + userName);

        String javaHome = System.getenv("JAVA_HOME");
        System.out.println("javaHome = " + javaHome);

        for(String key: varEnv.keySet()){
            System.out.println(key + " => " + varEnv.get(key));
        }

    }
}
