using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DryxStore
{
	public partial class FormCadastroProduto : Form
	{
		private string connectionString = "Server=127.0.0.1;Database=dryxstore;Uid=root;";

		public FormCadastroProduto()
		{
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
		}

		private void textBoxValorCompra_TextChanged(object sender, EventArgs e)
		{
			CalcularValorVenda();
		}

		private void textBoxPercentual_TextChanged(object sender, EventArgs e)
		{
			CalcularValorVenda();
		}

		private void CalcularValorVenda()
		{
			if (decimal.TryParse(textBoxValorCompra.Text, out decimal valorCompra) &&
				decimal.TryParse(textBoxPercentual.Text, out decimal percentual))
			{
				decimal valorVenda = valorCompra + (valorCompra * (percentual / 100));
				textBoxValorVenda.Text = valorVenda.ToString("F2");
			}
			else
			{
				textBoxValorVenda.Clear();
			}
		}

		private void buttonSalvar_Click(object sender, EventArgs e)
		{
			string codigoProduto = textBoxCodigo.Text;
			string descricaoProduto = textBoxDescricao.Text;
			string quantidadeProduto = textBoxQuantidade.Text;
			string valorCompraProduto = textBoxValorCompra.Text;
			string percentualProduto = textBoxPercentual.Text;
			string valorVendaProduto = textBoxValorVenda.Text;
			string corProduto = textBoxCor.Text;
			string tamanhoProduto = textBoxTamanho.Text;
			DateTime dataCadastro = DateTime.Now;

			if (string.IsNullOrWhiteSpace(codigoProduto) ||
				string.IsNullOrWhiteSpace(descricaoProduto) ||
				string.IsNullOrWhiteSpace(quantidadeProduto) ||
				string.IsNullOrWhiteSpace(valorCompraProduto) ||
				string.IsNullOrWhiteSpace(percentualProduto) ||
				string.IsNullOrWhiteSpace(valorVendaProduto))
			{
				MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (checkBoxRoupa.Checked)
			{
				if (string.IsNullOrWhiteSpace(corProduto))
				{
					MessageBox.Show("Por favor, informe a cor do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (string.IsNullOrWhiteSpace(tamanhoProduto))
				{
					MessageBox.Show("Por favor, informe o tamanho do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			if (!decimal.TryParse(valorCompraProduto, out decimal valorCompra))
			{
				MessageBox.Show("O valor de compra deve ser numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!decimal.TryParse(percentualProduto, out decimal percentual))
			{
				MessageBox.Show("O percentual deve ser numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!int.TryParse(quantidadeProduto, out int quantidade))
			{
				MessageBox.Show("A quantidade deve ser um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connectionString))
				{
					connection.Open();

					string query = @"
                        INSERT INTO produtos 
                        (codigo, descricao, quantidade, valor_compra, percentual, valor_venda, cor, tamanho, eh_roupa, data_cadastro)
                        VALUES 
                        (@codigo, @descricao, @quantidade, @valor_compra, @percentual, @valor_venda, @cor, @tamanho, @eh_roupa, @data_cadastro)"
					;

					using (MySqlCommand command = new MySqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@codigo", codigoProduto);
						command.Parameters.AddWithValue("@descricao", descricaoProduto);
						command.Parameters.AddWithValue("@quantidade", quantidade);
						command.Parameters.AddWithValue("@valor_compra", valorCompra);
						command.Parameters.AddWithValue("@percentual", percentual);
						command.Parameters.AddWithValue("@valor_venda", valorVendaProduto);
						command.Parameters.AddWithValue("@cor", corProduto);
						command.Parameters.AddWithValue("@tamanho", tamanhoProduto);
						command.Parameters.AddWithValue("@eh_roupa", checkBoxRoupa.Checked);
						command.Parameters.AddWithValue("@data_cadastro", dataCadastro);

						command.ExecuteNonQuery();
					}
				}

				MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro ao salvar no banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
