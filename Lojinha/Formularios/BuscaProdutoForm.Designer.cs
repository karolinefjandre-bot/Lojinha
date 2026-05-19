namespace Lojinha.Formularios
{
    partial class BuscaProdutoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.estoqueTextBox = new System.Windows.Forms.TextBox();
            this.ProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.LimpaButton = new System.Windows.Forms.Button();
            this.IncluirButton = new System.Windows.Forms.Button();
            this.AlterarButton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estoque:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(142, 23);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(120, 20);
            this.codigoTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(142, 60);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(233, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(142, 101);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(233, 20);
            this.precoTextBox.TabIndex = 6;
            // 
            // estoqueTextBox
            // 
            this.estoqueTextBox.Location = new System.Drawing.Point(142, 142);
            this.estoqueTextBox.Name = "estoqueTextBox";
            this.estoqueTextBox.Size = new System.Drawing.Size(233, 20);
            this.estoqueTextBox.TabIndex = 7;
            // 
            // ProdutoDataGridView
            // 
            this.ProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdutoDataGridView.Location = new System.Drawing.Point(53, 220);
            this.ProdutoDataGridView.Name = "ProdutoDataGridView";
            this.ProdutoDataGridView.Size = new System.Drawing.Size(422, 131);
            this.ProdutoDataGridView.TabIndex = 8;
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Location = new System.Drawing.Point(394, 367);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(81, 23);
            this.FiltrarButton.TabIndex = 9;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(53, 369);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(308, 20);
            this.filtroTextBox.TabIndex = 10;
            // 
            // LimpaButton
            // 
            this.LimpaButton.Location = new System.Drawing.Point(53, 182);
            this.LimpaButton.Name = "LimpaButton";
            this.LimpaButton.Size = new System.Drawing.Size(75, 23);
            this.LimpaButton.TabIndex = 11;
            this.LimpaButton.Text = "Limpar";
            this.LimpaButton.UseVisualStyleBackColor = true;
            // 
            // IncluirButton
            // 
            this.IncluirButton.Location = new System.Drawing.Point(142, 181);
            this.IncluirButton.Name = "IncluirButton";
            this.IncluirButton.Size = new System.Drawing.Size(75, 23);
            this.IncluirButton.TabIndex = 12;
            this.IncluirButton.Text = "Incluir";
            this.IncluirButton.UseVisualStyleBackColor = true;
            // 
            // AlterarButton
            // 
            this.AlterarButton.Location = new System.Drawing.Point(235, 182);
            this.AlterarButton.Name = "AlterarButton";
            this.AlterarButton.Size = new System.Drawing.Size(75, 23);
            this.AlterarButton.TabIndex = 13;
            this.AlterarButton.Text = "Alterar";
            this.AlterarButton.UseVisualStyleBackColor = true;
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Location = new System.Drawing.Point(332, 182);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.ExcluirButton.TabIndex = 14;
            this.ExcluirButton.Text = "Excluir";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            // 
            // BuscaProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 414);
            this.Controls.Add(this.ExcluirButton);
            this.Controls.Add(this.AlterarButton);
            this.Controls.Add(this.IncluirButton);
            this.Controls.Add(this.LimpaButton);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.ProdutoDataGridView);
            this.Controls.Add(this.estoqueTextBox);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscaProdutoForm";
            this.Text = "BuscaProduto";
            this.Load += new System.EventHandler(this.BuscaProdutoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox estoqueTextBox;
        private System.Windows.Forms.DataGridView ProdutoDataGridView;
        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Button LimpaButton;
        private System.Windows.Forms.Button IncluirButton;
        private System.Windows.Forms.Button AlterarButton;
        private System.Windows.Forms.Button ExcluirButton;
    }
}