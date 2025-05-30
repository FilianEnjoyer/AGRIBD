using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGRIBD
{
    public partial class EditarProductor : Form
    {
        public EditarProductor()
        {
            InitializeComponent();
        }
        ClaseSQLSERVER SQLSERVER = new ClaseSQLSERVER();
        private void OcultarDataGrids()
        {
            foreach (var dgv in this.Controls.OfType<DataGridView>())
            {
                dgv.Visible = false;
            }
            foreach (var lbl in this.Controls.OfType<Label>().Where(l => l.Text.StartsWith("Tabla: ")))
            {
                lbl.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    OcultarDataGrids();

                    if (string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        MessageBox.Show("Ingrese el ID del cultivo a actualizar.");
                        return;
                    }
                    string consultaSQL = "UPDATE Productores SET " +
                                         "nombre = '" + textBox2.Text + "', " +
                                         "email = '" + textBox3.Text + "', " +
                                         "direccion = '" + textBox4.Text + "' " +
                                         "WHERE id = " + textBox1.Text;
                    var (ds, comando) = SQLSERVER.EjecutarComandos(consultaSQL, "Productores");
                    MessageBox.Show("Productor Editado");
                    var (lbl, dgv) = SQLSERVER.CrearYMostrarDataGridView(ds, "Productores");
                    this.Controls.Add(lbl);
                    this.Controls.Add(dgv);
                    dgv.Refresh();
                }
                else
                {
                    MessageBox.Show(" Id y algun espacio mas deben estar llenos");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema: " + ex.Message);
            }
        }
    }
}
