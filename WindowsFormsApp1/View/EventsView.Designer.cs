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
            this.PanelStartEndHours = new System.Windows.Forms.TableLayoutPanel();
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
            this.comboBoxTimeStart = new System.Windows.Forms.ComboBox();
            this.comboBoxTimeEnd = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panelLabels = new System.Windows.Forms.TableLayoutPanel();
            this.Start = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPriority = new System.Windows.Forms.TableLayoutPanel();
            this.lblPriority = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTittle = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.PanelTittlePriority.SuspendLayout();
            this.PanelStartEndHours.SuspendLayout();
            this.PanelDueDateNewEvent.SuspendLayout();
            this.panelContactsEdit.SuspendLayout();
            this.panelAddDelete.SuspendLayout();
            this.panelDueDateHorsFre.SuspendLayout();
            this.panelHorsFrequency.SuspendLayout();
            this.panelLabels.SuspendLayout();
            this.panelPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.PanelTittlePriority, 0, 0);
            this.MainPanel.Controls.Add(this.PanelStartEndHours, 0, 3);
            this.MainPanel.Controls.Add(this.PanelDueDateNewEvent, 0, 2);
            this.MainPanel.Controls.Add(this.txtLocation, 0, 1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 4;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.42106F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.MainPanel.Size = new System.Drawing.Size(635, 422);
            this.MainPanel.TabIndex = 1;
            // 
            // PanelTittlePriority
            // 
            this.PanelTittlePriority.ColumnCount = 2;
            this.PanelTittlePriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.PanelTittlePriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PanelTittlePriority.Controls.Add(this.panelPriority, 1, 0);
            this.PanelTittlePriority.Controls.Add(this.txtTittle, 0, 0);
            this.PanelTittlePriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTittlePriority.Location = new System.Drawing.Point(3, 3);
            this.PanelTittlePriority.Name = "PanelTittlePriority";
            this.PanelTittlePriority.RowCount = 1;
            this.PanelTittlePriority.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTittlePriority.Size = new System.Drawing.Size(629, 54);
            this.PanelTittlePriority.TabIndex = 0;
            // 
            // PanelStartEndHours
            // 
            this.PanelStartEndHours.ColumnCount = 4;
            this.PanelStartEndHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PanelStartEndHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PanelStartEndHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PanelStartEndHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PanelStartEndHours.Controls.Add(this.btnSave, 0, 0);
            this.PanelStartEndHours.Controls.Add(this.btnUpdate, 1, 0);
            this.PanelStartEndHours.Controls.Add(this.btnDelete, 2, 0);
            this.PanelStartEndHours.Controls.Add(this.btnClear, 3, 0);
            this.PanelStartEndHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelStartEndHours.Location = new System.Drawing.Point(3, 386);
            this.PanelStartEndHours.Name = "PanelStartEndHours";
            this.PanelStartEndHours.RowCount = 1;
            this.PanelStartEndHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelStartEndHours.Size = new System.Drawing.Size(629, 33);
            this.PanelStartEndHours.TabIndex = 2;
            // 
            // PanelDueDateNewEvent
            // 
            this.PanelDueDateNewEvent.ColumnCount = 2;
            this.PanelDueDateNewEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDueDateNewEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDueDateNewEvent.Controls.Add(this.panelContactsEdit, 0, 0);
            this.PanelDueDateNewEvent.Controls.Add(this.panelDueDateHorsFre, 1, 0);
            this.PanelDueDateNewEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDueDateNewEvent.Location = new System.Drawing.Point(3, 139);
            this.PanelDueDateNewEvent.Name = "PanelDueDateNewEvent";
            this.PanelDueDateNewEvent.RowCount = 1;
            this.PanelDueDateNewEvent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelDueDateNewEvent.Size = new System.Drawing.Size(629, 241);
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
            this.panelContactsEdit.Size = new System.Drawing.Size(308, 235);
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
            this.panelAddDelete.Location = new System.Drawing.Point(3, 198);
            this.panelAddDelete.Name = "panelAddDelete";
            this.panelAddDelete.RowCount = 1;
            this.panelAddDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelAddDelete.Size = new System.Drawing.Size(302, 34);
            this.panelAddDelete.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(154, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(145, 28);
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
            this.listBoxContacts.Size = new System.Drawing.Size(302, 164);
            this.listBoxContacts.TabIndex = 1;
            // 
            // txtFiler
            // 
            this.txtFiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFiler.Location = new System.Drawing.Point(3, 3);
            this.txtFiler.Name = "txtFiler";
            this.txtFiler.Size = new System.Drawing.Size(302, 20);
            this.txtFiler.TabIndex = 2;
            // 
            // panelDueDateHorsFre
            // 
            this.panelDueDateHorsFre.ColumnCount = 1;
            this.panelDueDateHorsFre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDueDateHorsFre.Controls.Add(this.monthCalendar1, 0, 0);
            this.panelDueDateHorsFre.Controls.Add(this.panelHorsFrequency, 0, 1);
            this.panelDueDateHorsFre.Controls.Add(this.panelLabels, 0, 2);
            this.panelDueDateHorsFre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDueDateHorsFre.Location = new System.Drawing.Point(317, 3);
            this.panelDueDateHorsFre.Name = "panelDueDateHorsFre";
            this.panelDueDateHorsFre.RowCount = 3;
            this.panelDueDateHorsFre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDueDateHorsFre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelDueDateHorsFre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelDueDateHorsFre.Size = new System.Drawing.Size(309, 235);
            this.panelDueDateHorsFre.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.monthCalendar1.Location = new System.Drawing.Point(41, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // panelHorsFrequency
            // 
            this.panelHorsFrequency.ColumnCount = 3;
            this.panelHorsFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelHorsFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelHorsFrequency.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelHorsFrequency.Controls.Add(this.comboBoxTimeStart, 0, 0);
            this.panelHorsFrequency.Controls.Add(this.comboBoxTimeEnd, 1, 0);
            this.panelHorsFrequency.Controls.Add(this.comboBox3, 2, 0);
            this.panelHorsFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHorsFrequency.Location = new System.Drawing.Point(3, 183);
            this.panelHorsFrequency.Name = "panelHorsFrequency";
            this.panelHorsFrequency.RowCount = 1;
            this.panelHorsFrequency.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelHorsFrequency.Size = new System.Drawing.Size(303, 29);
            this.panelHorsFrequency.TabIndex = 2;
            // 
            // comboBoxTimeStart
            // 
            this.comboBoxTimeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTimeStart.FormattingEnabled = true;
            this.comboBoxTimeStart.Items.AddRange(new object[] {
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
            this.comboBoxTimeStart.Location = new System.Drawing.Point(3, 3);
            this.comboBoxTimeStart.Name = "comboBoxTimeStart";
            this.comboBoxTimeStart.Size = new System.Drawing.Size(95, 21);
            this.comboBoxTimeStart.TabIndex = 0;
            this.comboBoxTimeStart.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeStart_SelectedIndexChanged);
            // 
            // comboBoxTimeEnd
            // 
            this.comboBoxTimeEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTimeEnd.FormattingEnabled = true;
            this.comboBoxTimeEnd.Location = new System.Drawing.Point(104, 3);
            this.comboBoxTimeEnd.Name = "comboBoxTimeEnd";
            this.comboBoxTimeEnd.Size = new System.Drawing.Size(95, 21);
            this.comboBoxTimeEnd.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(205, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(95, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // panelLabels
            // 
            this.panelLabels.ColumnCount = 3;
            this.panelLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelLabels.Controls.Add(this.Start, 0, 2);
            this.panelLabels.Controls.Add(this.label2, 1, 2);
            this.panelLabels.Controls.Add(this.label3, 2, 2);
            this.panelLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLabels.Location = new System.Drawing.Point(3, 218);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.RowCount = 3;
            this.panelLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLabels.Size = new System.Drawing.Size(303, 14);
            this.panelLabels.TabIndex = 3;
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.AutoSize = true;
            this.Start.Location = new System.Drawing.Point(3, -6);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(94, 20);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "End";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, -6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frecuency";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPriority
            // 
            this.panelPriority.ColumnCount = 1;
            this.panelPriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPriority.Controls.Add(this.lblPriority, 0, 0);
            this.panelPriority.Controls.Add(this.comboBox1, 0, 1);
            this.panelPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPriority.Location = new System.Drawing.Point(506, 3);
            this.panelPriority.Name = "panelPriority";
            this.panelPriority.RowCount = 2;
            this.panelPriority.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPriority.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPriority.Size = new System.Drawing.Size(120, 48);
            this.panelPriority.TabIndex = 1;
            // 
            // lblPriority
            // 
            this.lblPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(3, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(114, 24);
            this.lblPriority.TabIndex = 2;
            this.lblPriority.Text = "Priority";
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // txtTittle
            // 
            this.txtTittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTittle.Location = new System.Drawing.Point(3, 3);
            this.txtTittle.Multiline = true;
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(497, 48);
            this.txtTittle.TabIndex = 2;
            this.txtTittle.Text = "TITTLE";
            this.txtTittle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLocation
            // 
            this.txtLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(3, 63);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(629, 70);
            this.txtLocation.TabIndex = 4;
            this.txtLocation.Text = "LOCATION";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 27);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(160, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 27);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(317, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 27);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(474, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 27);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
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
            this.PanelDueDateNewEvent.ResumeLayout(false);
            this.panelContactsEdit.ResumeLayout(false);
            this.panelContactsEdit.PerformLayout();
            this.panelAddDelete.ResumeLayout(false);
            this.panelDueDateHorsFre.ResumeLayout(false);
            this.panelHorsFrequency.ResumeLayout(false);
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.panelPriority.ResumeLayout(false);
            this.panelPriority.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.TableLayoutPanel PanelTittlePriority;
        private System.Windows.Forms.TableLayoutPanel PanelStartEndHours;
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
        private System.Windows.Forms.ComboBox comboBoxTimeStart;
        private System.Windows.Forms.ComboBox comboBoxTimeEnd;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TableLayoutPanel panelLabels;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel panelPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtTittle;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}