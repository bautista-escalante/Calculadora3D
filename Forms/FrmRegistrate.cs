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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
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
                    int consumo;
                    if (int.TryParse(TxtConsumo.Text, out consumo))
                    {
                        Usuario nuevo = new Usuario(consumo,this.nombre,this.contraseña);
                        string json = JsonConvert.SerializeObject(nuevo);
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\usuarios.json", json);
                        // form principal
                        Application.Exit();
                        FrmLogin frm = new FrmLogin();
                        frm.ShowDialog();
                    }
                    else
                    {
                        throw new FormatException();
                    }
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
                    case "consumo electrico":
                        ErrorConsumo.Text = ex.Message;
                        ErrorConsumo.Visible = true;
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
            catch (FormatException)
            {
                ErrorConsumo.Visible = true;
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
                else if(TxtConsumo.Text == string.Empty)
                {
                    throw new CampoVacioexeption("consumo electrico");
                }
                else if(this.nombre == string.Empty)
                {
                    throw new CampoVacioexeption("nombre");
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
