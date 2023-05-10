namespace newAscii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ofd = new OpenFileDialog();
            convert = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            tempPic = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tempPic).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ofd
            // 
            ofd.FileName = "ofd";
            // 
            // convert
            // 
            convert.Location = new Point(111, 483);
            convert.Name = "convert";
            convert.Size = new Size(124, 56);
            convert.TabIndex = 0;
            convert.Text = "Convert";
            convert.UseVisualStyleBackColor = true;
            convert.Click += convert_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(104, 313);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.UpDownAlign = LeftRightAlignment.Left;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(104, 406);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.UpDownAlign = LeftRightAlignment.Left;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 280);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 3;
            label1.Text = "Kernel Width (W)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 370);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 4;
            label2.Text = "Kernel Height (H)";
            // 
            // tempPic
            // 
            tempPic.BorderStyle = BorderStyle.FixedSingle;
            tempPic.Location = new Point(12, 30);
            tempPic.Name = "tempPic";
            tempPic.Size = new Size(340, 225);
            tempPic.TabIndex = 6;
            tempPic.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1081, 27);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(49, 24);
            toolStripButton1.Text = "Open";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(375, 30);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(683, 509);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 568);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(tempPic);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(convert);
            Name = "Form1";
            Text = "Asciify App";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tempPic).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog ofd;
        private Button convert;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Label label2;
        private PictureBox tempPic;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private RichTextBox richTextBox1;
    }
}