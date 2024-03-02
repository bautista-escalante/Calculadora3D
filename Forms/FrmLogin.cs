using Exepciones;
using Newtonsoft.Json;
using Objetos;

namespace Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Verificar())
                {
                    // entro en la app
                }
            }
            catch (IngresoIncorrectoExeption ex)
            {
               LblErrorContraseña.Text = ex.Message;
            }
            catch (CuentaExistenteExeption ex)
            {
                lblErrorCuenta.Text = ex.Message;
            }
            catch (Exception ex)
            {
                LblErrorNombre.Text = ex.Message;
            }
        }

        private void LlblRegistar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrate frm = new FrmRegistrate();
            frm.Show();
            this.Hide();
        }
        public bool Verificar()
        {
            string nombre = txtNombre.Text;
            string contraseña = TxtContraseña.Text;
            bool retorno = false;
            List<Usuario> datos = Deserializar();
            foreach (Usuario dato in datos)
            {
                if (dato.nombre == nombre && dato.contraseña == contraseña)
                {
                    retorno = true;
                }
                else if (dato.contraseña != contraseña && dato.nombre == nombre)
                {
                    throw new IngresoIncorrectoExeption("contraseña");
                }
                else if (dato.contraseña == contraseña && dato.nombre != nombre)
                {
                    throw new IngresoIncorrectoExeption("usuario");
                }
                else if (dato.contraseña != contraseña && dato.nombre != nombre)
                {
                    throw new CuentaExistenteExeption(nombre, existe: false);
                }
            }
            return retorno;
        }
        public List<Usuario> Deserializar()
        {
            List<Usuario>? usuarios;
            string jsonText = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\usuarios.json");
            usuarios = JsonConvert.DeserializeObject<List<Usuario>>(jsonText);
            return usuarios;
        }
    }
}
