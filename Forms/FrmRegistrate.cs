using Exepciones;
using Objetos;
using Newtonsoft.Json;

namespace Forms
{
    public partial class FrmRegistrate : Form
    {
        public FrmRegistrate()
        {
            InitializeComponent();
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Verificar())
                {

                }
            }
            catch (CuentaExistenteExeption)
            {
                ErrorNombre.Visible = true;
            }
            catch (ContraseñaDistintaExeption)
            {
                LblErrorContraseña.Visible = true;
            }
            catch(Exception ex)
            {
                ErrorConsumo.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // crear captcha
        }
        public bool Verificar()
        {
            string nombre = TxtNombre.Text;
            string contraseña = TxtContraseña.Text;
            string repetida = TxtRepetir.Text;
            int consumo = int.Parse(TxtConsumo.Text);
            bool retorno = false;
            List<Usuario> datos = Deserializar();
            foreach (Usuario dato in datos)
            {
                if(nombre == dato.nombre)
                {
                    throw new CuentaExistenteExeption(nombre);
                }
                else if(contraseña != repetida)
                {
                    throw new ContraseñaDistintaExeption();
                }
                else if(CbCaptcha.Checked == false)
                {
                    LblErrorCaptcha.Visible = true;
                }
                else if (CbCaptcha.Checked)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public List<Usuario> Deserializar()
        {
            List<Usuario> usuarios = null;
            string jsonText = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\usuarios.json");

            usuarios = JsonConvert.DeserializeObject<List<Usuario>>(jsonText);
            return usuarios;
        }
    }
}
