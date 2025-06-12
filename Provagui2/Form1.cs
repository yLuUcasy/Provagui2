using System.Diagnostics.Eventing.Reader;

namespace Provagui2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            string User = "admin";
            string senha = "123";

            string usuarioDigitado = txtuser.Text;
            string senhaDigitada   = txtsenha.Text;

            if (usuarioDigitado == User && senhaDigitada == "123") ;
            {
                MessageBox.Show("acesso liberado");

                telaprincipalcs telaprincipalcs = new telaprincipalcs();
                telaprincipalcs.Show();
                this.Hide();
            }
        }
    }
}
