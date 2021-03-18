public class SentenciaForEach {
    public static void main(String[] args) {

        int[] numeros = {1,3,5,7,9,11,13,14};
        for(int num: numeros){
            System.out.println("num = " + num);
        }

        String[] nombres = {"r344e","fs4","32fda","dsa","asd"};

        for(String nom : nombres){
            System.out.println("nom = " + nom);
        }

    }
}
