using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlenderArmyKnife
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = this;
            myForm.Close();
        }

        private void Popup_Load(object sender, EventArgs e)
        {

        }

        private void MainLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
