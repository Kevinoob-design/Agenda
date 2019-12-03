namespace WindowsFormsApp1.View
{
    partial class ContactList
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
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.btnAddContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContactList
            // 
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(12, 21);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.Size = new System.Drawing.Size(776, 198);
            this.dgvContactList.TabIndex = 0;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(357, 240);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(75, 23);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 273);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.dgvContactList);
            this.Name = "ContactList";
            this.Text = "ContactList";
            this.Load += new System.EventHandler(this.ContactList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.Button btnAddContact;
    }
}