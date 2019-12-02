namespace View.ChildEventView.ChildMonthView
{
    partial class MonthView
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
            this.TopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.TimeStartEndPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.TimeStartEndPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.TopPanel, 0, 0);
            this.MainPanel.Controls.Add(this.lblLocation, 0, 1);
            this.MainPanel.Controls.Add(this.TimeStartEndPanel, 0, 3);
            this.MainPanel.Controls.Add(this.lblDueDate, 0, 2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 4;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.Size = new System.Drawing.Size(373, 306);
            this.MainPanel.TabIndex = 1;
            // 
            // TopPanel
            // 
            this.TopPanel.ColumnCount = 3;
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.68966F));
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.96552F));
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.34483F));
            this.TopPanel.Controls.Add(this.lblDay, 0, 0);
            this.TopPanel.Controls.Add(this.lblTittle, 1, 0);
            this.TopPanel.Controls.Add(this.lblAlert, 2, 0);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(5, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.RowCount = 1;
            this.TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopPanel.Size = new System.Drawing.Size(363, 68);
            this.TopPanel.TabIndex = 0;
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(3, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(69, 68);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "1";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(78, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(244, 68);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Tag = "tittle";
            this.lblTittle.Text = "Tittle";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlert
            // 
            this.lblAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(328, 0);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(32, 68);
            this.lblAlert.TabIndex = 2;
            this.lblAlert.Tag = "priority";
            this.lblAlert.Text = "!!!";
            this.lblAlert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(5, 78);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(363, 74);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Tag = "location";
            this.lblLocation.Text = "Location\r\n";
            // 
            // TimeStartEndPanel
            // 
            this.TimeStartEndPanel.ColumnCount = 2;
            this.TimeStartEndPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TimeStartEndPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TimeStartEndPanel.Controls.Add(this.lblStart, 0, 0);
            this.TimeStartEndPanel.Controls.Add(this.lblEnd, 1, 0);
            this.TimeStartEndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeStartEndPanel.Location = new System.Drawing.Point(5, 233);
            this.TimeStartEndPanel.Name = "TimeStartEndPanel";
            this.TimeStartEndPanel.RowCount = 1;
            this.TimeStartEndPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TimeStartEndPanel.Size = new System.Drawing.Size(363, 68);
            this.TimeStartEndPanel.TabIndex = 2;
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(3, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(175, 68);
            this.lblStart.TabIndex = 0;
            this.lblStart.Tag = "startDate";
            this.lblStart.Text = "10:00";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(184, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(176, 68);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Tag = "endDate";
            this.lblEnd.Text = "12:30";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(5, 154);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(363, 74);
            this.lblDueDate.TabIndex = 3;
            this.lblDueDate.Tag = "startDate";
            this.lblDueDate.Text = "DUE DATE";
            this.lblDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonthView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 306);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthView";
            this.Text = "ChildMonthView";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.TimeStartEndPanel.ResumeLayout(false);
            this.TimeStartEndPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.TableLayoutPanel TopPanel;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TableLayoutPanel TimeStartEndPanel;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblDueDate;
    }
}