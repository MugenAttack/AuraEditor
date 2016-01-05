namespace AuraEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAuraList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBStart = new System.Windows.Forms.TextBox();
            this.txtBLoop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBEnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKiCharge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkiMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHenshinStart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHenshinEnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkInf = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.cbChar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // cbAuraList
            // 
            this.cbAuraList.FormattingEnabled = true;
            this.cbAuraList.Location = new System.Drawing.Point(13, 33);
            this.cbAuraList.Name = "cbAuraList";
            this.cbAuraList.Size = new System.Drawing.Size(143, 21);
            this.cbAuraList.TabIndex = 0;
            this.cbAuraList.SelectedIndexChanged += new System.EventHandler(this.cbAuraList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Boost Start";
            // 
            // txtBStart
            // 
            this.txtBStart.Location = new System.Drawing.Point(13, 87);
            this.txtBStart.Name = "txtBStart";
            this.txtBStart.Size = new System.Drawing.Size(143, 20);
            this.txtBStart.TabIndex = 3;
            this.txtBStart.TextChanged += new System.EventHandler(this.txtBStart_TextChanged);
            // 
            // txtBLoop
            // 
            this.txtBLoop.Location = new System.Drawing.Point(162, 87);
            this.txtBLoop.Name = "txtBLoop";
            this.txtBLoop.Size = new System.Drawing.Size(143, 20);
            this.txtBLoop.TabIndex = 5;
            this.txtBLoop.TextChanged += new System.EventHandler(this.txtBLoop_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(159, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Boost Loop";
            // 
            // txtBEnd
            // 
            this.txtBEnd.Location = new System.Drawing.Point(13, 131);
            this.txtBEnd.Name = "txtBEnd";
            this.txtBEnd.Size = new System.Drawing.Size(143, 20);
            this.txtBEnd.TabIndex = 7;
            this.txtBEnd.TextChanged += new System.EventHandler(this.txtBEnd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Boost End";
            // 
            // txtKiCharge
            // 
            this.txtKiCharge.Location = new System.Drawing.Point(162, 131);
            this.txtKiCharge.Name = "txtKiCharge";
            this.txtKiCharge.Size = new System.Drawing.Size(143, 20);
            this.txtKiCharge.TabIndex = 9;
            this.txtKiCharge.TextChanged += new System.EventHandler(this.txtKiCharge_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(159, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kiai Charge (Ki Charge)";
            // 
            // txtkiMax
            // 
            this.txtkiMax.Location = new System.Drawing.Point(13, 177);
            this.txtkiMax.Name = "txtkiMax";
            this.txtkiMax.Size = new System.Drawing.Size(143, 20);
            this.txtkiMax.TabIndex = 11;
            this.txtkiMax.TextChanged += new System.EventHandler(this.txtkiMax_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kiryoku Max (Ki Max)";
            // 
            // txtHenshinStart
            // 
            this.txtHenshinStart.Location = new System.Drawing.Point(162, 177);
            this.txtHenshinStart.Name = "txtHenshinStart";
            this.txtHenshinStart.Size = new System.Drawing.Size(143, 20);
            this.txtHenshinStart.TabIndex = 13;
            this.txtHenshinStart.TextChanged += new System.EventHandler(this.txtHenshinStart_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(159, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Henshin Start(Transform Start)";
            // 
            // txtHenshinEnd
            // 
            this.txtHenshinEnd.Location = new System.Drawing.Point(87, 223);
            this.txtHenshinEnd.Name = "txtHenshinEnd";
            this.txtHenshinEnd.Size = new System.Drawing.Size(143, 20);
            this.txtHenshinEnd.TabIndex = 15;
            this.txtHenshinEnd.TextChanged += new System.EventHandler(this.txtHenshinEnd_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(87, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Henshin End(Transform End)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 21);
            this.button2.TabIndex = 17;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBLoop);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtBEnd);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHenshinEnd);
            this.groupBox1.Controls.Add(this.txtKiCharge);
            this.groupBox1.Controls.Add(this.txtBStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbAuraList);
            this.groupBox1.Controls.Add(this.txtkiMax);
            this.groupBox1.Controls.Add(this.txtHenshinStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(320, 257);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aura Editor";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkInf);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.labelID);
            this.groupBox2.Controls.Add(this.cbChar);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(320, 117);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Character Aura Changer";
            // 
            // chkInf
            // 
            this.chkInf.AutoSize = true;
            this.chkInf.BackColor = System.Drawing.Color.White;
            this.chkInf.Location = new System.Drawing.Point(188, 87);
            this.chkInf.Name = "chkInf";
            this.chkInf.Size = new System.Drawing.Size(77, 17);
            this.chkInf.TabIndex = 10;
            this.chkInf.Text = "Infinite flag";
            this.chkInf.UseVisualStyleBackColor = false;
            this.chkInf.CheckedChanged += new System.EventHandler(this.chkInf_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(13, 85);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(143, 20);
            this.txtID.TabIndex = 9;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(10, 69);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(43, 13);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "Aura ID";
            // 
            // cbChar
            // 
            this.cbChar.FormattingEnabled = true;
            this.cbChar.Location = new System.Drawing.Point(13, 40);
            this.cbChar.Name = "cbChar";
            this.cbChar.Size = new System.Drawing.Size(292, 21);
            this.cbChar.TabIndex = 2;
            this.cbChar.SelectedIndexChanged += new System.EventHandler(this.cbChar_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Character -  Costume #";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AuraEditor.Properties.Resources._033380;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Aura Tool 1.0.1 by MugenAttack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHenshinEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHenshinStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtkiMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKiCharge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBLoop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAuraList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkInf;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox cbChar;
        private System.Windows.Forms.Label label9;
    }
}

