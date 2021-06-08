using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void napraviNoviListic_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            List<Odeljenje> odeljenja = db.GetOdeljenja();

            odeljenja.ForEach(odeljenje => MessageBox.Show(odeljenje.Ime));
        }
    }
}
