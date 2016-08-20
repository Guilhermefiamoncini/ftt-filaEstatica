namespace FilaCircularEstatica
{
    partial class Form1
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
            this.btnRetornaInicio = new System.Windows.Forms.Button();
            this.btnRetornaFim = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnInverterFila = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetornaInicio
            // 
            this.btnRetornaInicio.Location = new System.Drawing.Point(26, 12);
            this.btnRetornaInicio.Name = "btnRetornaInicio";
            this.btnRetornaInicio.Size = new System.Drawing.Size(233, 23);
            this.btnRetornaInicio.TabIndex = 0;
            this.btnRetornaInicio.Text = "Retorna Início";
            this.btnRetornaInicio.UseVisualStyleBackColor = true;
            this.btnRetornaInicio.Click += new System.EventHandler(this.btnRetornaInicio_Click);
            // 
            // btnRetornaFim
            // 
            this.btnRetornaFim.Location = new System.Drawing.Point(26, 41);
            this.btnRetornaFim.Name = "btnRetornaFim";
            this.btnRetornaFim.Size = new System.Drawing.Size(233, 23);
            this.btnRetornaFim.TabIndex = 1;
            this.btnRetornaFim.Text = "Retorna Fim";
            this.btnRetornaFim.UseVisualStyleBackColor = true;
            this.btnRetornaFim.Click += new System.EventHandler(this.btnRetornaFim_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(26, 70);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(233, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnInverterFila
            // 
            this.btnInverterFila.Location = new System.Drawing.Point(26, 99);
            this.btnInverterFila.Name = "btnInverterFila";
            this.btnInverterFila.Size = new System.Drawing.Size(233, 23);
            this.btnInverterFila.TabIndex = 3;
            this.btnInverterFila.Text = "Inverter Fila";
            this.btnInverterFila.UseVisualStyleBackColor = true;
            this.btnInverterFila.Click += new System.EventHandler(this.btnInverterFila_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(26, 161);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultado.Size = new System.Drawing.Size(233, 158);
            this.tbResultado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "RESULTADO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnInverterFila);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRetornaFim);
            this.Controls.Add(this.btnRetornaInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetornaInicio;
        private System.Windows.Forms.Button btnRetornaFim;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnInverterFila;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label label1;
    }
}

