
namespace Heladeria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_administrador = new System.Windows.Forms.Button();
            this.btn_trabajador = new System.Windows.Forms.Button();
            this.txt_fechahora = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "HELADERIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "A Y J";
            // 
            // btn_administrador
            // 
            this.btn_administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrador.Location = new System.Drawing.Point(12, 155);
            this.btn_administrador.Name = "btn_administrador";
            this.btn_administrador.Size = new System.Drawing.Size(213, 29);
            this.btn_administrador.TabIndex = 3;
            this.btn_administrador.Text = "ADMINISTRADOR";
            this.btn_administrador.UseVisualStyleBackColor = true;
            this.btn_administrador.Click += new System.EventHandler(this.btn_administrador_Click);
            // 
            // btn_trabajador
            // 
            this.btn_trabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trabajador.Location = new System.Drawing.Point(303, 155);
            this.btn_trabajador.Name = "btn_trabajador";
            this.btn_trabajador.Size = new System.Drawing.Size(162, 29);
            this.btn_trabajador.TabIndex = 4;
            this.btn_trabajador.Text = "TRABAJADOR";
            this.btn_trabajador.UseVisualStyleBackColor = true;
            this.btn_trabajador.Click += new System.EventHandler(this.btn_trabajador_Click);
            // 
            // txt_fechahora
            // 
            this.txt_fechahora.Enabled = false;
            this.txt_fechahora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechahora.Location = new System.Drawing.Point(141, 222);
            this.txt_fechahora.Name = "txt_fechahora";
            this.txt_fechahora.Size = new System.Drawing.Size(197, 26);
            this.txt_fechahora.TabIndex = 5;
            this.txt_fechahora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(507, 356);
            this.Controls.Add(this.txt_fechahora);
            this.Controls.Add(this.btn_trabajador);
            this.Controls.Add(this.btn_administrador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_administrador;
        private System.Windows.Forms.Button btn_trabajador;
        private System.Windows.Forms.TextBox txt_fechahora;
        private System.Windows.Forms.Timer timer1;
    }
}

