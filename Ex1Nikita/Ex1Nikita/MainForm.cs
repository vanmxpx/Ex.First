using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1Nikita
{
    public partial class MainForm : Form
    {
        public int unit = 0;
        Invoker invoker = new Invoker();

        public MainForm()
        {
            InitializeComponent();
        }

        private void unitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            unitComboBox.SelectedIndex = unit;
            exersizeComboBox.Items.Clear();
            exersizeComboBox.Items.AddRange(invoker.unitsList[unit]);
            unitComboBox.Invalidate();
        }
    }
}
