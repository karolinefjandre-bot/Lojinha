namespace Lojinha.Formularios
{
    partial class ProdutosForm
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
            this.codigoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.precoLlabel = new System.Windows.Forms.Label();
            this.estoqueLabel = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.estoqueTextBox = new System.Windows.Forms.TextBox();
            this.inserirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.selecionarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(13, 13);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(43, 13);
            this.codigoLabel.TabIndex = 0;
            this.codigoLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(13, 50);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome:";
            // 
            // precoLlabel
            // 
            this.precoLlabel.AutoSize = true;
            this.precoLlabel.Location = new System.Drawing.Point(13, 89);
            this.precoLlabel.Name = "precoLlabel";
            this.precoLlabel.Size = new System.Drawing.Size(38, 13);
            this.precoLlabel.TabIndex = 2;
            this.precoLlabel.Text = "Preço:";
            this.precoLlabel.Click += new System.EventHandler(this.precoLlabel_Click);
            // 
            // estoqueLabel
            // 
            this.estoqueLabel.AutoSize = true;
            this.estoqueLabel.Location = new System.Drawing.Point(13, 129);
            this.estoqueLabel.Name = "estoqueLabel";
            this.estoqueLabel.Size = new System.Drawing.Size(49, 13);
            this.estoqueLabel.TabIndex = 3;
            this.estoqueLabel.Text = "Estoque:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(107, 10);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(107, 50);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(194, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(107, 89);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(152, 20);
            this.precoTextBox.TabIndex = 6;
            // 
            // estoqueTextBox
            // 
            this.estoqueTextBox.Location = new System.Drawing.Point(107, 129);
            this.estoqueTextBox.Name = "estoqueTextBox";
            this.estoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.estoqueTextBox.TabIndex = 7;
            // 
            // inserirButton
            // 
            this.inserirButton.Location = new System.Drawing.Point(12, 198);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(75, 23);
            this.inserirButton.TabIndex = 8;
            this.inserirButton.Text = "Inserir";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(93, 198);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 9;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(174, 198);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 10;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // selecionarButton
            // 
            this.selecionarButton.Location = new System.Drawing.Point(255, 198);
            this.selecionarButton.Name = "selecionarButton";
            this.selecionarButton.Size = new System.Drawing.Size(75, 23);
            this.selecionarButton.TabIndex = 11;
            this.selecionarButton.Text = "Selecionar";
            this.selecionarButton.UseVisualStyleBackColor = true;
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(336, 198);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 12;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 312);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.selecionarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.inserirButton);
            this.Controls.Add(this.estoqueTextBox);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.estoqueLabel);
            this.Controls.Add(this.precoLlabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.codigoLabel);
            this.Name = "ProdutosForm";
            this.Text = "ProdutosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label precoLlabel;
        private System.Windows.Forms.Label estoqueLabel;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox estoqueTextBox;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button selecionarButton;
        private System.Windows.Forms.Button limparButton;
    }
}