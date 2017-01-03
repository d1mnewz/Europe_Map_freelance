using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Europe_Map_Task1
{
    public partial class AdditionalForm : Form
    {
        private string lastCountry;

        public AdditionalForm()
        {
            InitializeComponent();
        }

        public AdditionalForm(string lastCountry)
        {
            this.lastCountry = lastCountry;
            this.Text = lastCountry;
        }

    }
}
