
namespace WindowsFormsApp1
{
    partial class frmFlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlappyBird));
            this.pbxPtica = new System.Windows.Forms.PictureBox();
            this.uputstvo = new System.Windows.Forms.Button();
            this.btnPocetak = new System.Windows.Forms.Button();
            this.tmrKretanjePtice = new System.Windows.Forms.Timer(this.components);
            this.pbxPozadina = new System.Windows.Forms.PictureBox();
            this.tmrIgra = new System.Windows.Forms.Timer(this.components);
            this.tmrKretanjeCevi = new System.Windows.Forms.Timer(this.components);
            this.tbxPoeni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPtica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPozadina)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPtica
            // 
            this.pbxPtica.BackColor = System.Drawing.Color.Transparent;
            this.pbxPtica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxPtica.BackgroundImage")));
            this.pbxPtica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPtica.Location = new System.Drawing.Point(499, 193);
            this.pbxPtica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxPtica.Name = "pbxPtica";
            this.pbxPtica.Size = new System.Drawing.Size(65, 52);
            this.pbxPtica.TabIndex = 0;
            this.pbxPtica.TabStop = false;
            // 
            // uputstvo
            // 
            this.uputstvo.BackColor = System.Drawing.Color.LightBlue;
            this.uputstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uputstvo.Location = new System.Drawing.Point(1072, 16);
            this.uputstvo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uputstvo.Name = "uputstvo";
            this.uputstvo.Size = new System.Drawing.Size(51, 43);
            this.uputstvo.TabIndex = 0;
            this.uputstvo.Text = "?";
            this.uputstvo.UseMnemonic = false;
            this.uputstvo.UseVisualStyleBackColor = false;
            this.uputstvo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uputstvo_MouseClick);
            // 
            // btnPocetak
            // 
            this.btnPocetak.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPocetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPocetak.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPocetak.FlatAppearance.BorderSize = 3;
            this.btnPocetak.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPocetak.Location = new System.Drawing.Point(401, 258);
            this.btnPocetak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPocetak.Name = "btnPocetak";
            this.btnPocetak.Size = new System.Drawing.Size(267, 91);
            this.btnPocetak.TabIndex = 2;
            this.btnPocetak.Text = "POKRENI IGRU";
            this.btnPocetak.UseVisualStyleBackColor = false;
            this.btnPocetak.Click += new System.EventHandler(this.btnPocetak_Click);
            // 
            // tmrKretanjePtice
            // 
            this.tmrKretanjePtice.Interval = 50;
            this.tmrKretanjePtice.Tick += new System.EventHandler(this.tmrKretanjePtice_Tick);
            // 
            // pbxPozadina
            // 
            this.pbxPozadina.BackColor = System.Drawing.Color.Transparent;
            this.pbxPozadina.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Pozadina;
            this.pbxPozadina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPozadina.Location = new System.Drawing.Point(-2, 2);
            this.pbxPozadina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxPozadina.Name = "pbxPozadina";
            this.pbxPozadina.Size = new System.Drawing.Size(1140, 606);
            this.pbxPozadina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPozadina.TabIndex = 3;
            this.pbxPozadina.TabStop = false;
            this.pbxPozadina.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxPozadina_Paint);
            this.pbxPozadina.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxPozadina_MouseClick);
            // 
            // tmrIgra
            // 
            this.tmrIgra.Interval = 3000;
            this.tmrIgra.Tick += new System.EventHandler(this.tmrIgra_Tick);
            // 
            // tmrKretanjeCevi
            // 
            this.tmrKretanjeCevi.Tick += new System.EventHandler(this.timerKretanjeCevi_Tick);
            // 
            // tbxPoeni
            // 
            this.tbxPoeni.BackColor = System.Drawing.Color.LightCyan;
            this.tbxPoeni.Enabled = false;
            this.tbxPoeni.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPoeni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxPoeni.Location = new System.Drawing.Point(11, 16);
            this.tbxPoeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPoeni.Name = "tbxPoeni";
            this.tbxPoeni.Size = new System.Drawing.Size(300, 37);
            this.tbxPoeni.TabIndex = 4;
            this.tbxPoeni.Text = "Osvojen broj poena";
            // 
            // frmFlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 609);
            this.Controls.Add(this.uputstvo);
            this.Controls.Add(this.tbxPoeni);
            this.Controls.Add(this.btnPocetak);
            this.Controls.Add(this.pbxPtica);
            this.Controls.Add(this.pbxPozadina);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmFlappyBird";
            this.Text = "Flappy bird";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPtica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPozadina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPtica;
        private System.Windows.Forms.Button uputstvo;
        private System.Windows.Forms.Button btnPocetak;
        private System.Windows.Forms.Timer tmrKretanjePtice;
        private System.Windows.Forms.PictureBox pbxPozadina;
        private System.Windows.Forms.Timer tmrIgra;
        private System.Windows.Forms.Timer tmrKretanjeCevi;
        private System.Windows.Forms.TextBox tbxPoeni;
    }
}

