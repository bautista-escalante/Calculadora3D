using Exepciones;
using Objetos;

namespace Forms
{
    public partial class FrmPrincipal : Form
    {
        private GuardarDato json;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.json = new GuardarDato();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            // sumar y mostrar
            double? electricidad = this.ObtenerPrecioElectricidad();
            double filamento = this.ObtenerPrecioFilamento(TxtFilamento.Text);
            TxtResultado.Text = (electricidad + filamento).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
  
        private double? ObtenerPrecioElectricidad()
        {
            if (float.TryParse(TxtTiempo.Text, out float tiempo))
            {
                double kw = 67.883;
                return kw * tiempo;
            }
            else
            {
                throw new DatoIncorrectoExeption("tiempo","numerico");
            }
        }
        private double ObtenerPrecioFilamento(string gramos)
        {
            double retorno = 0;
            if (int.TryParse(gramos, out int gramosConsumidos))
            {
                if (this.VerificarFilamento(CbTipoFilamento.Text))
                {
                    List<Filamento> filamento = json.Deserializar();
                    foreach(Filamento i in filamento)
                    {
                        if(i.tipo == CbTipoFilamento.Text)
                        {
                            // calcular el precio por gramo
                            double gramo = i.precio / 1000;
                            // obtener el precio por los gramos consumidos
                            retorno = gramo * gramosConsumidos;
                        }
                    }
                }
                else
                {
                    LblErrorTipo.Visible = true;
                    throw new comboBoxInexistenteExeption("Filamento");
                }
            }
            return retorno;
        }
        private bool VerificarFilamento(string filamento)
        {
            bool retorno = false;
            foreach (string i in CbTipoFilamento.Items)
            {
                if (i == filamento)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
    }
}
