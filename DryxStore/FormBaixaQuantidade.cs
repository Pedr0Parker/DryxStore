using System;
using System.Windows.Forms;

namespace DryxStore
{
	public partial class FormBaixaQuantidade : Form
	{
		public string ProdutoCodigo { get; set; }
		public string ProdutoDescricao { get; set; }
		public int QuantidadeAtual { get; set; }
		public int QuantidadeBaixa { get; private set; }

		public FormBaixaQuantidade(string codigo, string descricao, int quantidadeAtual)
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			ProdutoCodigo = codigo;
			ProdutoDescricao = descricao;
			QuantidadeAtual = quantidadeAtual;

			labelDescricao.Text = "Descrição do produto: " + descricao;
			labelQuantidadeAtual.Text = "Quantidade atual: " + quantidadeAtual.ToString();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (int.TryParse(textBoxQuantidade.Text, out int quantidade))
			{
				QuantidadeBaixa = quantidade;
				this.DialogResult = DialogResult.OK;

				MessageBox.Show($"Baixa realizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonCancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
