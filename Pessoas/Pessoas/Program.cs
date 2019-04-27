using System;
using System.Collections.Generic;

namespace Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Pessoas> ListaPessoas = new List<Pessoas>();
                Pessoas pessoas = new Pessoas();

                ListaPessoas = pessoas.GerarPessoa();

                foreach(var p in ListaPessoas)
                {
                    Console.WriteLine(p.IdPessoa);
                    Console.WriteLine(p.NomePessoa);
                    Console.WriteLine(p.EmailPessoa);
                    Console.WriteLine(p.TelefonePessoa);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            Console.ReadLine();
        }
    }
}