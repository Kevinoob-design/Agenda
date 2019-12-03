namespace WindowsFormsApp1.View
{
    partial class ContactListRemove
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
            this.dgvCOntactListRemove = new System.Windows.Forms.DataGridView();
            this.btnREmoveContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCOntactListRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCOntactListRemove
            // 
            this.dgvCOntactListRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCOntactListRemove.Location = new System.Drawing.Point(13, 27);
            this.dgvCOntactListRemove.Name = "dgvCOntactListRemove";
            this.dgvCOntactListRemove.Size = new System.Drawing.Size(755, 158);
            this.dgvCOntactListRemove.TabIndex = 0;
            // 
            // btnREmoveContact
            // 
            this.btnREmoveContact.Location = new System.Drawing.Point(331, 207);
            this.btnREmoveContact.Name = "btnREmoveContact";
            this.btnREmoveContact.Size = new System.Drawing.Size(75, 23);
            this.btnREmoveContact.TabIndex = 1;
            this.btnREmoveContact.Text = "Remove Contact";
            this.btnREmoveContact.UseVisualStyleBackColor = true;
            this.btnREmoveContact.Click += new System.EventHandler(this.btnREmoveContact_Click);
            // 
            // ContactListRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 268);
            this.Controls.Add(this.btnREmoveContact);
            this.Controls.Add(this.dgvCOntactListRemove);
            this.Name = "ContactListRemove";
            this.Text = "ContactListRemove";
            this.Load += new System.EventHandler(this.ContactListRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCOntactListRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCOntactListRemove;
        private System.Windows.Forms.Button btnREmoveContact;
    }
}