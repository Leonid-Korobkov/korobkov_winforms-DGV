namespace korobkov_winforms_DGV
{
    partial class AddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownSumPerson = new System.Windows.Forms.NumericUpDown();
            this.checkBoxWiFi = new System.Windows.Forms.CheckBox();
            this.numericUpDownCountPeople = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCountNights = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxSumDop = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountNights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSumDop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 168);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::korobkov_winforms_DGV.Properties.Resources.world_travel_icon1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 109);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(147, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление/Редактирование тура";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 854);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 168);
            this.panel2.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(292, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 57);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(76, 61);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(183, 57);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(147, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 51);
            this.label2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.textBoxSumDop);
            this.panel3.Controls.Add(this.numericUpDownSumPerson);
            this.panel3.Controls.Add(this.checkBoxWiFi);
            this.panel3.Controls.Add(this.numericUpDownCountPeople);
            this.panel3.Controls.Add(this.numericUpDownCountNights);
            this.panel3.Controls.Add(this.dateTimePickerDeparture);
            this.panel3.Controls.Add(this.comboBoxDirection);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 686);
            this.panel3.TabIndex = 3;
            // 
            // numericUpDownSumPerson
            // 
            this.numericUpDownSumPerson.DecimalPlaces = 2;
            this.numericUpDownSumPerson.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSumPerson.Location = new System.Drawing.Point(438, 291);
            this.numericUpDownSumPerson.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSumPerson.Name = "numericUpDownSumPerson";
            this.numericUpDownSumPerson.Size = new System.Drawing.Size(382, 31);
            this.numericUpDownSumPerson.TabIndex = 15;
            // 
            // checkBoxWiFi
            // 
            this.checkBoxWiFi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxWiFi.AutoSize = true;
            this.checkBoxWiFi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxWiFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWiFi.Location = new System.Drawing.Point(76, 492);
            this.checkBoxWiFi.Name = "checkBoxWiFi";
            this.checkBoxWiFi.Size = new System.Drawing.Size(240, 35);
            this.checkBoxWiFi.TabIndex = 13;
            this.checkBoxWiFi.Text = "Наличие Wi-Fi: ";
            this.checkBoxWiFi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxWiFi.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCountPeople
            // 
            this.numericUpDownCountPeople.Location = new System.Drawing.Point(438, 405);
            this.numericUpDownCountPeople.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownCountPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountPeople.Name = "numericUpDownCountPeople";
            this.numericUpDownCountPeople.Size = new System.Drawing.Size(382, 31);
            this.numericUpDownCountPeople.TabIndex = 12;
            this.numericUpDownCountPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCountNights
            // 
            this.numericUpDownCountNights.Location = new System.Drawing.Point(438, 212);
            this.numericUpDownCountNights.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownCountNights.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountNights.Name = "numericUpDownCountNights";
            this.numericUpDownCountNights.Size = new System.Drawing.Size(382, 31);
            this.numericUpDownCountNights.TabIndex = 10;
            this.numericUpDownCountNights.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(438, 131);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(382, 31);
            this.dateTimePickerDeparture.TabIndex = 9;
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(438, 56);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(382, 32);
            this.comboBoxDirection.TabIndex = 8;
            this.comboBoxDirection.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxDirection_DrawItem);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(70, 575);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 31);
            this.label10.TabIndex = 7;
            this.label10.Text = "Доплаты (руб): ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 31);
            this.label8.TabIndex = 5;
            this.label8.Text = "Количество отдыхающих: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 62);
            this.label7.TabIndex = 4;
            this.label7.Text = "Стоимость за \r\nотдыхающего (руб): ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "Количество ночей: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Дата вылета: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Направление: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(147, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 51);
            this.label3.TabIndex = 0;
            // 
            // textBoxSumDop
            // 
            this.textBoxSumDop.DecimalPlaces = 2;
            this.textBoxSumDop.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxSumDop.Location = new System.Drawing.Point(438, 575);
            this.textBoxSumDop.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBoxSumDop.Name = "textBoxSumDop";
            this.textBoxSumDop.Size = new System.Drawing.Size(382, 31);
            this.textBoxSumDop.TabIndex = 16;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 1022);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление/Редактирование тура";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountNights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSumDop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.NumericUpDown numericUpDownCountNights;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.CheckBox checkBoxWiFi;
        private System.Windows.Forms.NumericUpDown numericUpDownCountPeople;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown numericUpDownSumPerson;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown textBoxSumDop;
    }
}