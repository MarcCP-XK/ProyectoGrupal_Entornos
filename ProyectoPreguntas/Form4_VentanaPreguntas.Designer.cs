
namespace ProyectoPreguntas
{
    partial class Form4_VentanaPreguntas
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
            this.labelNumPregunta = new System.Windows.Forms.Label();
            this.pictureboxImagen = new System.Windows.Forms.PictureBox();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.buttonRespuesta1 = new System.Windows.Forms.Button();
            this.buttonRespuesta2 = new System.Windows.Forms.Button();
            this.buttonRespuesta3 = new System.Windows.Forms.Button();
            this.buttonRespuesta4 = new System.Windows.Forms.Button();
            this.temporizadorPreguntas = new System.Windows.Forms.Timer(this.components);
            this.labelTiempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumPregunta
            // 
            this.labelNumPregunta.AutoSize = true;
            this.labelNumPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPregunta.Location = new System.Drawing.Point(664, 9);
            this.labelNumPregunta.Name = "labelNumPregunta";
            this.labelNumPregunta.Size = new System.Drawing.Size(55, 25);
            this.labelNumPregunta.TabIndex = 12;
            this.labelNumPregunta.Text = "1/10";
            this.labelNumPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureboxImagen
            // 
            this.pictureboxImagen.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxImagen.Location = new System.Drawing.Point(-2, -2);
            this.pictureboxImagen.Name = "pictureboxImagen";
            this.pictureboxImagen.Size = new System.Drawing.Size(734, 420);
            this.pictureboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxImagen.TabIndex = 11;
            this.pictureboxImagen.TabStop = false;
            // 
            // labelPregunta
            // 
            this.labelPregunta.BackColor = System.Drawing.SystemColors.Control;
            this.labelPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPregunta.Location = new System.Drawing.Point(90, 9);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(554, 51);
            this.labelPregunta.TabIndex = 10;
            this.labelPregunta.Text = "Texto Pregunta";
            this.labelPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRespuesta1
            // 
            this.buttonRespuesta1.Location = new System.Drawing.Point(95, 100);
            this.buttonRespuesta1.Name = "buttonRespuesta1";
            this.buttonRespuesta1.Size = new System.Drawing.Size(250, 67);
            this.buttonRespuesta1.TabIndex = 13;
            this.buttonRespuesta1.Tag = "1";
            this.buttonRespuesta1.Text = "button1";
            this.buttonRespuesta1.UseVisualStyleBackColor = true;
            this.buttonRespuesta1.Click += new System.EventHandler(this.buttonRespuestas_Click);
            // 
            // buttonRespuesta2
            // 
            this.buttonRespuesta2.Location = new System.Drawing.Point(394, 100);
            this.buttonRespuesta2.Name = "buttonRespuesta2";
            this.buttonRespuesta2.Size = new System.Drawing.Size(250, 67);
            this.buttonRespuesta2.TabIndex = 14;
            this.buttonRespuesta2.Tag = "2";
            this.buttonRespuesta2.Text = "button2";
            this.buttonRespuesta2.UseVisualStyleBackColor = true;
            this.buttonRespuesta2.Click += new System.EventHandler(this.buttonRespuestas_Click);
            // 
            // buttonRespuesta3
            // 
            this.buttonRespuesta3.Location = new System.Drawing.Point(95, 208);
            this.buttonRespuesta3.Name = "buttonRespuesta3";
            this.buttonRespuesta3.Size = new System.Drawing.Size(250, 67);
            this.buttonRespuesta3.TabIndex = 15;
            this.buttonRespuesta3.Tag = "3";
            this.buttonRespuesta3.Text = "button3";
            this.buttonRespuesta3.UseVisualStyleBackColor = true;
            this.buttonRespuesta3.Click += new System.EventHandler(this.buttonRespuestas_Click);
            // 
            // buttonRespuesta4
            // 
            this.buttonRespuesta4.Location = new System.Drawing.Point(394, 208);
            this.buttonRespuesta4.Name = "buttonRespuesta4";
            this.buttonRespuesta4.Size = new System.Drawing.Size(250, 67);
            this.buttonRespuesta4.TabIndex = 16;
            this.buttonRespuesta4.Tag = "4";
            this.buttonRespuesta4.Text = "button4";
            this.buttonRespuesta4.UseVisualStyleBackColor = true;
            this.buttonRespuesta4.Click += new System.EventHandler(this.buttonRespuestas_Click);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(344, 338);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(42, 44);
            this.labelTiempo.TabIndex = 17;
            this.labelTiempo.Text = "8";
            this.labelTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tiempo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4_VentanaPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 416);
            this.Controls.Add(this.labelPregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.buttonRespuesta4);
            this.Controls.Add(this.buttonRespuesta3);
            this.Controls.Add(this.buttonRespuesta2);
            this.Controls.Add(this.buttonRespuesta1);
            this.Controls.Add(this.labelNumPregunta);
            this.Controls.Add(this.pictureboxImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form4_VentanaPreguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preguntas";
            this.Load += new System.EventHandler(this.Form4_VentanaPreguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNumPregunta;
        private System.Windows.Forms.PictureBox pictureboxImagen;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.Button buttonRespuesta1;
        private System.Windows.Forms.Button buttonRespuesta2;
        private System.Windows.Forms.Button buttonRespuesta3;
        private System.Windows.Forms.Button buttonRespuesta4;
        private System.Windows.Forms.Timer temporizadorPreguntas;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label label1;
    }
}