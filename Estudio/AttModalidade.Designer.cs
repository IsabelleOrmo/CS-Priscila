
namespace Estudio
{
    partial class AttModalidade
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.txtAlunos = new System.Windows.Forms.TextBox();
            this.txtPrecoConsulta = new System.Windows.Forms.TextBox();
            this.txtDescConsulta = new System.Windows.Forms.TextBox();
            this.comboBoxConsulta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Controls.Add(this.txtAulas);
            this.groupBox1.Controls.Add(this.txtAlunos);
            this.groupBox1.Controls.Add(this.txtPrecoConsulta);
            this.groupBox1.Controls.Add(this.txtDescConsulta);
            this.groupBox1.Controls.Add(this.comboBoxConsulta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta/Atualização";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(247, 230);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(170, 34);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(18, 233);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(155, 31);
            this.btnConsulta.TabIndex = 10;
            this.btnConsulta.Text = "Atualizar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtAulas
            // 
            this.txtAulas.Enabled = false;
            this.txtAulas.Location = new System.Drawing.Point(56, 175);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(237, 20);
            this.txtAulas.TabIndex = 9;
            // 
            // txtAlunos
            // 
            this.txtAlunos.Enabled = false;
            this.txtAlunos.Location = new System.Drawing.Point(56, 139);
            this.txtAlunos.Name = "txtAlunos";
            this.txtAlunos.Size = new System.Drawing.Size(258, 20);
            this.txtAlunos.TabIndex = 8;
            // 
            // txtPrecoConsulta
            // 
            this.txtPrecoConsulta.Enabled = false;
            this.txtPrecoConsulta.Location = new System.Drawing.Point(56, 107);
            this.txtPrecoConsulta.Name = "txtPrecoConsulta";
            this.txtPrecoConsulta.Size = new System.Drawing.Size(237, 20);
            this.txtPrecoConsulta.TabIndex = 7;
            // 
            // txtDescConsulta
            // 
            this.txtDescConsulta.Enabled = false;
            this.txtDescConsulta.Location = new System.Drawing.Point(79, 66);
            this.txtDescConsulta.Name = "txtDescConsulta";
            this.txtDescConsulta.Size = new System.Drawing.Size(250, 20);
            this.txtDescConsulta.TabIndex = 6;
            this.txtDescConsulta.TextChanged += new System.EventHandler(this.txtDescConsulta_TextChanged);
            // 
            // comboBoxConsulta
            // 
            this.comboBoxConsulta.FormattingEnabled = true;
            this.comboBoxConsulta.Location = new System.Drawing.Point(54, 30);
            this.comboBoxConsulta.Name = "comboBoxConsulta";
            this.comboBoxConsulta.Size = new System.Drawing.Size(216, 21);
            this.comboBoxConsulta.TabIndex = 5;
            this.comboBoxConsulta.SelectedIndexChanged += new System.EventHandler(this.comboBoxConsulta_SelectedIndexChanged);
            this.comboBoxConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxConsulta_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aulas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // AttModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 316);
            this.Controls.Add(this.groupBox1);
            this.Name = "AttModalidade";
            this.Text = "AttModalidade";
            this.Load += new System.EventHandler(this.AttModalidade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAulas;
        private System.Windows.Forms.TextBox txtAlunos;
        private System.Windows.Forms.TextBox txtPrecoConsulta;
        private System.Windows.Forms.TextBox txtDescConsulta;
        private System.Windows.Forms.ComboBox comboBoxConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}