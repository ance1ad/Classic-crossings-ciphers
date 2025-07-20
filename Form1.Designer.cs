namespace Cipher
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
        public void InitializeComponent()
        {
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            keyBox = new TextBox();
            keyLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            warningLabel = new Label();
            button4 = new Button();
            button3 = new Button();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            warningText = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(91, 10);
            label5.Name = "label5";
            label5.Size = new Size(105, 24);
            label5.TabIndex = 4;
            label5.Text = "ваш текст:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 36);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(263, 384);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(565, 36);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(263, 384);
            textBox2.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(565, 10);
            label8.Name = "label8";
            label8.Size = new Size(268, 24);
            label8.TabIndex = 4;
            label8.Text = "шифрование/дешифрование";
            // 
            // keyBox
            // 
            keyBox.Location = new Point(370, 172);
            keyBox.Margin = new Padding(3, 2, 3, 2);
            keyBox.Name = "keyBox";
            keyBox.Size = new Size(133, 23);
            keyBox.TabIndex = 6;
            keyBox.Visible = false;
            keyBox.TextChanged += textBox3_TextChanged;
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(320, 174);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(38, 15);
            keyLabel.TabIndex = 7;
            keyLabel.Text = "Ключ";
            keyLabel.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(304, 271);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 22);
            button1.TabIndex = 8;
            button1.Text = "Шифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(419, 271);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(102, 22);
            button2.TabIndex = 8;
            button2.Text = "Дешифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(320, 45);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(122, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Шифр изгородью";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(320, 68);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(108, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Шифр ключом";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // warningLabel
            // 
            warningLabel.AutoSize = true;
            warningLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            warningLabel.Location = new Point(290, 210);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(0, 15);
            warningLabel.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(565, 422);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(262, 22);
            button4.TabIndex = 8;
            button4.Text = "Загрузить в файл";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(10, 423);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(262, 20);
            button3.TabIndex = 10;
            button3.Text = "Загрузить из файла";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(320, 90);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(169, 19);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Комбинированный шифр";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(320, 112);
            radioButton4.Margin = new Padding(3, 2, 3, 2);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(150, 19);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "Двойная перестановка";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // warningText
            // 
            warningText.AutoSize = true;
            warningText.ForeColor = Color.Brown;
            warningText.Location = new Point(320, 376);
            warningText.Name = "warningText";
            warningText.Size = new Size(0, 15);
            warningText.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 453);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 14;
            label1.Text = "Длина текста: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(920, 472);
            Controls.Add(label1);
            Controls.Add(warningText);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(button3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(keyLabel);
            Controls.Add(keyBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(warningLabel);
            HelpButton = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Шифрование";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label label5;
        public TextBox textBox1;
        public TextBox textBox2;
        public Label label8;
        public TextBox keyBox;
        public Label keyLabel;
        public Button button1;
        public Button button2;
        public RadioButton radioButton1;
        public RadioButton radioButton2;
        public Label warningLabel;
        public Button button4;
        public Button button3;
        public RadioButton radioButton3;
        public RadioButton radioButton4;
        public Label warningText;
        private Label label1;
    }
}