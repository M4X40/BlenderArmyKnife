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
using System.Net;
using System.IO;

namespace BlenderArmyKnife
{
	public partial class BlenderArmyKnife : Form
	{
		public BlenderArmyKnife()
		{
			InitializeComponent();
		}

		private void UDumpImporter_Click(object sender, EventArgs e)
		{
			WebClient client = new WebClient{ Encoding = Encoding.UTF8 };
			Clipboard.SetText(client.DownloadString("https://raw.githubusercontent.com/M4X40/UDumptoBlender/main/importer.py"));
			var popupWindow = new Popup();
			popupWindow.Show();
		}

		private void FindReplaceMat_Click(object sender, EventArgs e)
		{
			WebClient client = new WebClient { Encoding = Encoding.UTF8 };
			Clipboard.SetText(client.DownloadString("https://raw.githubusercontent.com/M4X40/BlenderArmyKnife/scripts/findreplacematerial.txt"));
			var popupWindow = new Popup();
			popupWindow.Show();
		}

		private void MatUVDupe_Click(object sender, EventArgs e)
		{
			WebClient client = new WebClient { Encoding = Encoding.UTF8 };
			Clipboard.SetText(client.DownloadString("https://raw.githubusercontent.com/M4X40/BlenderArmyKnife/scripts/Mat-UV_Looping.txt"));
			var popupWindow = new Popup();
			popupWindow.Show();
		}

		private void FindNodeType_Click(object sender, EventArgs e)
		{
			WebClient client = new WebClient { Encoding = Encoding.UTF8 };
			Clipboard.SetText(client.DownloadString("https://raw.githubusercontent.com/M4X40/BlenderArmyKnife/scripts/FindNodeType.txt"));
			var popupWindow = new Popup();
			popupWindow.Show();
		}

		private void GroupToPBSDF_Click(object sender, EventArgs e)
		{
			WebClient client = new WebClient { Encoding = Encoding.UTF8 };
			Clipboard.SetText(client.DownloadString("https://raw.githubusercontent.com/M4X40/BlenderArmyKnife/scripts/GroupToPBSDF.txt"));
			var popupWindow = new Popup();
			popupWindow.Show();

		}

		private void RemoveMatClones_Click(object sender, EventArgs e)
		{
			WebClient client = new WebClient { Encoding = Encoding.UTF8 };
			Clipboard.SetText(client.DownloadString("https://raw.githubusercontent.com/M4X40/BlenderArmyKnife/scripts/RemoveMaterialClones.txt"));
			var popupWindow = new Popup();
			popupWindow.Show();
		}
	}
}
