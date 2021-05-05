
namespace MultiFormApps
{
    partial class Members
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
            this.components = new System.ComponentModel.Container();
            this.memberformlogo = new System.Windows.Forms.Label();
            this.membersrch = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.delbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.addmembtn = new System.Windows.Forms.Button();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.addresslbl = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.phonelbl = new System.Windows.Forms.Label();
            this.custtext = new System.Windows.Forms.TextBox();
            this.customerlbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEMBERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopbdDataSet = new MultiFormApps.shopbdDataSet();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.mEMBERTableAdapter = new MultiFormApps.shopbdDataSetTableAdapters.MEMBERTableAdapter();
            this.membersrch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopbdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // memberformlogo
            // 
            this.memberformlogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.memberformlogo.AutoSize = true;
            this.memberformlogo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberformlogo.Location = new System.Drawing.Point(341, 9);
            this.memberformlogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberformlogo.Name = "memberformlogo";
            this.memberformlogo.Size = new System.Drawing.Size(479, 36);
            this.memberformlogo.TabIndex = 2;
            this.memberformlogo.Text = "Supershop Member Registration";
            // 
            // membersrch
            // 
            this.membersrch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.membersrch.Controls.Add(this.label5);
            this.membersrch.Controls.Add(this.delbtn);
            this.membersrch.Controls.Add(this.refreshbtn);
            this.membersrch.Controls.Add(this.addmembtn);
            this.membersrch.Controls.Add(this.addresstxt);
            this.membersrch.Controls.Add(this.addresslbl);
            this.membersrch.Controls.Add(this.emailtxt);
            this.membersrch.Controls.Add(this.emaillbl);
            this.membersrch.Controls.Add(this.phonetxt);
            this.membersrch.Controls.Add(this.phonelbl);
            this.membersrch.Controls.Add(this.custtext);
            this.membersrch.Controls.Add(this.customerlbl);
            this.membersrch.Location = new System.Drawing.Point(6, 72);
            this.membersrch.Margin = new System.Windows.Forms.Padding(4);
            this.membersrch.Name = "membersrch";
            this.membersrch.Size = new System.Drawing.Size(534, 549);
            this.membersrch.TabIndex = 4;
            this.membersrch.Paint += new System.Windows.Forms.PaintEventHandler(this.membersrch_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 22;
            // 
            // delbtn
            // 
            this.delbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delbtn.BackColor = System.Drawing.Color.Red;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delbtn.Location = new System.Drawing.Point(303, 350);
            this.delbtn.Margin = new System.Windows.Forms.Padding(4);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(209, 50);
            this.delbtn.TabIndex = 10;
            this.delbtn.Text = "Remove";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(24, 261);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(209, 50);
            this.refreshbtn.TabIndex = 9;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            // 
            // addmembtn
            // 
            this.addmembtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addmembtn.BackColor = System.Drawing.Color.Green;
            this.addmembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmembtn.Location = new System.Drawing.Point(303, 261);
            this.addmembtn.Margin = new System.Windows.Forms.Padding(4);
            this.addmembtn.Name = "addmembtn";
            this.addmembtn.Size = new System.Drawing.Size(209, 50);
            this.addmembtn.TabIndex = 8;
            this.addmembtn.Text = "Add";
            this.addmembtn.UseVisualStyleBackColor = false;
            this.addmembtn.Click += new System.EventHandler(this.addmembtn_Click);
            // 
            // addresstxt
            // 
            this.addresstxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addresstxt.Location = new System.Drawing.Point(185, 167);
            this.addresstxt.Margin = new System.Windows.Forms.Padding(4);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(329, 22);
            this.addresstxt.TabIndex = 7;
            // 
            // addresslbl
            // 
            this.addresslbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addresslbl.AutoSize = true;
            this.addresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslbl.Location = new System.Drawing.Point(20, 166);
            this.addresslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(80, 24);
            this.addresslbl.TabIndex = 6;
            this.addresslbl.Text = "Address";
            // 
            // emailtxt
            // 
            this.emailtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailtxt.Location = new System.Drawing.Point(185, 78);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(329, 22);
            this.emailtxt.TabIndex = 5;
            // 
            // emaillbl
            // 
            this.emaillbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(21, 76);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(57, 24);
            this.emaillbl.TabIndex = 4;
            this.emaillbl.Text = "Email";
            // 
            // phonetxt
            // 
            this.phonetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phonetxt.Location = new System.Drawing.Point(185, 121);
            this.phonetxt.Margin = new System.Windows.Forms.Padding(4);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(329, 22);
            this.phonetxt.TabIndex = 3;
            // 
            // phonelbl
            // 
            this.phonelbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phonelbl.AutoSize = true;
            this.phonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelbl.Location = new System.Drawing.Point(20, 119);
            this.phonelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(66, 24);
            this.phonelbl.TabIndex = 2;
            this.phonelbl.Text = "Phone";
            // 
            // custtext
            // 
            this.custtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custtext.Location = new System.Drawing.Point(185, 33);
            this.custtext.Margin = new System.Windows.Forms.Padding(4);
            this.custtext.Name = "custtext";
            this.custtext.Size = new System.Drawing.Size(329, 22);
            this.custtext.TabIndex = 1;
            // 
            // customerlbl
            // 
            this.customerlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerlbl.AutoSize = true;
            this.customerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerlbl.Location = new System.Drawing.Point(20, 32);
            this.customerlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerlbl.Name = "customerlbl";
            this.customerlbl.Size = new System.Drawing.Size(147, 24);
            this.customerlbl.TabIndex = 0;
            this.customerlbl.Text = "Customer Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mEMBERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(548, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 655);
            this.dataGridView1.TabIndex = 5;
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "memberid";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "memberid";
            this.memberidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            this.memberidDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberidDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // mEMBERBindingSource
            // 
            this.mEMBERBindingSource.DataMember = "MEMBER";
            this.mEMBERBindingSource.DataSource = this.shopbdDataSet;
            // 
            // shopbdDataSet
            // 
            this.shopbdDataSet.DataSetName = "shopbdDataSet";
            this.shopbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(935, 762);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(188, 50);
            this.logoutbtn.TabIndex = 12;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // mEMBERTableAdapter
            // 
            this.mEMBERTableAdapter.ClearBeforeFill = true;
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 858);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.membersrch);
            this.Controls.Add(this.memberformlogo);
            this.Name = "Members";
            this.Text = "Members";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Members_Load);
            this.membersrch.ResumeLayout(false);
            this.membersrch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopbdDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberformlogo;
        private System.Windows.Forms.Panel membersrch;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button addmembtn;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.TextBox custtext;
        private System.Windows.Forms.Label customerlbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logoutbtn;
        private shopbdDataSet shopbdDataSet;
        private System.Windows.Forms.BindingSource mEMBERBindingSource;
        private shopbdDataSetTableAdapters.MEMBERTableAdapter mEMBERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
    }
}