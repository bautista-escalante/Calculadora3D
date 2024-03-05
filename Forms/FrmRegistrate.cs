using Exepciones;
using Objetos;
using Newtonsoft.Json;
using System.Linq;

namespace Forms
{
    public partial class FrmRegistrate : Form
    {
        private string captcha;
        private string nombre;
        private string contraseña;
        private string repetida;
        public FrmRegistrate()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            this.nombre = TxtNombre.Text;
            this.contraseña = TxtContraseña.Text;
            this.repetida = TxtRepetir.Text;
            try
            {
                if (this.Verificar() && this.VerificarCaptcha())
                {
                    string impresora = CbImpresora.Text;
                    List<Usuario> listaUsuarios = this.Deserializar();
                    Usuario nuevo = new Usuario(impresora, this.nombre,this.contraseña,this.CalcularWatts(CbImpresora.Text));
                    listaUsuarios.Add(nuevo);
                    string json = JsonConvert.SerializeObject(listaUsuarios);
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\usuarios.json", json);
                    FrmPrincipal frm = new FrmPrincipal();
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            catch (CampoVacioexeption ex)
            {
                switch (ex.campo)
                {
                    case  "nombre":
                        ErrorNombre.Text = ex.Message;
                        ErrorNombre.Visible = true;
                        break;
                    case "impresora":
                        ErrorImpresora.Text = ex.Message;
                        ErrorImpresora.Visible = true;
                        break;
                    case "contraseña":
                        LblErrorContraseña.Text = ex.Message;
                        LblErrorContraseña.Visible = true;
                        break;
                }
            }
            catch (CuentaExistenteExeption)
            {
                ErrorNombre.Visible = true;
            }
            catch (ContraseñaDistintaExeption ex)
            {
                LblErrorContraseña.Text = ex.Message;
                LblErrorContraseña.Visible = true;
            }
            catch (CaptchaNoCompletadoExeption ex)
            {
                LblErrorCaptcha.Text = ex.Message;
                LblErrorCaptcha.Visible = true;
                CbCaptcha.Checked = false;
            }
            catch (comboBoxInexistenteExeption ex)
            {
                ErrorImpresora.Text = ex.Message;
                ErrorImpresora.Visible = true;
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnGenerarCodigo_Click(object sender, EventArgs e)
        {
            this.captcha = this.CrearCaptcha();
            LblCaptcha.Text = this.captcha;
            txtRespuestaCaptcha.Text = string.Empty;
        }

        public bool Verificar()
        {
            bool retorno = false;
            List<Usuario> datos = Deserializar();
            foreach (Usuario dato in datos)
            {
                if (this.nombre == dato.nombre)
                {
                    throw new CuentaExistenteExeption(nombre);
                }
                else if (this.contraseña != this.repetida)
                {
                    throw new ContraseñaDistintaExeption();
                }
                else if (CbCaptcha.Checked == false)
                {
                    LblErrorCaptcha.Visible = true;
                }
                else if (this.contraseña == string.Empty)                
                {
                    throw new CampoVacioexeption("contraseña");
                }
                else if(CbImpresora.Text == string.Empty)
                {
                    throw new CampoVacioexeption("impresora");
                }
                else if(this.nombre == string.Empty)
                {
                    throw new CampoVacioexeption("nombre");
                }
                else if (VerificarImpresora(CbImpresora.Text) == false)
                {
                    throw new comboBoxInexistenteExeption("impresora");
                }
                else if (CbCaptcha.Checked)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public bool VerificarCaptcha()
        {
            bool retorno = false;
            string ingreso = txtRespuestaCaptcha.Text;
            ingreso = string.Join(" ", ingreso.ToCharArray());
            if (ingreso == string.Empty)
            {
                throw new CaptchaNoCompletadoExeption();
            }
            else if (ingreso != this.captcha)
            {
                throw new CaptchaNoCompletadoExeption();
            }
            else if (ingreso == this.captcha)
            {
                retorno = true;
            }
            return retorno;
        }
        private bool VerificarImpresora(string impresora)
        {
            bool retorno = false;
            foreach(string i in CbImpresora.Items)
            {
                if(i == impresora)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public int CalcularWatts(string impresora)
        {
            int watts = 0;
            switch (impresora)
            {
                case "Artillery hornet":
                    watts = 350; 
                    break;
                case "Artillery Sidewinder X2":
                    watts = 600;
                    break;
                case "Artillery Genius PRO":
                    watts = 600;
                    break;
                case "Creality CR-10 Smart":
                    watts = 360;
                    break;
                case "Creality Ender 3 S1":
                    watts = 350;
                    break;
                case "Creality Ender 3 V2":
                    watts = 350;
                    break;
                case "Hellbot Magna SE":
                    watts = 150;
                    break;
            }
            return watts;
        }
        public List<Usuario> Deserializar()
        {
            List<Usuario> usuarios = null;
            string jsonText = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\usuarios.json");

            usuarios = JsonConvert.DeserializeObject<List<Usuario>>(jsonText);
            return usuarios;
        }

        private void FrmRegistrate_Load(object sender, EventArgs e)
        {
            this.captcha = this.CrearCaptcha();
            LblCaptcha.Text = this.captcha;
        }
        private string CrearCaptcha()
        {
            string abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            List<string> codigo = new List<string>();
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                int numero = random.Next(abecedario.Length);
                codigo.Add(abecedario[numero].ToString());
            }
            return string.Join(" ", codigo);
        }
    }
}
