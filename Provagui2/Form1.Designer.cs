namespace Provagui2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtuser = new TextBox();
            label2 = new Label();
            txtsenha = new TextBox();
            btnconfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 45);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(91, 89);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(100, 23);
            txtuser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 147);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(91, 189);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(100, 23);
            txtsenha.TabIndex = 3;
            // 
            // btnconfirmar
            // 
            btnconfirmar.Location = new Point(91, 247);
            btnconfirmar.Name = "btnconfirmar";
            btnconfirmar.Size = new Size(75, 23);
            btnconfirmar.TabIndex = 4;
            btnconfirmar.Text = "confirmar";
            btnconfirmar.UseVisualStyleBackColor = true;
            btnconfirmar.Click += btnconfirmar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnconfirmar);
            Controls.Add(txtsenha);
            Controls.Add(label2);
            Controls.Add(txtuser);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtuser;
        private Label label2;
        private TextBox txtsenha;
        private Button btnconfirmar;
    }
}
