using System;
class ArrayExample
{
    static void Main()
    {
        //CONTIENE UNA ARRAY DE CARACTERES
        //SE RESERVA MEMORIA PARA CIERTOS ELEMENTOS DE TIPO 'CHAR'
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        int[] a = new int[10];
        //BUCLE FOR CUYA FUNCION ES REPETIR EL BLOQUE UN NUMERO DETERMINADO DE VECES
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];//A LA VARIABLE NAME SE LE INCREMENTA EL NUMERO DE LA LONGITUD DEL ARRAY
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg); //MUESTRA EN CONSOLA EL CONTENIDO QUE HAY ENTRE LOS PARÉNTESIS
    }
}