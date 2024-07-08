using System;  // Importa o namespace System, que contém classes fundamentais para o .NET, como Console.

namespace Aula_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";  // Define a senha correta como "123".
            string senhauser;  // Declara uma variável para armazenar a senha digitada pelo usuário.
            int tentativas = 0;  // Inicializa o contador de tentativas com 0.

            do
            {
                Console.Clear();  // Limpa a tela do console.
                Console.WriteLine("Digite a senha");  // Exibe a mensagem solicitando que o usuário digite a senha.
                senhauser = Console.ReadLine();  // Lê a senha digitada pelo usuário e a armazena na variável 'senhauser'.
                tentativas++;  // Incrementa o contador de tentativas.

                if (senha != senhauser)  // Verifica se a senha digitada pelo usuário está incorreta.
                {
                    Console.WriteLine("Senha errada, tente novamente");  // Exibe a mensagem de senha incorreta.
                    System.Threading.Thread.Sleep(2000);  // Pausa a execução por 2 segundos para que o usuário possa ver a mensagem.
                }

            } while (senha != senhauser);  // Continua o loop enquanto a senha digitada pelo usuário for incorreta.

            Console.WriteLine($"Senha correta, tentativas: {tentativas}");  // Exibe uma mensagem indicando que a senha correta foi digitada e mostra o número de tentativas.
        }
    }
}
