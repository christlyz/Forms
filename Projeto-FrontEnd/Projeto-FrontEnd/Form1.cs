using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_FrontEnd
{
    public partial class CriCri : Form
    {
        public CriCri()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Form2 prodForm = new Form2();
            prodForm.ShowDialog();
        }
    }
}
