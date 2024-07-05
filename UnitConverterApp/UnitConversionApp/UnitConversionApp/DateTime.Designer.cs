namespace UnitConversionApp
{
    partial class DateTime
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.date_Time_Converter_Menu1 = new UnitConversionApp.Date_Time_Converter_Menu();
            this.SuspendLayout();
            // 
            // date_Time_Converter_Menu1
            // 
            this.date_Time_Converter_Menu1.Location = new System.Drawing.Point(3, 16);
            this.date_Time_Converter_Menu1.Name = "date_Time_Converter_Menu1";
            this.date_Time_Converter_Menu1.Size = new System.Drawing.Size(729, 558);
            this.date_Time_Converter_Menu1.TabIndex = 0;
            this.date_Time_Converter_Menu1.Load += new System.EventHandler(this.date_Time_Converter_Menu1_Load);
            // 
            // DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.date_Time_Converter_Menu1);
            this.Name = "DateTime";
            this.Size = new System.Drawing.Size(735, 577);
            this.ResumeLayout(false);

        }

        #endregion

        private Date_Time_Converter_Menu date_Time_Converter_Menu1;
    }
}
