namespace Exepciones
{
    public class CuentaExistenteExeption : Exception
    {
        public CuentaExistenteExeption(string usuario, bool existe = true) : base($"la cuenta de {usuario} {(existe ? "ya existe" : "no existe")}")
        {

        }
    }
}
