namespace Library
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SFB = new System.Windows.Forms.Button();
            this.RB = new System.Windows.Forms.Button();
            this.ANB = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListBLockedUSers = new System.Windows.Forms.ListBox();
            this.SFU = new System.Windows.Forms.Button();
            this.RU = new System.Windows.Forms.Button();
            this.BU = new System.Windows.Forms.Button();
            this.CU = new System.Windows.Forms.ListBox();
            this.PR = new System.Windows.Forms.Button();
            this.EP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.SFB);
            this.groupBox1.Controls.Add(this.RB);
            this.groupBox1.Controls.Add(this.ANB);
            this.groupBox1.Controls.Add(this.CB);
            this.groupBox1.Font = new System.Drawing.Font("Exo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Wheat;
            this.groupBox1.Location = new System.Drawing.Point(183, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(284, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Books";
            // 
            // SFB
            // 
            this.SFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SFB.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SFB.Location = new System.Drawing.Point(162, 201);
            this.SFB.Margin = new System.Windows.Forms.Padding(2);
            this.SFB.Name = "SFB";
            this.SFB.Size = new System.Drawing.Size(107, 73);
            this.SFB.TabIndex = 5;
            this.SFB.Text = "Search for\r\nBook";
            this.SFB.UseVisualStyleBackColor = true;
            this.SFB.Click += new System.EventHandler(this.SFB_Click);
            // 
            // RB
            // 
            this.RB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RB.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RB.Location = new System.Drawing.Point(162, 119);
            this.RB.Margin = new System.Windows.Forms.Padding(2);
            this.RB.Name = "RB";
            this.RB.Size = new System.Drawing.Size(107, 73);
            this.RB.TabIndex = 4;
            this.RB.Text = "Remove\r\nBook";
            this.RB.UseVisualStyleBackColor = true;
            this.RB.Click += new System.EventHandler(this.RB_Click);
            // 
            // ANB
            // 
            this.ANB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ANB.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ANB.Location = new System.Drawing.Point(162, 37);
            this.ANB.Margin = new System.Windows.Forms.Padding(2);
            this.ANB.Name = "ANB";
            this.ANB.Size = new System.Drawing.Size(107, 72);
            this.ANB.TabIndex = 3;
            this.ANB.Text = "Add New\r\nBook";
            this.ANB.UseVisualStyleBackColor = true;
            this.ANB.Click += new System.EventHandler(this.ANB_Click);
            // 
            // CB
            // 
            this.CB.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB.FormattingEnabled = true;
            this.CB.ItemHeight = 21;
            this.CB.Location = new System.Drawing.Point(18, 36);
            this.CB.Margin = new System.Windows.Forms.Padding(2);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(133, 235);
            this.CB.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ListBLockedUSers);
            this.groupBox2.Controls.Add(this.SFU);
            this.groupBox2.Controls.Add(this.RU);
            this.groupBox2.Controls.Add(this.BU);
            this.groupBox2.Controls.Add(this.CU);
            this.groupBox2.Font = new System.Drawing.Font("Exo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Wheat;
            this.groupBox2.Location = new System.Drawing.Point(471, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(284, 285);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Users";
            // 
            // ListBLockedUSers
            // 
            this.ListBLockedUSers.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBLockedUSers.ForeColor = System.Drawing.Color.Red;
            this.ListBLockedUSers.FormattingEnabled = true;
            this.ListBLockedUSers.ItemHeight = 21;
            this.ListBLockedUSers.Location = new System.Drawing.Point(18, 198);
            this.ListBLockedUSers.Margin = new System.Windows.Forms.Padding(2);
            this.ListBLockedUSers.Name = "ListBLockedUSers";
            this.ListBLockedUSers.ScrollAlwaysVisible = true;
            this.ListBLockedUSers.Size = new System.Drawing.Size(133, 67);
            this.ListBLockedUSers.TabIndex = 6;
            // 
            // SFU
            // 
            this.SFU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SFU.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFU.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SFU.Location = new System.Drawing.Point(162, 37);
            this.SFU.Margin = new System.Windows.Forms.Padding(2);
            this.SFU.Name = "SFU";
            this.SFU.Size = new System.Drawing.Size(107, 73);
            this.SFU.TabIndex = 5;
            this.SFU.Text = "Search for\r\nUser";
            this.SFU.UseVisualStyleBackColor = true;
            this.SFU.Click += new System.EventHandler(this.SFU_Click);
            // 
            // RU
            // 
            this.RU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RU.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RU.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RU.Location = new System.Drawing.Point(162, 198);
            this.RU.Margin = new System.Windows.Forms.Padding(2);
            this.RU.Name = "RU";
            this.RU.Size = new System.Drawing.Size(107, 73);
            this.RU.TabIndex = 4;
            this.RU.Text = "UnBlock\r\nUser";
            this.RU.UseVisualStyleBackColor = true;
            this.RU.Click += new System.EventHandler(this.RU_Click);
            // 
            // BU
            // 
            this.BU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BU.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BU.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BU.Location = new System.Drawing.Point(162, 120);
            this.BU.Margin = new System.Windows.Forms.Padding(2);
            this.BU.Name = "BU";
            this.BU.Size = new System.Drawing.Size(107, 72);
            this.BU.TabIndex = 3;
            this.BU.Text = "Block\r\nUser\r\n";
            this.BU.UseVisualStyleBackColor = true;
            this.BU.Click += new System.EventHandler(this.BU_Click);
            // 
            // CU
            // 
            this.CU.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU.FormattingEnabled = true;
            this.CU.ItemHeight = 21;
            this.CU.Location = new System.Drawing.Point(18, 36);
            this.CU.Margin = new System.Windows.Forms.Padding(2);
            this.CU.Name = "CU";
            this.CU.ScrollAlwaysVisible = true;
            this.CU.Size = new System.Drawing.Size(133, 151);
            this.CU.TabIndex = 2;
            // 
            // PR
            // 
            this.PR.BackColor = System.Drawing.Color.Transparent;
            this.PR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PR.Font = new System.Drawing.Font("Exo", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PR.ForeColor = System.Drawing.Color.White;
            this.PR.Location = new System.Drawing.Point(183, 327);
            this.PR.Margin = new System.Windows.Forms.Padding(2);
            this.PR.Name = "PR";
            this.PR.Size = new System.Drawing.Size(284, 202);
            this.PR.TabIndex = 7;
            this.PR.Text = "Pending Requests";
            this.PR.UseVisualStyleBackColor = false;
            this.PR.Click += new System.EventHandler(this.PR_Click);
            // 
            // EP
            // 
            this.EP.BackColor = System.Drawing.Color.Transparent;
            this.EP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EP.Font = new System.Drawing.Font("Exo", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EP.ForeColor = System.Drawing.Color.White;
            this.EP.Location = new System.Drawing.Point(471, 327);
            this.EP.Margin = new System.Windows.Forms.Padding(2);
            this.EP.Name = "EP";
            this.EP.Size = new System.Drawing.Size(284, 202);
            this.EP.TabIndex = 8;
            this.EP.Text = "Edit Profile\r\n";
            this.EP.UseVisualStyleBackColor = false;
            this.EP.Click += new System.EventHandler(this.button8_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 602);
            this.Controls.Add(this.EP);
            this.Controls.Add(this.PR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox CB;
        private System.Windows.Forms.Button SFB;
        private System.Windows.Forms.Button RB;
        private System.Windows.Forms.Button ANB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SFU;
        private System.Windows.Forms.Button RU;
        private System.Windows.Forms.Button BU;
        private System.Windows.Forms.Button PR;
        private System.Windows.Forms.Button EP;
        private System.Windows.Forms.ListBox ListBLockedUSers;
        private System.Windows.Forms.ListBox CU;
    }
}