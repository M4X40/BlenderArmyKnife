using BlenderArmyKnife.Properties;
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
    public partial class BlenderArmyKnife : Form
    {
        public BlenderArmyKnife()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UDumpImporter_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Resources.importer);
            var popupWindow = new Popup();
            popupWindow.Show();
        }

        private void FindReplaceMat_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Resources.findreplacematerial);
            var popupWindow = new Popup();
            popupWindow.Show();
        }

        private void MatUVDupe_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Resources.Mat_UV_Looping);
            var popupWindow = new Popup();
            popupWindow.Show();
        }

        private void FindNodeType_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Resources.FindNodeType);
            var popupWindow = new Popup();
            popupWindow.Show();
        }

        private void GroupToPBSDF_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Resources.GroupToPBSDF);
            var popupWindow = new Popup();
            popupWindow.Show();

        }

        private void RemoveMatClones_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Resources.RemoveMaterialClones);
            var popupWindow = new Popup();
            popupWindow.Show();
        }
    }
}
