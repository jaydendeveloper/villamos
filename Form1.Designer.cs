namespace villanyos
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
            this.fileNameBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.készítőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineLabel = new System.Windows.Forms.Label();
            this.tripLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tripTime = new System.Windows.Forms.Label();
            this.isShortestOrLongest = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileNameBtn
            // 
            this.fileNameBtn.Location = new System.Drawing.Point(12, 361);
            this.fileNameBtn.Name = "fileNameBtn";
            this.fileNameBtn.Size = new System.Drawing.Size(75, 23);
            this.fileNameBtn.TabIndex = 1;
            this.fileNameBtn.Text = "Betöltés";
            this.fileNameBtn.UseVisualStyleBackColor = true;
            this.fileNameBtn.Click += new System.EventHandler(this.fileNameBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(375, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 316);
            this.listBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.készítőToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // készítőToolStripMenuItem
            // 
            this.készítőToolStripMenuItem.Name = "készítőToolStripMenuItem";
            this.készítőToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.készítőToolStripMenuItem.Text = "Készítő";
            this.készítőToolStripMenuItem.Click += new System.EventHandler(this.készítőToolStripMenuItem_Click);
            // 
            // lineLabel
            // 
            this.lineLabel.AutoSize = true;
            this.lineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lineLabel.Location = new System.Drawing.Point(12, 42);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(0, 31);
            this.lineLabel.TabIndex = 4;
            // 
            // tripLabel
            // 
            this.tripLabel.AutoSize = true;
            this.tripLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tripLabel.Location = new System.Drawing.Point(14, 73);
            this.tripLabel.Name = "tripLabel";
            this.tripLabel.Size = new System.Drawing.Size(0, 20);
            this.tripLabel.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tripTime
            // 
            this.tripTime.AutoSize = true;
            this.tripTime.Location = new System.Drawing.Point(15, 93);
            this.tripTime.Name = "tripTime";
            this.tripTime.Size = new System.Drawing.Size(0, 13);
            this.tripTime.TabIndex = 7;
            // 
            // isShortestOrLongest
            // 
            this.isShortestOrLongest.AutoSize = true;
            this.isShortestOrLongest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.isShortestOrLongest.Location = new System.Drawing.Point(371, 359);
            this.isShortestOrLongest.Name = "isShortestOrLongest";
            this.isShortestOrLongest.Size = new System.Drawing.Size(0, 20);
            this.isShortestOrLongest.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 396);
            this.Controls.Add(this.isShortestOrLongest);
            this.Controls.Add(this.tripTime);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tripLabel);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.fileNameBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fileNameBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem készítőToolStripMenuItem;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Label tripLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label tripTime;
        private System.Windows.Forms.Label isShortestOrLongest;
    }
}

