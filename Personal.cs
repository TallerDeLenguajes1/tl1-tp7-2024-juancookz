namespace EspacioPersonal
{
    enum ECargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public class Personal
    {
        string Nombre;
        private string Apellido;
        private DateTime fecNac;
        private char EstadoCivil;
        private DateTime fecIngreso;
        private double sueldoBasico;
        private ECargo Cargo;

    }
}