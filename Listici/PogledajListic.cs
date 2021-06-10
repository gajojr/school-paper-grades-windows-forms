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
    public partial class PogledajListic : Form
    {
        public PogledajListic()
        {
            InitializeComponent();
        }

        private void traziUcenika_Click(object sender, EventArgs e)
        {
            string ime = imeUnos.Text;
            string prezime = prezimeUnos.Text;
            string odeljenje = odeljenjeUnos.Text;
        }
    }
}
