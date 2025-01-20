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
    public partial class CUEmpleados : UserControl
    {
        public CUEmpleados()
        {
            InitializeComponent();
        }

        private void btnAgregarPersonal_Click_1(object sender, EventArgs e)
        {
            Empleados.frmEmpleados frmpersonal = new Empleados.frmEmpleados("n");
            frmpersonal.ShowDialog();
        }
    }
}
