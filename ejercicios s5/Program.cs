double area(double radio)
{         
    return Math.PI * radio * radio;
}
double perimetro(double ancho, double altura)
{
    return 2 * (ancho + altura);
}
double Promedio(int[] lista)
{
    return lista.Sum() / (double)lista.Length;
}
string par(int numero)
{
    if (numero % 2 == 0)
    {
        return "par";
    }
    else
    {
        return "impar";
    }
}

string minusculas(string cadena)
{
    return cadena.ToUpper();
}

double distancia1(double x1, double y1,double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

int naturales(int num)
{
    return Enumerable.Range(1, num).Sum();
}
int factorial(int numerof)
{
    if (numerof > 0)
    {
        return numerof * factorial(numerof - 1);
    }
    if (numerof == 0)
    {
        return 1;

    }
    else
    {
        Console.WriteLine("El numero es negativo");
       return 0;
    }
}

double circulo =5;

double s= area(circulo);
Console.WriteLine("El area del circulo es : " + s);

double a1=5.5, b1=12;

double rectangulo=perimetro(a1, b1);
Console.WriteLine($"El perimetro del rectangulo es: {rectangulo}");

int[] c1 =  { 2, 3, 4, 5, 2, 6, 7 };

double media=Promedio(c1);
Console.WriteLine($"El promedio de los numeros del arreglo es:{media}");

int numero1 = 5;

Console.WriteLine($"El numero es: {par(numero1)}");

string convertir = "mayusculas";

Console.WriteLine($"La cadena de minusculas a mayusculas: {minusculas(convertir)}");

double x11 = 3, y11 = 4, x12 = 6, y12 = 12;

Console.WriteLine($"La distancia entre los puntos es: {distancia1(x11,y11,x12,y12)}");

int num2 = 12;

Console.WriteLine($"la suma de los numeros naturales hasta n = 12 es: {naturales(num2)}");

int numerof1 = 4;

Console.WriteLine($"El factorial de n = 4 es: {factorial(numerof1)}");







