namespace CastleWindsor
{
    public class Persona
    {
        private INombre _nombre;
        private IApellido _apellido;

        public Persona(INombre Nombre, IApellido Apellido)
        {
            _nombre = Nombre;
            _apellido = Apellido;
        }

        public string NombreCompleto()
        {
            _nombre.PrimerNombre = "Marisol";
            _apellido.PrimerApellido = "Maldonado";

            return string.Format("{0} {1}", _nombre.PrimerNombre, _apellido.PrimerApellido);

        }
             
        
    }
}