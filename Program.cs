using EspacioCalculadora;
Calculadora miCalculadora = new Calculadora();

miCalculadora.Suma(10);

Console.WriteLine("Resultado: "+miCalculadora.Memoria);

int opcion = 0;
// Interfaz grafica
// despues de hacer cada operacion limpiar la memoria
do
{
    System.Console.WriteLine("******Calculadora Simple******");
    
} while (opcion != 10);
