// Ahmad Atra
// Inventory Management
// 1/11/2018
// Uses MSACCESS Database

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            viewInventoryForm viewForm = new viewInventoryForm();
            viewForm.Show();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void editButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            editInventoryForm editForm = new editInventoryForm();
            editForm.Show();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void closeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
