using System;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pilha = new string[10];
            Console.WriteLine("Digite o índice da operação a ser realizada: \n 1 - Adicionar itens; \n 2 - Remover itens.");
            string input = Console.ReadLine();
            int digitoinicio = int.Parse(input);
            switch (digitoinicio)
            {
                case 1:
                    bool loop = true;
                    while (loop)
                    {
                        if (isFull(pilha))
                        {
                            Console.WriteLine("A pilha está cheia.");
                            break;
                        }
                        Console.WriteLine("Digite o nome do elemento a ser adicionado: ");
                        string inputelemento = Console.ReadLine();
                        Push(pilha, inputelemento);
                    }
                    break;
                case 2:
                    Console.WriteLine("Digite o índice do elemento a ser deletado: ");
                    string inputdelete = Console.ReadLine();
                    int digitodelete = int.Parse(inputdelete);
                    Pop(pilha, digitodelete);
                    break;
            }
        }
        static void Push(string[] pilha, string inputelemento)
        {
            for (int i = 0; i < pilha.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(pilha[i]))
                {
                    pilha[i] = inputelemento;
                    break;
                }
            }
        }
        public static bool isFull(string[] pilha)
        {
            for (int i = 0; i < pilha.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(pilha[i]))
                {
                    return false;
                }
            }
            return true;
        }
        static void Pop(string[] pilha, int digitodelete)
        {
            pilha[digitodelete] = null;
            return;
        }
    }
}
