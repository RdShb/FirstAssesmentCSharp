using static System.Console;

Clear();
Write("Ingrese el nombre del instrumento (Trompeta/Piano/Violín):");
string? nombre = ReadLine();

Write("Ingrese el precio:");
double precio = 0;
double.TryParse(ReadLine(), out precio);

InstrumentosMusicales? instrumento = null;

switch (nombre!.ToLower())
{
    case "trompeta":
        Write("Ingrese el tipo:");
        string? tipo = ReadLine();
        instrumento = new Trompeta(nombre!, precio, tipo!);
        WriteLine(instrumento);
        break;
    case "piano":
        Write("Ingrese el marca:");
        string? marca = ReadLine();
        instrumento = new Piano(nombre, precio, marca!);
        WriteLine(instrumento);
        break;

    case "violín":
        Write("Ingrese el tipo:");
        string? tipoViolin = ReadLine();
        instrumento = new Violin(nombre, precio, tipoViolin!);
        WriteLine(instrumento);
        break;

    default:
        WriteLine("Instrumento Invalido");
        break;
}
if (instrumento != null)
    WriteLine(instrumento.Descripcion());
    
Write("Entre cualquier tecla");
ReadKey();