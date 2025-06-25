namespace DryxStore
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.labelBemVindo = new System.Windows.Forms.Label();
			this.labelDescricao = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelBemVindo
			// 
			this.labelBemVindo.AutoSize = true;
			this.labelBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBemVindo.Location = new System.Drawing.Point(54, 46);
			this.labelBemVindo.Name = "labelBemVindo";
			this.labelBemVindo.Size = new System.Drawing.Size(515, 31);
			this.labelBemVindo.TabIndex = 0;
			this.labelBemVindo.Text = "Seja bem-vindo ao Sistema DryxStore!";
			this.labelBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDescricao
			// 
			this.labelDescricao.AutoSize = true;
			this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDescricao.Location = new System.Drawing.Point(200, 100);
			this.labelDescricao.Name = "labelDescricao";
			this.labelDescricao.Size = new System.Drawing.Size(260, 25);
			this.labelDescricao.TabIndex = 1;
			this.labelDescricao.Text = "Qual função deseja realizar?";
			this.labelDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(206, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(257, 33);
			this.button1.TabIndex = 2;
			this.button1.Text = "Cadastrar novo Produto";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(206, 210);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(257, 33);
			this.button2.TabIndex = 3;
			this.button2.Text = "Consultar Produtos Cadastrados";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 409);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelDescricao);
			this.Controls.Add(this.labelBemVindo);
			this.Name = "Form1";
			this.Text = "DryxStore - Menu Principal";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelBemVindo;
		private System.Windows.Forms.Label labelDescricao;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}