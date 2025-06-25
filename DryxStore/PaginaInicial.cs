using System;
using System.Windows.Forms;

namespace DryxStore
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormCadastroProduto formCadastroProduto = new FormCadastroProduto();

			formCadastroProduto.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormConsultarProduto formConsultarProduto = new FormConsultarProduto();

			formConsultarProduto.Show();
		}
	}
}
