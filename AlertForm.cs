using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InAppAlerts
{
    public class AlertForm : Form
    {
        public AlertForm(string message)
        {
            // === Form Styling ===
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = new Size(320, 130);

            // Rounded corners
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));

            // Position bottom-right
            var screen = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(screen.Right - this.Width - 450,
                                      screen.Bottom - this.Height - 450);

            this.TopMost = true;

            // === Build UI ===
            SetupUI(message);
        }

        private void SetupUI(string message)
        {
            // Icon
            PictureBox icon = new PictureBox
            {
                Image = SystemIcons.Warning.ToBitmap(),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(32, 32),
                Location = new Point(15, 20)
            };
            this.Controls.Add(icon);

            // Message Label
            Label lblMessage = new Label
            {
                Text = message,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(60, 30)
            };
            this.Controls.Add(lblMessage);

            // Restart Service button
            Button btnRestart = new Button
            {
                Text = "Restart Service",
                Size = new Size(120, 35),
                BackColor = Color.FromArgb(255, 192, 57), // Orange
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Location = new Point(60, 80)
            };
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.Click += BtnRestart_Click;
            this.Controls.Add(btnRestart);

            // Close button
            /*
            Button btnClose = new Button
            {
                Text = "X",
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = Color.Gray,
                Location = new Point(this.Width - 40, 10)
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => { this.Close(); };
            this.Controls.Add(btnClose);*/
        }
        

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Restart Service clicked (dummy).",
                            "Service Control",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // GDI32 Rounded Corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void AlertForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AlertForm
            // 
            this.ClientSize = new System.Drawing.Size(402, 347);
            this.Name = "AlertForm";
            this.Load += new System.EventHandler(this.AlertForm_Load_1);
            this.ResumeLayout(false);

        }

        private void AlertForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}