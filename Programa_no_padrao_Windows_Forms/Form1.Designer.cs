namespace Programa_no_padrao_Windows_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_botao = new System.Windows.Forms.Button();
            this.lb_label = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_botao
            // 
            this.btn_botao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_botao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_botao.ForeColor = System.Drawing.Color.Maroon;
            this.btn_botao.Location = new System.Drawing.Point(36, 117);
            this.btn_botao.Name = "btn_botao";
            this.btn_botao.Size = new System.Drawing.Size(75, 41);
            this.btn_botao.TabIndex = 0;
            this.btn_botao.Text = "Botão";
            this.btn_botao.UseVisualStyleBackColor = false;
            this.btn_botao.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_label
            // 
            this.lb_label.AutoSize = true;
            this.lb_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_label.Location = new System.Drawing.Point(45, 27);
            this.lb_label.Name = "lb_label";
            this.lb_label.Size = new System.Drawing.Size(112, 20);
            this.lb_label.TabIndex = 1;
            this.lb_label.Text = "Visual studio";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(10, 76);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 450);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_label);
            this.Controls.Add(this.btn_botao);
            this.Name = "Form1";
            this.Text = "iniçio_formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_botao;
        private System.Windows.Forms.Label lb_label;
        private System.Windows.Forms.TextBox tb_nome;
    }
}

