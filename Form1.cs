using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora_3_Problema_1
{
    public partial class Form1 : Form
    {
        int contador = 0;
        Empleados[] emp = new Empleados[100];
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            emp[contador] = new Empleados();
            string valor = txtNombre.Text;
            emp[contador].setNombre(valor);
            valor = txtArea.Text;
            emp[contador].setArea(valor);
            valor = txtSueldo.Text;
            emp[contador].setSueldo(valor);
            Limpiar();
            contador++;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();
            for (int i = 0; i < contador; i++)
            {
                dgvEmpleados.Rows.Add(1);
                dgvEmpleados.Rows[i].Cells[0].Value = emp[i].getNombre();
                dgvEmpleados.Rows[i].Cells[1].Value = emp[i].getArea();
                dgvEmpleados.Rows[i].Cells[2].Value = emp[i].getSueldo();
                dgvEmpleados.Refresh();
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();
            int g = 0;
            for (int i = 0; i < contador; i++)
            {
                if (emp[i].getArea() == txtFiltro.Text)
                {
                    dgvEmpleados.Rows.Add(1);
                    dgvEmpleados.Rows[g].Cells[0].Value = emp[i].getNombre();
                    dgvEmpleados.Rows[g].Cells[1].Value = emp[i].getArea();
                    dgvEmpleados.Rows[g].Cells[2].Value = emp[i].getSueldo();
                    dgvEmpleados.Refresh();
                    g++;
                }
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtArea.Text = string.Empty;
            txtSueldo.Text = string.Empty;
            txtNombre.Focus();
        }
    }
}
