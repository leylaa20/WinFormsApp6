namespace WinFormsApp6
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_center = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_italic = new System.Windows.Forms.Button();
            this.btn_underline = new System.Windows.Forms.Button();
            this.btn_bold = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_right);
            this.panel1.Controls.Add(this.btn_center);
            this.panel1.Controls.Add(this.btn_left);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_italic);
            this.panel1.Controls.Add(this.btn_underline);
            this.panel1.Controls.Add(this.btn_bold);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 98);
            this.panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(976, 52);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 29);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(976, 14);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(94, 29);
            this.btn_load.TabIndex = 15;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(772, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Tap to enter name and save";
            this.textBox3.Size = new System.Drawing.Size(189, 27);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(772, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Enter name and load file";
            this.textBox2.Size = new System.Drawing.Size(189, 27);
            this.textBox2.TabIndex = 13;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(576, 44);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 28);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(625, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Color";
            // 
            // btn_right
            // 
            this.btn_right.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_right.Location = new System.Drawing.Point(514, 42);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(35, 29);
            this.btn_right.TabIndex = 10;
            this.btn_right.Text = "R";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_center
            // 
            this.btn_center.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_center.Location = new System.Drawing.Point(471, 42);
            this.btn_center.Name = "btn_center";
            this.btn_center.Size = new System.Drawing.Size(35, 29);
            this.btn_center.TabIndex = 9;
            this.btn_center.Text = "C";
            this.btn_center.UseVisualStyleBackColor = true;
            this.btn_center.Click += new System.EventHandler(this.btn_center_Click);
            // 
            // btn_left
            // 
            this.btn_left.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_left.Location = new System.Drawing.Point(426, 42);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(35, 29);
            this.btn_left.TabIndex = 8;
            this.btn_left.Text = "L";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(439, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alignment";
            // 
            // btn_italic
            // 
            this.btn_italic.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_italic.Location = new System.Drawing.Point(363, 42);
            this.btn_italic.Name = "btn_italic";
            this.btn_italic.Size = new System.Drawing.Size(35, 29);
            this.btn_italic.TabIndex = 6;
            this.btn_italic.Text = "I";
            this.btn_italic.UseVisualStyleBackColor = true;
            this.btn_italic.Click += new System.EventHandler(this.btn_italic_Click);
            // 
            // btn_underline
            // 
            this.btn_underline.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btn_underline.Location = new System.Drawing.Point(320, 42);
            this.btn_underline.Name = "btn_underline";
            this.btn_underline.Size = new System.Drawing.Size(35, 29);
            this.btn_underline.TabIndex = 5;
            this.btn_underline.Text = "U";
            this.btn_underline.UseVisualStyleBackColor = true;
            this.btn_underline.Click += new System.EventHandler(this.btn_underline_Click);
            // 
            // btn_bold
            // 
            this.btn_bold.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_bold.Location = new System.Drawing.Point(275, 42);
            this.btn_bold.Name = "btn_bold";
            this.btn_bold.Size = new System.Drawing.Size(35, 29);
            this.btn_bold.TabIndex = 4;
            this.btn_bold.Text = "B";
            this.btn_bold.UseVisualStyleBackColor = true;
            this.btn_bold.Click += new System.EventHandler(this.btn_bold_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(295, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "FontStyle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(170, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(170, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(48, 28);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1077, 539);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 667);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "WordPad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_save;
        private Button btn_load;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private Label label5;
        private Button btn_right;
        private Button btn_center;
        private Button btn_left;
        private Label label4;
        private Button btn_italic;
        private Button btn_underline;
        private Button btn_bold;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private OpenFileDialog openFileDialog1;
        private RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
    }
}