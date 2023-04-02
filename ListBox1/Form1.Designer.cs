namespace ListBox1
{
    partial class DataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBase));
            this.peopleLBX = new System.Windows.Forms.ListBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTBX = new System.Windows.Forms.TextBox();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.surnameTBX = new System.Windows.Forms.TextBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.telLbl = new System.Windows.Forms.Label();
            this.telTBX = new System.Windows.Forms.MaskedTextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTBX = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleLBX
            // 
            this.peopleLBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.peopleLBX.FormattingEnabled = true;
            this.peopleLBX.ItemHeight = 25;
            this.peopleLBX.Location = new System.Drawing.Point(51, 40);
            this.peopleLBX.Margin = new System.Windows.Forms.Padding(4);
            this.peopleLBX.Name = "peopleLBX";
            this.peopleLBX.Size = new System.Drawing.Size(250, 379);
            this.peopleLBX.TabIndex = 0;
            this.peopleLBX.SelectedIndexChanged += new System.EventHandler(this.peopleLBX_SelectedIndexChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nameLbl.Location = new System.Drawing.Point(342, 50);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(59, 25);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            // 
            // nameTBX
            // 
            this.nameTBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nameTBX.Location = new System.Drawing.Point(439, 50);
            this.nameTBX.Margin = new System.Windows.Forms.Padding(4);
            this.nameTBX.Name = "nameTBX";
            this.nameTBX.Size = new System.Drawing.Size(155, 31);
            this.nameTBX.TabIndex = 2;
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.surnameLbl.Location = new System.Drawing.Point(342, 112);
            this.surnameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(82, 25);
            this.surnameLbl.TabIndex = 3;
            this.surnameLbl.Text = "Surname";
            // 
            // surnameTBX
            // 
            this.surnameTBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.surnameTBX.Location = new System.Drawing.Point(439, 112);
            this.surnameTBX.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTBX.Name = "surnameTBX";
            this.surnameTBX.Size = new System.Drawing.Size(155, 31);
            this.surnameTBX.TabIndex = 4;
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.Lime;
            this.addBTN.Location = new System.Drawing.Point(342, 292);
            this.addBTN.Margin = new System.Windows.Forms.Padding(4);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(118, 36);
            this.addBTN.TabIndex = 5;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // telLbl
            // 
            this.telLbl.AutoSize = true;
            this.telLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.telLbl.Location = new System.Drawing.Point(342, 174);
            this.telLbl.Name = "telLbl";
            this.telLbl.Size = new System.Drawing.Size(77, 25);
            this.telLbl.TabIndex = 6;
            this.telLbl.Text = "Tel. num";
            // 
            // telTBX
            // 
            this.telTBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.telTBX.Location = new System.Drawing.Point(439, 174);
            this.telTBX.Mask = "(999) 000-0000";
            this.telTBX.Name = "telTBX";
            this.telTBX.Size = new System.Drawing.Size(150, 31);
            this.telTBX.TabIndex = 7;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.emailLbl.Location = new System.Drawing.Point(342, 233);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(54, 25);
            this.emailLbl.TabIndex = 8;
            this.emailLbl.Text = "Email";
            // 
            // emailTBX
            // 
            this.emailTBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.emailTBX.Location = new System.Drawing.Point(439, 233);
            this.emailTBX.Name = "emailTBX";
            this.emailTBX.Size = new System.Drawing.Size(150, 31);
            this.emailTBX.TabIndex = 9;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(506, 292);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(117, 36);
            this.delete.TabIndex = 10;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.Yellow;
            this.change.Location = new System.Drawing.Point(342, 348);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(118, 36);
            this.change.TabIndex = 11;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.RoyalBlue;
            this.save.Location = new System.Drawing.Point(506, 348);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(117, 36);
            this.save.TabIndex = 12;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 444);
            this.Controls.Add(this.save);
            this.Controls.Add(this.change);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.emailTBX);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.telTBX);
            this.Controls.Add(this.telLbl);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.surnameTBX);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.nameTBX);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.peopleLBX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataBase";
            this.Text = "DataBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private ListBox peopleLBX;
        private Label nameLbl;
        private TextBox nameTBX;
        private Label surnameLbl;
        private TextBox surnameTBX;
        private Button addBTN;
        private Label telLbl;
        private MaskedTextBox telTBX;
        private Label emailLbl;
        private TextBox emailTBX;
        private Button delete;
        private Button change;
        private Button save;
    }
}