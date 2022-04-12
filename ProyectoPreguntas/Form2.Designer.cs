
namespace ProyectoPreguntas
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtb_usuario = new System.Windows.Forms.TextBox();
            this.txtb_password = new System.Windows.Forms.TextBox();
            this.b_start = new System.Windows.Forms.Button();
            this.timerForm2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_usuario.ForeColor = System.Drawing.Color.Blue;
            this.lbl_usuario.Location = new System.Drawing.Point(153, 364);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(106, 24);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "USUARIO:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_password.ForeColor = System.Drawing.Color.Blue;
            this.lbl_password.Location = new System.Drawing.Point(111, 402);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(158, 24);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "CONTRASEÑA:";
            // 
            // txtb_usuario
            // 
            this.txtb_usuario.Location = new System.Drawing.Point(268, 367);
            this.txtb_usuario.Name = "txtb_usuario";
            this.txtb_usuario.Size = new System.Drawing.Size(155, 20);
            this.txtb_usuario.TabIndex = 3;
            // 
            // txtb_password
            // 
            this.txtb_password.Location = new System.Drawing.Point(268, 406);
            this.txtb_password.Name = "txtb_password";
            this.txtb_password.Size = new System.Drawing.Size(155, 20);
            this.txtb_password.TabIndex = 4;
            // 
            // b_start
            // 
            this.b_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_start.BackgroundImage")));
            this.b_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_start.FlatAppearance.BorderSize = 0;
            this.b_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_start.Location = new System.Drawing.Point(196, 442);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(227, 84);
            this.b_start.TabIndex = 5;
            this.b_start.UseVisualStyleBackColor = true;
            // 
            // timerForm2
            // 
            this.timerForm2.Interval = 3000;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 592);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.txtb_password);
            this.Controls.Add(this.txtb_usuario);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtb_usuario;
        private System.Windows.Forms.TextBox txtb_password;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Timer timerForm2;
    }
}