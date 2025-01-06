using System;
using System.Windows.Forms;

namespace SistemaSeguroVeiculos
{
    public partial class CadastroClienteForm : Form
    {

        private readonly List<Cliente> _clientes;
        public CadastroClienteForm(List<Cliente> clientes)
        {
            InitializeComponent();
            _clientes = clientes;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string cpf = txtCPF.Text;
                string modeloCarro = txtModeloCarro.Text;
                int anoCarro = int.Parse(txtAnoCarro.Text);
                decimal valorCarro = decimal.Parse(txtValorCarro.Text);
                string placaCarro = txtPlacaCarro.Text;
                string planoSelecionado = cmbPlanoSeguro.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var cliente = new Cliente(nome, cpf);
                var carro = new Carro(modeloCarro, anoCarro, valorCarro, placaCarro);
                var plano = new PlanoSeguro(planoSelecionado);

                cliente.AtribuirCarro(carro);
                cliente.AtribuirPlano(plano);

                _clientes.Add(cliente); // Adiciona o cliente à lista compartilhada

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroClienteForm_Load(object sender, EventArgs e)
        {
            cmbPlanoSeguro.Items.Clear();
            cmbPlanoSeguro.Items.Add("Básico");
            cmbPlanoSeguro.Items.Add("Intermediário");
            cmbPlanoSeguro.Items.Add("Completo");
            cmbPlanoSeguro.SelectedIndex = 0; // Define o item inicial como "Básico"
        }
    }
}
