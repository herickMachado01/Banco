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

    public partial class FormAlterar : Form
    {
      

        public FormAlterar(string cpf, string nome, string telefone)
        {
            InitializeComponent();
            txtCPF.Text = cpf;
            txtNome.Text = nome;
            txtTel.Text = telefone;
           
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormAlterar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string novoCPF = txtCPF.Text;
            string novoNome = txtNome.Text;
            string novoTelefone = txtTel.Text;

            
        }
    }
}
