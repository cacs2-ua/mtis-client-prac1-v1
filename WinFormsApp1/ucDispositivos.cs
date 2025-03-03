using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Api;
using IO.Swagger.Model;
using WinFormsApp1.utils;


namespace WinFormsApp1
{
    public partial class ucDispositivos: UserControl
    {
        public ucDispositivos()
        {
            InitializeComponent();
            Utils.ConfigurarDataGridView(consultarDispositivoDataGridView, this.BackColor);
        }
    }
}
