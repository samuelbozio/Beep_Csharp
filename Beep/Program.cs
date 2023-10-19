
Console.WriteLine("Digite uma frequência? Hz");
int Frequency = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite uma duração? Ms");
int Duration = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite [A] para dar Play");
var a = Console.ReadLine();

if (a == "A")
{
    Console.Beep(frequency: Frequency, duration: Duration);
}
else
{
    Console.WriteLine("Digite pelo menos a tecla certa...");
}

