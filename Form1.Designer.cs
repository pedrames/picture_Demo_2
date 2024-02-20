namespace picture_Demo_2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.tenHPB = new System.Windows.Forms.PictureBox();
            this.kingSPB = new System.Windows.Forms.PictureBox();
            this.aceSPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tenHPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingSPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSPB)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Ace of Spades",
            "10 of Hearts",
            "King of Clubs"});
            this.listBox1.Location = new System.Drawing.Point(110, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(119, 84);
            this.listBox1.TabIndex = 3;
            // 
            // showBtn
            // 
            this.showBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.Location = new System.Drawing.Point(42, 304);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(111, 55);
            this.showBtn.TabIndex = 4;
            this.showBtn.Text = "Show Card";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(184, 304);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(111, 55);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // tenHPB
            // 
            this.tenHPB.Image = global::picture_Demo_2.Properties.Resources.OIP__2_;
            this.tenHPB.Location = new System.Drawing.Point(127, 43);
            this.tenHPB.Name = "tenHPB";
            this.tenHPB.Size = new System.Drawing.Size(88, 113);
            this.tenHPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tenHPB.TabIndex = 2;
            this.tenHPB.TabStop = false;
            this.tenHPB.Visible = false;
            // 
            // kingSPB
            // 
            this.kingSPB.Image = global::picture_Demo_2.Properties.Resources.OIP__3_;
            this.kingSPB.Location = new System.Drawing.Point(131, 43);
            this.kingSPB.Name = "kingSPB";
            this.kingSPB.Size = new System.Drawing.Size(85, 113);
            this.kingSPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingSPB.TabIndex = 1;
            this.kingSPB.TabStop = false;
            this.kingSPB.Visible = false;
            // 
            // aceSPB
            // 
            this.aceSPB.Image = global::picture_Demo_2.Properties.Resources.download__1_;
            this.aceSPB.Location = new System.Drawing.Point(131, 43);
            this.aceSPB.Name = "aceSPB";
            this.aceSPB.Size = new System.Drawing.Size(84, 113);
            this.aceSPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aceSPB.TabIndex = 0;
            this.aceSPB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 402);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tenHPB);
            this.Controls.Add(this.kingSPB);
            this.Controls.Add(this.aceSPB);
            this.Name = "Form1";
            this.Text = "Cards Demo";
            ((System.ComponentModel.ISupportInitialize)(this.tenHPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingSPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox aceSPB;
        private System.Windows.Forms.PictureBox kingSPB;
        private System.Windows.Forms.PictureBox tenHPB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

