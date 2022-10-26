
namespace Estudio
{
    partial class CadUsuario
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
            this.grp = new System.Windows.Forms.GroupBox();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.cmbBoxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp
            // 
            this.grp.Controls.Add(this.btnCadastrarUsuario);
            this.grp.Controls.Add(this.cmbBoxTipo);
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.txtBoxSenha);
            this.grp.Controls.Add(this.label2);
            this.grp.Controls.Add(this.txtBoxUsuario);
            this.grp.Controls.Add(this.label1);
            this.grp.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp.Location = new System.Drawing.Point(12, 12);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(653, 293);
            this.grp.TabIndex = 0;
            this.grp.TabStop = false;
            this.grp.Text = "Dados!";
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(336, 192);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(170, 42);
            this.btnCadastrarUsuario.TabIndex = 6;
            this.btnCadastrarUsuario.Text = "Cadastrar";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // cmbBoxTipo
            // 
            this.cmbBoxTipo.FormattingEnabled = true;
            this.cmbBoxTipo.Items.AddRange(new object[] {
            "Administrador",
            "Restrito"});
            this.cmbBoxTipo.Location = new System.Drawing.Point(97, 192);
            this.cmbBoxTipo.Name = "cmbBoxTipo";
            this.cmbBoxTipo.Size = new System.Drawing.Size(174, 36);
            this.cmbBoxTipo.TabIndex = 5;
            this.cmbBoxTipo.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(120, 123);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(425, 41);
            this.txtBoxSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(120, 52);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(425, 41);
            this.txtBoxUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Serif Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // CadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(682, 315);
            this.Controls.Add(this.grp);
            this.Name = "CadUsuario";
            this.Text = "Cadastrar Usuário";
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.ComboBox cmbBoxTipo;
        private System.Windows.Forms.Label label3;
    }
}