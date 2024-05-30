namespace MainChiwiro
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.obfuscar = new MaterialSkin.Controls.MaterialButton();
            this.path = new MaterialSkin.Controls.MaterialTextBox();
            this.loadfile = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.log_text = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codepro = new System.Windows.Forms.RichTextBox();
            this.original_code = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // obfuscar
            // 
            this.obfuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.obfuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.obfuscar.Depth = 0;
            this.obfuscar.HighEmphasis = true;
            this.obfuscar.Icon = null;
            this.obfuscar.Location = new System.Drawing.Point(516, 204);
            this.obfuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.obfuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.obfuscar.Name = "obfuscar";
            this.obfuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.obfuscar.Size = new System.Drawing.Size(96, 36);
            this.obfuscar.TabIndex = 1;
            this.obfuscar.Text = "Obfuscar";
            this.obfuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.obfuscar.UseAccentColor = false;
            this.obfuscar.UseVisualStyleBackColor = true;
            this.obfuscar.Click += new System.EventHandler(this.obfuscar_Click);
            // 
            // path
            // 
            this.path.AnimateReadOnly = false;
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.path.Depth = 0;
            this.path.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.path.LeadingIcon = null;
            this.path.Location = new System.Drawing.Point(244, 145);
            this.path.MaxLength = 50;
            this.path.MouseState = MaterialSkin.MouseState.OUT;
            this.path.Multiline = false;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(368, 50);
            this.path.TabIndex = 2;
            this.path.Text = "";
            this.path.TrailingIcon = null;
            // 
            // loadfile
            // 
            this.loadfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadfile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loadfile.Depth = 0;
            this.loadfile.HighEmphasis = true;
            this.loadfile.Icon = null;
            this.loadfile.Location = new System.Drawing.Point(244, 204);
            this.loadfile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loadfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadfile.Name = "loadfile";
            this.loadfile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loadfile.Size = new System.Drawing.Size(145, 36);
            this.loadfile.TabIndex = 3;
            this.loadfile.Text = "Cargar Archivo";
            this.loadfile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loadfile.UseAccentColor = false;
            this.loadfile.UseVisualStyleBackColor = true;
            this.loadfile.Click += new System.EventHandler(this.loadfile_Click);
            // 
            // log_text
            // 
            this.log_text.Location = new System.Drawing.Point(247, 265);
            this.log_text.Name = "log_text";
            this.log_text.Size = new System.Drawing.Size(364, 159);
            this.log_text.TabIndex = 4;
            this.log_text.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.codepro);
            this.groupBox1.Controls.Add(this.original_code);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(649, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 441);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decompilador";
            // 
            // codepro
            // 
            this.codepro.Location = new System.Drawing.Point(455, 87);
            this.codepro.Name = "codepro";
            this.codepro.Size = new System.Drawing.Size(409, 332);
            this.codepro.TabIndex = 1;
            this.codepro.Text = "";
            // 
            // original_code
            // 
            this.original_code.Location = new System.Drawing.Point(24, 87);
            this.original_code.Name = "original_code";
            this.original_code.Size = new System.Drawing.Size(409, 332);
            this.original_code.TabIndex = 0;
            this.original_code.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(21, 47);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Codigo Original";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(452, 47);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Codigo Protegido";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.log_text);
            this.Controls.Add(this.loadfile);
            this.Controls.Add(this.path);
            this.Controls.Add(this.obfuscar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Obfuscador Chiguiro";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton obfuscar;
        private MaterialSkin.Controls.MaterialTextBox path;
        private MaterialSkin.Controls.MaterialButton loadfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox log_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox codepro;
        private System.Windows.Forms.RichTextBox original_code;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

