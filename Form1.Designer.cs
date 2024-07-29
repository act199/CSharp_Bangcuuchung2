namespace CSharp_Bangcuuchung2
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
            label1 = new Label();
            lblketqua = new Label();
            btnxem = new Button();
            btnxemlai = new Button();
            txtso = new TextBox();
            listBox1 = new ListBox();
            nudso = new DomainUpDown();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 114);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Chọn bảng cửu chương";
            // 
            // lblketqua
            // 
            lblketqua.AutoSize = true;
            lblketqua.Location = new Point(147, 151);
            lblketqua.Name = "lblketqua";
            lblketqua.Size = new Size(47, 15);
            lblketqua.TabIndex = 1;
            lblketqua.Text = "Kết quả";
            // 
            // btnxem
            // 
            btnxem.Location = new Point(545, 111);
            btnxem.Name = "btnxem";
            btnxem.Size = new Size(75, 23);
            btnxem.TabIndex = 2;
            btnxem.Text = "xem";
            btnxem.UseVisualStyleBackColor = true;
            btnxem.Click += btnxem_Click;
            // 
            // btnxemlai
            // 
            btnxemlai.Location = new Point(545, 151);
            btnxemlai.Name = "btnxemlai";
            btnxemlai.Size = new Size(75, 23);
            btnxemlai.TabIndex = 3;
            btnxemlai.Text = "Xem lại";
            btnxemlai.UseVisualStyleBackColor = true;
            // 
            // txtso
            // 
            txtso.Location = new Point(261, 111);
            txtso.Name = "txtso";
            txtso.Size = new Size(100, 23);
            txtso.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(489, 240);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 5;
            // 
            // nudso
            // 
            nudso.Location = new Point(385, 112);
            nudso.Name = "nudso";
            nudso.Size = new Size(120, 23);
            nudso.TabIndex = 6;
            nudso.SelectedItemChanged += nudso_SelectedItemChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudso);
            Controls.Add(listBox1);
            Controls.Add(txtso);
            Controls.Add(btnxemlai);
            Controls.Add(btnxem);
            Controls.Add(lblketqua);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblketqua;
        private Button btnxem;
        private Button btnxemlai;
        private TextBox txtso;
        private ListBox listBox1;
        private DomainUpDown nudso;
    }
}
