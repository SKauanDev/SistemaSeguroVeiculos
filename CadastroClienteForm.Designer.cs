namespace SistemaSeguroVeiculos
{
    partial class CadastroClienteForm
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
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtModeloCarro = new TextBox();
            txtAnoCarro = new TextBox();
            txtValorCarro = new TextBox();
            txtPlacaCarro = new TextBox();
            cmbPlanoSeguro = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            lblNome = new Label();
            lblCPF = new Label();
            lblModeloCarro = new Label();
            lblAnoCarro = new Label();
            lblValorCarro = new Label();
            lblPlacaCarro = new Label();
            lblPlanoSeguro = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(120, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 31);
            txtNome.TabIndex = 0;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(120, 60);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(200, 31);
            txtCPF.TabIndex = 1;
            // 
            // txtModeloCarro
            // 
            txtModeloCarro.Location = new Point(120, 100);
            txtModeloCarro.Name = "txtModeloCarro";
            txtModeloCarro.Size = new Size(200, 31);
            txtModeloCarro.TabIndex = 2;
            // 
            // txtAnoCarro
            // 
            txtAnoCarro.Location = new Point(120, 140);
            txtAnoCarro.Name = "txtAnoCarro";
            txtAnoCarro.Size = new Size(200, 31);
            txtAnoCarro.TabIndex = 3;
            // 
            // txtValorCarro
            // 
            txtValorCarro.Location = new Point(120, 180);
            txtValorCarro.Name = "txtValorCarro";
            txtValorCarro.Size = new Size(200, 31);
            txtValorCarro.TabIndex = 4;
            // 
            // txtPlacaCarro
            // 
            txtPlacaCarro.Location = new Point(120, 220);
            txtPlacaCarro.Name = "txtPlacaCarro";
            txtPlacaCarro.Size = new Size(200, 31);
            txtPlacaCarro.TabIndex = 5;
            // 
            // cmbPlanoSeguro
            // 
            cmbPlanoSeguro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlanoSeguro.FormattingEnabled = true;
            cmbPlanoSeguro.Items.AddRange(new object[] { "Plano Básico", "Plano Intermediário", "Plano Completo" });
            cmbPlanoSeguro.Location = new Point(120, 260);
            cmbPlanoSeguro.Name = "cmbPlanoSeguro";
            cmbPlanoSeguro.Size = new Size(200, 33);
            cmbPlanoSeguro.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(120, 310);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 30);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(230, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 30);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNome
            // 
            lblNome.Location = new Point(20, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            lblCPF.Location = new Point(20, 60);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(100, 23);
            lblCPF.TabIndex = 10;
            lblCPF.Text = "CPF:";
            // 
            // lblModeloCarro
            // 
            lblModeloCarro.Location = new Point(20, 100);
            lblModeloCarro.Name = "lblModeloCarro";
            lblModeloCarro.Size = new Size(100, 23);
            lblModeloCarro.TabIndex = 11;
            lblModeloCarro.Text = "Modelo Carro:";
            // 
            // lblAnoCarro
            // 
            lblAnoCarro.Location = new Point(20, 140);
            lblAnoCarro.Name = "lblAnoCarro";
            lblAnoCarro.Size = new Size(100, 23);
            lblAnoCarro.TabIndex = 12;
            lblAnoCarro.Text = "Ano Carro:";
            // 
            // lblValorCarro
            // 
            lblValorCarro.Location = new Point(20, 180);
            lblValorCarro.Name = "lblValorCarro";
            lblValorCarro.Size = new Size(100, 23);
            lblValorCarro.TabIndex = 13;
            lblValorCarro.Text = "Valor Carro:";
            // 
            // lblPlacaCarro
            // 
            lblPlacaCarro.Location = new Point(20, 220);
            lblPlacaCarro.Name = "lblPlacaCarro";
            lblPlacaCarro.Size = new Size(100, 23);
            lblPlacaCarro.TabIndex = 14;
            lblPlacaCarro.Text = "Placa Carro:";
            // 
            // lblPlanoSeguro
            // 
            lblPlanoSeguro.Location = new Point(20, 260);
            lblPlanoSeguro.Name = "lblPlanoSeguro";
            lblPlanoSeguro.Size = new Size(100, 23);
            lblPlanoSeguro.TabIndex = 15;
            lblPlanoSeguro.Text = "Plano Seguro:";
            // 
            // CadastroClienteForm
            // 
            ClientSize = new Size(350, 360);
            Controls.Add(txtNome);
            Controls.Add(txtCPF);
            Controls.Add(txtModeloCarro);
            Controls.Add(txtAnoCarro);
            Controls.Add(txtValorCarro);
            Controls.Add(txtPlacaCarro);
            Controls.Add(cmbPlanoSeguro);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(lblNome);
            Controls.Add(lblCPF);
            Controls.Add(lblModeloCarro);
            Controls.Add(lblAnoCarro);
            Controls.Add(lblValorCarro);
            Controls.Add(lblPlacaCarro);
            Controls.Add(lblPlanoSeguro);
            Name = "CadastroClienteForm";
            Text = "Cadastro de Cliente";
            Load += CadastroClienteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtModeloCarro;
        private System.Windows.Forms.TextBox txtAnoCarro;
        private System.Windows.Forms.TextBox txtValorCarro;
        private System.Windows.Forms.TextBox txtPlacaCarro;
        private System.Windows.Forms.ComboBox cmbPlanoSeguro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblModeloCarro;
        private System.Windows.Forms.Label lblAnoCarro;
        private System.Windows.Forms.Label lblValorCarro;
        private System.Windows.Forms.Label lblPlacaCarro;
        private System.Windows.Forms.Label lblPlanoSeguro;
    }
}
