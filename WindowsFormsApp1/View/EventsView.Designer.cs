namespace View
{
    partial class EventsView
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
            this.MainEventPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MainEventPanel
            // 
            this.MainEventPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainEventPanel.Location = new System.Drawing.Point(0, 0);
            this.MainEventPanel.Name = "MainEventPanel";
            this.MainEventPanel.Size = new System.Drawing.Size(1055, 627);
            this.MainEventPanel.TabIndex = 0;
            // 
            // EventsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 627);
            this.Controls.Add(this.MainEventPanel);
            this.Name = "EventsView";
            this.Text = "EventsView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainEventPanel;
    }
}