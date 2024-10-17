namespace korobkov_winforms_DGV
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAddNewTour = new System.Windows.Forms.ToolStripButton();
            this.BtnEditTour = new System.Windows.Forms.ToolStripButton();
            this.BtnRemoveTour = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusCountDop = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTotalSumDop = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusTotalCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTotalSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toursDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toursDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.пToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1356, 40);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.справкаToolStripMenuItem.Text = "Правка";
            // 
            // пToolStripMenuItem
            // 
            this.пToolStripMenuItem.Name = "пToolStripMenuItem";
            this.пToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.пToolStripMenuItem.Text = "Справка";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAddNewTour,
            this.BtnEditTour,
            this.BtnRemoveTour});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1356, 42);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAddNewTour
            // 
            this.BtnAddNewTour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAddNewTour.Image = global::korobkov_winforms_DGV.Properties.Resources.plus;
            this.BtnAddNewTour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddNewTour.Name = "BtnAddNewTour";
            this.BtnAddNewTour.Size = new System.Drawing.Size(46, 36);
            this.BtnAddNewTour.Text = "toolStripButton1";
            this.BtnAddNewTour.Click += new System.EventHandler(this.BtnAddNewTour_Click);
            // 
            // BtnEditTour
            // 
            this.BtnEditTour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEditTour.Image = global::korobkov_winforms_DGV.Properties.Resources.edit;
            this.BtnEditTour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditTour.Name = "BtnEditTour";
            this.BtnEditTour.Size = new System.Drawing.Size(46, 36);
            this.BtnEditTour.Text = "toolStripButton2";
            this.BtnEditTour.Click += new System.EventHandler(this.BtnEditTour_Click);
            // 
            // BtnRemoveTour
            // 
            this.BtnRemoveTour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRemoveTour.Image = global::korobkov_winforms_DGV.Properties.Resources.remove;
            this.BtnRemoveTour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRemoveTour.Name = "BtnRemoveTour";
            this.BtnRemoveTour.Size = new System.Drawing.Size(46, 36);
            this.BtnRemoveTour.Text = "toolStripButton3";
            this.BtnRemoveTour.Click += new System.EventHandler(this.BtnRemoveTour_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(10);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusCountDop,
            this.toolStripStatusTotalSumDop});
            this.statusStrip1.Location = new System.Drawing.Point(0, 696);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1356, 42);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusCountDop
            // 
            this.toolStripStatusCountDop.Name = "toolStripStatusCountDop";
            this.toolStripStatusCountDop.Size = new System.Drawing.Size(363, 32);
            this.toolStripStatusCountDop.Text = "Количество туров с доплатами:";
            // 
            // toolStripStatusTotalSumDop
            // 
            this.toolStripStatusTotalSumDop.Name = "toolStripStatusTotalSumDop";
            this.toolStripStatusTotalSumDop.Size = new System.Drawing.Size(254, 32);
            this.toolStripStatusTotalSumDop.Text = "Общая сумма доплат:";
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusTotalCount,
            this.toolStripStatusTotalSum});
            this.statusStrip2.Location = new System.Drawing.Point(0, 654);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1356, 42);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusTotalCount
            // 
            this.toolStripStatusTotalCount.Name = "toolStripStatusTotalCount";
            this.toolStripStatusTotalCount.Size = new System.Drawing.Size(250, 32);
            this.toolStripStatusTotalCount.Text = "Общее кол-во туров:";
            // 
            // toolStripStatusTotalSum
            // 
            this.toolStripStatusTotalSum.Name = "toolStripStatusTotalSum";
            this.toolStripStatusTotalSum.Size = new System.Drawing.Size(305, 32);
            this.toolStripStatusTotalSum.Text = "Общая сумма за все туры:";
            // 
            // toursDGV
            // 
            this.toursDGV.AllowUserToAddRows = false;
            this.toursDGV.AllowUserToDeleteRows = false;
            this.toursDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toursDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toursDGV.Location = new System.Drawing.Point(0, 82);
            this.toursDGV.Name = "toursDGV";
            this.toursDGV.ReadOnly = true;
            this.toursDGV.RowHeadersWidth = 82;
            this.toursDGV.RowTemplate.Height = 33;
            this.toursDGV.Size = new System.Drawing.Size(1356, 572);
            this.toursDGV.TabIndex = 5;
            this.toursDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.toursDGV_CellFormatting);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 738);
            this.Controls.Add(this.toursDGV);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная - Горящие туры";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toursDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCountDop;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTotalSumDop;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTotalCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTotalSum;
        private System.Windows.Forms.ToolStripButton BtnAddNewTour;
        private System.Windows.Forms.ToolStripButton BtnEditTour;
        private System.Windows.Forms.ToolStripButton BtnRemoveTour;
        private System.Windows.Forms.DataGridView toursDGV;
    }
}

