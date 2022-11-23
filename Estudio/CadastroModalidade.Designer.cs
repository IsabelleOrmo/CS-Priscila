
namespace Estudio
{
    partial class CadastroModalidade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxModalidade = new System.Windows.Forms.ComboBox();
            this.btnCadastrarModalidade = new System.Windows.Forms.Button();
            this.maskedTextBoxAulas = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAlunos = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPreco = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxModalidade);
            this.groupBox1.Controls.Add(this.btnCadastrarModalidade);
            this.groupBox1.Controls.Add(this.maskedTextBoxAulas);
            this.groupBox1.Controls.Add(this.maskedTextBoxAlunos);
            this.groupBox1.Controls.Add(this.maskedTextBoxPreco);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Modalidade";
            // 
            // comboBoxModalidade
            // 
            this.comboBoxModalidade.FormattingEnabled = true;
            this.comboBoxModalidade.Location = new System.Drawing.Point(54, 33);
            this.comboBoxModalidade.Name = "comboBoxModalidade";
            this.comboBoxModalidade.Size = new System.Drawing.Size(298, 21);
            this.comboBoxModalidade.TabIndex = 11;
            this.comboBoxModalidade.SelectedIndexChanged += new System.EventHandler(this.comboBoxModalidade_SelectedIndexChanged);
            // 
            // btnCadastrarModalidade
            // 
            this.btnCadastrarModalidade.Location = new System.Drawing.Point(392, 216);
            this.btnCadastrarModalidade.Name = "btnCadastrarModalidade";
            this.btnCadastrarModalidade.Size = new System.Drawing.Size(140, 27);
            this.btnCadastrarModalidade.TabIndex = 10;
            this.btnCadastrarModalidade.Text = "Cadastrar";
            this.btnCadastrarModalidade.UseVisualStyleBackColor = true;
            this.btnCadastrarModalidade.Click += new System.EventHandler(this.btnCadastrarModalidade_Click);
            // 
            // maskedTextBoxAulas
            // 
            this.maskedTextBoxAulas.Location = new System.Drawing.Point(134, 216);
            this.maskedTextBoxAulas.Name = "maskedTextBoxAulas";
            this.maskedTextBoxAulas.Size = new System.Drawing.Size(214, 20);
            this.maskedTextBoxAulas.TabIndex = 9;
            // 
            // maskedTextBoxAlunos
            // 
            this.maskedTextBoxAlunos.Location = new System.Drawing.Point(134, 172);
            this.maskedTextBoxAlunos.Name = "maskedTextBoxAlunos";
            this.maskedTextBoxAlunos.Size = new System.Drawing.Size(224, 20);
            this.maskedTextBoxAlunos.TabIndex = 8;
            // 
            // maskedTextBoxPreco
            // 
            this.maskedTextBoxPreco.Location = new System.Drawing.Point(64, 132);
            this.maskedTextBoxPreco.Name = "maskedTextBoxPreco";
            this.maskedTextBoxPreco.Size = new System.Drawing.Size(294, 20);
            this.maskedTextBoxPreco.TabIndex = 7;
            this.maskedTextBoxPreco.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxPreco_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade de Aulas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade de Alunos:";
            // 
            // txtBoxDescricao
            // 
            this.txtBoxDescricao.Location = new System.Drawing.Point(77, 78);
            this.txtBoxDescricao.Name = "txtBoxDescricao";
            this.txtBoxDescricao.Size = new System.Drawing.Size(416, 20);
            this.txtBoxDescricao.TabIndex = 3;
            this.txtBoxDescricao.TextChanged += new System.EventHandler(this.txtBoxDescricao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // CadastroModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 295);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroModalidade";
            this.Text = "CadastroModalidade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrarModalidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAulas;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAlunos;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModalidade;
    }
}