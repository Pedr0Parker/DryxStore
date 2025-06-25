using System.Windows.Forms;
using System;

namespace DryxStore
{
	partial class FormCadastroProduto
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
			this.labelCodigo = new System.Windows.Forms.Label();
			this.textBoxCodigo = new System.Windows.Forms.TextBox();
			this.checkBoxRoupa = new System.Windows.Forms.CheckBox();
			this.labelDescricao = new System.Windows.Forms.Label();
			this.textBoxDescricao = new System.Windows.Forms.TextBox();
			this.labelQuantidade = new System.Windows.Forms.Label();
			this.textBoxQuantidade = new System.Windows.Forms.TextBox();
			this.labelValorCompra = new System.Windows.Forms.Label();
			this.textBoxValorCompra = new System.Windows.Forms.TextBox();
			this.labelPercentual = new System.Windows.Forms.Label();
			this.textBoxPercentual = new System.Windows.Forms.TextBox();
			this.labelValorVenda = new System.Windows.Forms.Label();
			this.textBoxValorVenda = new System.Windows.Forms.TextBox();
			this.buttonSalvar = new System.Windows.Forms.Button();
			this.labelCor = new System.Windows.Forms.Label();
			this.textBoxCor = new System.Windows.Forms.TextBox();
			this.labelTamanho = new System.Windows.Forms.Label();
			this.textBoxTamanho = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelCodigo
			// 
			this.labelCodigo.AutoSize = true;
			this.labelCodigo.Location = new System.Drawing.Point(20, 20);
			this.labelCodigo.Name = "labelCodigo";
			this.labelCodigo.Size = new System.Drawing.Size(53, 16);
			this.labelCodigo.TabIndex = 0;
			this.labelCodigo.Text = "Código:";
			// 
			// textBoxCodigo
			// 
			this.textBoxCodigo.Location = new System.Drawing.Point(150, 20);
			this.textBoxCodigo.Name = "textBoxCodigo";
			this.textBoxCodigo.Size = new System.Drawing.Size(200, 22);
			this.textBoxCodigo.TabIndex = 1;
			// 
			// checkBoxRoupa
			//
			this.checkBoxRoupa.AutoSize = true;
			this.checkBoxRoupa.Location = new System.Drawing.Point(20, 60);
			this.checkBoxRoupa.Name = "checkBoxRoupa";
			this.checkBoxRoupa.Size = new System.Drawing.Size(350, 20);
			this.checkBoxRoupa.TabIndex = 2;
			this.checkBoxRoupa.Text = "O produto cadastrado é uma roupa?";
			this.checkBoxRoupa.UseVisualStyleBackColor = true;
			this.checkBoxRoupa.CheckedChanged += new System.EventHandler(this.checkBoxRoupa_CheckedChanged);
			// 
			// labelDescricao
			// 
			this.labelDescricao.AutoSize = true;
			this.labelDescricao.Location = new System.Drawing.Point(20, 100);
			this.labelDescricao.Name = "labelDescricao";
			this.labelDescricao.Size = new System.Drawing.Size(72, 16);
			this.labelDescricao.TabIndex = 3;
			this.labelDescricao.Text = "Descrição:";
			// 
			// textBoxDescricao
			// 
			this.textBoxDescricao.Location = new System.Drawing.Point(150, 100);
			this.textBoxDescricao.Name = "textBoxDescricao";
			this.textBoxDescricao.Size = new System.Drawing.Size(200, 22);
			this.textBoxDescricao.TabIndex = 4;
			// 
			// labelQuantidade
			// 
			this.labelQuantidade.AutoSize = true;
			this.labelQuantidade.Location = new System.Drawing.Point(20, 140);
			this.labelQuantidade.Name = "labelQuantidade";
			this.labelQuantidade.Size = new System.Drawing.Size(81, 16);
			this.labelQuantidade.TabIndex = 5;
			this.labelQuantidade.Text = "Quantidade:";
			// 
			// textBoxQuantidade
			// 
			this.textBoxQuantidade.Location = new System.Drawing.Point(150, 140);
			this.textBoxQuantidade.Name = "textBoxQuantidade";
			this.textBoxQuantidade.Size = new System.Drawing.Size(200, 22);
			this.textBoxQuantidade.TabIndex = 6;
			// 
			// labelValorCompra
			// 
			this.labelValorCompra.AutoSize = true;
			this.labelValorCompra.Location = new System.Drawing.Point(20, 180);
			this.labelValorCompra.Name = "labelValorCompra";
			this.labelValorCompra.Size = new System.Drawing.Size(96, 16);
			this.labelValorCompra.TabIndex = 7;
			this.labelValorCompra.Text = "Valor Compra:";
			// 
			// textBoxValorCompra
			// 
			this.textBoxValorCompra.Location = new System.Drawing.Point(150, 180);
			this.textBoxValorCompra.Name = "textBoxValorCompra";
			this.textBoxValorCompra.Size = new System.Drawing.Size(200, 22);
			this.textBoxValorCompra.TabIndex = 8;
			// 
			// labelPercentual
			// 
			this.labelPercentual.AutoSize = true;
			this.labelPercentual.Location = new System.Drawing.Point(20, 220);
			this.labelPercentual.Name = "labelPercentual";
			this.labelPercentual.Size = new System.Drawing.Size(77, 16);
			this.labelPercentual.TabIndex = 9;
			this.labelPercentual.Text = "Percentual:";
			// 
			// textBoxPercentual
			// 
			this.textBoxPercentual.Location = new System.Drawing.Point(150, 220);
			this.textBoxPercentual.Name = "textBoxPercentual";
			this.textBoxPercentual.Size = new System.Drawing.Size(200, 22);
			this.textBoxPercentual.TabIndex = 10;
			// 
			// labelValorVenda
			// 
			this.labelValorVenda.AutoSize = true;
			this.labelValorVenda.Location = new System.Drawing.Point(20, 260);
			this.labelValorVenda.Name = "labelValorVenda";
			this.labelValorVenda.Size = new System.Drawing.Size(87, 16);
			this.labelValorVenda.TabIndex = 11;
			this.labelValorVenda.Text = "Valor Venda:";
			// 
			// textBoxValorVenda
			// 
			this.textBoxValorVenda.Location = new System.Drawing.Point(150, 260);
			this.textBoxValorVenda.Name = "textBoxValorVenda";
			this.textBoxValorVenda.Size = new System.Drawing.Size(200, 22);
			this.textBoxValorVenda.TabIndex = 12;
			// 
			// labelCor
			// 
			this.labelCor.AutoSize = true;
			this.labelCor.Location = new System.Drawing.Point(20, 300);
			this.labelCor.Name = "labelCor";
			this.labelCor.Size = new System.Drawing.Size(30, 16);
			this.labelCor.TabIndex = 13;
			this.labelCor.Text = "Cor:";
			this.labelCor.Visible = false;
			// 
			// textBoxCor
			// 
			this.textBoxCor.Location = new System.Drawing.Point(150, 300);
			this.textBoxCor.Name = "textBoxCor";
			this.textBoxCor.Size = new System.Drawing.Size(200, 22);
			this.textBoxCor.TabIndex = 14;
			this.textBoxCor.Visible = false;
			// 
			// labelTamanho
			// 
			this.labelTamanho.AutoSize = true;
			this.labelTamanho.Location = new System.Drawing.Point(20, 340);
			this.labelTamanho.Name = "labelTamanho";
			this.labelTamanho.Size = new System.Drawing.Size(66, 16);
			this.labelTamanho.TabIndex = 15;
			this.labelTamanho.Text = "Tamanho:";
			this.labelTamanho.Visible = false;
			// 
			// textBoxTamanho
			// 
			this.textBoxTamanho.Location = new System.Drawing.Point(150, 340);
			this.textBoxTamanho.Name = "textBoxTamanho";
			this.textBoxTamanho.Size = new System.Drawing.Size(200, 22);
			this.textBoxTamanho.TabIndex = 16;
			this.textBoxTamanho.Visible = false;
			// 
			// buttonSalvar
			// 
			this.buttonSalvar.Location = new System.Drawing.Point(150, 380);
			this.buttonSalvar.Name = "buttonSalvar";
			this.buttonSalvar.Size = new System.Drawing.Size(75, 30);
			this.buttonSalvar.TabIndex = 17;
			this.buttonSalvar.Text = "Salvar";
			this.buttonSalvar.UseVisualStyleBackColor = true;
			this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
			// 
			// FormCadastroProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 420);
			this.Controls.Add(this.buttonSalvar);
			this.Controls.Add(this.textBoxTamanho);
			this.Controls.Add(this.labelTamanho);
			this.Controls.Add(this.textBoxCor);
			this.Controls.Add(this.labelCor);
			this.Controls.Add(this.labelDescricao);
			this.Controls.Add(this.textBoxDescricao);
			this.Controls.Add(this.checkBoxRoupa);
			this.Controls.Add(this.textBoxValorVenda);
			this.Controls.Add(this.labelValorVenda);
			this.Controls.Add(this.textBoxPercentual);
			this.Controls.Add(this.labelPercentual);
			this.Controls.Add(this.textBoxValorCompra);
			this.Controls.Add(this.labelValorCompra);
			this.Controls.Add(this.textBoxQuantidade);
			this.Controls.Add(this.labelQuantidade);
			this.Controls.Add(this.textBoxCodigo);
			this.Controls.Add(this.labelCodigo);
			this.Name = "FormCadastroProduto";
			this.Text = "Cadastro de Produto";
			this.ResumeLayout(false);
			this.PerformLayout();

