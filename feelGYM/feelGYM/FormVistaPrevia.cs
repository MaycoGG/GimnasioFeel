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

        Clases.Metodos m = new Clases.Metodos();

        List<DataGridView> grillas = new List<DataGridView>();

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

            GenerarGrillas();
            m.LlenarGridReporte(dgv_vistaprevia, query);


        }

        ReportDataSource rs = new ReportDataSource();
        ReportDataSource rsDetalle = new ReportDataSource();

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            List<Clases.Imprimir> listDatosImp = new List<Clases.Imprimir>();
            listDatosImp.Clear();
            Clases.Imprimir datos = new Clases.Imprimir();

            for (int i = 0; i < dgv_vistaprevia.Rows.Count - 1; i++)
            {


                datos.NombreSocio = dgv_vistaprevia.Rows[i].Cells["nombre"].Value.ToString();
                datos.ApellidoSocio = dgv_vistaprevia.Rows[i].Cells["apellido"].Value.ToString();
                datos.NombreApeProfe = dgv_vistaprevia.Rows[i].Cells["nombreApe"].Value.ToString();
                datos.NroPlan = int.Parse(dgv_vistaprevia.Rows[i].Cells["nroPlan"].Value.ToString());
                datos.objetivo = dgv_vistaprevia.Rows[i].Cells["objetivo"].Value.ToString();
                datos.observacionPlan = dgv_vistaprevia.Rows[i].Cells["observacion"].Value.ToString();
                datos.fechaInicio = dgv_vistaprevia.Rows[i].Cells["fechaInicio"].Value.ToString();
                datos.fechaFin = dgv_vistaprevia.Rows[i].Cells["fechaFin"].Value.ToString();

                datos.ejercicio = dgv_vistaprevia.Rows[i].Cells["Ejercicio"].Value.ToString();

                listDatosImp.Add(datos);
            }

            rs.Name = "DataSet1";
            rs.Value = listDatosImp;

            List<Clases.ImpresionDetalle> listDetalle = new List<Clases.ImpresionDetalle>();
            listDetalle.Clear();
            Clases.ImpresionDetalle datosDetalle = new Clases.ImpresionDetalle();
            
            for (int j = 0; j < grillas.ElementAt(0).Rows.Count - 1; j++)
            {
                datosDetalle.ejercicio = grillas.ElementAt(0).Rows[j].Cells[1].Value.ToString();
                listDetalle.Add(new Clases.ImpresionDetalle(datosDetalle.ejercicio));
            }

            rsDetalle.Name = "DataSet2";
            rsDetalle.Value = listDetalle;

            Form3 frm = new Form3();
            frm.reportViewerImprimir.LocalReport.DataSources.Clear();
            frm.reportViewerImprimir.LocalReport.DataSources.Add(rs);
            frm.reportViewerImprimir.LocalReport.DataSources.Add(rsDetalle);
            frm.reportViewerImprimir.LocalReport.ReportEmbeddedResource = "feelGYM.ReporteImpresion.rdlc";
            frm.ShowDialog();


        }

        public void GenerarGrillas()
        {
            int nroS = Clases.Metodos.ObtenerNroSesiones(1, 15000111);
            int x = 8;
            int y = 8;

            //for que crea dataGridView, uno para cada sesion.
            for (int i = 0; i < nroS; i++)
            {
                DataGridView dg = new DataGridView();
                Controls.Add(dg);
                int nroSesion = i + 1;
                dg.Name = "grilla" + nroSesion;
                dg.Location = new Point(x, y);
                dg.Size = new Size(750, 200);
                dg.ReadOnly = true;
                //x = x + 450;
                y += 250;

                if (dg.Name == "grilla" + nroSesion)
                {
                    string querySesion = "SELECT tipodetalleejercicio.nombre as 'Tipo Ejercicio', ejercicios.nombre, detalleplanejercicios.intensidad, detalleplanejercicios.series, detalleplanejercicios.repeticiones, detalleplanejercicios.observacionesEC as 'Observaciones' FROM ejercicios JOIN detalleplanejercicios ON ejercicios.id = detalleplanejercicios.idEjercicio JOIN tipodetalleejercicio ON tipodetalleejercicio.id = detalleplanejercicios.idTipoDetalle WHERE detalleplanejercicios.nroPlan = 2 AND detalleplanejercicios.dniSocio = 15000111 AND detalleplanejercicios.nroSesion = " + nroSesion + " ORDER BY detalleplanejercicios.idTipoDetalle";
                    //string queryEC = "SELECT ejercicios.nombre, detalleplanejercicios.observacionesEC, detalleplanejercicios.idTipoDetalle FROM ejercicios JOIN detalleplanejercicios ON ejercicios.id = detalleplanejercicios.idEjercicio WHERE detalleplanejercicios.nroPlan = 9 AND detalleplanejercicios.dniSocio = 15000111 AND detalleplanejercicios.nroSesion = " + nroSesion + " AND detalleplanejercicios.idTipoDetalle = 1";
                    m.LlenarGridReporte(dg, querySesion);
                }

                grillas.Add(dg);

            }
        }

        
    }
}
