namespace Library
{
    partial class pending_requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pending_requests));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dec = new System.Windows.Forms.Button();
            this.App = new System.Windows.Forms.Button();
            this.PR = new System.Windows.Forms.ListBox();
            this.RD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Dec);
            this.groupBox1.Controls.Add(this.App);
            this.groupBox1.Controls.Add(this.PR);
            this.groupBox1.Font = new System.Drawing.Font("Exo", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(691, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Requests";
            // 
            // Dec
            // 
            this.Dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dec.Font = new System.Drawing.Font("Exo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dec.Location = new System.Drawing.Point(16, 122);
            this.Dec.Margin = new System.Windows.Forms.Padding(2);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(102, 55);
            this.Dec.TabIndex = 2;
            this.Dec.Text = "Decline";
            this.Dec.UseVisualStyleBackColor = true;
            this.Dec.Click += new System.EventHandler(this.Dec_Click);
            // 
            // App
            // 
            this.App.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.App.Font = new System.Drawing.Font("Exo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App.Location = new System.Drawing.Point(16, 47);
            this.App.Margin = new System.Windows.Forms.Padding(2);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(102, 55);
            this.App.TabIndex = 1;
            this.App.Text = "Approve";
            this.App.UseVisualStyleBackColor = true;
            this.App.Click += new System.EventHandler(this.button1_Click);
            // 
            // PR
            // 
            this.PR.Font = new System.Drawing.Font("Exo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PR.FormattingEnabled = true;
            this.PR.ItemHeight = 24;
            this.PR.Location = new System.Drawing.Point(130, 42);
            this.PR.Margin = new System.Windows.Forms.Padding(2);
            this.PR.Name = "PR";
            this.PR.Size = new System.Drawing.Size(267, 316);
            this.PR.TabIndex = 0;
            // 
            // RD
            // 
            this.RD.Location = new System.Drawing.Point(425, 61);
            this.RD.Margin = new System.Windows.Forms.Padding(2);
            this.RD.Name = "RD";
            this.RD.Size = new System.Drawing.Size(247, 43);
            this.RD.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Return Date";
            // 
            // pending_requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 406);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "pending_requests";
            this.Text = "pending_requests";
            this.Load += new System.EventHandler(this.pending_requests_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Dec;
        private System.Windows.Forms.Button App;
        private System.Windows.Forms.ListBox PR;
        private System.Windows.Forms.TextBox RD;
        private System.Windows.Forms.Label label2;
    }
}