namespace WindowsFormsApp1.View
{
    partial class Event_RelatedList
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvEventsRelated = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventsRelated)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(314, 221);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvEventsRelated
            // 
            this.dgvEventsRelated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventsRelated.Location = new System.Drawing.Point(-4, 45);
            this.dgvEventsRelated.Name = "dgvEventsRelated";
            this.dgvEventsRelated.Size = new System.Drawing.Size(754, 150);
            this.dgvEventsRelated.TabIndex = 2;
            // 
            // Event_RelatedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 289);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvEventsRelated);
            this.Name = "Event_RelatedList";
            this.Text = "Event_RelatedList";
            this.Load += new System.EventHandler(this.Event_RelatedList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventsRelated)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvEventsRelated;
    }
}