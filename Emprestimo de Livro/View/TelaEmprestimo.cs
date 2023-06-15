using Emprestimo_de_Livro.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprestimo_de_Livro.View
{
    public partial class TelaEmprestimo : Form
    {
        Livro livro = new Livro();
        public TelaEmprestimo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtLivro.Text == string.Empty || cbDesc.Text == string.Empty || txtValor.Text == string.Empty || txtCpf.Text == string.Empty || txtNome.Text == string.Empty || txtAnoLivro.Text == string.Empty) 
            {
                MessageBox.Show("Preencha todos os Campos","Atenção");
            }
            else
            {
                lblResultado.Text = "Nome do Cliente: " + txtNome.Text +
                "\nPreço do Livro: R$" + livro.CalcularDesc(cbDesc.Text, Convert.ToDecimal(txtValor.Text)) +
                "\nCPF do Cliente: " + txtCpf.Text +
                "\nNome do Livro: " + txtLivro.Text +
                "\nPreço sem Desconto: R$" + txtValor.Text;
            }
            
        }
    }
}
