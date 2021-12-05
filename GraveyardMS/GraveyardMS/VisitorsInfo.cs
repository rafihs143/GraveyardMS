using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraveyardMS
{
    public partial class VisitorsInfo : Form
    {
        public VisitorsInfo()
        {
            InitializeComponent();
        }
        private void VisitorsInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void VisitorsInfo_Load(object sender, EventArgs e)
        {
            //UpdateGridView();
            VisitorDataAccess visitorDataAccess = new VisitorDataAccess();
            visitorsInfoGridView.DataSource = visitorDataAccess.GetVisitors();
        }

        
    }
}
