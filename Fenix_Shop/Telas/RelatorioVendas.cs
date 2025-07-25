using Fenix_Shop.programação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fenix_Shop.Telas
{
    public partial class RelatorioVendas : UserControl
    {
        ItensVendidos itensVendidos = new ItensVendidos();
        public RelatorioVendas()
        {
            InitializeComponent();

        }
        public void CarregarRelatorio()
        {
            var dt = itensVendidos.TotalPorProduto();

            if (dt != null)
            {
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["VALOR"].DefaultCellStyle.Format = "C2";
                dataGridView1.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

            }
        }
        private void label16PagamentosCredito_Click(object sender, EventArgs e)
        {

        }
        public bool AtualizarRelatorio()
        {
            label9VendasRealizadas.Text = itensVendidos.VendasRealizadas().ToString();
            label11ConvercoesDeVendas.Text = itensVendidos.TotalVendidos().ToString("C2");
            label13ItensVendidos.Text = itensVendidos.QtVendidas().ToString();
            label12MediaDeVendas.Text = itensVendidos.TotalCustoProdutos().ToString("C2");
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RelatorioVendas_Load(object sender, EventArgs e)
        {
            AtualizarRelatorio();
            dataGridView1.DataSource = null;
            CarregarRelatorio();
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Columns["Foto"].Width = 40;
            if (dataGridView1.Columns["Foto"] is DataGridViewImageColumn imageColumn)
            {
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            DateTime inicioMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePickerInicio.Text = inicioMes.ToString("dd/MM/yyyy");
        }

        
    }
}
