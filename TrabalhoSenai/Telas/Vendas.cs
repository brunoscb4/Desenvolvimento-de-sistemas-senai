using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoSenai.Programas;

namespace TrabalhoSenai.Telas
{
    public partial class Vendas : UserControl
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textCepVenda.Text != "")
                {
                    Endereco endereco = BuscarCep.BuscarCEP(textCepVenda.Text);

                    textLogradouroVenda.Text = endereco.Logradouro;
                    textLocalidadeVenda.Text = endereco.Localidade;
                    textBairroVenda.Text = endereco.Bairro;
                    textUfVenda.Text = endereco.Uf;
                }
                else
                {
                    MessageBox.Show("Prencha os campos corretamente ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("erro ao buscar cep " + ex.Message);
            }
        }

      

        private void textCepVenda_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            textCepVenda.Select(0, 0);
        }
    }
}
