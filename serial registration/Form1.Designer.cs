namespace serial_registration
{
    partial class Serialdb
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seriales";
            // 
            // button1
            // 
            button1.Location = new Point(355, 103);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 2;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(349, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 73);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crear - Eliminar";
            // 
            // button2
            // 
            button2.Location = new Point(485, 103);
            button2.Name = "button2";
            button2.Size = new Size(118, 23);
            button2.TabIndex = 4;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InfoText;
            richTextBox1.ForeColor = SystemColors.MenuBar;
            richTextBox1.Location = new Point(373, 233);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(327, 242);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // Serialdb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 531);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Serialdb";
            Text = "Chiwiro Panel";
            Load += Serialdb_Load;
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
        private RichTextBox richTextBox1;
    }
}
