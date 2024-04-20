import java.util.ArrayList;
import java.util.Scanner;


public class Main {
    static Persona personaTop;
    static Persona personaTop2;
    static ArrayList<Persona> personas = new ArrayList<>();
    static ArrayList<Persona> listaMenores = new ArrayList<>();
    static int n = 3;
    static double promedio = 0;
    static double prom = 0;
    static Scanner scanner = new Scanner(System.in);

    // Función de mayor
    static Persona mayor(){
        personaTop = personas.get(0);
        for(int i = 1; i < personas.size(); i++){
            if(personas.get(i).edad() > personaTop.edad()){
                personaTop = personas.get(i);
            }
        }
        return personaTop;
    }

    // Función de menor
        static ArrayList<Persona> menor(){
        ArrayList<Persona> auxiliar = new ArrayList<>();
        auxiliar = personas;
        personaTop = auxiliar.get(0);
        for(int i = 1; i < auxiliar.size(); i++){
            if(auxiliar.get(i).edad() < personaTop.edad()){
                personaTop = auxiliar.get(i);
            }
        }
        auxiliar.remove(personaTop);


        personaTop2 = auxiliar.get(0);
        for(int i = 1; i < auxiliar.size(); i++){
            if(auxiliar.get(i).edad() < personaTop2.edad()){
                personaTop2 = auxiliar.get(i);
            }
        }

        listaMenores.add(personaTop);
        listaMenores.add(personaTop2);


            return listaMenores;
    }

    // Función del promedio
    static double promedio(){
        for (int i = 0; i < personas.size(); i++){
            personaTop = personas.get(i);
            prom += personaTop.edad();
        }
        promedio = prom / personas.size();
        return promedio;
    }

    public static void main(String[] args){
        String inputNombre = "";
        String inputFecha = "";
        Scanner inputEscaner = new Scanner(System.in);
        for(int i = 0; i < n; i++){
            System.out.print("Ingresar nombre: ");
            inputNombre = inputEscaner.nextLine();
            System.out.print("Ingresar fecha de nacimiento: ");
            inputFecha = inputEscaner.nextLine();
            personaTop = new Persona(inputNombre,inputFecha);
            personas.add(personaTop);
        }

        promedio = promedio();
        System.out.println("El promedio de edades es: " + promedio);
        personaTop = mayor();
        System.out.println("El mayor es: " + personaTop.nombre + " y su edad es: " + personaTop.edad());
        listaMenores = menor();
        System.out.print("Los menores son: " + personaTop.nombre + " y " + personaTop2.nombre + " y sus edades son: " + personaTop.edad() + " y " + personaTop2.edad() + " respectivamente.");


    }
}