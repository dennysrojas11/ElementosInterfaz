namespace WinAppElementosInterfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menú1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMostrarImagen = new System.Windows.Forms.Button();
            this.comboBoxPunteros = new System.Windows.Forms.ComboBox();
            this.groupBoxSonidos = new System.Windows.Forms.GroupBox();
            this.buttonPregunta = new System.Windows.Forms.Button();
            this.buttonMano = new System.Windows.Forms.Button();
            this.buttonExclamacion = new System.Windows.Forms.Button();
            this.buttonAsterisco = new System.Windows.Forms.Button();
            this.buttonBeep = new System.Windows.Forms.Button();
            this.labelCursores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSonidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menú1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menú1ToolStripMenuItem
            // 
            this.menú1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menú1ToolStripMenuItem.Name = "menú1ToolStripMenuItem";
            this.menú1ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.menú1ToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // buttonMostrarImagen
            // 
            this.buttonMostrarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarImagen.Location = new System.Drawing.Point(397, 52);
            this.buttonMostrarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMostrarImagen.Name = "buttonMostrarImagen";
            this.buttonMostrarImagen.Size = new System.Drawing.Size(184, 54);
            this.buttonMostrarImagen.TabIndex = 1;
            this.buttonMostrarImagen.Text = "Mostrar Imagen";
            this.buttonMostrarImagen.UseVisualStyleBackColor = true;
            this.buttonMostrarImagen.Click += new System.EventHandler(this.buttonMostrarImagen_Click);
            // 
            // comboBoxPunteros
            // 
            this.comboBoxPunteros.FormattingEnabled = true;
            this.comboBoxPunteros.Items.AddRange(new object[] {
            "Mano",
            "Esperar",
            "Flecha"});
            this.comboBoxPunteros.Location = new System.Drawing.Point(48, 311);
            this.comboBoxPunteros.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPunteros.Name = "comboBoxPunteros";
            this.comboBoxPunteros.Size = new System.Drawing.Size(313, 21);
            this.comboBoxPunteros.TabIndex = 3;
            this.comboBoxPunteros.SelectedIndexChanged += new System.EventHandler(this.comboBoxPunteros_SelectedIndexChanged);
            // 
            // groupBoxSonidos
            // 
            this.groupBoxSonidos.Controls.Add(this.buttonPregunta);
            this.groupBoxSonidos.Controls.Add(this.buttonMano);
            this.groupBoxSonidos.Controls.Add(this.buttonExclamacion);
            this.groupBoxSonidos.Controls.Add(this.buttonAsterisco);
            this.groupBoxSonidos.Controls.Add(this.buttonBeep);
            this.groupBoxSonidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSonidos.Location = new System.Drawing.Point(38, 52);
            this.groupBoxSonidos.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSonidos.Name = "groupBoxSonidos";
            this.groupBoxSonidos.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSonidos.Size = new System.Drawing.Size(313, 141);
            this.groupBoxSonidos.TabIndex = 4;
            this.groupBoxSonidos.TabStop = false;
            this.groupBoxSonidos.Text = "Sonidos";
            // 
            // buttonPregunta
            // 
            this.buttonPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPregunta.Location = new System.Drawing.Point(175, 93);
            this.buttonPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPregunta.Name = "buttonPregunta";
            this.buttonPregunta.Size = new System.Drawing.Size(61, 28);
            this.buttonPregunta.TabIndex = 4;
            this.buttonPregunta.Text = "Pregunta";
            this.buttonPregunta.UseVisualStyleBackColor = true;
            this.buttonPregunta.Click += new System.EventHandler(this.buttonPregunta_Click);
            // 
            // buttonMano
            // 
            this.buttonMano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMano.Location = new System.Drawing.Point(63, 93);
            this.buttonMano.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMano.Name = "buttonMano";
            this.buttonMano.Size = new System.Drawing.Size(61, 28);
            this.buttonMano.TabIndex = 3;
            this.buttonMano.Text = "Mano";
            this.buttonMano.UseVisualStyleBackColor = true;
            this.buttonMano.Click += new System.EventHandler(this.buttonMano_Click);
            // 
            // buttonExclamacion
            // 
            this.buttonExclamacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExclamacion.Location = new System.Drawing.Point(215, 34);
            this.buttonExclamacion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExclamacion.Name = "buttonExclamacion";
            this.buttonExclamacion.Size = new System.Drawing.Size(85, 28);
            this.buttonExclamacion.TabIndex = 2;
            this.buttonExclamacion.Text = "Exclamación";
            this.buttonExclamacion.UseVisualStyleBackColor = true;
            this.buttonExclamacion.Click += new System.EventHandler(this.buttonExclamacion_Click);
            // 
            // buttonAsterisco
            // 
            this.buttonAsterisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsterisco.Location = new System.Drawing.Point(122, 34);
            this.buttonAsterisco.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAsterisco.Name = "buttonAsterisco";
            this.buttonAsterisco.Size = new System.Drawing.Size(61, 28);
            this.buttonAsterisco.TabIndex = 1;
            this.buttonAsterisco.Text = "Asterisco";
            this.buttonAsterisco.UseVisualStyleBackColor = true;
            this.buttonAsterisco.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBeep
            // 
            this.buttonBeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeep.Location = new System.Drawing.Point(14, 34);
            this.buttonBeep.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBeep.Name = "buttonBeep";
            this.buttonBeep.Size = new System.Drawing.Size(61, 28);
            this.buttonBeep.TabIndex = 0;
            this.buttonBeep.Text = "Beep";
            this.buttonBeep.UseVisualStyleBackColor = true;
            this.buttonBeep.Click += new System.EventHandler(this.buttonBeep_Click);
            // 
            // labelCursores
            // 
            this.labelCursores.AutoSize = true;
            this.labelCursores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursores.Location = new System.Drawing.Point(48, 277);
            this.labelCursores.Name = "labelCursores";
            this.labelCursores.Size = new System.Drawing.Size(94, 24);
            this.labelCursores.TabIndex = 5;
            this.labelCursores.Text = "Cursores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppElementosInterfaz.Properties.Resources.altavoz;
            this.pictureBox1.Location = new System.Drawing.Point(142, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Image = global::WinAppElementosInterfaz.Properties.Resources.xps_ocAuPlfZXEc_unsplash;
            this.pictureBoxImagen.Location = new System.Drawing.Point(397, 126);
            this.pictureBoxImagen.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(184, 150);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 2;
            this.pictureBoxImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCursores);
            this.Controls.Add(this.groupBoxSonidos);
            this.Controls.Add(this.comboBoxPunteros);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.buttonMostrarImagen);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Elementos de la interfaz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSonidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menú1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button buttonMostrarImagen;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.ComboBox comboBoxPunteros;
        private System.Windows.Forms.GroupBox groupBoxSonidos;
        private System.Windows.Forms.Button buttonBeep;
        private System.Windows.Forms.Button buttonAsterisco;
        private System.Windows.Forms.Button buttonExclamacion;
        private System.Windows.Forms.Button buttonMano;
        private System.Windows.Forms.Button buttonPregunta;
        private System.Windows.Forms.Label labelCursores;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

