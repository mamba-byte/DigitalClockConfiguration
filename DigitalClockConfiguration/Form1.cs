using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DigitalClockConfiguration
{
    public partial class Form1 : Form
    {
        private Label labelDigitalClock;
        private Label labelTimeZones;
        private ComboBox comboBoxTimeZones;
        private CheckedListBox checkedListBoxTimeZones;
        private Button buttonAddTimeZone;
        private Button buttonUpdateTimeZone;
        private Button buttonDeleteTimeZone;
        private Label labelCurrentTime;
        private DateTimePicker dateTimePicker;
        private NumericUpDown numericUpDownTimeDifferenceHours;
        private NumericUpDown numericUpDownTimeDifferenceMinutes;
        private Timer timer;
        private Color dayColor = Color.Blue;
        private List<TimeZoneInfo> timeZones = new List<TimeZoneInfo>();
        private DateTime previousTime;

        public Form1()
        {
            InitializeComponent();
            InitializeClock();
            InitializeTimeZones();
        }

        private void InitializeClock()
        {
            timer = new Timer();
            timer.Interval = 1000; // Update every second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update digital clock
            DateTime currentTime = DateTime.Now;
            labelDigitalClock.Text = currentTime.ToString("HH:mm:ss");

            // Change text color based on time of day
            if (currentTime.Hour >= 8 && currentTime.Hour < 20)
            {
                labelDigitalClock.ForeColor = dayColor;
            }
            else
            {
                labelDigitalClock.ForeColor = Color.Black;
            }
        }

        private void InitializeTimeZones()
        {
            // Set up controls related to time zones
            // ... (omitted for brevity)

            // Populate ComboBox with system time zones
            foreach (TimeZoneInfo timeZone in TimeZoneInfo.GetSystemTimeZones())
            {
                comboBoxTimeZones.Items.Add(timeZone.DisplayName);
                timeZones.Add(timeZone);
            }

            // Populate CheckedListBox with time zones
            foreach (TimeZoneInfo timeZone in TimeZoneInfo.GetSystemTimeZones())
            {
                checkedListBoxTimeZones.Items.Add(timeZone);
            }

            // Assign event handlers
            buttonAddTimeZone.Click += buttonAddTimeZone_Click;
            buttonUpdateTimeZone.Click += buttonUpdateTimeZone_Click;
            buttonDeleteTimeZone.Click += buttonDeleteTimeZone_Click;
            comboBoxTimeZones.SelectedIndexChanged += comboBoxTimeZones_SelectedIndexChanged;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;

            // Set DateTimePicker to show only time
            dateTimePicker.Format = DateTimePickerFormat.Time;
            dateTimePicker.ShowUpDown = true;
        }

        private void buttonAddTimeZone_Click(object sender, EventArgs e)
        {
            // Add new time zone to CheckedListBox
            string timeZoneName = comboBoxTimeZones.SelectedItem.ToString();
            int timeDifferenceHours = (int)numericUpDownTimeDifferenceHours.Value;
            int timeDifferenceMinutes = (int)numericUpDownTimeDifferenceMinutes.Value;

            checkedListBoxTimeZones.Items.Add($"{timeZoneName} ({timeDifferenceHours}:{timeDifferenceMinutes})");

        }

        private void buttonUpdateTimeZone_Click(object sender, EventArgs e)
        {
            // Update selected time zone in CheckedListBox
            if (checkedListBoxTimeZones.SelectedItem != null && checkedListBoxTimeZones.CheckedItems.Count <= 1)
            {
                string timeZoneName = comboBoxTimeZones.SelectedItem.ToString();
                int timeDifferenceHours = (int)numericUpDownTimeDifferenceHours.Value;
                int timeDifferenceMinutes = (int)numericUpDownTimeDifferenceMinutes.Value;

                checkedListBoxTimeZones.Items[checkedListBoxTimeZones.SelectedIndex] = $"{timeZoneName} ({timeDifferenceHours}:{timeDifferenceMinutes})";

                // Update digital clock
                TimeZoneInfo selectedTimeZone = timeZones[comboBoxTimeZones.SelectedIndex];
                DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, selectedTimeZone);
                labelDigitalClock.Text = currentTime.ToString("HH:mm:ss");

                // Check if the day has changed
                if (previousTime.Date != currentTime.Date)
                {
                    // Show a message box
                    MessageBox.Show("Gün değişti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Update the previous time
                previousTime = currentTime;
            }
        }

        private void buttonDeleteTimeZone_Click(object sender, EventArgs e)
        {
            // Delete selected time zone(s) from CheckedListBox
            while (checkedListBoxTimeZones.CheckedItems.Count > 0)
            {
                checkedListBoxTimeZones.Items.Remove(checkedListBoxTimeZones.CheckedItems[0]);
            }
        }

        private void comboBoxTimeZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change current time when ComboBox selection changes
            TimeZoneInfo selectedTimeZone = timeZones[comboBoxTimeZones.SelectedIndex];
            DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, selectedTimeZone);
            labelCurrentTime.Text = currentTime.ToString("HH:mm:ss");
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Change current time when DateTimePicker value changes
            DateTime selectedTime = dateTimePicker.Value;
            labelCurrentTime.Text = selectedTime.ToString("HH:mm:ss");
        }
    }
}
