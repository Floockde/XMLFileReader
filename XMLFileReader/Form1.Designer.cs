namespace XMLFileReader
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReadBt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SceneTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 355);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ReadBt
            // 
            this.ReadBt.Location = new System.Drawing.Point(525, 400);
            this.ReadBt.Name = "ReadBt";
            this.ReadBt.Size = new System.Drawing.Size(113, 23);
            this.ReadBt.TabIndex = 1;
            this.ReadBt.Text = "Browse and read";
            this.ReadBt.UseVisualStyleBackColor = true;
            this.ReadBt.Click += new System.EventHandler(this.ReadBt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SceneTB
            // 
            this.SceneTB.Location = new System.Drawing.Point(12, 402);
            this.SceneTB.Name = "SceneTB";
            this.SceneTB.Size = new System.Drawing.Size(100, 20);
            this.SceneTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Get scene";
            // 
            // DescBT
            // 
            this.DescBT.Location = new System.Drawing.Point(644, 399);
            this.DescBT.Name = "DescBT";
            this.DescBT.Size = new System.Drawing.Size(135, 23);
            this.DescBT.TabIndex = 4;
            this.DescBT.Text = "Get scene Description";
            this.DescBT.UseVisualStyleBackColor = true;
            this.DescBT.Click += new System.EventHandler(this.DescBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DescBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SceneTB);
            this.Controls.Add(this.ReadBt);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReadBt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox SceneTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DescBT;
    }
}

