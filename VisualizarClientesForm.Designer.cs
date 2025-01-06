namespace SistemaSeguroVeiculos
{
    partial class VisualizarClientesForm
    {
        private System.ComponentModel.IContainer components = null;

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
            dgvClientes = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colCPF = new DataGridViewTextBoxColumn();
            colModeloCarro = new DataGridViewTextBoxColumn();
            colPlaca = new DataGridViewTextBoxColumn();
            colPlanoSeguro = new DataGridViewTextBoxColumn();
            colValorPlano = new DataGridViewTextBoxColumn();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colNome, colCPF, colModeloCarro, colPlaca, colPlanoSeguro, colValorPlano });
            dgvClientes.Location = new Point(12, 12);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 24;
            dgvClientes.Size = new Size(760, 350);
            dgvClientes.TabIndex = 0;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            colNome.Width = 125;
            // 
            // colCPF
            // 
            colCPF.HeaderText = "CPF";
            colCPF.MinimumWidth = 6;
            colCPF.Name = "colCPF";
            colCPF.ReadOnly = true;
            colCPF.Width = 125;
            // 
            // colModeloCarro
            // 
            colModeloCarro.HeaderText = "Modelo do Carro";
            colModeloCarro.MinimumWidth = 6;
            colModeloCarro.Name = "colModeloCarro";
            colModeloCarro.ReadOnly = true;
            colModeloCarro.Width = 150;
            // 
            // colPlaca
            // 
            colPlaca.HeaderText = "Placa";
            colPlaca.MinimumWidth = 6;
            colPlaca.Name = "colPlaca";
            colPlaca.ReadOnly = true;
            colPlaca.Width = 125;
            // 
            // colPlanoSeguro
            // 
            colPlanoSeguro.HeaderText = "Plano Seguro";
            colPlanoSeguro.MinimumWidth = 6;
            colPlanoSeguro.Name = "colPlanoSeguro";
            colPlanoSeguro.ReadOnly = true;
            colPlanoSeguro.Width = 150;
            // 
            // colValorPlano
            // 
            colValorPlano.HeaderText = "Valor Mensal";
            colValorPlano.MinimumWidth = 6;
            colValorPlano.Name = "colValorPlano";
            colValorPlano.ReadOnly = true;
            colValorPlano.Width = 125;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(680, 380);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(90, 30);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.Click += btnFechar_Click;
            // 
            // VisualizarClientesForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClientes);
            Controls.Add(btnFechar);
            Name = "VisualizarClientesForm";
            Text = "Visualizar Clientes";
            Load += VisualizarClientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModeloCarro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanoSeguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorPlano;
        private System.Windows.Forms.Button btnFechar;
    }
}
