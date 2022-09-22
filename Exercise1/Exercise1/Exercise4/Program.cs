using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] estados = { 67836.43, 36676.66, 29229.88, 27165.48, 19849.53 };
            string[] nomeEstado = { "sp", "rj", "mg", "es", "outros" }; 

            double resultado;

            double total = estados[0] + estados[1] + estados[2] + estados[3] + estados[4];

            for(int i=0; i < estados.Length; i++)
            {
                resultado = ( estados[i] * 100 ) / total;
                Console.WriteLine($"{nomeEstado[i]} equivale a {resultado}% do valor total");
            }


        }
    }
}
