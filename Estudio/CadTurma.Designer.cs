
namespace Estudio
{
    partial class TurmaCadastro
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
            this.txtBoxProfessor = new System.Windows.Forms.TextBox();
            this.btnCadTurma = new System.Windows.Forms.Button();
            this.txtBoxSemana = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCadTurma = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia de Semana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // txtBoxProfessor
            // 
            this.txtBoxProfessor.Location = new System.Drawing.Point(130, 112);
            this.txtBoxProfessor.Name = "txtBoxProfessor";
            this.txtBoxProfessor.Size = new System.Drawing.Size(242, 29);
            this.txtBoxProfessor.TabIndex = 5;
            // 
            // btnCadTurma
            // 
            this.btnCadTurma.Location = new System.Drawing.Point(37, 402);
            this.btnCadTurma.Name = "btnCadTurma";
            this.btnCadTurma.Size = new System.Drawing.Size(203, 33);
            this.btnCadTurma.TabIndex = 14;
            this.btnCadTurma.Text = "Cadastrar";
            this.btnCadTurma.UseVisualStyleBackColor = true;
            this.btnCadTurma.Click += new System.EventHandler(this.btnCadTurma_Click);
            // 
            // txtBoxSemana
            // 
            this.txtBoxSemana.Location = new System.Drawing.Point(160, 170);
            this.txtBoxSemana.Name = "txtBoxSemana";
            this.txtBoxSemana.Size = new System.Drawing.Size(189, 29);
            this.txtBoxSemana.TabIndex = 17;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(90, 228);
            this.maskedTextBox1.Mask = "90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(136, 29);
            this.maskedTextBox1.TabIndex = 18;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxCadTurma
            // 
            this.comboBoxCadTurma.FormattingEnabled = true;
            this.comboBoxCadTurma.Location = new System.Drawing.Point(130, 52);
            this.comboBoxCadTurma.Name = "comboBoxCadTurma";
            this.comboBoxCadTurma.Size = new System.Drawing.Size(277, 29);
            this.comboBoxCadTurma.TabIndex = 19;
            // 
            // TurmaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 727);
            this.Controls.Add(this.comboBoxCadTurma);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtBoxSemana);
            this.Controls.Add(this.btnCadTurma);
            this.Controls.Add(this.txtBoxProfessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TurmaCadastro";
            this.Text = "Cadastrar Turma";
            this.Load += new System.EventHandler(this.TurmaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxProfessor;
        private System.Windows.Forms.Button btnCadTurma;
        private System.Windows.Forms.TextBox txtBoxSemana;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBoxCadTurma;
    }
}