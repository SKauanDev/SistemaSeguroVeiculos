using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaSeguroVeiculos
{
    public partial class MenuForm : Form
    {
        private readonly List<Cliente> _clientes; // Lista compartilhada de clientes

        public MenuForm()
        {
            InitializeComponent();
            _clientes = new List<Cliente>(); // Inicializa a lista de clientes
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            // Substitui o conteúdo do Panel com o formulário de cadastro
            CarregarFormulario(new CadastroClienteForm(_clientes));
        }

        private void btnVisualizarClientes_Click(object sender, EventArgs e)
        {
            // Substitui o conteúdo do Panel com o formulário de visualização
            CarregarFormulario(new VisualizarClientesForm(_clientes));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha o programa
            Application.Exit();
        }

        private void CarregarFormulario(Form form)
        {
            // Limpa qualquer conteúdo anterior no Panel
            pnlConteudo.Controls.Clear();

            // Configura o novo formulário para exibição no Panel
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(form);
            form.Show();
        }
    }
}
