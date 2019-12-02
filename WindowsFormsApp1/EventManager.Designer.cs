namespace WindowsFormsApp1
{
    partial class EventManager
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
            this.panelTittleContainer = new System.Windows.Forms.Panel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionPanel = new System.Windows.Forms.Panel();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panelTittleContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DescriptionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTittleContainer
            // 
            this.panelTittleContainer.Controls.Add(this.lblTittle);
            this.panelTittleContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleContainer.Location = new System.Drawing.Point(0, 0);
            this.panelTittleContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTittleContainer.MinimumSize = new System.Drawing.Size(0, 108);
            this.panelTittleContainer.Name = "panelTittleContainer";
            this.panelTittleContainer.Size = new System.Drawing.Size(1072, 108);
            this.panelTittleContainer.TabIndex = 0;
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(320, 3);
            this.lblTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(236, 67);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "TiTULO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescriptionPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1072, 815);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de Evento";
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(228)))));
            this.DescriptionPanel.Controls.Add(this.txtNotas);
            this.DescriptionPanel.Controls.Add(this.panel1);
            this.DescriptionPanel.Location = new System.Drawing.Point(18, 46);
            this.DescriptionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescriptionPanel.MaximumSize = new System.Drawing.Size(690, 615);
            this.DescriptionPanel.MinimumSize = new System.Drawing.Size(600, 308);
            this.DescriptionPanel.Name = "DescriptionPanel";
            this.DescriptionPanel.Size = new System.Drawing.Size(600, 446);
            this.DescriptionPanel.TabIndex = 3;
            // 
            // txtNotas
            // 
            this.txtNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotas.Location = new System.Drawing.Point(0, 77);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(600, 369);
            this.txtNotas.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 77);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 77);
            this.panel1.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(0, 0);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(275, 42);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "DESCRIPCION";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1072, 923);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTittleContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1072, 0);
            this.Name = "EventManager";
            this.Text = "EventManager";
            this.panelTittleContainer.ResumeLayout(false);
            this.panelTittleContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.DescriptionPanel.ResumeLayout(false);
            this.DescriptionPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTittleContainer;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel DescriptionPanel;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescripcion;
    }
}