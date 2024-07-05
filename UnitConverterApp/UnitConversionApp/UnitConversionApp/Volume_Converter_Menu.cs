using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversionApp
{
    public partial class Volume_Converter_Menu : UserControl
    {
        private TextBox txtInput;
        private ComboBox cmbFromUnit;
        private ComboBox cmbToUnit;
        private TextBox txtOutput;
        private Button btnConvert;
        private Button btnSaveConversion;
        private ListBox listBoxSavedConversions;
        private Button btnDeleteConversion;
        private Label lblSavedConversions; 

        public Volume_Converter_Menu()
        {
            InitializeComponent();
            InitializeComponents();
            LoadUnits();
        }

        private void InitializeComponents()
        {

            txtInput = new TextBox();
            cmbFromUnit = new ComboBox();
            cmbToUnit = new ComboBox();
            txtOutput = new TextBox();
            btnConvert = new Button();
            lblSavedConversions = new Label(); 

            this.SuspendLayout();

            //label:
            lblSavedConversions.AutoSize = true;
            lblSavedConversions.Font = new Font("Arial", 10, FontStyle.Bold);
            lblSavedConversions.Location = new Point(10, 120); 
            lblSavedConversions.Text = "Saved Conversions:";
            this.Controls.Add(lblSavedConversions);

            //INPUT:
            this.txtInput.Location = new System.Drawing.Point(20, 20);
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(txtInput);

            //FROM UNIT SELECTION:
            this.cmbFromUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFromUnit.Location = new System.Drawing.Point(140, 20);
            this.cmbFromUnit.Size = new System.Drawing.Size(100, 21);
            this.Controls.Add(cmbFromUnit);

            //FOR UNIT SELECTION:
            this.cmbToUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbToUnit.Location = new System.Drawing.Point(260, 20);
            this.cmbToUnit.Size = new System.Drawing.Size(100, 21);
            this.Controls.Add(cmbToUnit);

            //OUTPUT:
            this.txtOutput.Location = new System.Drawing.Point(380, 20);
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.ReadOnly = true;
            this.Controls.Add(txtOutput);

            //BTN KONVERZIJA
            this.btnConvert.Location = new System.Drawing.Point(500, 18);
            this.btnConvert.Size = new System.Drawing.Size(75, 25);
            this.btnConvert.Text = "Convert";
            this.Controls.Add(btnConvert);
            this.btnConvert.Click += new EventHandler(btnConvert_Click);

            this.ResumeLayout(false);

            //SAVE KOPCCE
            btnSaveConversion = new Button();
            btnSaveConversion.Text = "Save Conversion";
            btnSaveConversion.Location = new Point(10, 70);
            btnSaveConversion.Size = new Size(150, 30);
            btnSaveConversion.Click += BtnSaveConversion_Click;
            Controls.Add(btnSaveConversion);

            //LIST BOX
            listBoxSavedConversions = new ListBox();
            listBoxSavedConversions.Location = new Point(10, 150);
            listBoxSavedConversions.Size = new Size(320, 150);
            listBoxSavedConversions.SelectedIndexChanged += ListBoxSavedConversions_SelectedIndexChanged;
            Controls.Add(listBoxSavedConversions);

            //DELETE KOPCE
            btnDeleteConversion = new Button();
            btnDeleteConversion.Text = "Delete";
            btnDeleteConversion.Location = new Point(10, 310);
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
            
            if (!string.IsNullOrEmpty(txtInput.Text) && !string.IsNullOrEmpty(txtOutput.Text) &&
                cmbFromUnit.SelectedItem != null && cmbToUnit.SelectedItem != null)
            {
                
                string conversion = $"{txtInput.Text} {cmbFromUnit.SelectedItem} = {txtOutput.Text} {cmbToUnit.SelectedItem}";

                
                listBoxSavedConversions.Items.Add(conversion);

                
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please perform a conversion first before saving.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ClearInputFields()
        {
            txtInput.Text = "";
            txtOutput.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double inputValue))
            {
                if (cmbFromUnit.SelectedItem != null && cmbToUnit.SelectedItem != null)
                {
                    string fromUnit = cmbFromUnit.SelectedItem.ToString();
                    string toUnit = cmbToUnit.SelectedItem.ToString();

                    double result = ConvertVolume(inputValue, fromUnit, toUnit);
                    txtOutput.Text = result.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Please select units for conversion.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for conversion.");
            }
        }


        private void LoadUnits()
        {

            string[] units = { "Liters", "Milliliters", "Cubic Meters", "Cubic Feet", "Gallons" };
            cmbFromUnit.Items.AddRange(units);
            cmbToUnit.Items.AddRange(units);


            cmbFromUnit.SelectedIndex = 0;
            cmbToUnit.SelectedIndex = 1;
        }


        private double ConvertVolume(double value, string fromUnit, string toUnit)
        {

            double result = value;


            switch (fromUnit)
            {
                case "Liters":
                    switch (toUnit)
                    {
                        case "Milliliters":
                            result *= 1000;
                            break;
                        case "Cubic Meters":
                            result /= 1000;
                            break;
                        case "Cubic Feet":
                            result *= 0.0353147;
                            break;
                        case "Gallons":
                            result *= 0.264172;
                            break;
                    }
                    break;
                case "Milliliters":
                    switch (toUnit)
                    {
                        case "Liters":
                            result /= 1000;
                            break;
                        case "Cubic Meters":
                            result /= 1e+6;
                            break;
                        case "Cubic Feet":
                            result *= 3.53147e-5;
                            break;
                        case "Gallons":
                            result *= 0.000264172;
                            break;
                    }
                    break;
                case "Cubic Meters":
                    switch (toUnit)
                    {
                        case "Liters":
                            result *= 1000;
                            break;
                        case "Milliliters":
                            result *= 1e+6;
                            break;
                        case "Cubic Feet":
                            result *= 35.3147;
                            break;
                        case "Gallons":
                            result *= 264.172;
                            break;
                    }
                    break;
                case "Cubic Feet":
                    switch (toUnit)
                    {
                        case "Liters":
                            result /= 0.0353147;
                            break;
                        case "Milliliters":
                            result /= 3.53147e-5;
                            break;
                        case "Cubic Meters":
                            result /= 35.3147;
                            break;
                        case "Gallons":
                            result *= 7.48052;
                            break;
                    }
                    break;
                case "Gallons":
                    switch (toUnit)
                    {
                        case "Liters":
                            result /= 0.264172;
                            break;
                        case "Milliliters":
                            result /= 0.000264172;
                            break;
                        case "Cubic Meters":
                            result /= 264.172;
                            break;
                        case "Cubic Feet":
                            result /= 7.48052;
                            break;
                    }
                    break;
            }

            return result;
        }


        private void date_Time_Converter_Menu1_Load(object sender, EventArgs e)
        {

        }

        private void Volume_Converter_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
