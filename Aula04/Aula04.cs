using System;
class Aula04{
    int num1 = 15; // Variável global
    static int num2 = 20; 
    static void Main(){
        int num = 5;  // essa é uma variável local
        Console.WriteLine(num2); // Essa variágel global que que ser static
        Console.Write(num); 
    }
    void teste(){
        int num = 10; // o mesmo nome da variável local, mas o escopo é diferente
        Console.WriteLine(num);
        Console.WriteLine(num1); // Essa variável é global 
    }    
}