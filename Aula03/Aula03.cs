using System;
class aula03{
    static void Main(){
            byte n1 = 10; // armazena de 0 a 255
            int num = 0; 
            char letra = 'c'; //no Char usamos o ' apostolo
            float valor = 5.3f;
            string nome = " Farias"; // na string usamos o " aspas
            /* VAR - não foi definido o tipo, o qual será defenido
            na compilação conforme atribição feita a ela */
            var aux1 = "Altemar";
            var aux2 = nome;
            Console.Write(aux1);
            Console.WriteLine(aux2);
            int num1, num2, res;
            num1 = 10; num2 = 2; res = num1 * num2;
            Console.WriteLine("A multiplicação de " + num1 + " vezes " + num2 + " é igual a: " + res);

        }

}

