
namespace Estudio
{
    partial class CPF
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
            this.maskedTxtBoxCPFExclusao = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o CPF para a exclusão:";
            // 
            // maskedTxtBoxCPFExclusao
            // 
            this.maskedTxtBoxCPFExclusao.Location = new System.Drawing.Point(117, 92);
            this.maskedTxtBoxCPFExclusao.Name = "maskedTxtBoxCPFExclusao";
            this.maskedTxtBoxCPFExclusao.Size = new System.Drawing.Size(177, 20);
            this.maskedTxtBoxCPFExclusao.TabIndex = 1;
            this.maskedTxtBoxCPFExclusao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtBoxCPFExclusao_MaskInputRejected);
            this.maskedTxtBoxCPFExclusao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTxtBoxCPFExclusao_KeyPress);
            // 
            // CPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(412, 191);
            this.Controls.Add(this.maskedTxtBoxCPFExclusao);
            this.Controls.Add(this.label1);
            this.Name = "CPF";
            this.Text = "Exclusão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxCPFExclusao;
    }
}