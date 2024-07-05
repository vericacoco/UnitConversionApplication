namespace UnitConversionApp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_panel = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.Panel();
            this.caption_panel = new System.Windows.Forms.Panel();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.tlp_buttonsHolder = new System.Windows.Forms.TableLayoutPanel();
            this.btn_volume = new FontAwesome.Sharp.IconButton();
            this.btn_date_time = new FontAwesome.Sharp.IconButton();
            this.btn_data = new FontAwesome.Sharp.IconButton();
            this.btn_length = new FontAwesome.Sharp.IconButton();
            this.btn_currency = new FontAwesome.Sharp.IconButton();
            this.dashboard_panel = new System.Windows.Forms.Panel();
            this.dashboard_btn = new FontAwesome.Sharp.IconButton();
            this.title_bar_panel = new System.Windows.Forms.Panel();
            this.btn_minimize = new FontAwesome.Sharp.IconButton();
            this.btn_resize = new FontAwesome.Sharp.IconButton();
            this.btn_exit = new FontAwesome.Sharp.IconButton();
            this.main_panel.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.tlp_buttonsHolder.SuspendLayout();
            this.dashboard_panel.SuspendLayout();
            this.title_bar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.content_panel);
            this.main_panel.Controls.Add(this.caption_panel);
            this.main_panel.Controls.Add(this.menu_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(648, 496);
            this.main_panel.TabIndex = 0;
            // 
            // content_panel
            // 
            this.content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_panel.Location = new System.Drawing.Point(200, 95);
            this.content_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(448, 401);
            this.content_panel.TabIndex = 3;
            // 
            // caption_panel
            // 
            this.caption_panel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.caption_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.caption_panel.Location = new System.Drawing.Point(200, 0);
            this.caption_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.caption_panel.Name = "caption_panel";
            this.caption_panel.Size = new System.Drawing.Size(448, 95);
            this.caption_panel.TabIndex = 2;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menu_panel.Controls.Add(this.tlp_buttonsHolder);
            this.menu_panel.Controls.Add(this.dashboard_panel);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(200, 496);
            this.menu_panel.TabIndex = 1;
            // 
            // tlp_buttonsHolder
            // 
            this.tlp_buttonsHolder.ColumnCount = 1;
            this.tlp_buttonsHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_buttonsHolder.Controls.Add(this.btn_volume, 0, 4);
            this.tlp_buttonsHolder.Controls.Add(this.btn_date_time, 0, 3);
            this.tlp_buttonsHolder.Controls.Add(this.btn_data, 0, 2);
            this.tlp_buttonsHolder.Controls.Add(this.btn_length, 0, 1);
            this.tlp_buttonsHolder.Controls.Add(this.btn_currency, 0, 0);
            this.tlp_buttonsHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_buttonsHolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlp_buttonsHolder.Location = new System.Drawing.Point(0, 95);
            this.tlp_buttonsHolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlp_buttonsHolder.Name = "tlp_buttonsHolder";
            this.tlp_buttonsHolder.RowCount = 5;
            this.tlp_buttonsHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_buttonsHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_buttonsHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_buttonsHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_buttonsHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_buttonsHolder.Size = new System.Drawing.Size(200, 259);
            this.tlp_buttonsHolder.TabIndex = 1;
            // 
            // btn_volume
            // 
            this.btn_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_volume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_volume.FlatAppearance.BorderSize = 0;
            this.btn_volume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volume.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btn_volume.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btn_volume.IconColor = System.Drawing.Color.White;
            this.btn_volume.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_volume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_volume.Location = new System.Drawing.Point(0, 204);
            this.btn_volume.Margin = new System.Windows.Forms.Padding(0);
            this.btn_volume.Name = "btn_volume";
            this.btn_volume.Padding = new System.Windows.Forms.Padding(10, 5, 55, 5);
            this.btn_volume.Size = new System.Drawing.Size(200, 55);
            this.btn_volume.TabIndex = 8;
            this.btn_volume.Text = "Volume";
            this.btn_volume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_volume.UseVisualStyleBackColor = false;
            this.btn_volume.Click += new System.EventHandler(this.btn_volume_Click);
            this.btn_volume.MouseEnter += new System.EventHandler(this.btn_volume_MouseEnter);
            this.btn_volume.MouseLeave += new System.EventHandler(this.btn_volume_MouseLeave);
            // 
            // btn_date_time
            // 
            this.btn_date_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_date_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_date_time.FlatAppearance.BorderSize = 0;
            this.btn_date_time.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_date_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_date_time.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btn_date_time.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.btn_date_time.IconColor = System.Drawing.Color.White;
            this.btn_date_time.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_date_time.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_date_time.Location = new System.Drawing.Point(0, 153);
            this.btn_date_time.Margin = new System.Windows.Forms.Padding(0);
            this.btn_date_time.Name = "btn_date_time";
            this.btn_date_time.Padding = new System.Windows.Forms.Padding(10, 5, 13, 5);
            this.btn_date_time.Size = new System.Drawing.Size(200, 51);
            this.btn_date_time.TabIndex = 7;
            this.btn_date_time.Text = "Date and Time";
            this.btn_date_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_date_time.UseVisualStyleBackColor = false;
            this.btn_date_time.Click += new System.EventHandler(this.btn_date_time_Click);
            this.btn_date_time.MouseEnter += new System.EventHandler(this.btn_date_time_MouseEnter);
            this.btn_date_time.MouseLeave += new System.EventHandler(this.btn_date_time_MouseLeave);
            // 
            // btn_data
            // 
            this.btn_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_data.FlatAppearance.BorderSize = 0;
            this.btn_data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btn_data.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btn_data.IconColor = System.Drawing.Color.White;
            this.btn_data.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_data.Location = new System.Drawing.Point(0, 102);
            this.btn_data.Margin = new System.Windows.Forms.Padding(0);
            this.btn_data.Name = "btn_data";
            this.btn_data.Padding = new System.Windows.Forms.Padding(10, 5, 75, 5);
            this.btn_data.Size = new System.Drawing.Size(200, 51);
            this.btn_data.TabIndex = 6;
            this.btn_data.Text = "Data";
            this.btn_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_data.UseVisualStyleBackColor = false;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            this.btn_data.MouseEnter += new System.EventHandler(this.btn_data_MouseEnter);
            this.btn_data.MouseLeave += new System.EventHandler(this.btn_data_MouseLeave);
            // 
            // btn_length
            // 
            this.btn_length.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_length.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_length.FlatAppearance.BorderSize = 0;
            this.btn_length.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_length.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_length.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btn_length.IconChar = FontAwesome.Sharp.IconChar.Ruler;
            this.btn_length.IconColor = System.Drawing.Color.White;
            this.btn_length.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_length.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_length.Location = new System.Drawing.Point(0, 51);
            this.btn_length.Margin = new System.Windows.Forms.Padding(0);
            this.btn_length.Name = "btn_length";
            this.btn_length.Padding = new System.Windows.Forms.Padding(10, 5, 62, 5);
            this.btn_length.Size = new System.Drawing.Size(200, 51);
            this.btn_length.TabIndex = 5;
            this.btn_length.Text = "Length";
            this.btn_length.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_length.UseVisualStyleBackColor = false;
            this.btn_length.Click += new System.EventHandler(this.btn_length_Click);
            this.btn_length.MouseEnter += new System.EventHandler(this.btn_length_MouseEnter);
            this.btn_length.MouseLeave += new System.EventHandler(this.btn_length_MouseLeave);
            // 
            // btn_currency
            // 
            this.btn_currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_currency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_currency.FlatAppearance.BorderSize = 0;
            this.btn_currency.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_currency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_currency.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_currency.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            this.btn_currency.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_currency.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_currency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_currency.Location = new System.Drawing.Point(0, 0);
            this.btn_currency.Margin = new System.Windows.Forms.Padding(0);
            this.btn_currency.Name = "btn_currency";
            this.btn_currency.Padding = new System.Windows.Forms.Padding(10, 5, 50, 5);
            this.btn_currency.Size = new System.Drawing.Size(200, 51);
            this.btn_currency.TabIndex = 0;
            this.btn_currency.Text = "Currency";
            this.btn_currency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_currency.UseVisualStyleBackColor = false;
            this.btn_currency.Click += new System.EventHandler(this.btn_currency_Click);
            this.btn_currency.MouseEnter += new System.EventHandler(this.btn_currency_MouseEnter);
            this.btn_currency.MouseLeave += new System.EventHandler(this.btn_currency_MouseLeave);
            // 
            // dashboard_panel
            // 
            this.dashboard_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dashboard_panel.Controls.Add(this.dashboard_btn);
            this.dashboard_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard_panel.Location = new System.Drawing.Point(0, 0);
            this.dashboard_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboard_panel.Name = "dashboard_panel";
            this.dashboard_panel.Size = new System.Drawing.Size(200, 95);
            this.dashboard_panel.TabIndex = 0;
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.IconChar = FontAwesome.Sharp.IconChar.House;
            this.dashboard_btn.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboard_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(0, 24);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.dashboard_btn.Size = new System.Drawing.Size(200, 71);
            this.dashboard_btn.TabIndex = 0;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // title_bar_panel
            // 
            this.title_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.title_bar_panel.Controls.Add(this.btn_minimize);
            this.title_bar_panel.Controls.Add(this.btn_resize);
            this.title_bar_panel.Controls.Add(this.btn_exit);
            this.title_bar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_bar_panel.Location = new System.Drawing.Point(0, 0);
            this.title_bar_panel.Margin = new System.Windows.Forms.Padding(0);
            this.title_bar_panel.Name = "title_bar_panel";
            this.title_bar_panel.Size = new System.Drawing.Size(648, 25);
            this.title_bar_panel.TabIndex = 1;
            this.title_bar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.title_bar_panel_Paint);
            this.title_bar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_panel_MouseDown);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.Transparent;
            this.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btn_minimize.IconColor = System.Drawing.Color.White;
            this.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minimize.IconSize = 20;
            this.btn_minimize.Location = new System.Drawing.Point(569, 4);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(20, 19);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseEnter += new System.EventHandler(this.btn_minimize_MouseEnter);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.btn_minimize_MouseLeave);
            // 
            // btn_resize
            // 
            this.btn_resize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_resize.BackColor = System.Drawing.Color.Transparent;
            this.btn_resize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.btn_resize.FlatAppearance.BorderSize = 0;
            this.btn_resize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.btn_resize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.btn_resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resize.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btn_resize.IconColor = System.Drawing.Color.White;
            this.btn_resize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_resize.IconSize = 20;
            this.btn_resize.Location = new System.Drawing.Point(594, 4);
            this.btn_resize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(20, 19);
            this.btn_resize.TabIndex = 1;
            this.btn_resize.UseVisualStyleBackColor = false;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            this.btn_resize.MouseEnter += new System.EventHandler(this.btn_resize_MouseEnter);
            this.btn_resize.MouseLeave += new System.EventHandler(this.btn_resize_MouseLeave);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btn_exit.IconColor = System.Drawing.Color.White;
            this.btn_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_exit.IconSize = 20;
            this.btn_exit.Location = new System.Drawing.Point(619, 4);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(20, 19);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 496);
            this.Controls.Add(this.title_bar_panel);
            this.Controls.Add(this.main_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(618, 527);
            this.Name = "Form1";
            this.Text = "Form1";
            this.main_panel.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.tlp_buttonsHolder.ResumeLayout(false);
            this.dashboard_panel.ResumeLayout(false);
            this.title_bar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.TableLayoutPanel tlp_buttonsHolder;
        private FontAwesome.Sharp.IconButton btn_volume;
        private FontAwesome.Sharp.IconButton btn_date_time;
        private FontAwesome.Sharp.IconButton btn_data;
        private FontAwesome.Sharp.IconButton btn_length;
        private FontAwesome.Sharp.IconButton btn_currency;
        private System.Windows.Forms.Panel dashboard_panel;
        private System.Windows.Forms.Panel title_bar_panel;
        private FontAwesome.Sharp.IconButton btn_minimize;
        private FontAwesome.Sharp.IconButton btn_resize;
        private FontAwesome.Sharp.IconButton btn_exit;
        private System.Windows.Forms.Panel caption_panel;
        private FontAwesome.Sharp.IconButton dashboard_btn;
        private System.Windows.Forms.Panel content_panel;
    }
}

