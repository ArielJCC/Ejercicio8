//Escribir un programa que escriba todos los múltiplos de 3 del número 1 al 3000 
internal class Program
{
    private static void Main(string[] args)
    {
        for(int i = 0; i <= 3000; i = i + 3)
        Console.WriteLine(i);
    }
}