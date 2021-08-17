
namespace JuegoMayorOMenor_Forms
{
    partial class JuegoMayorOMenorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonMayor = new System.Windows.Forms.Button();
            this.botonMenor = new System.Windows.Forms.Button();
            this.labelChancesRestantes = new System.Windows.Forms.Label();
            this.botonDeReset = new System.Windows.Forms.Button();
            this.labelPuntuacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // botonMayor
            // 
            this.botonMayor.Location = new System.Drawing.Point(226, 32);
            this.botonMayor.Name = "botonMayor";
            this.botonMayor.Size = new System.Drawing.Size(98, 70);
            this.botonMayor.TabIndex = 1;
            this.botonMayor.Text = "MAYOR";
            this.botonMayor.UseVisualStyleBackColor = true;
            this.botonMayor.Click += new System.EventHandler(this.botonMayor_Click);
            // 
            // botonMenor
            // 
            this.botonMenor.Location = new System.Drawing.Point(330, 32);
            this.botonMenor.Name = "botonMenor";
            this.botonMenor.Size = new System.Drawing.Size(92, 70);
            this.botonMenor.TabIndex = 2;
            this.botonMenor.Text = "MENOR";
            this.botonMenor.UseVisualStyleBackColor = true;
            this.botonMenor.Click += new System.EventHandler(this.botonMenor_Click);
            // 
            // labelChancesRestantes
            // 
            this.labelChancesRestantes.AutoSize = true;
            this.labelChancesRestantes.Location = new System.Drawing.Point(277, 14);
            this.labelChancesRestantes.Name = "labelChancesRestantes";
            this.labelChancesRestantes.Size = new System.Drawing.Size(108, 15);
            this.labelChancesRestantes.TabIndex = 3;
            this.labelChancesRestantes.Text = "Chances restantes: ";
            // 
            // botonDeReset
            // 
            this.botonDeReset.Location = new System.Drawing.Point(286, 207);
            this.botonDeReset.Name = "botonDeReset";
            this.botonDeReset.Size = new System.Drawing.Size(75, 23);
            this.botonDeReset.TabIndex = 4;
            this.botonDeReset.Text = "Resetear";
            this.botonDeReset.UseVisualStyleBackColor = true;
            this.botonDeReset.Click += new System.EventHandler(this.botonDeReset_Click);
            // 
            // labelPuntuacion
            // 
            this.labelPuntuacion.AutoSize = true;
            this.labelPuntuacion.Location = new System.Drawing.Point(286, 189);
            this.labelPuntuacion.Name = "labelPuntuacion";
            this.labelPuntuacion.Size = new System.Drawing.Size(38, 15);
            this.labelPuntuacion.TabIndex = 5;
            this.labelPuntuacion.Text = "label1";
            // 
            // JuegoMayorOMenorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 351);
            this.Controls.Add(this.labelPuntuacion);
            this.Controls.Add(this.botonDeReset);
            this.Controls.Add(this.labelChancesRestantes);
            this.Controls.Add(this.botonMenor);
            this.Controls.Add(this.botonMayor);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(450, 390);
            this.Name = "JuegoMayorOMenorForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonMayor;
        private System.Windows.Forms.Button botonMenor;
        private System.Windows.Forms.Label labelChancesRestantes;
        private System.Windows.Forms.Button botonDeReset;
        private System.Windows.Forms.Label labelPuntuacion;
    }
}

