import javax.swing.*;

public class SentenciaForArreglo {
    public static void main(String[] args) {

        //String[] nombres = new String[6];
        String[] nombres = {"r344e","fs4","32fda","dsa","asd"};

        int count = nombres.length;

        for(int i = 0; i < count; i++){

            if(nombres[i].toLowerCase().contains("fs4".toLowerCase())){
                continue;
            }

            System.out.println(nombres[i]);
        }

        String buscar = JOptionPane.showInputDialog("nombre");
        System.out.println("buscar = " + buscar);

        boolean encontrado = false;
        for (int i = 0; i<count; i++){
            if(nombres[i].equalsIgnoreCase(buscar)){
                encontrado = true;
                break;
            }
        }
        if(encontrado){
            JOptionPane.showMessageDialog(null, buscar);
        }else{
            JOptionPane.showMessageDialog(null, "no existe");
        }

    }
}
