using System;
using System.Collections.Generic;

namespace Pessoas
{
    public class Pessoas
    {
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string EmailPessoa { get; set; }
        public string TelefonePessoa { get; set; }

        public List<Pessoas> GerarPessoa()
        {
            List<Pessoas> ListaPessoas = new List<Pessoas>();

            try
            {
                Pessoas pessoa1 = new Pessoas
                {
                    IdPessoa = 1,
                    NomePessoa = "Pessoa 1",
                    EmailPessoa = "email1@email1.com",
                    TelefonePessoa = "111111111"
                };

                ListaPessoas.Add(pessoa1);

                Pessoas pessoa2 = new Pessoas
                {
                    IdPessoa = 2,
                    NomePessoa = "Pessoa 2",
                    EmailPessoa = "email1@email2.com",
                    TelefonePessoa = "222222222"
                };

                ListaPessoas.Add(pessoa2);

                return ListaPessoas;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}