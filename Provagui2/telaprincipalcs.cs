using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provagui2
{
    public partial class telaprincipalcs : Form
    {
        public telaprincipalcs()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            telaprincipalcs clientes = new telaprincipalcs();
            clientes.Show();
            this.Hide();

        }
    }
}
