namespace zad2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.genbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pad = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pad)).BeginInit();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(679, 118);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(117, 54);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "START";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startbtn_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pad);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 648);
            this.panel1.TabIndex = 2;
            // 
            // genbtn
            // 
            this.genbtn.Location = new System.Drawing.Point(679, 218);
            this.genbtn.Name = "genbtn";
            this.genbtn.Size = new System.Drawing.Size(116, 53);
            this.genbtn.TabIndex = 3;
            this.genbtn.Text = "Generate";
            this.genbtn.UseVisualStyleBackColor = true;
            this.genbtn.Click += new System.EventHandler(this.genbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pad
            // 
            this.pad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pad.Location = new System.Drawing.Point(30, 600);
            this.pad.Name = "pad";
            this.pad.Size = new System.Drawing.Size(200, 30);
            this.pad.TabIndex = 0;
            this.pad.TabStop = false;
            this.pad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PadMouseDown);
            this.pad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PadMouseMove);
            this.pad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PadMouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(808, 672);
            this.Controls.Add(this.genbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startbtn);
            this.Name = "Form1";
            this.Text = "Zad2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button genbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pad;
    }
}

