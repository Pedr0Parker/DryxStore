using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DryxStore
{
	public partial class FormConsultarProduto : Form
	{
		public FormConsultarProduto()
		{
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
		}

		private void FormConsultarProduto_Load(object sender, EventArgs e)
		{
			CarregarProdutos();
			AdicionarBotaoLupa();
		}

		private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
		{
			if (textBoxPesquisa.Text.Length >= 3)
			{
				CarregarSugestoes(textBoxPesquisa.Text);
			}
		}

		private void buttonPesquisar_Click(object sender, EventArgs e)
		{
			string descricaoPesquisa = textBoxPesquisa.Text.Trim();

			if (descricaoPesquisa.Length >= 3)
			{
				CarregarProdutos(descricaoPesquisa);
			}
			else
			{
				MessageBox.Show("Digite pelo menos 3 caracteres para pesquisar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void buttonLimparPesquisa_Click(object sender, EventArgs e)
		{
			textBoxPesquisa.Clear();
			CarregarProdutos();
		}

		private void CarregarProdutos(string descricaoPesquisa = "")
		{
			string conexao = "Server=127.0.0.1;Database=dryxstore;Uid=root;";
			string consulta;

			if (string.IsNullOrEmpty(descricaoPesquisa))
			{
				consulta = "SELECT codigo, descricao, cor, tamanho, quantidade, valor_compra, percentual, valor_venda FROM produtos";
			}
			else
			{
				consulta = "SELECT codigo, descricao, cor, tamanho, quantidade, valor_compra, percentual, valor_venda FROM produtos WHERE descricao LIKE @descricao";
			}

			try
			{
				using (MySqlConnection conn = new MySqlConnection(conexao))
				{
					conn.Open();

					using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
					{
						if (!string.IsNullOrEmpty(descricaoPesquisa))
						{
							cmd.Parameters.AddWithValue("@descricao", "%" + descricaoPesquisa + "%");
						}

						using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
						{
							DataTable dataTable = new DataTable();
							dataAdapter.Fill(dataTable);

							if (dataTable.Rows.Count == 0)
							{
								MessageBox.Show("Nenhum produto encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								dataGridViewProdutos.DataSource = dataTable;
							}
						}
					}
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao carregar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CarregarSugestoes(string pesquisa)
		{
			string conexao = "Server=127.0.0.1;Database=dryxstore;Uid=root;";
			string consulta = "SELECT descricao FROM produtos WHERE descricao LIKE @descricao LIMIT 10";

			try
			{
				using (MySqlConnection conn = new MySqlConnection(conexao))
				{
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
					{
						cmd.Parameters.AddWithValue("@descricao", pesquisa + "%");

						using (MySqlDataReader reader = cmd.ExecuteReader())
						{
							var autoCompleteSource = new AutoCompleteStringCollection();

							while (reader.Read())
							{
								autoCompleteSource.Add(reader["descricao"].ToString());
							}

							textBoxPesquisa.AutoCompleteCustomSource = autoCompleteSource;
							textBoxPesquisa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
							textBoxPesquisa.AutoCompleteSource = AutoCompleteSource.CustomSource;
						}
					}
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao buscar descrições: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AdicionarBotaoLupa()
		{
			DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
			btnColumn.Name = "btnBaixa";
			btnColumn.HeaderText = "Baixa";
			btnColumn.Text = "🔍";
			btnColumn.UseColumnTextForButtonValue = true;

			dataGridViewProdutos.Columns.Add(btnColumn);

			dataGridViewProdutos.CellContentClick += DataGridViewProdutos_CellContentClick;
		}

		private void DataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dataGridViewProdutos.Columns["btnBaixa"].Index)
			{
				DataGridViewRow row = dataGridViewProdutos.Rows[e.RowIndex];
				string produtoCodigo = row.Cells["codigo"].Value.ToString();
				string produtoDescricao = row.Cells["descricao"].Value.ToString();
				int quantidadeAtual = Convert.ToInt32(row.Cells["quantidade"].Value);

				AbrirModalBaixa(produtoCodigo, produtoDescricao, quantidadeAtual);
			}
		}

		private void AbrirModalBaixa(string produtoCodigo, string produtoDescricao, int quantidadeAtual)
		{
			using (FormBaixaQuantidade formBaixa = new FormBaixaQuantidade(produtoCodigo, produtoDescricao, quantidadeAtual))
			{
				if (formBaixa.ShowDialog() == DialogResult.OK)
				{
					int quantidadeBaixa = formBaixa.QuantidadeBaixa;

					if (quantidadeBaixa > 0 && quantidadeBaixa <= quantidadeAtual)
					{
						AtualizarQuantidadeProduto(produtoCodigo, quantidadeAtual - quantidadeBaixa);
						CarregarProdutos();
					}
					else
					{
						MessageBox.Show("Quantidade inválida. Certifique-se de não tentar dar baixa em mais produtos do que os disponíveis.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void AtualizarQuantidadeProduto(string codigoProduto, int novaQuantidade)
		{
			string conexao = "Server=127.0.0.1;Database=dryxstore;Uid=root;";
			string consulta = "UPDATE produtos SET quantidade = @Quantidade WHERE codigo = @Codigo";

			try
			{
				using (MySqlConnection conn = new MySqlConnection(conexao))
				{
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
					{
						cmd.Parameters.AddWithValue("@Quantidade", novaQuantidade);
						cmd.Parameters.AddWithValue("@Codigo", codigoProduto);

						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao atualizar a quantidade do produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
