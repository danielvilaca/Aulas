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

Console.WriteLine();

//LEITURA DE DADOS ALFANUMÉRICOS
Console.WriteLine("LEITURA DE DADOS ALFANUMÉRICOS");

Console.WriteLine();

//LEITURA DE DADOS NUMÉRICOS
Console.WriteLine("LEITURA DE DADOS NUMÉRICOS");

Console.WriteLine();

//MAIOR DE DOIS
Console.WriteLine("MAIOR DE DOIS");

Console.WriteLine();

//MULTIBANCO
Console.WriteLine("MULTIBANCO");

Console.WriteLine();

//NÚMEROS ÍMPARES
Console.WriteLine("NÚMEROS ÍMPARES");

Console.WriteLine();








