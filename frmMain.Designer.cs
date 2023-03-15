
namespace ISSTracker
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nupRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chxNegative = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMapType = new System.Windows.Forms.ComboBox();
            this.gmapMap = new GMap.NET.WindowsForms.GMapControl();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlContainer.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupRefreshRate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlTitle);
            this.pnlContainer.Controls.Add(this.pnlMenu);
            this.pnlContainer.Controls.Add(this.gmapMap);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1118, 595);
            this.pnlContainer.TabIndex = 1;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.btnMenu);
            this.pnlTitle.Controls.Add(this.lblHeader);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1118, 78);
            this.pnlTitle.TabIndex = 2;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseUp);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(63)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(24, 19);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 36);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(365, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(308, 78);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "ISS Tracker";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnAbout);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.nupRefreshRate);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.chxNegative);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.cbxMapType);
            this.pnlMenu.Location = new System.Drawing.Point(0, 78);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(278, 186);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Visible = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.Crimson;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(96, 142);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(73, 29);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(163, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "seconds";
            // 
            // nupRefreshRate
            // 
            this.nupRefreshRate.Location = new System.Drawing.Point(111, 106);
            this.nupRefreshRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupRefreshRate.Name = "nupRefreshRate";
            this.nupRefreshRate.Size = new System.Drawing.Size(44, 20);
            this.nupRefreshRate.TabIndex = 4;
            this.nupRefreshRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupRefreshRate.ValueChanged += new System.EventHandler(this.nupRefreshRate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Refresh rate: ";
            // 
            // chxNegative
            // 
            this.chxNegative.AutoSize = true;
            this.chxNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxNegative.ForeColor = System.Drawing.Color.White;
            this.chxNegative.Location = new System.Drawing.Point(12, 68);
            this.chxNegative.Name = "chxNegative";
            this.chxNegative.Size = new System.Drawing.Size(83, 21);
            this.chxNegative.TabIndex = 2;
            this.chxNegative.Text = "Negative";
            this.chxNegative.UseVisualStyleBackColor = true;
            this.chxNegative.CheckedChanged += new System.EventHandler(this.chxNegative_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map type: ";
            // 
            // cbxMapType
            // 
            this.cbxMapType.FormattingEnabled = true;
            this.cbxMapType.Items.AddRange(new object[] {
            "Terrain",
            "Satellite"});
            this.cbxMapType.Location = new System.Drawing.Point(86, 29);
            this.cbxMapType.Name = "cbxMapType";
            this.cbxMapType.Size = new System.Drawing.Size(165, 21);
            this.cbxMapType.TabIndex = 0;
            this.cbxMapType.Tag = "";
            this.cbxMapType.SelectedIndexChanged += new System.EventHandler(this.cbxMapType_SelectedIndexChanged);
            // 
            // gmapMap
            // 
            this.gmapMap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gmapMap.Bearing = 0F;
            this.gmapMap.CanDragMap = true;
            this.gmapMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmapMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapMap.GrayScaleMode = true;
            this.gmapMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapMap.LevelsKeepInMemmory = 5;
            this.gmapMap.Location = new System.Drawing.Point(0, 0);
            this.gmapMap.MarkersEnabled = true;
            this.gmapMap.MaxZoom = 5;
            this.gmapMap.MinZoom = 2;
            this.gmapMap.MouseWheelZoomEnabled = true;
            this.gmapMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gmapMap.Name = "gmapMap";
            this.gmapMap.NegativeMode = false;
            this.gmapMap.PolygonsEnabled = true;
            this.gmapMap.RetryLoadTile = 0;
            this.gmapMap.RoutesEnabled = true;
            this.gmapMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gmapMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapMap.ShowTileGridLines = false;
            this.gmapMap.Size = new System.Drawing.Size(1118, 595);
            this.gmapMap.TabIndex = 0;
            this.gmapMap.Zoom = 2D;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 2000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1118, 595);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISS Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupRefreshRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContainer;
        private GMap.NET.WindowsForms.GMapControl gmapMap;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ComboBox cbxMapType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chxNegative;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupRefreshRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAbout;
    }
}

