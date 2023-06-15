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
            int escolha = 3;
            while(escolha > 0)
            {
                Console.WriteLine(" 0-Sair \n 1-Gravar texto \n 2-Ler texto gravado \n Opção:");
                escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    Console.WriteLine("Qual a frase ou palavra desejada? \n");
                    String frase = Console.ReadLine();
                    escrita(frase);
                }
                else if (escolha == 2)
                {
                    leitura();
                }
                else
                {
                    escolha = 0;
                }

            }

            

        }
        static void leitura()
        {
            try
            {
                String line;

                StreamReader sr = new StreamReader("");

                line = sr.ReadLine();

                while (line != null)

                {


                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                
            }

        }
        static void escrita(String frase)
        {
            try
            {
                
                StreamWriter sw = new StreamWriter("");
                sw.WriteLine(frase);




                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("executado!");
            }

        }
    }
}
