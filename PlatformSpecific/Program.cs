//O .NET é multiplataforma, e pode ser necessário identificar a plataforma da execução do programa
//OperationSystem identifica o sistema operacional em que o programa está rodando
using System.Runtime.Versioning;

if (OperatingSystem.IsWindows())
    Console.WriteLine("Rodando no Windows");

if (OperatingSystem.IsMacOS())
    Console.WriteLine("Rodando no Mac");

//A nível de compilação (para apresentar avisos nas chamadas de métodos), métodos podem receber o atributo "SupportedOSPlatform" ou "UnsopprtedOSPlatform" (metadata), que recebe o parâmetro do(s) sistema(s) operacional(is) suportados
[SupportedOSPlatform("windows"), SupportedOSPlatform("macos")]
[UnsupportedOSPlatform("linux")]
void Windows()
{
}