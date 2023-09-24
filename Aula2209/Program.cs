// See https://aka.ms/new-console-template for more information

//ALINHAMENTO À DIREITA
Console.WriteLine("ALINHAMENTO À DIREITA");
Console.WriteLine("Maria" .PadRight(20) + "Barcelos" .PadRight(20));
Console.WriteLine("Filipe" .PadRight(20) + "Braga" .PadRight(20));
Console.WriteLine("Manel" .PadRight(20) + "Porto" .PadRight(20));

//CONCATENAÇÃO DE STRINGS
string nome = "Luisa";
string apelido = "Silva";

string nomecomp = nome + apelido;
Console.WriteLine();
Console.WriteLine("CONCATENAÇÃO DE STRINGS");
Console.WriteLine(nomecomp);
Console.WriteLine();


//ALINHAMENTO À ESQUERDA
Console.WriteLine("ALINHAMENTO À ESQUERDA");
Console.WriteLine("Maria" .PadLeft(20) + "Barcelos" .PadLeft(20));
Console.WriteLine("Filipe".PadLeft(20) + "Braga" .PadLeft(20));

Console.WriteLine();

//TABULAÇÃO
Console.WriteLine("TABULAÇÃO");
Console.WriteLine("Ana Ruivo\t" + "Porto\t");
Console.WriteLine("Joaquina Pinto\t" + "Aveiro\t");
Console.WriteLine("Miguel Costa\t" + "Braga\t");

Console.WriteLine();

//OPERAÇÕES ARITMÉTICAS
Console.WriteLine("OPERAÇÕES ARITMÉTICAS");
Console.WriteLine(21.5 + 21.5);
Console.WriteLine(8.888888888888 / 2);
Console.WriteLine(1 * 1);

Console.WriteLine();

//FUNÇÕES MATEMÁTICAS
Console.WriteLine("FUNÇÕES MATEMÁTICAS");
Console.WriteLine(Math.Pow(2, 2));
Console.WriteLine(Math.Sqrt(125));
Console.WriteLine(Math.Exp(2));

Console.WriteLine();

//OPERAÇÕES LÓGICAS
Console.WriteLine("OPERAÇÕES LÓGICAS");
string teste = "12";
int num = 12;
int testeconv;

testeconv = Convert.ToInt32(teste);

bool verifica = testeconv == num;
Console.WriteLine(verifica);

Console.WriteLine(1 == 2);
Console.WriteLine(1 != 2);
Console.WriteLine(3 > 2);
Console.WriteLine((3 < 4) && (5 > 6));
Console.WriteLine(3 > 4 || 1 > 2);
Console.WriteLine(!(4 > 5 || 6 > 7));

Console.WriteLine();

//OPERAÇÕES COM ALFANUMÉRICOS
Console.WriteLine("OPERAÇÕES COM ALFANUMÉRICOS");
Console.WriteLine("Lisboa".Length);
Console.WriteLine("Lisboa é a " + "capital de Portugal");
Console.WriteLine("Coimbra".ToUpper());
Console.WriteLine("testeAdelaideteste1teste2".Substring(5, 8));
Console.WriteLine("      6    ".Trim());
Console.WriteLine("Lisboa".CompareTo("Lsb"));
string name = "Braga a melhor cidade do mundo, a segunda é => Porto".Split("=> ")[1];
Console.WriteLine(name);

Console.WriteLine();

//NÚMEROS INTEIROS
Console.WriteLine("NÚMEROS INTEIROS");
sbyte sb = 34;
byte b = 250;
short sh = 32000;
ushort ush = 60000;
int i = 100000012;
uint ui = 3500000000;
long l = 1532333333334581239;
ulong ul = 14532333333334581239;

Console.WriteLine(sb + "<" + b + "<" + sh + "<" + ush);
Console.WriteLine(i + "<" + l + "<" + ui + "<" + ul + "\n");

Console.WriteLine();

//CONVERSÃO DE INTEIROS PARA REAIS E VICEVERSA
Console.WriteLine("CONVERSÃO DE INTEIROS PARA REAIS E VICEVERSA");
double d = 99.56;
int a = (int)d;

int e = 100;
double f = (double)e;

Console.WriteLine(d + " e " + a);
Console.WriteLine(f + " e " + e);
Console.WriteLine();

Console.WriteLine();

//CONVERSÃO DE ALFANUMÉRICOS PARA NUMÉRICOS
Console.WriteLine("CONVERSÃO DE ALFANUMÉRICOS PARA NUMÉRICOS");

string alfanum = "100";

int numer = Convert.ToInt32(alfanum);
Console.WriteLine(numer);

string tamanho = Convert.ToString(numer);
Console.WriteLine(tamanho + " tem " + tamanho.Length + " dígitos.\n");

Console.WriteLine();

//ARREDONDAMENTOS DE NÚMEROS REAIS
Console.WriteLine("ARREDONDAMENTOS DE NÚMEROS REAIS");
Console.WriteLine("{0, 4:F2}", 4.789876);
Console.WriteLine("{0, 4:F2}", 4.701876);
Console.WriteLine("{0, 4:F2}", 5.898765);
Console.WriteLine("{0, 4:F2}", 5.004987);
Console.WriteLine();

Console.WriteLine();

//PERCENTAGENS
Console.WriteLine("PERCENTAGENS");

Console.WriteLine("{0:F2}%", (456.84 / 1000) * 100);
Console.WriteLine("{0:F2}%", (456.79 / 1000) * 100);
Console.WriteLine("{0:F1}%", ((double)457 / 1000) * 100);

Console.WriteLine();

//DATAS CRONOLÓGICAS
Console.WriteLine("DATAS CRONOLÓGICAS");

// Criar um objeto DateTime de exemplo
DateTime data = DateTime.Now;

