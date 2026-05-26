namespace EmpleadoSis
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fecha;
        private char estadoCivil;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    }
}