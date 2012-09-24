using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelMana
{
    public partial class Nhatky : Form
    {
        public Nhatky()
        {
            InitializeComponent();
        }

        private void Nhatky_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.selectAllEmploy' table. You can move, or remove it, as needed.
            this.selectAllEmployTableAdapter.Fill(this.dataDataSet.selectAllEmploy);

        }
    }
}
