using OrçamentosAPP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrçamentosAPP
{
    public partial class Home : Form
    {
        public Home()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void btnMenuCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro frmCadastro = new FormCadastro();
            frmCadastro.TopLevel = false;
            frmCadastro.Visible = true;
            panelContent.Controls.Add(frmCadastro);

        }
    }
}
