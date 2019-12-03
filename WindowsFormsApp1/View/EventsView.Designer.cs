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
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PanelTittlePriority = new System.Windows.Forms.TableLayoutPanel();
            this.lblTittlePriority = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.PanelStartEndHours = new System.Windows.Forms.TableLayoutPanel();
            this.lblStartHour = new System.Windows.Forms.Label();
            this.lblEndHour = new System.Windows.Forms.Label();
            this.PanelDueDateNewEvent = new System.Windows.Forms.TableLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.MainPanel.SuspendLayout();
            this.PanelTittlePriority.SuspendLayout();
            this.PanelStartEndHours.SuspendLayout();
            this.PanelDueDateNewEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.PanelTittlePriority, 0, 0);
            this.MainPanel.Controls.Add(this.lblLocation, 0, 1);
            this.MainPanel.Controls.Add(this.PanelStartEndHours, 0, 3);
            this.MainPanel.Controls.Add(this.PanelDueDateNewEvent, 0, 2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 4;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainPanel.Size = new System.Drawing.Size(635, 422);
            this.MainPanel.TabIndex = 1;
            // 
            // PanelTittlePriority
            // 
            this.PanelTittlePriority.ColumnCount = 2;
            this.PanelTittlePriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.PanelTittlePriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PanelTittlePriority.Controls.Add(this.lblTittlePriority, 0, 0);
            this.PanelTittlePriority.Controls.Add(this.lblPriority, 1, 0);
            this.PanelTittlePriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTittlePriority.Location = new System.Drawing.Point(3, 3);
            this.PanelTittlePriority.Name = "PanelTittlePriority";
            this.PanelTittlePriority.RowCount = 1;
            this.PanelTittlePriority.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTittlePriority.Size = new System.Drawing.Size(629, 44);
            this.PanelTittlePriority.TabIndex = 0;
            // 
            // lblTittlePriority
            // 
            this.lblTittlePriority.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTittlePriority.AutoSize = true;
            this.lblTittlePriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittlePriority.Location = new System.Drawing.Point(3, 0);
            this.lblTittlePriority.Name = "lblTittlePriority";
            this.lblTittlePriority.Size = new System.Drawing.Size(497, 44);
            this.lblTittlePriority.TabIndex = 0;
            this.lblTittlePriority.Text = "TITTLE";
            this.lblTittlePriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriority
            // 
            this.lblPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(506, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(120, 44);
            this.lblPriority.TabIndex = 1;
            this.lblPriority.Text = "Priority";
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(3, 50);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(81, 24);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // PanelStartEndHours
            // 
            this.PanelStartEndHours.ColumnCount = 2;
            this.PanelStartEndHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelStartEndHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelStartEndHours.Controls.Add(this.lblStartHour, 0, 0);
            this.PanelStartEndHours.Controls.Add(this.lblEndHour, 1, 0);
            this.PanelStartEndHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelStartEndHours.Location = new System.Drawing.Point(3, 350);
            this.PanelStartEndHours.Name = "PanelStartEndHours";
            this.PanelStartEndHours.RowCount = 1;
            this.PanelStartEndHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelStartEndHours.Size = new System.Drawing.Size(629, 69);
            this.PanelStartEndHours.TabIndex = 2;
            // 
            // lblStartHour
            // 
            this.lblStartHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartHour.AutoSize = true;
            this.lblStartHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartHour.Location = new System.Drawing.Point(3, 0);
            this.lblStartHour.Name = "lblStartHour";
            this.lblStartHour.Size = new System.Drawing.Size(308, 69);
            this.lblStartHour.TabIndex = 0;
            this.lblStartHour.Text = "Start: 10:00 AM";
            this.lblStartHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndHour
            // 
            this.lblEndHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndHour.AutoSize = true;
            this.lblEndHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndHour.Location = new System.Drawing.Point(317, 0);
            this.lblEndHour.Name = "lblEndHour";
            this.lblEndHour.Size = new System.Drawing.Size(309, 69);
            this.lblEndHour.TabIndex = 1;
            this.lblEndHour.Text = "End: 1:00 PM";
            this.lblEndHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDueDateNewEvent
            // 
            this.PanelDueDateNewEvent.ColumnCount = 2;
            this.PanelDueDateNewEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PanelDueDateNewEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.PanelDueDateNewEvent.Controls.Add(this.monthCalendar1, 1, 0);
            this.PanelDueDateNewEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDueDateNewEvent.Location = new System.Drawing.Point(3, 127);
            this.PanelDueDateNewEvent.Name = "PanelDueDateNewEvent";
            this.PanelDueDateNewEvent.RowCount = 1;
            this.PanelDueDateNewEvent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelDueDateNewEvent.Size = new System.Drawing.Size(629, 217);
            this.PanelDueDateNewEvent.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(386, 27);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // EventsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 422);
            this.Controls.Add(this.MainPanel);
            this.Name = "EventsView";
            this.Text = "EventsView";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.PanelTittlePriority.ResumeLayout(false);
            this.PanelTittlePriority.PerformLayout();
            this.PanelStartEndHours.ResumeLayout(false);
            this.PanelStartEndHours.PerformLayout();
            this.PanelDueDateNewEvent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.TableLayoutPanel PanelTittlePriority;
        private System.Windows.Forms.Label lblTittlePriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TableLayoutPanel PanelStartEndHours;
        private System.Windows.Forms.Label lblStartHour;
        private System.Windows.Forms.Label lblEndHour;
        private System.Windows.Forms.TableLayoutPanel PanelDueDateNewEvent;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}