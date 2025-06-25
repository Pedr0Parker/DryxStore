namespace DryxStore
{
	partial class FormConsultarProduto
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
			this.textBoxPesquisa = new System.Windows.Forms.TextBox();
			this.buttonPesquisar = new System.Windows.Forms.Button();
			this.buttonLimparPesquisa = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxPesquisa
			// 
			this.textBoxPesquisa.Location = new System.Drawing.Point(12, 12); // Posição acima da tabela
			this.textBoxPesquisa.Name = "textBoxPesquisa";
			this.textBoxPesquisa.Size = new System.Drawing.Size(300, 22);
			this.textBoxPesquisa.TabIndex = 0;
			this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
			// 
			// buttonPesquisar
			// 
			this.buttonPesquisar.Location = new System.Drawing.Point(318, 12); // Ao lado do TextBox
			this.buttonPesquisar.Name = "buttonPesquisar";
			this.buttonPesquisar.Size = new System.Drawing.Size(100, 23);
			this.buttonPesquisar.TabIndex = 1;
			this.buttonPesquisar.Text = "Pesquisar";
			this.buttonPesquisar.UseVisualStyleBackColor = true;
			this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
			// 
			// buttonLimparPesquisa
			// 
			this.buttonLimparPesquisa.Location = new System.Drawing.Point(424, 12); // Ao lado do botão de pesquisa
			this.buttonLimparPesquisa.Name = "buttonLimparPesquisa";
			this.buttonLimparPesquisa.Size = new System.Drawing.Size(100, 23);
			this.buttonLimparPesquisa.TabIndex = 2;
			this.buttonLimparPesquisa.Text = "Limpar";
			this.buttonLimparPesquisa.UseVisualStyleBackColor = true;
			this.buttonLimparPesquisa.Click += new System.EventHandler(this.buttonLimparPesquisa_Click);
			// 
			// dataGridViewProdutos
			// 
			this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProdutos.Location = new System.Drawing.Point(12, 50); // Tabela abaixo do campo de pesquisa
			this.dataGridViewProdutos.Name = "dataGridViewProdutos";
			this.dataGridViewProdutos.RowTemplate.Height = 24;
			this.dataGridViewProdutos.Size = new System.Drawing.Size(1242, 400);
			this.dataGridViewProdutos.TabIndex = 3;
			// 
			// FormConsultarProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1266, 450);
			this.Controls.Add(this.dataGridViewProdutos);
			this.Controls.Add(this.buttonLimparPesquisa);
			this.Controls.Add(this.buttonPesquisar);
			this.Controls.Add(this.textBoxPesquisa);
			this.Name = "FormConsultarProduto";
			this.Text = "Consultar Produtos";
			this.Load += new System.EventHandler(this.FormConsultarProduto_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewProdutos;
		private System.Windows.Forms.TextBox textBoxPesquisa;
		private System.Windows.Forms.Button buttonPesquisar;
		private System.Windows.Forms.Button buttonLimparPesquisa;
	}
}
