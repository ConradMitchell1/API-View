namespace API_View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAppDetails = new System.Windows.Forms.TextBox();
            this.btnGetApplications = new System.Windows.Forms.Button();
            this.btnAppDetails = new System.Windows.Forms.Button();
            this.btnGetResources = new System.Windows.Forms.Button();
            this.btnResourceDetails = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.cmbSortType = new System.Windows.Forms.ComboBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbDetails = new System.Windows.Forms.ComboBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 102);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(973, 574);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // txtAppDetails
            // 
            this.txtAppDetails.BackColor = System.Drawing.SystemColors.Window;
            this.txtAppDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAppDetails.Location = new System.Drawing.Point(3, 394);
            this.txtAppDetails.Multiline = true;
            this.txtAppDetails.Name = "txtAppDetails";
            this.txtAppDetails.Size = new System.Drawing.Size(124, 37);
            this.txtAppDetails.TabIndex = 5;
            this.txtAppDetails.Text = "Enter App/Resource Name";
            this.txtAppDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAppDetails.Click += new System.EventHandler(this.txtAppDetails_Click);
            // 
            // btnGetApplications
            // 
            this.btnGetApplications.AutoSize = true;
            this.btnGetApplications.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetApplications.FlatAppearance.BorderSize = 0;
            this.btnGetApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetApplications.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetApplications.Location = new System.Drawing.Point(672, 18);
            this.btnGetApplications.Name = "btnGetApplications";
            this.btnGetApplications.Size = new System.Drawing.Size(146, 65);
            this.btnGetApplications.TabIndex = 7;
            this.btnGetApplications.Text = "Get Applications";
            this.btnGetApplications.UseVisualStyleBackColor = false;
            this.btnGetApplications.Click += new System.EventHandler(this.btnGetApplications_Click);
            // 
            // btnAppDetails
            // 
            this.btnAppDetails.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAppDetails.FlatAppearance.BorderSize = 0;
            this.btnAppDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAppDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAppDetails.Location = new System.Drawing.Point(4, 437);
            this.btnAppDetails.Name = "btnAppDetails";
            this.btnAppDetails.Size = new System.Drawing.Size(124, 65);
            this.btnAppDetails.TabIndex = 8;
            this.btnAppDetails.Text = "Get App Details";
            this.btnAppDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppDetails.UseVisualStyleBackColor = false;
            this.btnAppDetails.Click += new System.EventHandler(this.btnAppDetails_Click);
            // 
            // btnGetResources
            // 
            this.btnGetResources.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetResources.FlatAppearance.BorderSize = 0;
            this.btnGetResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetResources.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetResources.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetResources.Location = new System.Drawing.Point(824, 18);
            this.btnGetResources.Name = "btnGetResources";
            this.btnGetResources.Size = new System.Drawing.Size(124, 65);
            this.btnGetResources.TabIndex = 9;
            this.btnGetResources.Text = "Get Resources";
            this.btnGetResources.UseVisualStyleBackColor = false;
            this.btnGetResources.Click += new System.EventHandler(this.btnGetResources_Click);
            // 
            // btnResourceDetails
            // 
            this.btnResourceDetails.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnResourceDetails.FlatAppearance.BorderSize = 0;
            this.btnResourceDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourceDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResourceDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResourceDetails.Location = new System.Drawing.Point(4, 519);
            this.btnResourceDetails.Name = "btnResourceDetails";
            this.btnResourceDetails.Size = new System.Drawing.Size(124, 65);
            this.btnResourceDetails.TabIndex = 10;
            this.btnResourceDetails.Text = "Get Resource Details";
            this.btnResourceDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResourceDetails.UseVisualStyleBackColor = false;
            this.btnResourceDetails.Click += new System.EventHandler(this.btnResourceDetails_Click);
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlSide.Controls.Add(this.cmbSortType);
            this.pnlSide.Controls.Add(this.lblOrder);
            this.pnlSide.Controls.Add(this.pictureBox2);
            this.pnlSide.Controls.Add(this.txtAppDetails);
            this.pnlSide.Controls.Add(this.btnAppDetails);
            this.pnlSide.Controls.Add(this.cmbDetails);
            this.pnlSide.Controls.Add(this.btnResourceDetails);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(136, 676);
            this.pnlSide.TabIndex = 11;
            // 
            // cmbSortType
            // 
            this.cmbSortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortType.ForeColor = System.Drawing.Color.Black;
            this.cmbSortType.FormattingEnabled = true;
            this.cmbSortType.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cmbSortType.Location = new System.Drawing.Point(4, 177);
            this.cmbSortType.Name = "cmbSortType";
            this.cmbSortType.Size = new System.Drawing.Size(124, 23);
            this.cmbSortType.TabIndex = 17;
            // 
            // lblOrder
            // 
            this.lblOrder.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrder.ForeColor = System.Drawing.Color.White;
            this.lblOrder.Location = new System.Drawing.Point(3, 145);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(124, 20);
            this.lblOrder.TabIndex = 16;
            this.lblOrder.Text = "Sort By";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::API_View.Properties.Resources.Elanco_svg__1_;
            this.pictureBox2.Location = new System.Drawing.Point(4, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // cmbDetails
            // 
            this.cmbDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetails.ForeColor = System.Drawing.Color.Black;
            this.cmbDetails.FormattingEnabled = true;
            this.cmbDetails.Items.AddRange(new object[] {
            "ConsumedQuantity",
            "Cost",
            "Date",
            "MeterCategory",
            "ResourceGroup",
            "ResourceLocation",
            "UnitOfMeasure",
            "Location",
            "ServiceName"});
            this.cmbDetails.Location = new System.Drawing.Point(4, 206);
            this.cmbDetails.Name = "cmbDetails";
            this.cmbDetails.Size = new System.Drawing.Size(124, 23);
            this.cmbDetails.TabIndex = 13;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LightGray;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.btnGetApplications);
            this.pnlHeader.Controls.Add(this.btnGetResources);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(136, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(974, 106);
            this.pnlHeader.TabIndex = 12;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Narrow", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeader.Location = new System.Drawing.Point(49, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(365, 53);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Swagger API Demo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1110, 676);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Elanco App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtAppDetails;
        private Button btnGetApplications;
        private Button btnAppDetails;
        private Button btnGetResources;
        private Button btnResourceDetails;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlSide;
        private Panel pnlHeader;
        private Label lblHeader;
        private ComboBox cmbDetails;
        private PictureBox pictureBox2;
        private Label lblOrder;
        private ComboBox cmbSortType;
        private PictureBox pctDetails;
    }
}