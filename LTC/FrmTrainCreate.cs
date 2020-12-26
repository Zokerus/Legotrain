using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTC
{
    public partial class FrmTrainCreate : Form
    {
        FrmMainWindow main;

        public FrmTrainCreate(FrmMainWindow _main, int numSections)
        {
            InitializeComponent();
            main = _main;
            for(int i = 0; i < numSections; i++)
            {
                this.CbbPosition.Items.Add("Abschnitt " + i);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            main.CreateTrain(TxbName.Text,  CbbPosition.SelectedIndex);
            this.Close();
        }
    }
}
