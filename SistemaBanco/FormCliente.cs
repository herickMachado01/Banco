using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBanco
{
    public partial class FormCliente : Form
    {
        FormContainer container;

        public FormCliente(FormContainer f)
        {
            this.container = f;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();            
            cliente.cpf = txtCPF.Text;
            cliente.nome = txtNome.Text;
            cliente.telefone = txtTel.Text;

            bool result = FormContainer.agencia.addCliente(cliente);
            if (result)
            {
                MessageBox.Show("Cliente cadastrado com sucesso!", "Info");
                txtCPF.Clear();
                txtNome.Clear();
                txtTel.Clear();
                txtCPF.Focus();
                caregarDados();
            }
            else 
            {
                MessageBox.Show(FormContainer.agencia.erro, "Info");
            }


        }

        private void caregarDados()
        {
            dtvCliente.Rows.Clear();
            foreach (Cliente c in FormContainer.agencia.exibirClientes())
            {
                dtvCliente.Rows.Add(c.cpf, c.nome, c.telefone, "📝", "❌");
            }
        }

        private void dtvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cpf = dtvCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            string nome = dtvCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            string telefone = dtvCliente.Rows[e.RowIndex].Cells[2].Value.ToString();

            int funcao = e.ColumnIndex;
            if (funcao == 3) 
            {
                FormAlterar A = new FormAlterar(cpf , nome , telefone);
                A.MdiParent = container;
                A.Show();

                
                
            }
            if (funcao == 4) 
            {
                if (FormContainer.agencia.removerCliente(cpf))
                {
                    caregarDados();
                }
                else 
                {
                    MessageBox.Show(FormContainer.agencia.erro, "Erro de exclusão");
                }
            }
           


        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
