using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.utils;
using ControlPresenciaSoapServiceReference;

namespace WinFormsApp1
{
    public partial class ucSalas : UserControl
    {
        public ucSalas()
        {
            InitializeComponent();
            Utils.ConfigurarDataGridView(consultarSalasDataGridView, this.BackColor);
        }

        private void consultarSalaButton_Click(object sender, EventArgs e)
        {

        }
    }
}
