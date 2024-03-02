using Exepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmCaptcha : Form
    {
        private string captcha;
        public FrmCaptcha()
        {
            this.captcha = string.Empty;
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.verificar())
                {

                    //check
                }
            }
            catch(CaptchaNoCompletadoExeption ex)
            {
                lblErrorCapcha.Text = ex.Message;
                lblErrorCapcha.Visible = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        public bool verificar()
        {
            bool retorno = false;
            string ingreso = TxtCaptcha.Text;
            if (TxtCaptcha.Text ==string.Empty)
            {
                throw new CaptchaNoCompletadoExeption();
            }
            else if(TxtCaptcha.Text != this.captcha)
            {
                throw new CaptchaNoCompletadoExeption();
            }
            else if(ingreso == this.captcha)
            {
                retorno = true;
            }
            return retorno;
        }

        private void FrmCaptcha_Load(object sender, EventArgs e)
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
