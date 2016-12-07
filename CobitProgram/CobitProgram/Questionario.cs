using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CobitProgram
{
    public class Questionario
    {
        public Questionario()
        {
            int pontos = 0;
            int vidas = 10;
            string[] vidasArrayStr = new string[11];
            vidasArrayStr[10] = @"|S2 S2 S2 S2 S2 S2 S2 S2 S2 S2|[10]";
            vidasArrayStr[9] = @"|S2 S2 S2 S2 S2 S2 S2 S2 S2  X|[9]";
            vidasArrayStr[8] = @"|S2 S2 S2 S2 S2 S2 S2 S2  X  X|[8]";
            vidasArrayStr[7] = @"|S2 S2 S2 S2 S2 S2 S2 X   X  X|[7]";
            vidasArrayStr[6] = @"|S2 S2 S2 S2 S2 S2 X  X   X  X|[6]";
            vidasArrayStr[5] = @"|S2 S2 S2 S2 S2 X  X  X   X  X|[5]";
            vidasArrayStr[4] = @"|S2 S2 S2 S2 X  X  X  X   X  X|[4]";
            vidasArrayStr[3] = @"|S2 S2 S2 X  X  X  X  X   X  X|[3]";
            vidasArrayStr[2] = @"|S2 S2 X  X  X  X  X  X   X  X|[2]";
            vidasArrayStr[1] = @"|S2 X  X  X  X  X  X  X   X  X|[1]";
            vidasArrayStr[0] = @"|X  X  X   X  X  X  X  X  X  X|[0]";
            string avaliacao = "";
            bool desejaGameOver = false;
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.WriteLine("Teste COBIT");
            Console.WriteLine();
            Console.WriteLine("Quantidade de Vidas " + vidasArrayStr[10]);
            Console.WriteLine();
            Console.WriteLine("Digite 1 para AV1 e 2 para AV2");
            avaliacao = Console.ReadLine().Trim();
            Console.WriteLine();
            Console.WriteLine("Deseja realizar tentativar infinitas? 1 - SIM ou 0 - Não");
            if (Console.ReadLine().Trim().Equals("0"))
            {
                Console.WriteLine();
                desejaGameOver = true;
                Console.WriteLine("Modo GameOver Ativado!");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Digite 1 para sortear as questões ou 0 para manter em ordem:");
            Console.WriteLine();


            List<QuestoesRespostas> questionario = (avaliacao.Equals("1") ? new List<QuestoesRespostas>(QuestoesRespostas.GeraQuestionario()) : new List<QuestoesRespostas>(QuestoesRespostas.GeraQuestionarioAV2()));


            Random rand = new Random();
            string selecaoRand = Console.ReadLine().Trim();
            if (selecaoRand.Equals("1"))
            {
                questionario = questionario.OrderBy(item => rand.Next()).ToList();
            }

            int[] positions = Enumerable.Range(0, 5).OrderBy(x => Guid.NewGuid()).Take(5).ToArray();

            for (int i = 0; i < questionario.Count; i++)
            {
                Console.WriteLine("Questao " + i);
                Console.WriteLine();

                Console.WriteLine(questionario.ElementAt(i).Questao);
                Console.WriteLine("Selecione a alternativa correta: ");
                Console.WriteLine();
                Console.WriteLine("1 - " + questionario.ElementAt(i).Alternativas[positions[0]]);
                Console.WriteLine();
                Console.WriteLine("2 - " + questionario.ElementAt(i).Alternativas[positions[1]]);
                Console.WriteLine();
                Console.WriteLine("3 - " + questionario.ElementAt(i).Alternativas[positions[2]]);
                Console.WriteLine();
                Console.WriteLine("4 - " + questionario.ElementAt(i).Alternativas[positions[3]]);
                Console.WriteLine();
                Console.WriteLine("5 - " + questionario.ElementAt(i).Alternativas[positions[4]]);

                Console.WriteLine();

                int selecionado = Int32.Parse(Console.ReadLine().Trim());
                if (questionario.ElementAt(i).Resposta.Equals(questionario.ElementAt(i).Alternativas[positions[selecionado - 1]]))
                {
                    Console.WriteLine("Correto! +1");
                    Console.WriteLine("Pontos: " + ++pontos);
                    Console.WriteLine();
                    Console.WriteLine("Vidas: " + vidasArrayStr[vidas]);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Errado! -1 Vida!");
                    vidas--;
                    Console.WriteLine();
                    Console.WriteLine("Resposta Correta: " + questionario.ElementAt(i).Resposta);
                    Console.WriteLine();
                    if (vidas < 0 && desejaGameOver)
                    {
                        Console.WriteLine("GAME OVER!");
                        Console.WriteLine();
                        Console.ReadLine();
                        break;
                    }
                    Console.WriteLine("Vidas: " + vidasArrayStr[vidas]);
                    Console.WriteLine();
                    Console.WriteLine("Pressione Enter para continuar...");
                    Console.ReadLine();

                }
            }

            Console.WriteLine();
            Console.WriteLine("Fim! O seu placar foi de: " + pontos + " pontos");
            Console.ReadLine();

        }
    }
}
