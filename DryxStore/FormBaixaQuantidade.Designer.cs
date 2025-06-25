namespace DryxStore
{
	partial class FormBaixaQuantidade
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
		/// Required method for Designer support - do not modify the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelDescricao = new System.Windows.Forms.Label();
			this.labelQuantidadeAtual = new System.Windows.Forms.Label();
			this.textBoxQuantidade = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancelar = new System.Windows.Forms.Button();

			this.SuspendLayout();

			// labelDescricao
			this.labelDescricao.AutoSize = true;
			this.labelDescricao.Location = new System.Drawing.Point(20, 20);
			this.labelDescricao.Name = "labelDescricao";
			this.labelDescricao.Size = new System.Drawing.Size(140, 17);
			this.labelDescricao.TabIndex = 0;
			this.labelDescricao.Text = "Descrição do produto:";

			// labelQuantidadeAtual
			this.labelQuantidadeAtual.AutoSize = true;
			this.labelQuantidadeAtual.Location = new System.Drawing.Point(20, 60);
			this.labelQuantidadeAtual.Name = "labelQuantidadeAtual";
			this.labelQuantidadeAtual.Size = new System.Drawing.Size(130, 17);
			this.labelQuantidadeAtual.TabIndex = 1;
			this.labelQuantidadeAtual.Text = "Quantidade atual:";

			// textBoxQuantidade
			this.textBoxQuantidade.Location = new System.Drawing.Point(20, 100);
			this.textBoxQuantidade.Name = "textBoxQuantidade";
			this.textBoxQuantidade.Size = new System.Drawing.Size(200, 22);
			this.textBoxQuantidade.TabIndex = 2;

			// buttonOk
			this.buttonOk.Location = new System.Drawing.Point(20, 140);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 30);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);

			// buttonCancelar
			this.buttonCancelar.Location = new System.Drawing.Point(100, 140);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(75, 30);
			this.buttonCancelar.TabIndex = 4;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = true;
			this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);

			// FormBaixaQuantidade
			this.ClientSize = new System.Drawing.Size(300, 200);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxQuantidade);
			this.Controls.Add(this.labelQuantidadeAtual);
			this.Controls.Add(this.labelDescricao);
			this.Name = "FormBaixaQuantidade";
			this.Text = "Baixa de Quantidade";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label labelDescricao;
		private System.Windows.Forms.Label labelQuantidadeAtual;
		private System.Windows.Forms.TextBox textBoxQuantidade;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancelar;
	}
}
