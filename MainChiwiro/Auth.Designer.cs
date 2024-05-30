namespace MainChiwiro
{
    partial class Auth
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.Serial = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Ingresar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.Serial);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(391, 104);
            this.materialCard1.TabIndex = 0;
            // 
            // Serial
            // 
            this.Serial.AnimateReadOnly = false;
            this.Serial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Serial.Depth = 0;
            this.Serial.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Serial.HideSelection = true;
            this.Serial.LeadingIcon = null;
            this.Serial.Location = new System.Drawing.Point(84, 27);
            this.Serial.MaxLength = 32767;
            this.Serial.MouseState = MaterialSkin.MouseState.OUT;
            this.Serial.Name = "Serial";
            this.Serial.PasswordChar = '\0';
            this.Serial.PrefixSuffixText = null;
            this.Serial.ReadOnly = false;
            this.Serial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Serial.SelectedText = "";
            this.Serial.SelectionLength = 0;
            this.Serial.SelectionStart = 0;
            this.Serial.ShortcutsEnabled = true;
            this.Serial.Size = new System.Drawing.Size(250, 48);
            this.Serial.TabIndex = 0;
            this.Serial.TabStop = false;
            this.Serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Serial.TrailingIcon = null;
            this.Serial.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(37, 43);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Serial";
            // 
            // Ingresar
            // 
            this.Ingresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ingresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Ingresar.Depth = 0;
            this.Ingresar.HighEmphasis = true;
            this.Ingresar.Icon = null;
            this.Ingresar.Location = new System.Drawing.Point(181, 202);
            this.Ingresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Ingresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Ingresar.Size = new System.Drawing.Size(91, 36);
            this.Ingresar.TabIndex = 1;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Ingresar.UseAccentColor = false;
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 275);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.materialCard1);
            this.Name = "Auth";
            this.Text = "Auth";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 Serial;
        private MaterialSkin.Controls.MaterialButton Ingresar;
    }
}