using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica
{
    public partial class scelta_allievo : Form
    {
        public scelta_allievo()
        {
            InitializeComponent();
        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            scelta_allievo formInsert = new scelta_allievo();
            formInsert.ShowDialog();
        }
    }
}
