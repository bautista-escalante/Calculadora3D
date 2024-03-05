namespace Objetos
{
    public class Usuario
    {
        public string impresora;
        public string nombre;
        public string contraseña;
        public int consumo;

        public Usuario(string impresora, string nombre, string contraseña,int consumo)
        {
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.impresora = impresora;
            this.consumo = consumo;
        }


    }
}