
namespace MultiFormApps
{
    partial class delete
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
            this.memdellbl = new System.Windows.Forms.Label();
            this.deltext = new System.Windows.Forms.TextBox();
            this.delconfbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memdellbl
            // 
            this.memdellbl.AutoSize = true;
            this.memdellbl.Location = new System.Drawing.Point(76, 107);
            this.memdellbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memdellbl.Name = "memdellbl";
            this.memdellbl.Size = new System.Drawing.Size(118, 17);
            this.memdellbl.TabIndex = 0;
            this.memdellbl.Text = "Enter Member ID:";
            // 
            // deltext
            // 
            this.deltext.Location = new System.Drawing.Point(219, 103);
            this.deltext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deltext.Name = "deltext";
            this.deltext.Size = new System.Drawing.Size(255, 22);
            this.deltext.TabIndex = 1;
            // 
            // delconfbtn
            // 
            this.delconfbtn.Location = new System.Drawing.Point(375, 162);
            this.delconfbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delconfbtn.Name = "delconfbtn";
            this.delconfbtn.Size = new System.Drawing.Size(100, 28);
            this.delconfbtn.TabIndex = 2;
            this.delconfbtn.Text = "Confirm";
            this.delconfbtn.UseVisualStyleBackColor = true;
            this.delconfbtn.Click += new System.EventHandler(this.delconfbtn_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 256);
            this.Controls.Add(this.delconfbtn);
            this.Controls.Add(this.deltext);
            this.Controls.Add(this.memdellbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "delete";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Member";
            this.Load += new System.EventHandler(this.delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memdellbl;
        private System.Windows.Forms.TextBox deltext;
        private System.Windows.Forms.Button delconfbtn;
    }
}