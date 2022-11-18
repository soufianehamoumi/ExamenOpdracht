namespace hotel_management
{
    partial class StaffInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Staffnumlbl = new System.Windows.Forms.TextBox();
            this.Staffnamelbl = new System.Windows.Forms.TextBox();
            this.Staffidtbl = new System.Windows.Forms.TextBox();
            this.Staffcountrytb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fresh = new System.Windows.Forms.Button();
            this.searchStaff = new System.Windows.Forms.TextBox();
            this.StaffGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Staffbtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.passwordlbl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 1;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Datelbl.Location = new System.Drawing.Point(622, 73);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(43, 18);
            this.Datelbl.TabIndex = 1;
            this.Datelbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(329, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Info";
            // 
            // Staffnumlbl
            // 
            this.Staffnumlbl.Location = new System.Drawing.Point(16, 291);
            this.Staffnumlbl.Name = "Staffnumlbl";
            this.Staffnumlbl.Size = new System.Drawing.Size(121, 23);
            this.Staffnumlbl.TabIndex = 20;
            // 
            // Staffnamelbl
            // 
            this.Staffnamelbl.Location = new System.Drawing.Point(16, 221);
            this.Staffnamelbl.Name = "Staffnamelbl";
            this.Staffnamelbl.Size = new System.Drawing.Size(121, 23);
            this.Staffnamelbl.TabIndex = 19;
            // 
            // Staffidtbl
            // 
            this.Staffidtbl.Location = new System.Drawing.Point(16, 148);
            this.Staffidtbl.Name = "Staffidtbl";
            this.Staffidtbl.Size = new System.Drawing.Size(121, 23);
            this.Staffidtbl.TabIndex = 18;
            // 
            // Staffcountrytb
            // 
            this.Staffcountrytb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Staffcountrytb.FormattingEnabled = true;
            this.Staffcountrytb.Items.AddRange(new object[] {
            "male ",
            "female"});
            this.Staffcountrytb.Location = new System.Drawing.Point(16, 357);
            this.Staffcountrytb.Name = "Staffcountrytb";
            this.Staffcountrytb.Size = new System.Drawing.Size(139, 23);
            this.Staffcountrytb.TabIndex = 17;
            this.Staffcountrytb.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Staff num";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Staff Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(16, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Staff id";
            // 
            // fresh
            // 
            this.fresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.fresh.ForeColor = System.Drawing.Color.Brown;
            this.fresh.Location = new System.Drawing.Point(650, 130);
            this.fresh.Name = "fresh";
            this.fresh.Size = new System.Drawing.Size(41, 23);
            this.fresh.TabIndex = 24;
            this.fresh.Text = "fresh";
            this.fresh.UseVisualStyleBackColor = false;
            this.fresh.Click += new System.EventHandler(this.fresh_Click);
            // 
            // searchStaff
            // 
            this.searchStaff.Location = new System.Drawing.Point(467, 128);
            this.searchStaff.Name = "searchStaff";
            this.searchStaff.Size = new System.Drawing.Size(100, 23);
            this.searchStaff.TabIndex = 23;
            // 
            // StaffGridView1
            // 
            this.StaffGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGridView1.Location = new System.Drawing.Point(329, 159);
            this.StaffGridView1.Name = "StaffGridView1";
            this.StaffGridView1.RowTemplate.Height = 25;
            this.StaffGridView1.Size = new System.Drawing.Size(393, 279);
            this.StaffGridView1.TabIndex = 22;
            this.StaffGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(573, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 30);
            this.button4.TabIndex = 21;
            this.button4.Text = "SEARCH";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Deletebtn.Location = new System.Drawing.Point(125, 408);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(53, 30);
            this.Deletebtn.TabIndex = 27;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Staffbtn
            // 
            this.Staffbtn.FlatAppearance.BorderSize = 0;
            this.Staffbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staffbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Staffbtn.Location = new System.Drawing.Point(56, 408);
            this.Staffbtn.Name = "Staffbtn";
            this.Staffbtn.Size = new System.Drawing.Size(63, 30);
            this.Staffbtn.TabIndex = 26;
            this.Staffbtn.Text = "EDIT";
            this.Staffbtn.UseVisualStyleBackColor = true;
            this.Staffbtn.Click += new System.EventHandler(this.Staffbtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AddBtn.Location = new System.Drawing.Point(7, 408);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(53, 30);
            this.AddBtn.TabIndex = 25;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // passwordlbl
            // 
            this.passwordlbl.Location = new System.Drawing.Point(176, 148);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(121, 23);
            this.passwordlbl.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(176, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Staff password";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 64);
            this.button1.TabIndex = 45;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Staffbtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.fresh);
            this.Controls.Add(this.searchStaff);
            this.Controls.Add(this.StaffGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Staffnumlbl);
            this.Controls.Add(this.Staffnamelbl);
            this.Controls.Add(this.Staffidtbl);
            this.Controls.Add(this.Staffcountrytb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "StaffInfo";
            this.Text = "StaffInfo";
            this.Load += new System.EventHandler(this.StaffInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label Datelbl;
        private Label label1;
        private TextBox Staffnumlbl;
        private TextBox Staffnamelbl;
        private TextBox Staffidtbl;
        private ComboBox Staffcountrytb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button fresh;
        private TextBox searchStaff;
        private DataGridView StaffGridView1;
        private Button button4;
        private Button Deletebtn;
        private Button Staffbtn;
        private Button AddBtn;
        private TextBox passwordlbl;
        private Label label5;
        private Button button1;
    }
}