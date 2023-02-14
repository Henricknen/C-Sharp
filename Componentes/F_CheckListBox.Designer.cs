namespace Componentes
{
    partial class F_CheckListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CheckListBox));
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_navio = new System.Windows.Forms.CheckBox();
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.btn_transpotesMarcados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            resources.ApplyResources(this.cb_carro, "cb_carro");
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            resources.ApplyResources(this.cb_aviao, "cb_aviao");
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.UseVisualStyleBackColor = true;
            this.cb_aviao.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cb_navio
            // 
            resources.ApplyResources(this.cb_navio, "cb_navio");
            this.cb_navio.Name = "cb_navio";
            this.cb_navio.UseVisualStyleBackColor = true;
            // 
            // cb_onibus
            // 
            resources.ApplyResources(this.cb_onibus, "cb_onibus");
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            this.cb_onibus.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // btn_transpotesMarcados
            // 
            resources.ApplyResources(this.btn_transpotesMarcados, "btn_transpotesMarcados");
            this.btn_transpotesMarcados.Name = "btn_transpotesMarcados";
            this.btn_transpotesMarcados.UseVisualStyleBackColor = true;
            this.btn_transpotesMarcados.Click += new System.EventHandler(this.btn_transpotesMarcados_Click);
            // 
            // F_CheckListBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_transpotesMarcados);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.cb_navio);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_carro;
        private System.Windows.Forms.CheckBox cb_aviao;
        private System.Windows.Forms.CheckBox cb_navio;
        private System.Windows.Forms.CheckBox cb_onibus;
        private System.Windows.Forms.Button btn_transpotesMarcados;
    }
}