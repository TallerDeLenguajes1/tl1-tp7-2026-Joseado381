namespace EspacioCalculadora;

public class Calculadora
{   
    private double memoria;

    public double Memoria {get => memoria;}

    private double resultado;

    public double Resultado { get => resultado;}

    public void Suma(double dato)
    {
        memoria += dato;
        resultado = dato;
    }

    public void Restar(double dato)
    {
        memoria -= dato;
        resultado = dato;
    }

    public void Multiplicar(double dato)
    {
        memoria *= dato;
        resultado = dato;
    }

    public void Dividir(double dato)
    {
        if (dato != 0)
        {
            memoria /= dato;
            resultado = dato;
        }
    }

    public void Limpiar(double dato)
    {
        memoria = 0;
        dato = 0;
    }
}