using System;
using MundoSanrio;

namespace MundoSanrio {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("===== ♥♥♥♥♥ =====");
            personagemSanrio pet = EscolherPersonagem();

            string opcao;
            do
            {
                MostrarStatus(pet);
                Console.WriteLine("[1] Comer Doce  [2] Passear  [3] Dormir  [0] Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                string mensagem = ExecutarAcao(pet, opcao);
                Console.WriteLine("\n" + mensagem);
            } while (opcao != "0");
        }

        static personagemSanrio EscolherPersonagem() {
            Console.WriteLine("Escolha seu personagem:");
            Console.WriteLine("[1] Hello Kitty");
            Console.WriteLine("[2] Cinnamoroll");
            Console.WriteLine("[3] Kuromi");
            Console.Write("Opção: ");
            string escolha = Console.ReadLine();

            if (escolha == "2")
                return new Cinnamoroll();
            if (escolha == "3")
                return new Kuromi();

            return new HelloKitty();
        }

        static string ExecutarAcao(personagemSanrio _pet, string _opcao) {
            if (_opcao == "0")
                return $"Até logo! {_pet.Nome} vai sentir sua falta.";

            string mensagem = "";

            if (_opcao == "1")
                mensagem = _pet.ComerDoce();
            else if (_opcao == "2")
                mensagem = _pet.PassearNoParque();
            else if (_opcao == "3")
                mensagem = _pet.TirarSoneca();
            else
                return "Opção inválida!";

            _pet.PassarTempo();
            return mensagem;
        }

        static void MostrarStatus(personagemSanrio _pet) {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine(_pet.fraseFofa());
            Console.WriteLine($"Humor: {_pet.Humor}");
            Console.WriteLine($"Fome: {_pet.Fome}/100 | Energia: {_pet.Energia}/100 | Amizade: {_pet.Amizade}/100");
            Console.WriteLine("-----------------------------");
        }
    }
}