// Formatos pré-definidos
Console.WriteLine("Formatos Pré-definidos:");
Console.WriteLine("Universal Sortable: {0:s}", data.ToUniversalTime().ToString("s"));
Console.WriteLine("Universal Full Date: {0:U}", data.ToUniversalTime());
Console.WriteLine("Data Longa: {0:D}", data);
Console.WriteLine("Data Curta: {0:d}", data);
Console.WriteLine("Hora Longa: {0:T}", data);
Console.WriteLine("Hora Curta: {0:t}", data);

Console.WriteLine();

//FORMATOS NUMÉRICOS
Console.WriteLine("FORMATOS NUMÉRICOS");

Console.WriteLine("Decimal: {0}", 2500);
Console.WriteLine("Scientific: {0:E}", 0.7887600);
Console.WriteLine("Fixed Point: {0:F}", 0.79);
Console.WriteLine("Formato geral: {0:G}", 2500);
Console.WriteLine("Round-trip: {0:R}", 0.7887600);
Console.WriteLine("Number: {0:N}", 2500);
Console.WriteLine("Percent: {0:P}", 0.7887600);
Console.WriteLine("Hexadecimal: 0x{0:X}", 2500);

Console.WriteLine();

//OPERADORES COMBINADOS
Console.WriteLine("OPERADORES COMBINADOS");
int salario = 1000;
int vendas = 100;
int capital = 1050;
int dividendo = 10;
int divisor = 3;

salario += 10;
vendas -= 20;
capital *= 1;
dividendo %= divisor;

Console.WriteLine("Salário depois do aumento={0}", salario);
Console.WriteLine("Vendas líquidas={0}", vendas);
Console.WriteLine("Capital acumulado={0}", capital);
Console.WriteLine("Resto da divisão de 10 por 3={0}", dividendo);

Console.WriteLine();

//LEITURA DE DADOS ALFANUMÉRICOS
Console.WriteLine("LEITURA DE DADOS ALFANUMÉRICOS");
Console.Write("Digite o seu nome: ");
string nomeuser = Console.ReadLine();

Console.WriteLine("Boa Tarde, " +  nomeuser + "!");

Console.WriteLine();

//LEITURA DE DADOS NUMÉRICOS
Console.WriteLine("LEITURA DE DADOS NUMÉRICOS");
Console.Write("Digite a sua idade: ");
string idade = Console.ReadLine();
Console.Write("Digite o seu salario: ");
string sal = Console.ReadLine();
Console.Write("Digite um número muito grande: ");
string numgrande = Console.ReadLine();
Console.WriteLine("Vc tem {0} anos e ganha {1} euros por mês!", idade, sal);
Console.WriteLine("Digitou o número {0}", numgrande);


Console.WriteLine();

//MAIOR DE DOIS
Console.WriteLine("MAIOR DE DOIS");
Console.Write("Digite um número: ");
string num1Str = Console.ReadLine();
Console.Write("Digite outro número: ");
string num2Str = Console.ReadLine();

int num1 = Convert.ToInt32(num1Str);
int num2 = Convert.ToInt32(num2Str); 

int maior;

if (num1 > num2)
{
    maior = num1;
}
else if (num1 < num2)
{
    maior = num2;
}
else
{
    maior = num1;
}

Console.WriteLine("{0} é o maior dos dois números: {1} e {2}", maior, num1, num2);

Console.WriteLine();

//MULTIBANCO
Console.WriteLine("MULTIBANCO");

double saldo = 1000.00;
int saida = 1;

while (saida == 1)
{

    Console.WriteLine("1. Levantamento");
    Console.WriteLine("2. Depósito");
    Console.WriteLine("3. Pagamento de Serviços");
    Console.WriteLine("4. Fim");
    Console.WriteLine();
    Console.Write("Digite a sua opção --> ");

    int escolha;
    if (!int.TryParse(Console.ReadLine(), out escolha))
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
        continue;
    }

    switch (escolha)
    {
        case 1:
            Console.Write("Digite o valor para levantamento: ");
            double valorLevantamento;
            if (double.TryParse(Console.ReadLine(), out valorLevantamento))
            {
                if (valorLevantamento <= saldo)
                {
                    saldo -= valorLevantamento;
                    Console.WriteLine("Levantamento bem-sucedido. Saldo atual: {0:C}", saldo);
                    Console.WriteLine("Retire o talão");
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para levantamento.");
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
            }
            break;
        case 2:
            Console.Write("Digite o valor para depósito: ");
            double valorDeposito;
            if (double.TryParse(Console.ReadLine(), out valorDeposito))
            {
                if (valorDeposito > 0)
                {
                    saldo += valorDeposito;
                    Console.WriteLine("Depósito bem-sucedido. Saldo atual: {0:C}", saldo);
                    Console.WriteLine("Retire o talão");
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Valor inválido para depósito.");
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
            }
            break;
        case 3:

            string entidade, referencia;

            Console.WriteLine("Pagamento de serviços");
            Console.Write("Entidade --> ");
            entidade = Console.ReadLine();
            Console.Write("Referência --> ");
            referencia = Console.ReadLine();
            Console.Write("Quantia --> ");
            string quantiastr = Console.ReadLine();
            int quantia = Convert.ToInt32(quantiastr);
            saldo -= quantia;
            Console.WriteLine("Pagamento bem-sucedido. Saldo atual: {0:C}", saldo);
            Console.WriteLine("Retire o talão");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");

            break;
        case 4:
            Console.WriteLine("Retire o seu cartão. Obrigado por utilizar o Multibanco.");
            saida = 0;
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            break;
    }
}

Console.WriteLine();

//NÚMEROS ÍMPARES
Console.WriteLine("NÚMEROS ÍMPARES");

Console.WriteLine();








