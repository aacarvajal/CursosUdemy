public class PrecedenciaOperadores {
    public static void main(String[] args) {

        int i = 14;
        int j = 4;
        int k = 1;

        double promedio = i + j + (k / 3d);
        System.out.println("promedio = " + promedio);

        promedio = (i + j + k) / 3d * 10;
        System.out.println("promedio = " + promedio);

        promedio = ++i + j-- + k / 3d * 10;
        System.out.println("promedio = " + promedio);

    }
}
