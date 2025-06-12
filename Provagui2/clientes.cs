using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Http;
using System.Text.Json;

namespace Provagui2
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] dados = {
                txtnome.Text, txtcpf.Text, txtemail.Text,
                txtcep.Text, txtlogradouro.Text, txtnumero.Text,
                txtbairro.Text, txtcidade.Text, txtestado.Text,
                txttelefone.Text, txtwhatsapp.Text
            };
            string linha = string.Join(";", dados);
            File.AppendAllText("clientes.csv", linha + Environment.NewLine);
            MessageBox.Show("Cliente salvo com sucesso!");
        }
        private async Task button1_Click(object sender, EventArgs e)
        {
            string cep = txtcep.txt.Trim().Replace("-", "");
            if (string.IsNullOrEmpty(cep)) return;

            using (HttpClient client = new HttpClient()) ;
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    HttpResponseMessage response = await client.GetAsync(url);
                    string json = await response.Content.ReadAsStringAsync();
                    var endereco = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

                    if (endereco.ContainsKey("erro"))
                    {
                        MessageBox.Show("CEP não encontrado.");
                        return;
                    }
                    txtlogradouro.Text = endereco["logradouro"];
                    txtbairro.Text = endereco["bairro"];
                    txtcidade.Text = endereco["localidade"];
                    txtestado.Text = endereco["uf"];


                
                }
            }
        }
    }
}
