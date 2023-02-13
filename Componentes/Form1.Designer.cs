namespace Componentes
{
    partial class F_Principal
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
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.lb_texto = new System.Windows.Forms.Label();
            this.tb_listaVeiculos = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_valNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_botao
            // 
            this.btn_botao.Location = new System.Drawing.Point(197, 33);
            this.btn_botao.Name = "btn_botao";
            this.btn_botao.Size = new System.Drawing.Size(75, 23);
            this.btn_botao.TabIndex = 0;
            this.btn_botao.Text = "Adicionar";
            this.btn_botao.UseVisualStyleBackColor = true;
            this.btn_botao.Click += new System.EventHandler(this.btn_botao_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(12, 36);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(170, 20);
            this.tb_veiculo.TabIndex = 1;
            this.tb_veiculo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(9, 9);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(88, 13);
            this.lb_texto.TabIndex = 2;
            this.lb_texto.Text = "Digite um veiculo";
            // 
            // tb_listaVeiculos
            // 
            this.tb_listaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_listaVeiculos.Location = new System.Drawing.Point(12, 80);
            this.tb_listaVeiculos.Multiline = true;
            this.tb_listaVeiculos.Name = "tb_listaVeiculos";
            this.tb_listaVeiculos.ReadOnly = true;
            this.tb_listaVeiculos.Size = new System.Drawing.Size(260, 206);
            this.tb_listaVeiculos.TabIndex = 3;
            this.tb_listaVeiculos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(12, 292);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(260, 23);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(229, 36);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(8, 8);
            this.Limpar.TabIndex = 5;
            this.Limpar.Text = "btn_botao";
            this.Limpar.UseVisualStyleBackColor = true;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btn_mostrar.Location = new System.Drawing.Point(12, 321);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(260, 23);
            this.btn_mostrar.TabIndex = 6;
            this.btn_mostrar.Text = "Mostrar veiculos";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_valNum
            // 
            this.btn_valNum.Location = new System.Drawing.Point(12, 350);
            this.btn_valNum.Name = "btn_valNum";
            this.btn_valNum.Size = new System.Drawing.Size(260, 23);
            this.btn_valNum.TabIndex = 7;
            this.btn_valNum.Text = "Valor da variavel num";
            this.btn_valNum.UseVisualStyleBackColor = true;
            this.btn_valNum.Click += new System.EventHandler(this.btn_valNum_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 377);
            this.Controls.Add(this.btn_valNum);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_listaVeiculos);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_botao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.Load += new System.EventHandler(this.F_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_botao;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_valNum;
        public System.Windows.Forms.TextBox tb_listaVeiculos;
    }
}

