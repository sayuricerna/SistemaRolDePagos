using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rol_De_Pagos.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            CUEmpleados frm = new CUEmpleados();
            PanelGeneral.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frm);
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            CUCargos frm = new CUCargos();
            PanelGeneral.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frm);
        }

        private void btnRolDePagos_Click(object sender, EventArgs e)
        {
            CURolDePagos frm = new CURolDePagos();
            PanelGeneral.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frm);
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            CUMovimientos frm = new CUMovimientos();
            PanelGeneral.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frm);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
