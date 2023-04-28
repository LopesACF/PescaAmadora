const double LimiteAguaContinentais = 10;
const double LimiteAguaMaritimas = 15;
const string Aguas_Maritimas = "M";
const string Aguas_Continentais = "C";


const decimal MultaExcessoPeso = 1000;
const decimal MultaPorKgExcedido = 20;


double PesoDoPescadoEmKg;
string LocalPesca;

Console.WriteLine("--- Pesca Amadora ---\n");

Console.Write("Peso (em kg)...: ");

PesoDoPescadoEmKg = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Águas [c]constinentais ou [m]maritimas? ");
LocalPesca = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (LocalPesca != Aguas_Continentais
 && LocalPesca != Aguas_Maritimas)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Local nao reconhecido.");
    Console.ResetColor();
    return;
}

if ((LocalPesca == Aguas_Continentais 
&& PesoDoPescadoEmKg <= LimiteAguaContinentais)
||
(LocalPesca == Aguas_Maritimas
&& PesoDoPescadoEmKg <= LimiteAguaMaritimas))
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Pescaria dentro dos limites legais.");
    Console.ResetColor();
    return;

}

double PesoPermitido;

if (LocalPesca == Aguas_Continentais)
{
    PesoPermitido = LimiteAguaContinentais;
}
else
{
    PesoPermitido = LimiteAguaMaritimas;
}

double PesoEmExcesso = PesoDoPescadoEmKg - PesoPermitido;

    decimal Multa = MultaExcessoPeso + MultaPorKgExcedido * Convert.ToDecimal(PesoEmExcesso);

    Console.ForegroundColor = ConsoleColor.DarkYellow;

    Console.WriteLine($"Pescaria excede os limites legais em {PesoEmExcesso}kg.");
    Console.WriteLine($"Sujeito a multa de {Multa:C2}");