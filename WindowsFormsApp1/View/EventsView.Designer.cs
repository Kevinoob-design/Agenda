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
            this.panelContactsEdit = new System.Windows.Forms.TableLayoutPanel();
            this.panelAddDelete = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.txtFiler = new System.Windows.Forms.TextBox();
            this.panelDueDateHorsFre = new System.Windows.Forms.TableLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelHorsFrequency = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.MainPanel.SuspendLayout();
            this.PanelTittlePriority.SuspendLayout();
            this.PanelStartEndHours.SuspendLayout();
            this.PanelDueDateNewEvent.SuspendLayout();
            this.panelContactsEdit.SuspendLayout();
            this.panelAddDelete.SuspendLayout();
            this.panelDueDateHorsFre.SuspendLayout();
            this.panelHorsFrequency.SuspendLayout();
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
            this.PanelDueDateNewEvent.Controls.Add(this.panelContactsEdit, 0, 0);
            this.PanelDueDateNewEvent.Controls.Add(this.panelDueDateHorsFre, 1, 0);
            this.PanelDueDateNewEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDueDateNewEvent.Location = new System.Drawing.Point(3, 127);
            this.PanelDueDateNewEvent.Name = "PanelDueDateNewEvent";
            this.PanelDueDateNewEvent.RowCount = 1;
            this.PanelDueDateNewEvent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelDueDateNewEvent.Size = new System.Drawing.Size(629, 217);
            this.PanelDueDateNewEvent.TabIndex = 3;
            // 
            // panelContactsEdit
            // 
            this.panelContactsEdit.ColumnCount = 1;
            this.panelContactsEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContactsEdit.Controls.Add(this.panelAddDelete, 0, 2);
            this.panelContactsEdit.Controls.Add(this.listBoxContacts, 0, 1);
            this.panelContactsEdit.Controls.Add(this.txtFiler, 0, 0);
            this.panelContactsEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContactsEdit.Location = new System.Drawing.Point(3, 3);
            this.panelContactsEdit.Name = "panelContactsEdit";
            this.panelContactsEdit.RowCount = 3;
            this.panelContactsEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panelContactsEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContactsEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelContactsEdit.Size = new System.Drawing.Size(371, 211);
            this.panelContactsEdit.TabIndex = 1;
            // 
            // panelAddDelete
            // 
            this.panelAddDelete.ColumnCount = 2;
            this.panelAddDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelAddDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelAddDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelAddDelete.Controls.Add(this.btnAdd, 0, 0);
            this.panelAddDelete.Controls.Add(this.btnRemove, 1, 0);
            this.panelAddDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddDelete.Location = new System.Drawing.Point(3, 174);
            this.panelAddDelete.Name = "panelAddDelete";
            this.panelAddDelete.RowCount = 1;
            this.panelAddDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelAddDelete.Size = new System.Drawing.Size(365, 34);
            this.panelAddDelete.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(185, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(177, 28);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Contact";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.Location = new System.Drawing.Point(3, 28);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(365, 140);
            this.listBoxContacts.TabIndex = 1;
            // 
            // txtFiler
            // 
            this.txtFiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFiler.Location = new System.Drawing.Point(3, 3);
            this.txtFiler.Name = "txtFiler";
            this.txtFiler.Size = new System.Drawing.Size(365, 20);
            this.txtFiler.TabIndex = 2;
            // 
            // panelDueDateHorsFre
            // 
            this.panelDueDateHorsFre.ColumnCount = 1;
            this.panelDueDateHorsFre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDueDateHorsFre.Controls.Add(this.monthCalendar1, 0, 0);
            this.panelDueDateHorsFre.Controls.Add(this.panelHorsFrequency, 0, 1);
            this.panelDueDateHorsFre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDueDateHorsFre.Location = new System.Drawing.Point(380, 3);
            this.panelDueDateHorsFre.Name = "panelDueDateHorsFre";
            this.panelDueDateHorsFre.RowCount = 2;
            this.panelDueDateHorsFre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDueDateHorsFre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelDueDateHorsFre.Size = new System.Drawing.Size(246, 211);
            this.panelDueDateHorsFre.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // panelHorsFrequency
            // 
            this.panelHorsFrequency.ColumnCount = 3;
            this.panelHorsFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelHorsFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelHorsFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelHorsFrequency.Controls.Add(this.comboBox1, 0, 0);
            this.panelHorsFrequency.Controls.Add(this.comboBox2, 1, 0);
            this.panelHorsFrequency.Controls.Add(this.comboBox3, 2, 0);
            this.panelHorsFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHorsFrequency.Location = new System.Drawing.Point(3, 174);
            this.panelHorsFrequency.Name = "panelHorsFrequency";
            this.panelHorsFrequency.RowCount = 1;
            this.panelHorsFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelHorsFrequency.Size = new System.Drawing.Size(240, 34);
            this.panelHorsFrequency.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "12:00 AM",
            "12:30 AM",
            "1:00 AM",
            "1:30 AM",
            "2:00 AM",
            "2:30 AM",
            "3:00 AM",
            "3:30 AM",
            "4:00 AM",
            "4:30 AM",
            "5:00 AM",
            "5:30 AM",
            "6:00 AM",
            "6:30 AM",
            "7:00 AM",
            "7:30 AM",
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM",
            "5:30 PM",
            "6:00 PM",
            "6:30 PM",
            "7:00 PM",
            "7:30 PM",
            "8:00 PM",
            "8:30 PM",
            "9:00 PM",
            "9:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(82, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(73, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(161, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(76, 21);
            this.comboBox3.TabIndex = 2;
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
            this.panelContactsEdit.ResumeLayout(false);
            this.panelContactsEdit.PerformLayout();
            this.panelAddDelete.ResumeLayout(false);
            this.panelDueDateHorsFre.ResumeLayout(false);
            this.panelHorsFrequency.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel panelContactsEdit;
        private System.Windows.Forms.TableLayoutPanel panelAddDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.TextBox txtFiler;
        private System.Windows.Forms.TableLayoutPanel panelDueDateHorsFre;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TableLayoutPanel panelHorsFrequency;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}