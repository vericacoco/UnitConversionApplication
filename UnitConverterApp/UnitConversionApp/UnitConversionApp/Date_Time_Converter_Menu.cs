using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;


namespace UnitConversionApp
{
    public partial class Date_Time_Converter_Menu: UserControl
    {
        private Label lblDateTime; //labela za date and time
        private ComboBox cmbFromTimeZone;
        private ComboBox cmbToTimeZone;
        private Timer timer;
        private Button btnSaveConversion;
        private ListBox listBoxSavedConversions;
        private Button btnDeleteConversion;
        private Label lblSavedConversions;



        public Date_Time_Converter_Menu()
        {
            InitializeComponent();
            InitializeComponents();
            InitializeTimeZones();
            StartTimer();
            UpdateDateTime();
        }

        private void InitializeComponents()
        {

            lblSavedConversions = new Label();
            lblSavedConversions.AutoSize = true;
            lblSavedConversions.Font = new Font("Arial", 10, FontStyle.Bold);
            lblSavedConversions.Location = new Point(10, 205);
            lblSavedConversions.Text = "Saved Conversions:";
            this.Controls.Add(lblSavedConversions);
            lblSavedConversions = new Label();




            lblDateTime = new Label();
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Arial", 12, FontStyle.Bold);
            lblDateTime.Location = new Point(10, 10);
            lblDateTime.ForeColor = Color.Black;
            Controls.Add(lblDateTime);

            cmbFromTimeZone = new ComboBox();
            cmbFromTimeZone.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFromTimeZone.Location = new Point(10, 100);
            cmbFromTimeZone.Size = new Size(150, 50);
            cmbFromTimeZone.SelectedIndexChanged += CmbFromTimeZone_SelectedIndexChanged;
            Controls.Add(cmbFromTimeZone);

            cmbToTimeZone = new ComboBox();
            cmbToTimeZone.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToTimeZone.Location = new Point(180, 100);
            cmbToTimeZone.Size = new Size(150, 50);
            cmbToTimeZone.SelectedIndexChanged += CmbToTimeZone_SelectedIndexChanged;
            Controls.Add(cmbToTimeZone);


            //SAVE KOPCCE
           btnSaveConversion = new Button();
            btnSaveConversion.Text = "Save Conversion";
            btnSaveConversion.Location = new Point(10, 150);
            btnSaveConversion.Size = new Size(150, 30);
            btnSaveConversion.Click += BtnSaveConversion_Click;
            Controls.Add(btnSaveConversion);

            //LIST BOX
             listBoxSavedConversions = new ListBox();
            listBoxSavedConversions.Location = new Point(10, 250);
            listBoxSavedConversions.Size = new Size(320, 150);
            listBoxSavedConversions.SelectedIndexChanged += ListBoxSavedConversions_SelectedIndexChanged;
            Controls.Add(listBoxSavedConversions);

            //DELETE KOPCE
             btnDeleteConversion = new Button();
            btnDeleteConversion.Text = "Delete";
            btnDeleteConversion.Location = new Point(10, 410);
            btnDeleteConversion.Size = new Size(150, 30);
            btnDeleteConversion.Click += BtnDeleteConversion_Click;
            Controls.Add(btnDeleteConversion);

           

        }

       

        

        private void BtnDeleteConversion_Click(object sender, EventArgs e)
        {
            if (listBoxSavedConversions.SelectedIndex != -1)
            {
                listBoxSavedConversions.Items.RemoveAt(listBoxSavedConversions.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a conversion to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListBoxSavedConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteConversion.Enabled = listBoxSavedConversions.SelectedIndex != -1;
        }

        private void BtnSaveConversion_Click(object sender, EventArgs e)
        {
            string fromTimeZone = cmbFromTimeZone.SelectedItem?.ToString();
            string toTimeZone = cmbToTimeZone.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(fromTimeZone) && !string.IsNullOrEmpty(toTimeZone))
            {
                try
                {
                    TimeZoneInfo fromTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(fromTimeZone);
                    TimeZoneInfo toTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(toTimeZone);

                    DateTimeOffset currentDateTime = DateTimeOffset.UtcNow;
                    DateTimeOffset fromDateTime = TimeZoneInfo.ConvertTime(currentDateTime, fromTimeZoneInfo);
                    DateTimeOffset toDateTime = TimeZoneInfo.ConvertTime(fromDateTime, toTimeZoneInfo);

                    // Save the conversion to the list box
                    string conversionText = $"From {fromTimeZone}: {fromDateTime:yyyy-MM-dd HH:mm:ss} to {toTimeZone}: {toDateTime:yyyy-MM-dd HH:mm:ss}";
                    listBoxSavedConversions.Items.Add(conversionText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving conversion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select time zones before saving.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InitializeTimeZones()
        {
            foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
            {
                cmbFromTimeZone.Items.Add(timeZone.Id);
                cmbToTimeZone.Items.Add(timeZone.Id);
            }

            if (cmbFromTimeZone.Items.Count > 0)
                cmbFromTimeZone.SelectedIndex = 0;

            if (cmbToTimeZone.Items.Count > 1)
                cmbToTimeZone.SelectedIndex = 1;
        }


        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            string fromTimeZone = cmbFromTimeZone.SelectedItem?.ToString();
            string toTimeZone = cmbToTimeZone.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(fromTimeZone) && !string.IsNullOrEmpty(toTimeZone))
            {
                try
                {
                    TimeZoneInfo fromTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(fromTimeZone);
                    TimeZoneInfo toTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(toTimeZone);

                    DateTimeOffset currentDateTime = DateTimeOffset.UtcNow;
                    DateTimeOffset fromDateTime = TimeZoneInfo.ConvertTime(currentDateTime, fromTimeZoneInfo);
                    DateTimeOffset toDateTime = TimeZoneInfo.ConvertTime(fromDateTime, toTimeZoneInfo);
                    lblDateTime.Text = $"From {fromTimeZone}: {fromDateTime:yyyy-MM-dd HH:mm:ss}\n" +
                                       $"To {toTimeZone}: {toDateTime:yyyy-MM-dd HH:mm:ss}";
                }
                catch (TimeZoneNotFoundException)
                {
                    lblDateTime.Text = "Invalid time zone.";
                }
                catch (InvalidTimeZoneException)
                {
                    lblDateTime.Text = "Invalid time zone.";
                }
            }
        }

        private void CmbFromTimeZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void CmbToTimeZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void Date_Time_Converter_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
