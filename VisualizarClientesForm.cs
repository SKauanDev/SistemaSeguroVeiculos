using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaSeguroVeiculos
{
    public partial class VisualizarClientesForm : Form
    {
        private readonly List<Cliente> _clientes;


        public VisualizarClientesForm(List<Cliente> clientes)
        {
            InitializeComponent();
            _clientes = clientes;
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgvClientes.Rows.Clear();

            foreach (var cliente in _clientes)
            {
                dgvClientes.Rows.Add(
                    cliente.Nome,
                    cliente.CPF,
                    cliente.Carro?.Modelo ?? "Não atribuído",
                    cliente.Carro?.Placa ?? "Não atribuído",
                    cliente.PlanoSeguro?.TipoPlano ?? "Não atribuído",
                    cliente.PlanoSeguro?.ValorMensal.ToString("C") ?? "R$ 0,00"
                );
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisualizarClientesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
