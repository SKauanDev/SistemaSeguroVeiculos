namespace SistemaSeguroVeiculos
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnVisualizarClientes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlConteudo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnVisualizarClientes = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Purple;
            this.lblTitulo.Location = new System.Drawing.Point(110, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Seguro de Veículos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnCadastrarCliente
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.Purple;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(30, 100);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(200, 50);
            this.btnCadastrarCliente.TabIndex = 1;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);

            // btnVisualizarClientes
            this.btnVisualizarClientes.BackColor = System.Drawing.Color.White;
            this.btnVisualizarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizarClientes.ForeColor = System.Drawing.Color.Purple;
            this.btnVisualizarClientes.Location = new System.Drawing.Point(30, 180);
            this.btnVisualizarClientes.Name = "btnVisualizarClientes";
            this.btnVisualizarClientes.Size = new System.Drawing.Size(200, 50);
            this.btnVisualizarClientes.TabIndex = 2;
            this.btnVisualizarClientes.Text = "Visualizar Clientes";
            this.btnVisualizarClientes.UseVisualStyleBackColor = false;
            this.btnVisualizarClientes.Click += new System.EventHandler(this.btnVisualizarClientes_Click);

            // btnSair
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.Purple;
            this.btnSair.Location = new System.Drawing.Point(30, 260);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 50);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);

            // pnlConteudo
            this.pnlConteudo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlConteudo.Location = new System.Drawing.Point(250, 80);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(500, 300);
            this.pnlConteudo.TabIndex = 4;

            // MenuForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnVisualizarClientes);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
