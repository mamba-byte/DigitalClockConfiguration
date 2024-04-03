namespace DigitalClockConfiguration
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.labelDigitalClock = new System.Windows.Forms.Label();
            this.labelTimeZones = new System.Windows.Forms.Label();
            this.comboBoxTimeZones = new System.Windows.Forms.ComboBox();
            this.checkedListBoxTimeZones = new System.Windows.Forms.CheckedListBox();
            this.buttonAddTimeZone = new System.Windows.Forms.Button();
            this.buttonUpdateTimeZone = new System.Windows.Forms.Button();
            this.buttonDeleteTimeZone = new System.Windows.Forms.Button();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownTimeDifferenceHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimeDifferenceMinutes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeDifferenceHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeDifferenceMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDigitalClock
            // 
            this.labelDigitalClock.AutoSize = true;
            this.labelDigitalClock.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigitalClock.Location = new System.Drawing.Point(50, 50);
            this.labelDigitalClock.Name = "labelDigitalClock";
            this.labelDigitalClock.Size = new System.Drawing.Size(0, 37);
            // 
            // labelTimeZones
            // 
            this.labelTimeZones.AutoSize = true;
            this.labelTimeZones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeZones.Location = new System.Drawing.Point(50, 100);
            this.labelTimeZones.Name = "labelTimeZones";
            this.labelTimeZones.Size = new System.Drawing.Size(100, 20);
            this.labelTimeZones.Text = "Time Zones:";
            // 
            // comboBoxTimeZones
            // 
            this.comboBoxTimeZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeZones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTimeZones.Location = new System.Drawing.Point(200, 100);
            this.comboBoxTimeZones.Size = new System.Drawing.Size(200, 25);
            // 
            // checkedListBoxTimeZones
            // 
            this.checkedListBoxTimeZones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxTimeZones.FormattingEnabled = true;
            this.checkedListBoxTimeZones.Location = new System.Drawing.Point(50, 150);
            this.checkedListBoxTimeZones.Size = new System.Drawing.Size(350, 200);
            // 
            // buttonAddTimeZone
            // 
            this.buttonAddTimeZone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTimeZone.Location = new System.Drawing.Point(450, 150);
            this.buttonAddTimeZone.Size = new System.Drawing.Size(100, 30);
            this.buttonAddTimeZone.Text = "Add Time Zone";
            // 
            // buttonUpdateTimeZone
            // 
            this.buttonUpdateTimeZone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTimeZone.Location = new System.Drawing.Point(450, 200);
            this.buttonUpdateTimeZone.Size = new System.Drawing.Size(100, 30);
            this.buttonUpdateTimeZone.Text = "Update Time Zone";
            // 
            // buttonDeleteTimeZone
            // 
            this.buttonDeleteTimeZone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTimeZone.Location = new System.Drawing.Point(450, 250);
            this.buttonDeleteTimeZone.Size = new System.Drawing.Size(100, 30);
            this.buttonDeleteTimeZone.Text = "Delete Time Zone";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime.Location = new System.Drawing.Point(50, 375);
            this.labelCurrentTime.Size = new System.Drawing.Size(0, 20);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "HH:mm:ss";
            this.dateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(200, 370);
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(150, 25);
            // 
            // numericUpDownTimeDifferenceHours
            // 
            this.numericUpDownTimeDifferenceHours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTimeDifferenceHours.Location = new System.Drawing.Point(450, 100);
            this.numericUpDownTimeDifferenceHours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            this.numericUpDownTimeDifferenceHours.Size = new System.Drawing.Size(50, 25);
            // 
            // numericUpDownTimeDifferenceMinutes
            // 
            this.numericUpDownTimeDifferenceMinutes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTimeDifferenceMinutes.Location = new System.Drawing.Point(520, 100);
            this.numericUpDownTimeDifferenceMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            this.numericUpDownTimeDifferenceMinutes.Size = new System.Drawing.Size(50, 25);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.labelDigitalClock);
            this.Controls.Add(this.labelTimeZones);
            this.Controls.Add(this.comboBoxTimeZones);
            this.Controls.Add(this.checkedListBoxTimeZones);
            this.Controls.Add(this.buttonAddTimeZone);
            this.Controls.Add(this.buttonUpdateTimeZone);
            this.Controls.Add(this.buttonDeleteTimeZone);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.numericUpDownTimeDifferenceHours);
            this.Controls.Add(this.numericUpDownTimeDifferenceMinutes);
        }
    }
}


