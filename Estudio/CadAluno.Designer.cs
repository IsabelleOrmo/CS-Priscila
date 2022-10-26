
namespace Estudio
{
    partial class cadAluno
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
            this.lblCPF = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTxtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.maskedTxtBoxN = new System.Windows.Forms.MaskedTextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.maskedTxtBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCPF.Location = new System.Drawing.Point(15, 37);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(57, 29);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.Click += new System.EventHandler(this.lblCPF_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnFoto);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnCadastrarAluno);
            this.groupBox1.Controls.Add(this.txtBoxEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maskedTxtBoxTelefone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxEstado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxComplemento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBairro);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.maskedTxtBoxN);
            this.groupBox1.Controls.Add(this.lblN);
            this.groupBox1.Controls.Add(this.txtBoxEndereco);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.txtBoxNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.maskedTxtBoxCPF);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 608);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados!";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(108, 243);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(137, 41);
            this.textBoxCidade.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cidade:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFoto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFoto.Location = new System.Drawing.Point(551, 380);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(178, 32);
            this.btnFoto.TabIndex = 20;
            this.btnFoto.Text = "Escolher foto:";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Location = new System.Drawing.Point(513, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 330);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarAluno.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(18, 534);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(727, 38);
            this.btnCadastrarAluno.TabIndex = 18;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(100, 484);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(363, 41);
            this.txtBoxEmail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(21, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // maskedTxtBoxTelefone
            // 
            this.maskedTxtBoxTelefone.Location = new System.Drawing.Point(143, 420);
            this.maskedTxtBoxTelefone.Name = "maskedTxtBoxTelefone";
            this.maskedTxtBoxTelefone.Size = new System.Drawing.Size(186, 41);
            this.maskedTxtBoxTelefone.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefone:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxEstado
            // 
            this.txtBoxEstado.Location = new System.Drawing.Point(375, 242);
            this.txtBoxEstado.Name = "txtBoxEstado";
            this.txtBoxEstado.Size = new System.Drawing.Size(88, 41);
            this.txtBoxEstado.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(269, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Estado:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(177, 358);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(199, 41);
            this.textBoxComplemento.TabIndex = 11;
            this.textBoxComplemento.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Complemento:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(104, 298);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(190, 41);
            this.textBoxBairro.TabIndex = 9;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBairro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBairro.Location = new System.Drawing.Point(15, 310);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(83, 29);
            this.lblBairro.TabIndex = 8;
            this.lblBairro.Text = "Bairro:";
            this.lblBairro.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTxtBoxN
            // 
            this.maskedTxtBoxN.Location = new System.Drawing.Point(447, 358);
            this.maskedTxtBoxN.Name = "maskedTxtBoxN";
            this.maskedTxtBoxN.Size = new System.Drawing.Size(38, 41);
            this.maskedTxtBoxN.TabIndex = 7;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblN.Location = new System.Drawing.Point(400, 361);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(41, 29);
            this.lblN.TabIndex = 6;
            this.lblN.Text = "N°:";
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Location = new System.Drawing.Point(92, 169);
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(333, 41);
            this.txtBoxEndereco.TabIndex = 5;
            this.txtBoxEndereco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndereco.Location = new System.Drawing.Point(15, 172);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 29);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Rua:";
            this.lblEndereco.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(100, 101);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(325, 41);
            this.txtBoxNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(13, 104);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 29);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // maskedTxtBoxCPF
            // 
            this.maskedTxtBoxCPF.Location = new System.Drawing.Point(78, 34);
            this.maskedTxtBoxCPF.Name = "maskedTxtBoxCPF";
            this.maskedTxtBoxCPF.Size = new System.Drawing.Size(208, 41);
            this.maskedTxtBoxCPF.TabIndex = 1;
            this.maskedTxtBoxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtBoxCPF_MaskInputRejected);
            this.maskedTxtBoxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTxtBoxCPF_KeyPress);
            // 
            // cadAluno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(788, 661);
            this.Controls.Add(this.groupBox1);
            this.Name = "cadAluno";
            this.Text = "Cadastrar Aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxCPF;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.TextBox txtBoxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelefone;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCidade;
    }
}