using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InAppAlerts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private AlertForm stickyAlert; // keep reference

        private void btnAlert_Click(object sender, EventArgs e)
        {
            // If already showing, don't show again
            if (stickyAlert == null || stickyAlert.IsDisposed)
            {
                stickyAlert = new AlertForm("⚠ Service Stopped!");
                stickyAlert.Show(); // non-blocking
            }
        }

       

        private void btnCloseAlert_Click_1(object sender, EventArgs e)
        {
            if (stickyAlert != null && !stickyAlert.IsDisposed)
            {
                stickyAlert.Close();
            }
        }
    }
}

