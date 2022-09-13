using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportWiew
{
    public partial class Form1 : Form
    {

        Metodos mt = new Metodos();
        public Form1()
        {
            InitializeComponent();
            rView.RefreshReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rView.RefreshReport();
            this.rView.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mt.reportone(txtNombreP.Text, rView);
        }
    }

   
}
