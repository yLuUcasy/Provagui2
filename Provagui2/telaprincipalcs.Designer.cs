namespace Provagui2
{
    partial class telaprincipalcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClientes = new Button();
            btnprodutos = new Button();
            btnpedidos = new Button();
            btnusuarios = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(321, 75);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(75, 23);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnprodutos
            // 
            btnprodutos.Location = new Point(321, 121);
            btnprodutos.Name = "btnprodutos";
            btnprodutos.Size = new Size(75, 23);
            btnprodutos.TabIndex = 1;
            btnprodutos.Text = "produtos";
            btnprodutos.UseVisualStyleBackColor = true;
            // 
            // btnpedidos
            // 
            btnpedidos.Location = new Point(321, 173);
            btnpedidos.Name = "btnpedidos";
            btnpedidos.Size = new Size(75, 23);
            btnpedidos.TabIndex = 2;
            btnpedidos.Text = "pedidos";
            btnpedidos.UseVisualStyleBackColor = true;
            // 
            // btnusuarios
            // 
            btnusuarios.Location = new Point(321, 223);
            btnusuarios.Name = "btnusuarios";
            btnusuarios.Size = new Size(75, 23);
            btnusuarios.TabIndex = 3;
            btnusuarios.Text = "usuarios";
            btnusuarios.UseVisualStyleBackColor = true;
            // 
            // telaprincipalcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnusuarios);
            Controls.Add(btnpedidos);
            Controls.Add(btnprodutos);
            Controls.Add(btnClientes);
            Name = "telaprincipalcs";
            Text = "telaprincipalcs";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnprodutos;
        private Button btnpedidos;
        private Button btnusuarios;
    }
}