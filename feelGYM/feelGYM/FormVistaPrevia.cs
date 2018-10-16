using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feelGYM
{
    public partial class FormVistaPrevia : Form
    {
        public FormVistaPrevia()
        {
            InitializeComponent();
        }

        private void FormVistaPrevia_Load(object sender, EventArgs e)
        {
            String query = "SELECT socio.nombre, socio.apellido, profesores.nombreApe, planejercicios.nroPlan, " +
                "planejercicios.fechaInicio, planejercicios.fechaFin, planejercicios.numSesiones, planejercicios.objetivo, " +
                "planejercicios.observacion, detalleplanejercicios.nroSesion, detalleplanejercicios.observacionesEC, " +
                "detalleplanejercicios.intensidad, detalleplanejercicios.series, detalleplanejercicios.repeticiones, " +
                "detalleplanejercicios.observacionesD, ejercicios.nombre AS 'Ejercicio', planejercicios.dniSocio, " +
                "tipoejercicio.nombre AS 'Tipo Ejercicio', tipodetalleejercicio.nombre as 'NombreDetalle' " +
                "FROM socio JOIN planejercicios ON socio.dni = planejercicios.dniSocio " +
                "JOIN detalleplanejercicios ON detalleplanejercicios.nroPlan = planejercicios.nroPlan AND detalleplanejercicios.dniSocio = planejercicios.dniSocio " +
                "JOIN profesores ON profesores.dniProfe = planejercicios.dniProfe " +
                "JOIN ejercicios ON ejercicios.id = detalleplanejercicios.idEjercicio " +
                "JOIN tipoejercicio ON tipoejercicio.id = detalleplanejercicios.idTipoDetalle " +
                "JOIN tipodetalleejercicio ON tipodetalleejercicio.id = detalleplanejercicios.idTipoDetalle " +
                "WHERE planejercicios.nroPlan = 1 AND planejercicios.dniSocio = 15000111";

            Clases.Metodos m = new Clases.Metodos();
            int nroS = Clases.Metodos.ObtenerNroSesiones(1, 15000111);
            int x = 8;
            int y = 8;

            //for que crea dataGridView, uno para cada sesion.
            for (int i = 0; i < nroS; i++)
            {
                DataGridView dg = new DataGridView();
                Controls.Add(dg);
                int nroSesion = i + 1;
                dg.Name = "grilla"+nroSesion;
                dg.Location = new Point(x, y);
                dg.Size = new Size(750, 200);
                //x = x + 450;
                y += 250;

                if (dg.Name == "grilla"+nroSesion)
                {
                    string querySesion = "SELECT tipodetalleejercicio.nombre, ejercicios.nombre, detalleplanejercicios.observacionesEC, detalleplanejercicios.intensidad, detalleplanejercicios.series, detalleplanejercicios.repeticiones, detalleplanejercicios.observacionesD FROM ejercicios JOIN detalleplanejercicios ON ejercicios.id = detalleplanejercicios.idEjercicio JOIN tipodetalleejercicio ON tipodetalleejercicio.id = detalleplanejercicios.idTipoDetalle WHERE detalleplanejercicios.nroPlan = 1 AND detalleplanejercicios.dniSocio = 15000111 AND detalleplanejercicios.nroSesion = " + nroSesion + " ORDER BY detalleplanejercicios.idTipoDetalle";
                    //string queryEC = "SELECT ejercicios.nombre, detalleplanejercicios.observacionesEC, detalleplanejercicios.idTipoDetalle FROM ejercicios JOIN detalleplanejercicios ON ejercicios.id = detalleplanejercicios.idEjercicio WHERE detalleplanejercicios.nroPlan = 9 AND detalleplanejercicios.dniSocio = 15000111 AND detalleplanejercicios.nroSesion = " + nroSesion + " AND detalleplanejercicios.idTipoDetalle = 1";
                    m.LlenarGridReporte(dg, querySesion);
                }
               
            }



            m.LlenarGridReporte(dgv_vistaprevia, query);


        }

        ReportDataSource rs = new ReportDataSource();

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            List < Clases.Class1> listDatosImp = new List<Clases.Class1>();
            listDatosImp.Clear();

            for (int i = 0; i < dgv_vistaprevia.Rows.Count -1 ; i++)
            {

                Clases.Class1 datos = new Clases.Class1
                {
                    NombreSocio = dgv_vistaprevia.Rows[i].Cells["nombre"].Value.ToString(),
                    ApellidoSocio = dgv_vistaprevia.Rows[i].Cells["apellido"].Value.ToString(),
                    NombreApeProfe = dgv_vistaprevia.Rows[i].Cells["nombreApe"].Value.ToString(),
                    NroPlan = int.Parse(dgv_vistaprevia.Rows[i].Cells["nroPlan"].Value.ToString()),
                    NombreDetalle = dgv_vistaprevia.Rows[i].Cells["NombreDetalle"].Value.ToString()
                };

                listDatosImp.Add(datos);
            }

            rs.Name = "DataSet1";
            rs.Value = listDatosImp;
            Form3 frm = new Form3();
            frm.reportViewerImprimir.LocalReport.DataSources.Clear();
            frm.reportViewerImprimir.LocalReport.DataSources.Add(rs);
            frm.reportViewerImprimir.LocalReport.ReportEmbeddedResource = "feelGYM.ReporteDatos.rdlc";
            frm.ShowDialog();


        }

        //public class DatosImpresion
        //{
        //    public string NombreSocio { get; set; }
        //    public string ApellidoSocio { get; set; }
        //    public int NroPlan { get; set; }
        //    public string NombreApeProfe { get; set; }
        //    public int IdTipoDetalle { get; set; }
        //}

        
    }
}
