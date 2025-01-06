namespace SistemaSeguroVeiculos
{
    public class SeguroManager
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return clientes;
        }

        public Cliente BuscarClientePorCPF(string cpf)
        {
            return clientes.FirstOrDefault(c => c.CPF == cpf);
        }
    }
}
