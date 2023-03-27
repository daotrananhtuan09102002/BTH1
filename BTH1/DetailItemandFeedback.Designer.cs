namespace BTH1
{
    partial class DetailItemandFeedback
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailItemandFeedback));
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            label3 = new Label();
            richTextBox4 = new RichTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 0;
            label1.Text = "Mô tả sản phẩm";
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(3, 46);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(788, 83);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 132);
            label2.Name = "label2";
            label2.Size = new Size(487, 28);
            label2.TabIndex = 2;
            label2.Text = "Kiểu dáng thanh lịch, nhỏ gọn dễ dàng mang theo";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.White;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(3, 163);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(788, 185);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.White;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(5, 382);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(788, 213);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 351);
            label3.Name = "label3";
            label3.Size = new Size(549, 28);
            label3.TabIndex = 4;
            label3.Text = "Màn hình 15,6 inch Full HD sắc nét, trang bị tấm nền IPS";
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.White;
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(5, 629);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new Size(788, 161);
            richTextBox4.TabIndex = 7;
            richTextBox4.Text = resources.GetString("richTextBox4.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(4, 598);
            label4.Name = "label4";
            label4.Size = new Size(642, 28);
            label4.TabIndex = 6;
            label4.Text = "Hiệu năng ổn định, Intel Core i3-1115G4  cho mọi tác vụ mượt mà";
            // 
            // DetailItemandFeedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(richTextBox4);
            Controls.Add(label4);
            Controls.Add(richTextBox3);
            Controls.Add(label3);
            Controls.Add(richTextBox2);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "DetailItemandFeedback";
            Size = new Size(792, 858);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Label label3;
        private RichTextBox richTextBox4;
        private Label label4;
    }
}
