public class EjemploStringTestRendimientoConcat {

    public static void main(String[] args) {

        String a = "a";
        String b = "b";
        String c = a;

        StringBuilder sb = new StringBuilder(a);
        long iniciado = System.currentTimeMillis();

        for(int i = 0; i<500;i++){

            //c = c.concat(a).concat(b).concat("\n");
            //c += a+b+"\n";
            sb.append(a).append(b).append("\n");

        }

        //liberar espacio
        System.gc();

        long fin = System.currentTimeMillis();
        System.out.println(fin - iniciado);
        System.out.println("c = " + c);
        System.out.println("sb.toString() = " + sb.toString());
        System.exit(0);

    }

}
