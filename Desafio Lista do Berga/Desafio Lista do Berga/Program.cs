using System.Reflection;
using System.Runtime.CompilerServices;

namespace Desafio_Lista_do_Berga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice;
            bool repete = true;
            bool verifica = false;
            string chek;
            Console.WriteLine("Bem vindo ao projeto: resolução da lista de exercicios do Berga.[V 1.0]");
            
            while ( repete == true)
            {
                Console.WriteLine("Digite o número do exercício que você deseja acessar.");
                Console.WriteLine("Exercícios disponíveis 1 ao 10");
                indice = int.Parse(Console.ReadLine());
                
                while ( verifica ==false) { 
                if ( indice < 1 || indice > 10)
                {
                    Console.WriteLine("Valor incorreto, digite somente um número disponível");
                    Console.Clear();
                    Console.WriteLine("Digite o número do exercício que você deseja acessar.");
                    Console.WriteLine("Exercícios disponíveis 1 ao 10");
                    indice = int.Parse(Console.ReadLine());
                    }
                    else { verifica = true; }
                }

                switch (indice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Exercício "+indice+ " selecionado.\r\n");
                            Console.WriteLine("Enunciado: Entrar via teclado com a base e a altura de um retângulo, calcular e exibir sua área.\r\n");
                            Console.WriteLine("Digite a altura do retângulo");
                            double altura = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a largura do retângulo");
                            double largura = double.Parse(Console.ReadLine());
                            Console.WriteLine("A área do retângulo é: " + (altura * largura));
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        { 
                            Console.Clear();
                            Console.WriteLine("Exercício " + indice + " selecionado.\r\n");
                            Console.WriteLine("Enunciado: Calcular e exibir a área de um quadrado, a partir do valor de sua aresta que será digitado.\r\n");
                            Console.WriteLine("Digite a aresta do seu quadrado");
                            double aresta = double.Parse(Console.ReadLine());
                            Console.WriteLine("A área do seu quadrado obtida a partir da aresta é: "+(Math.Pow(aresta,2)));
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Exercício " + indice + " selecionado.\r\n");
                            Console.WriteLine("Calcular e exibir a área de um quadrado a partir do valor de sua diagonal que será digitado.\r\n");
                            Console.WriteLine("Digite a diagonal do seu quadrado");
                            double diagonal = double.Parse(Console.ReadLine());
                            Console.WriteLine("A área do seu quadrado obtida a partir da diagonal é: " + ( ( (Math.Pow( diagonal, 2 ) ) ) / 2) );
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Exercício " + indice + " selecionado.\r\n");
                            Console.WriteLine("A partir dos valores da base e altura de um triângulo, calcular e exibir sua área.\r\n");
                            Console.WriteLine("Digite a altura do triângulo");
                            double altura = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a base do triângulo");
                            double Base = double.Parse(Console.ReadLine());
                            // OBS: base é uma palavra reservada do C#, por isso eu dei o nome de Base para a váriavel, memso que isso não seja o mais recomendado[V 1.0]
                            Console.WriteLine("A área do seu triângulo é: " + ( (Base * altura) / 2) );
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Exercício " + indice + " selecionado.\r\n");
                            Console.WriteLine("Calcular e exibir o volume de uma esfera a partir do valor de seu diâmetro que será digitado.\r\n");
                            Console.WriteLine("Digite o diametro da sua esfera");
                            double diametro = double.Parse(Console.ReadLine());
                            Console.WriteLine("O volume da sua esfera obtido a partir do diametro é: " + ((((4*(Math.PI))/3)*(Math.Pow((diametro / 2), 3)))) );
                            Console.ReadKey();
                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("Exercício " + indice + " selecionado.\r\n");
                            Console.WriteLine("Calcular e exibir a média aritmética de quatro valores quaisquer que serão digitados.\r\n");
                            Console.WriteLine("Digite o primeiro valor:");
                            double valorUm = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo valor:");
                            double valorDois = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o terceiro valor:");
                            double valorTres = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o quarto valor:");
                            double valorQuatro = double.Parse(Console.ReadLine());
                            Console.WriteLine("A média aritimética desses valores é: " + ((valorUm+valorDois+valorTres+valorQuatro)/4));
                            Console.ReadKey();
                        }
                        break;
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("Exercício " + indice + " selecionado.\r\n");
                            Console.WriteLine("Calcular e exibir a média geométrica de dois valores quaisquer que serão digitados.\r\n");
                            Console.WriteLine("Digite o primeiro valor:");
                            double valorUm = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo valor:");
                            double valorDois = double.Parse(Console.ReadLine());
                            Console.WriteLine("A média geométrica desses valores é: " + (Math.Pow(Math.Sqrt(valorUm * valorDois),2 )));
                            Console.ReadKey();
                        }
                        break;
                    case 8:
                        {
                            Console.Clear();
                            Console.WriteLine("Exercício " + indice + " selecionado.\r\n");
                            Console.WriteLine("Enunciado: Sabendo que uma milha marítima equivale a um mil, oitocentos e cinquenta e dois metros e que um");
                            Console.WriteLine("quilômetro possui mil metros, fazer um programa para converter milhas marítimas em quilômetros.\r\n");
                            Console.WriteLine("Digite a quantidade de milhas marítimas");
                            double milhasMaritimas = double.Parse(Console.ReadLine());
                            Console.WriteLine("A quantidade de quilômetros convertidos a partir de "+milhasMaritimas+"  é: "+(milhasMaritimas*1.852)+"km");
                            Console.ReadKey();
                        }
                        break;
                    case 9:
                        {
                            Console.Clear();
                            Console.WriteLine("Exercício " + indice + " selecionado.\r\n");
                            Console.WriteLine("Enunciado: Calcular e exibir a tensão de um determinado circuito eletrônico a partir dos valores da resistência e");
                            Console.WriteLine("corrente elétrica que serão digitados. Utilize a lei de Ohm.\r\n");
                            Console.WriteLine("Digite o valor da resistência:");
                            double resistencia = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o valor da corrente elétrica");
                            double correnteEletrica = double.Parse(Console.ReadLine());
                            Console.WriteLine("O valor da tensão do circuito eletrônio é:" + (resistencia*correnteEletrica)+"v.");
                            Console.ReadKey();
                        }
                        break;
                    case 10:
                        {
                            Console.Clear();
                            Console.WriteLine("Exercício " + indice + " selecionado.\r\n");
                            Console.WriteLine("Enunciado: Entrar via teclado com o valor de uma temperatura em graus Celsius, calcular e exibir sua temperatura"); 
                            Console.WriteLine("equivalente em Fahrenheit.\r\n");
                            Console.WriteLine("Digite o valor de graus célcius");
                            double celsius = double.Parse(Console.ReadLine());
                            Console.WriteLine("O valor de "+celsius+ "graus Céscius para Fahrenheit é de: " + ((celsius *(9 / 5)) + 32)+ "°F");
                            Console.ReadKey();
                        }
                        break;
                }
                Console.Clear();
                Console.WriteLine("Deseja selecionar outro exercício?");
                Console.WriteLine("S/N");
                chek = Console.ReadLine();
                Console.Clear();
                if (chek == "Não" || chek == "N" || chek == "n" || chek == "não") {
                    repete = false;
                }
            }
            Console.WriteLine("Espero que tenha gostado desse projeto. Se você encontrou algum erro me mande uma mensagem pelo meu linkedin");
            Console.WriteLine("link: https://www.linkedin.com/in/atilio-almeida-costa/");
            Console.WriteLine("Feito por: Atilio Almeida Costa");
            Console.WriteLine("[V 1.0] data: 01/04/2023");
            Console.ReadKey();
        }
    }
}