using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            if (this.Verificar())
            {
                // mostrar dato en txtResultado

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool Verificar()
        {
            bool retorno = false;
            if (int.TryParse(CbTipoFilamento.Text, out int tipo))
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            if (int.TryParse(TxtFilamento.Text, out int gramosConsumidos))
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            if (int.TryParse(TxtTiempo.Text, out int tiempo))
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
