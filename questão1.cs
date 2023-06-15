using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace leitor_de_pag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista_numeros = new List<int>();
            leitura(lista_numeros);
            lista_numeros.Sort();
            escrita(lista_numeros);
            
        }
        static void leitura(List<int> lista_numeros)
        {
            try
            {
                String line;

                StreamReader sr = new StreamReader("");

                line = sr.ReadLine();
   
                while (line != null)

                {
                    int numero = int.Parse(line);  
                    lista_numeros.Add(numero);

                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
        static void escrita(List<int> lista_numeros)
        {
            try
            {
                
                StreamWriter sw = new StreamWriter("");

                foreach(int num in lista_numeros)
                {
                    sw.WriteLine(num);
                }

                
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
    }
}
