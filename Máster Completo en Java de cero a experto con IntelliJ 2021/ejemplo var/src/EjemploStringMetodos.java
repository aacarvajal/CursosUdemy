public class EjemploStringMetodos {

    public static void main(String[] args) {

        String nombre = "asdfggh";

        System.out.println("nombre.length() = " + nombre.length());
        System.out.println("nombre.toLowerCase() = " + nombre.toLowerCase());
        System.out.println("nombre.toUpperCase() = " + nombre.toUpperCase());
        System.out.println("nombre.equals(\"as\") = " + nombre.equals("As"));
        System.out.println("nombre.compareToIgnoreCase() = " + nombre.compareToIgnoreCase("as"));
        System.out.println("nombre.compareTo(\"sd\") = " + nombre.compareTo("sd"));
        System.out.println("nombre.charAt(0) = " + nombre.charAt(0));
        System.out.println("nombre.substring(1) = " + nombre.substring(1));
        System.out.println("nombre.substring(1,4) = " + nombre.substring(1, 4));//desde hasta
        System.out.println("nombre.substring(nombre.length()-1) = " + nombre.substring(nombre.length()-1));//ultimo caracter
        
        String str = "asdfdsa";
        System.out.println("str.replace(\"a\",\".\") = " + str.replace("a", "."));
        System.out.println("str.indexOf('a') = " + str.indexOf('a'));//devuelve la posicion del primer caracter que encuentra
        System.out.println("str.lastIndexOf('a') = " + str.lastIndexOf('a'));
        System.out.println("str.contains(\"d\") = " + str.contains("d"));
        System.out.println("str.startsWith(\"dfd\") = " + str.startsWith("dfd"));
        System.out.println("str.endsWith(\"sa\") = " + str.endsWith("sa"));
        System.out.println(" asdfdsa ");
        System.out.println(" asdfdsa ".trim());//quita espacios a der e izq


    }

}
