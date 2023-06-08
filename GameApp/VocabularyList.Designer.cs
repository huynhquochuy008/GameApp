namespace GameApp
{
    partial class VocabularyList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VocabularyList));
            listView = new ListView();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            tbWord = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Location = new Point(2, 2);
            listView.Name = "listView";
            listView.Size = new Size(390, 452);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // button1
            // 
            button1.Location = new Point(433, 302);
            button1.Name = "button1";
            button1.Size = new Size(149, 29);
            button1.TabIndex = 1;
            button1.Text = "Add image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbWord
            // 
            tbWord.BorderStyle = BorderStyle.FixedSingle;
            tbWord.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            tbWord.Location = new Point(433, 109);
            tbWord.Name = "tbWord";
            tbWord.Size = new Size(149, 27);
            tbWord.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(433, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 38);
            label1.TabIndex = 3;
            label1.Text = "Vocabulary Action";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(433, 78);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 4;
            label2.Text = "Add new word";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(631, 78);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 5;
            label3.Text = "Delete word";
            // 
            // button2
            // 
            button2.Location = new Point(433, 337);
            button2.Name = "button2";
            button2.Size = new Size(149, 29);
            button2.TabIndex = 6;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(631, 109);
            button3.Name = "button3";
            button3.Size = new Size(149, 29);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(810, 2);
            button4.Name = "button4";
            button4.Size = new Size(47, 36);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(858, 2);
            button5.Name = "button5";
            button5.Size = new Size(47, 36);
            button5.TabIndex = 10;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(433, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // VocabularyList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 453);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbWord);
            Controls.Add(button1);
            Controls.Add(listView);
            Name = "VocabularyList";
            Text = "VocabularyList";
            Load += VocabularyList_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private TextBox tbWord;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
    }
}