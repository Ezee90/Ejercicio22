Console.WriteLine("ingrese el lado A:");
var ladoA=int.Parse(Console.ReadLine());
Console.WriteLine("ingrese el lado B:");
var ladoB=int.Parse(Console.ReadLine());
Console.Write("ingrese el lado C:");
var ladoC=int.Parse(Console.ReadLine());

var esTriangulo=VerificarTriangulo(ladoA,ladoB,ladoC);
if (esTriangulo)
{
    string TipoDeTriangulo = DevolverTipoDeTriangulo(ladoA, ladoB, ladoC);
    Console.WriteLine($"los lados ingresados conforman un {TipoDeTriangulo}");
}
else
{
    Console.WriteLine($"los lados ingresados no conforman un Triangulo");
}

string DevolverTipoDeTriangulo(int ladoA, int ladoB, int ladoC)
{
    if (ladoA!=ladoB && ladoB!=ladoC && ladoA!=ladoC)
    {
        return "Triangulo Escaleno";
    }else if (ladoA==ladoB && ladoB==ladoC)
    {
        return "triangulo equilatero";
    }else {
        return "triangulo isosceles";
    }
        bool VerificarTriangulo(int ladoA, int ladoB, int ladoC)
{
    return ladoA+ladoB>ladoC && ladoA+ladoC>ladoB &&
        ladoB + ladoC > ladoA;  
}