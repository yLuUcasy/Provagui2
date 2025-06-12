using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Provagui2
{
    internal class Cliente
    {
        public string txtnome { get; set; }
        public string txtcpf { get; set; }

        public string txtemail { get; set; }

        public string txtcep { get; set; }

        public string txtlogradouro { get; set; }

        public string txtnumero { get; set; }

        public string txtbairro { get; set; }

        public string txtcidade { get; set; }

        public string txtestado { get; set; }

        public string txttelefone { get; set; }

        public string txtwhatsapp { get; set; }

        public override string ToString()
        {
            return $"{Nome},{CPF},{Email},{CEP},{Logradouro},{Numero},{Bairro},{Cidade},{Estado},{Telefone},{WhatsApp}";

        }
    }
