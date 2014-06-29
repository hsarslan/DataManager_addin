namespace DataManager_addin
{
    partial class frm_DataManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Data = new System.Windows.Forms.TabPage();
            this.btn_ImpExp = new System.Windows.Forms.Button();
            this.btn_Attachments = new System.Windows.Forms.Button();
            this.btn_Projection = new System.Windows.Forms.Button();
            this.btn_SupportFormats = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ConnectDatabase = new System.Windows.Forms.Button();
            this.btn_DataMigration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ManageData = new System.Windows.Forms.Button();
            this.tabPage_Metadata = new System.Windows.Forms.TabPage();
            this.btn_TrackingChanges = new System.Windows.Forms.Button();
            this.btn_SupportPolicy = new System.Windows.Forms.Button();
            this.btn_DisplayISOMetadata = new System.Windows.Forms.Button();
            this.btn_InternetMetadataService = new System.Windows.Forms.Button();
            this.btn_EnforceMetadataStandards = new System.Windows.Forms.Button();
            this.btn_ImpExpMetadata = new System.Windows.Forms.Button();
            this.btn_GenerateMetadata = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_Data.SuspendLayout();
            this.tabPage_Metadata.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Data);
            this.tabControl1.Controls.Add(this.tabPage_Metadata);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(357, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Data
            // 
            this.tabPage_Data.Controls.Add(this.btn_About);
            this.tabPage_Data.Controls.Add(this.btn_ImpExp);
            this.tabPage_Data.Controls.Add(this.btn_Attachments);
            this.tabPage_Data.Controls.Add(this.btn_Projection);
            this.tabPage_Data.Controls.Add(this.btn_SupportFormats);
            this.tabPage_Data.Controls.Add(this.btn_Search);
            this.tabPage_Data.Controls.Add(this.btn_ConnectDatabase);
            this.tabPage_Data.Controls.Add(this.btn_DataMigration);
            this.tabPage_Data.Controls.Add(this.button1);
            this.tabPage_Data.Controls.Add(this.btn_ManageData);
            this.tabPage_Data.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Data.Name = "tabPage_Data";
            this.tabPage_Data.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Data.Size = new System.Drawing.Size(349, 277);
            this.tabPage_Data.TabIndex = 0;
            this.tabPage_Data.Text = "Data Storage & Loading";
            // 
            // btn_ImpExp
            // 
            this.btn_ImpExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ImpExp.Location = new System.Drawing.Point(6, 92);
            this.btn_ImpExp.Name = "btn_ImpExp";
            this.btn_ImpExp.Size = new System.Drawing.Size(337, 23);
            this.btn_ImpExp.TabIndex = 9;
            this.btn_ImpExp.Text = "Data Import and Export";
            this.btn_ImpExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImpExp.UseVisualStyleBackColor = true;
            this.btn_ImpExp.Click += new System.EventHandler(this.btn_ImpExp_Click);
            // 
            // btn_Attachments
            // 
            this.btn_Attachments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Attachments.Location = new System.Drawing.Point(6, 208);
            this.btn_Attachments.Name = "btn_Attachments";
            this.btn_Attachments.Size = new System.Drawing.Size(337, 23);
            this.btn_Attachments.TabIndex = 8;
            this.btn_Attachments.Text = "Support Storage of a Broad Range of Documents";
            this.btn_Attachments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Attachments.UseVisualStyleBackColor = true;
            this.btn_Attachments.Click += new System.EventHandler(this.btn_Attachments_Click);
            // 
            // btn_Projection
            // 
            this.btn_Projection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Projection.Location = new System.Drawing.Point(6, 179);
            this.btn_Projection.Name = "btn_Projection";
            this.btn_Projection.Size = new System.Drawing.Size(337, 23);
            this.btn_Projection.TabIndex = 7;
            this.btn_Projection.Text = "Projection Transformation/Conversion ";
            this.btn_Projection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Projection.UseVisualStyleBackColor = true;
            this.btn_Projection.Click += new System.EventHandler(this.btn_Projection_Click);
            // 
            // btn_SupportFormats
            // 
            this.btn_SupportFormats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SupportFormats.Location = new System.Drawing.Point(6, 150);
            this.btn_SupportFormats.Name = "btn_SupportFormats";
            this.btn_SupportFormats.Size = new System.Drawing.Size(337, 23);
            this.btn_SupportFormats.TabIndex = 6;
            this.btn_SupportFormats.Text = "Support Standard GIS/CAD/Raster Formats";
            this.btn_SupportFormats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SupportFormats.UseVisualStyleBackColor = true;
            this.btn_SupportFormats.Click += new System.EventHandler(this.btn_SupportFormats_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Location = new System.Drawing.Point(6, 121);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(337, 23);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search by Name, Type, Path, Keyword Tag";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_ConnectDatabase
            // 
            this.btn_ConnectDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ConnectDatabase.Location = new System.Drawing.Point(6, 64);
            this.btn_ConnectDatabase.Name = "btn_ConnectDatabase";
            this.btn_ConnectDatabase.Size = new System.Drawing.Size(337, 23);
            this.btn_ConnectDatabase.TabIndex = 4;
            this.btn_ConnectDatabase.Text = "Connect to Remote Databases ";
            this.btn_ConnectDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConnectDatabase.UseVisualStyleBackColor = true;
            this.btn_ConnectDatabase.Click += new System.EventHandler(this.btn_ConnectDatabase_Click);
            // 
            // btn_DataMigration
            // 
            this.btn_DataMigration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DataMigration.Location = new System.Drawing.Point(6, 35);
            this.btn_DataMigration.Name = "btn_DataMigration";
            this.btn_DataMigration.Size = new System.Drawing.Size(337, 23);
            this.btn_DataMigration.TabIndex = 3;
            this.btn_DataMigration.Text = "Data Migration Wizards";
            this.btn_DataMigration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DataMigration.UseVisualStyleBackColor = true;
            this.btn_DataMigration.Click += new System.EventHandler(this.btn_DataMigration_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove Toolbars";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ManageData
            // 
            this.btn_ManageData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ManageData.Location = new System.Drawing.Point(6, 6);
            this.btn_ManageData.Name = "btn_ManageData";
            this.btn_ManageData.Size = new System.Drawing.Size(337, 23);
            this.btn_ManageData.TabIndex = 0;
            this.btn_ManageData.Text = "Manage PSS and Associated External Data";
            this.btn_ManageData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ManageData.UseVisualStyleBackColor = true;
            this.btn_ManageData.Click += new System.EventHandler(this.btn_ManageData_Click);
            // 
            // tabPage_Metadata
            // 
            this.tabPage_Metadata.Controls.Add(this.btn_TrackingChanges);
            this.tabPage_Metadata.Controls.Add(this.btn_SupportPolicy);
            this.tabPage_Metadata.Controls.Add(this.btn_DisplayISOMetadata);
            this.tabPage_Metadata.Controls.Add(this.btn_InternetMetadataService);
            this.tabPage_Metadata.Controls.Add(this.btn_EnforceMetadataStandards);
            this.tabPage_Metadata.Controls.Add(this.btn_ImpExpMetadata);
            this.tabPage_Metadata.Controls.Add(this.btn_GenerateMetadata);
            this.tabPage_Metadata.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Metadata.Name = "tabPage_Metadata";
            this.tabPage_Metadata.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Metadata.Size = new System.Drawing.Size(349, 277);
            this.tabPage_Metadata.TabIndex = 1;
            this.tabPage_Metadata.Text = "Metadata";
            this.tabPage_Metadata.UseVisualStyleBackColor = true;
            // 
            // btn_TrackingChanges
            // 
            this.btn_TrackingChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TrackingChanges.Location = new System.Drawing.Point(6, 180);
            this.btn_TrackingChanges.Name = "btn_TrackingChanges";
            this.btn_TrackingChanges.Size = new System.Drawing.Size(337, 23);
            this.btn_TrackingChanges.TabIndex = 7;
            this.btn_TrackingChanges.Text = "Tracking of changes";
            this.btn_TrackingChanges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TrackingChanges.UseVisualStyleBackColor = true;
            this.btn_TrackingChanges.Click += new System.EventHandler(this.btn_TrackingChanges_Click);
            // 
            // btn_SupportPolicy
            // 
            this.btn_SupportPolicy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SupportPolicy.Location = new System.Drawing.Point(6, 151);
            this.btn_SupportPolicy.Name = "btn_SupportPolicy";
            this.btn_SupportPolicy.Size = new System.Drawing.Size(337, 23);
            this.btn_SupportPolicy.TabIndex = 6;
            this.btn_SupportPolicy.Text = "Support for policy and regulations compliance";
            this.btn_SupportPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SupportPolicy.UseVisualStyleBackColor = true;
            this.btn_SupportPolicy.Click += new System.EventHandler(this.btn_SupportPolicy_Click);
            // 
            // btn_DisplayISOMetadata
            // 
            this.btn_DisplayISOMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DisplayISOMetadata.Location = new System.Drawing.Point(6, 122);
            this.btn_DisplayISOMetadata.Name = "btn_DisplayISOMetadata";
            this.btn_DisplayISOMetadata.Size = new System.Drawing.Size(337, 23);
            this.btn_DisplayISOMetadata.TabIndex = 5;
            this.btn_DisplayISOMetadata.Text = "Display of metadata in ISO standard format";
            this.btn_DisplayISOMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DisplayISOMetadata.UseVisualStyleBackColor = true;
            this.btn_DisplayISOMetadata.Click += new System.EventHandler(this.btn_DisplayISOMetadata_Click);
            // 
            // btn_InternetMetadataService
            // 
            this.btn_InternetMetadataService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InternetMetadataService.Location = new System.Drawing.Point(6, 93);
            this.btn_InternetMetadataService.Name = "btn_InternetMetadataService";
            this.btn_InternetMetadataService.Size = new System.Drawing.Size(337, 23);
            this.btn_InternetMetadataService.TabIndex = 4;
            this.btn_InternetMetadataService.Text = "Internet metadata services";
            this.btn_InternetMetadataService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InternetMetadataService.UseVisualStyleBackColor = true;
            this.btn_InternetMetadataService.Click += new System.EventHandler(this.btn_InternetMetadataService_Click);
            // 
            // btn_EnforceMetadataStandards
            // 
            this.btn_EnforceMetadataStandards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EnforceMetadataStandards.Location = new System.Drawing.Point(6, 64);
            this.btn_EnforceMetadataStandards.Name = "btn_EnforceMetadataStandards";
            this.btn_EnforceMetadataStandards.Size = new System.Drawing.Size(337, 23);
            this.btn_EnforceMetadataStandards.TabIndex = 3;
            this.btn_EnforceMetadataStandards.Text = "Enforcement of metadata standards";
            this.btn_EnforceMetadataStandards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EnforceMetadataStandards.UseVisualStyleBackColor = true;
            this.btn_EnforceMetadataStandards.Click += new System.EventHandler(this.btn_EnforceMetadataStandards_Click);
            // 
            // btn_ImpExpMetadata
            // 
            this.btn_ImpExpMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ImpExpMetadata.Location = new System.Drawing.Point(6, 35);
            this.btn_ImpExpMetadata.Name = "btn_ImpExpMetadata";
            this.btn_ImpExpMetadata.Size = new System.Drawing.Size(337, 23);
            this.btn_ImpExpMetadata.TabIndex = 2;
            this.btn_ImpExpMetadata.Text = "Import/export of metadata";
            this.btn_ImpExpMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImpExpMetadata.UseVisualStyleBackColor = true;
            this.btn_ImpExpMetadata.Click += new System.EventHandler(this.btn_ImpExpMetadata_Click);
            // 
            // btn_GenerateMetadata
            // 
            this.btn_GenerateMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GenerateMetadata.Location = new System.Drawing.Point(6, 6);
            this.btn_GenerateMetadata.Name = "btn_GenerateMetadata";
            this.btn_GenerateMetadata.Size = new System.Drawing.Size(337, 23);
            this.btn_GenerateMetadata.TabIndex = 1;
            this.btn_GenerateMetadata.Text = "Automatic and manual generation of metadata ";
            this.btn_GenerateMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GenerateMetadata.UseVisualStyleBackColor = true;
            this.btn_GenerateMetadata.Click += new System.EventHandler(this.btn_GenerateMetadata_Click);
            // 
            // btn_About
            // 
            this.btn_About.Location = new System.Drawing.Point(115, 248);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(75, 23);
            this.btn_About.TabIndex = 10;
            this.btn_About.Text = "About";
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(349, 277);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(343, 245);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_DataManager
            // 
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_DataManager";
            this.Size = new System.Drawing.Size(357, 303);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Data.ResumeLayout(false);
            this.tabPage_Metadata.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Data;
        private System.Windows.Forms.TabPage tabPage_Metadata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ManageData;
        private System.Windows.Forms.Button btn_DataMigration;
        private System.Windows.Forms.Button btn_ConnectDatabase;
        private System.Windows.Forms.Button btn_Attachments;
        private System.Windows.Forms.Button btn_Projection;
        private System.Windows.Forms.Button btn_SupportFormats;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ImpExp;
        private System.Windows.Forms.Button btn_TrackingChanges;
        private System.Windows.Forms.Button btn_SupportPolicy;
        private System.Windows.Forms.Button btn_DisplayISOMetadata;
        private System.Windows.Forms.Button btn_InternetMetadataService;
        private System.Windows.Forms.Button btn_EnforceMetadataStandards;
        private System.Windows.Forms.Button btn_ImpExpMetadata;
        private System.Windows.Forms.Button btn_GenerateMetadata;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;

    }
}
