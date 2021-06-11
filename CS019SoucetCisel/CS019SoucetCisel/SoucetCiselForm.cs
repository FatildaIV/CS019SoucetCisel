using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS019SoucetCisel
{
	public partial class SoucetCiselForm : Form
	{
		public SoucetCiselForm()
		{
			InitializeComponent();
		}

		private void cislaTextBox_TextChanged(object sender, EventArgs e)
		{

			soucetLabel.Text = string.Format("Soucet: {0}", Soucet(cislaTextBox.Text.Split(";")));
		}

		private static double Soucet(string[] cisla)
		{
			double soucet = 0;
			for (var i = 0; i < cisla.Length; i++)
			{

				double tmp;
				if (double.TryParse(cisla[i], out tmp))
					soucet += double.Parse(cisla[i]);
			}
			return soucet;
		}

	}
}
