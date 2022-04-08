
namespace ProyectoEntornos_UD7
{
    partial class FormVentana
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
            this.labelTextoPregunta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2_Opcion2 = new System.Windows.Forms.Button();
            this.button3_Opcion3 = new System.Windows.Forms.Button();
            this.button4_Opcion4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Opcion1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTextoPregunta
            // 
            this.labelTextoPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoPregunta.Location = new System.Drawing.Point(110, 235);
            this.labelTextoPregunta.Name = "labelTextoPregunta";
            this.labelTextoPregunta.Size = new System.Drawing.Size(442, 51);
            this.labelTextoPregunta.TabIndex = 0;
            this.labelTextoPregunta.Text = "Texto Pregunta";
            this.labelTextoPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(110, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 220);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button2_Opcion2
            // 
            this.button2_Opcion2.Location = new System.Drawing.Point(224, 6);
            this.button2_Opcion2.Name = "button2_Opcion2";
            this.button2_Opcion2.Size = new System.Drawing.Size(218, 89);
            this.button2_Opcion2.TabIndex = 3;
            this.button2_Opcion2.Text = "opcion2";
            this.button2_Opcion2.UseVisualStyleBackColor = true;
            // 
            // button3_Opcion3
            // 
            this.button3_Opcion3.Location = new System.Drawing.Point(0, 101);
            this.button3_Opcion3.Name = "button3_Opcion3";
            this.button3_Opcion3.Size = new System.Drawing.Size(218, 89);
            this.button3_Opcion3.TabIndex = 4;
            this.button3_Opcion3.Text = "opcion3";
            this.button3_Opcion3.UseVisualStyleBackColor = true;
            // 
            // button4_Opcion4
            // 
            this.button4_Opcion4.Location = new System.Drawing.Point(224, 101);
            this.button4_Opcion4.Name = "button4_Opcion4";
            this.button4_Opcion4.Size = new System.Drawing.Size(218, 89);
            this.button4_Opcion4.TabIndex = 5;
            this.button4_Opcion4.Text = "opcion4";
            this.button4_Opcion4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Opcion1);
            this.panel1.Controls.Add(this.button4_Opcion4);
            this.panel1.Controls.Add(this.button2_Opcion2);
            this.panel1.Controls.Add(this.button3_Opcion3);
            this.panel1.Location = new System.Drawing.Point(110, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 198);
            this.panel1.TabIndex = 6;
            // 
            // button_Opcion1
            // 
            this.button_Opcion1.Location = new System.Drawing.Point(0, 6);
            this.button_Opcion1.Name = "button_Opcion1";
            this.button_Opcion1.Size = new System.Drawing.Size(218, 89);
            this.button_Opcion1.TabIndex = 3;
            this.button_Opcion1.Text = "opcion1";
            this.button_Opcion1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "1/10";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTextoPregunta);
            this.Name = "FormVentana";
            this.Text = "Ventana Preguntas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextoPregunta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2_Opcion2;
        private System.Windows.Forms.Button button3_Opcion3;
        private System.Windows.Forms.Button button4_Opcion4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Opcion1;
        private System.Windows.Forms.Label label1;
    }
}

