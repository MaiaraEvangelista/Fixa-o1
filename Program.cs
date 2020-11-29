using System;

namespace fixação1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ler o ano atual e o ano de nascimento, e dizer se ela poderá votar ou não
                Console.WriteLine("Insira o ano atual: ");
               int anoAtual = int.Parse(Console.ReadLine());

               Console.WriteLine("Insira o ano de nascimento");
               int anoNascimento = int.Parse(Console.ReadLine());
               int retornoDaFuncao = Idade(anoAtual, anoNascimento);

               ExibirMensagem(retornoDaFuncao);

                if (retornoDaFuncao>=18)
                {
                    Console.WriteLine("Adulto");
                }else{
                    Console.WriteLine("Infantil");
                }

                int Idade(int atual, int nascimento){
                    int idade = atual - nascimento;
                    return idade;
                }

                void ExibirMensagem(int idade){
                    Console.WriteLine($"A idade é de {idade}:");
                }
        }
    }
}
