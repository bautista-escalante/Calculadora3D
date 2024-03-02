namespace Objetos
{
    public class Usuario
    {
        public int consumo;
        public string nombre;
        public string contraseña;
        
        public Usuario(int consumo, string nombre, string contraseña)
        {
            this.consumo = consumo;
            this.nombre = nombre;
            this.contraseña = contraseña;
        }

    }
}