			this.textBoxValorCompra.TextChanged += new System.EventHandler(this.textBoxValorCompra_TextChanged);
			this.textBoxPercentual.TextChanged += new System.EventHandler(this.textBoxPercentual_TextChanged);
		}

		private System.Windows.Forms.Label labelCodigo;
		private System.Windows.Forms.TextBox textBoxCodigo;
		private System.Windows.Forms.CheckBox checkBoxRoupa;
		private System.Windows.Forms.Label labelDescricao;
		private System.Windows.Forms.TextBox textBoxDescricao;
		private System.Windows.Forms.Label labelQuantidade;
		private System.Windows.Forms.TextBox textBoxQuantidade;
		private System.Windows.Forms.Label labelValorCompra;
		private System.Windows.Forms.TextBox textBoxValorCompra;
		private System.Windows.Forms.Label labelPercentual;
		private System.Windows.Forms.TextBox textBoxPercentual;
		private System.Windows.Forms.Label labelValorVenda;
		private System.Windows.Forms.TextBox textBoxValorVenda;
		private System.Windows.Forms.Button buttonSalvar;
		private System.Windows.Forms.Label labelCor;
		private System.Windows.Forms.TextBox textBoxCor;
		private System.Windows.Forms.Label labelTamanho;
		private System.Windows.Forms.TextBox textBoxTamanho;

		#endregion

		private void checkBoxRoupa_CheckedChanged(object sender, EventArgs e)
		{
			bool isChecked = checkBoxRoupa.Checked;
			labelCor.Visible = isChecked;
			textBoxCor.Visible = isChecked;
			labelTamanho.Visible = isChecked;
			textBoxTamanho.Visible = isChecked;
		}
	}
}
