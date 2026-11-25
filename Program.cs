Console.WriteLine($"Digite o nome do seu personagem: ");
string nomePersonagem = (Console.ReadLine() ?? string.Empty).Trim();

int vida = 100;
int moedas = 20;
int nivel = 1;

Console.WriteLine($"Bem-vindo, {nomePersonagem}! Sua jornada começa agora.");
Console.WriteLine($"Vida: {vida}");
Console.WriteLine($"Moedas: {moedas}");
Console.WriteLine($"Nível: {nivel}");