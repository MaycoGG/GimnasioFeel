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
        ReportDataSource rsDetalle1 = new ReportDataSource();
        ReportDataSource rsDetalle2 = new ReportDataSource();
        ReportDataSource rsDetalle3 = new ReportDataSource();
        ReportDataSource rsDetalle4 = new ReportDataSource();
        ReportDataSource rsDetalle5 = new ReportDataSource();
        ReportDataSource rsDetalle6 = new ReportDataSource();

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            #region DataSet Datos - Encabezado
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
            #endregion

            #region DatasetDetalle - 1
            List<Clases.ImpresionDetalle> listDetalle1 = new List<Clases.ImpresionDetalle>();
            listDetalle1.Clear();
            Clases.ImpresionDetalle datosDetalle1 = new Clases.ImpresionDetalle();

            if (grillas.ElementAt(0) != null)
            {
                for (int j = 0; j < grillas.ElementAt(0).Rows.Count - 1; j++)
                {
                    datosDetalle1.ejercicio = grillas.ElementAt(0).Rows[j].Cells[1].Value.ToString();
                    datosDetalle1.intesidad = grillas.ElementAt(0).Rows[j].Cells[2].Value.ToString();
                    datosDetalle1.series = grillas.ElementAt(0).Rows[j].Cells[3].Value.ToString();
                    datosDetalle1.repeticiones = grillas.ElementAt(0).Rows[j].Cells[4].Value.ToString();
                    datosDetalle1.observacionDetalle = grillas.ElementAt(0).Rows[j].Cells[5].Value.ToString();
                    listDetalle1.Add(new Clases.ImpresionDetalle(datosDetalle1.ejercicio, datosDetalle1.intesidad,datosDetalle1.series,datosDetalle1.repeticiones,datosDetalle1.observacionDetalle));
                }
            }

            rsDetalle1.Name = "DataSet2";
            rsDetalle1.Value = listDetalle1;

            #endregion

            #region DatasetDetalle - 2
            List<Clases.ImpresionDetalle> listDetalle2 = new List<Clases.ImpresionDetalle>();
            listDetalle2.Clear();
            Clases.ImpresionDetalle datosDetalle2 = new Clases.ImpresionDetalle();

            if (grillas.ElementAt(1) != null)
            {
                for (int j = 0; j < grillas.ElementAt(1).Rows.Count - 1; j++)   
                {
                    datosDetalle2.ejercicio = grillas.ElementAt(1).Rows[j].Cells[1].Value.ToString();
                    datosDetalle2.intesidad = grillas.ElementAt(1).Rows[j].Cells[2].Value.ToString();
                    datosDetalle2.series = grillas.ElementAt(1).Rows[j].Cells[3].Value.ToString();
                    datosDetalle2.repeticiones = grillas.ElementAt(1).Rows[j].Cells[4].Value.ToString();
                    datosDetalle2.observacionDetalle = grillas.ElementAt(1).Rows[j].Cells[5].Value.ToString();
                    listDetalle2.Add(new Clases.ImpresionDetalle(datosDetalle2.ejercicio, datosDetalle2.intesidad, datosDetalle2.series, datosDetalle2.repeticiones, datosDetalle2.observacionDetalle));
                }
            }

            rsDetalle2.Name = "DataSet3";
            rsDetalle2.Value = listDetalle2;
            #endregion

            #region DatasetDetalle - 3
            List<Clases.ImpresionDetalle> listDetalle3 = new List<Clases.ImpresionDetalle>();
            listDetalle3.Clear();
            Clases.ImpresionDetalle datosDetalle3 = new Clases.ImpresionDetalle();

            if (grillas.Count == 3)
            {
                for (int j = 0; j < grillas.ElementAt(2).Rows.Count - 1; j++)
                {
                    datosDetalle3.ejercicio = grillas.ElementAt(2).Rows[j].Cells[1].Value.ToString();
                    datosDetalle3.intesidad = grillas.ElementAt(2).Rows[j].Cells[2].Value.ToString();
                    datosDetalle3.series = grillas.ElementAt(2).Rows[j].Cells[3].Value.ToString();
                    datosDetalle3.repeticiones = grillas.ElementAt(2).Rows[j].Cells[4].Value.ToString();
                    datosDetalle3.observacionDetalle = grillas.ElementAt(2).Rows[j].Cells[5].Value.ToString();
                    listDetalle3.Add(new Clases.ImpresionDetalle(datosDetalle3.ejercicio, datosDetalle3.intesidad, datosDetalle3.series, datosDetalle3.repeticiones, datosDetalle3.observacionDetalle));
                }
            }

            rsDetalle3.Name = "DataSet4";
            rsDetalle3.Value = listDetalle3;
            #endregion

            #region DatasetDetalle - 4
            List<Clases.ImpresionDetalle> listDetalle4 = new List<Clases.ImpresionDetalle>();
            listDetalle4.Clear();
            Clases.ImpresionDetalle datosDetalle4 = new Clases.ImpresionDetalle();

            if (grillas.Count == 4)
            {
                for (int j = 0; j < grillas.ElementAt(3).Rows.Count - 1; j++)
                {
                    datosDetalle4.ejercicio = grillas.ElementAt(3).Rows[j].Cells[1].Value.ToString();
                    datosDetalle4.intesidad = grillas.ElementAt(3).Rows[j].Cells[2].Value.ToString();
                    datosDetalle4.series = grillas.ElementAt(3).Rows[j].Cells[3].Value.ToString();
                    datosDetalle4.repeticiones = grillas.ElementAt(3).Rows[j].Cells[4].Value.ToString();
                    datosDetalle4.observacionDetalle = grillas.ElementAt(3).Rows[j].Cells[5].Value.ToString();
                    listDetalle4.Add(new Clases.ImpresionDetalle(datosDetalle4.ejercicio, datosDetalle4.intesidad, datosDetalle4.series, datosDetalle4.repeticiones, datosDetalle4.observacionDetalle));
                }
            }

            rsDetalle4.Name = "DataSet5";
            rsDetalle4.Value = listDetalle4;
            #endregion

            #region DatasetDetalle - 5
            List<Clases.ImpresionDetalle> listDetalle5 = new List<Clases.ImpresionDetalle>();
            listDetalle5.Clear();
            Clases.ImpresionDetalle datosDetalle5 = new Clases.ImpresionDetalle();

            if (grillas.Count == 5)
            {
                for (int j = 0; j < grillas.ElementAt(4).Rows.Count - 1; j++)
                {
                    datosDetalle5.ejercicio = grillas.ElementAt(4).Rows[j].Cells[1].Value.ToString();
                    datosDetalle5.intesidad = grillas.ElementAt(4).Rows[j].Cells[2].Value.ToString();
                    datosDetalle5.series = grillas.ElementAt(4).Rows[j].Cells[3].Value.ToString();
                    datosDetalle5.repeticiones = grillas.ElementAt(4).Rows[j].Cells[4].Value.ToString();
                    datosDetalle5.observacionDetalle = grillas.ElementAt(4).Rows[j].Cells[5].Value.ToString();
                    listDetalle5.Add(new Clases.ImpresionDetalle(datosDetalle5.ejercicio, datosDetalle5.intesidad, datosDetalle5.series, datosDetalle5.repeticiones, datosDetalle5.observacionDetalle));
                }
            }

            rsDetalle5.Name = "DataSet6";
            rsDetalle5.Value = listDetalle5;
            #endregion

            #region DatasetDetalle - 6
            List<Clases.ImpresionDetalle> listDetalle6 = new List<Clases.ImpresionDetalle>();
            listDetalle6.Clear();
            Clases.ImpresionDetalle datosDetalle6 = new Clases.ImpresionDetalle();

            if (grillas.Count == 6)
            {
                for (int j = 0; j < grillas.ElementAt(5).Rows.Count - 1; j++)
                {
                    datosDetalle6.ejercicio = grillas.ElementAt(5).Rows[j].Cells[1].Value.ToString();
                    datosDetalle6.intesidad = grillas.ElementAt(5).Rows[j].Cells[2].Value.ToString();
                    datosDetalle6.series = grillas.ElementAt(5).Rows[j].Cells[3].Value.ToString();
                    datosDetalle6.repeticiones = grillas.ElementAt(5).Rows[j].Cells[4].Value.ToString();
                    datosDetalle6.observacionDetalle = grillas.ElementAt(5).Rows[j].Cells[5].Value.ToString();
                    listDetalle6.Add(new Clases.ImpresionDetalle(datosDetalle6.ejercicio, datosDetalle6.intesidad, datosDetalle6.series, datosDetalle6.repeticiones, datosDetalle6.observacionDetalle));
                }
            }

            rsDetalle6.Name = "DataSet7";
            rsDetalle6.Value = listDetalle6;
            #endregion



            Form3 frm = new Form3();
            frm.reportViewerImprimir.LocalReport.DataSources.Clear();

            //Agregar los DataSources de cada DataSet
            frm.reportViewerImprimir.LocalReport.DataSources.Add(rs);
            frm.reportViewerImprimir.LocalReport.DataSources.Add(rsDetalle1);
            frm.reportViewerImprimir.LocalReport.DataSources.Add(rsDetalle2);
            frm.reportViewerImprimir.LocalReport.DataSources.Add(rsDetalle3);
            frm.reportViewerImprimir.LocalReport.DataSources.Add(rsDetalle4);
            frm.reportViewerImprimir.LocalReport.DataSources.Add(rsDetalle5);
            frm.reportViewerImprimir.LocalReport.DataSources.Add(rsDetalle6);

            //asigna el reporte
            frm.reportViewerImprimir.LocalReport.ReportEmbeddedResource = "feelGYM.ReporteImpresion.rdlc";

            //parametros para ocultar las tablas
            #region asignamos los parametros

            ReportParameter s1 = new ReportParameter("s1", "Sesión 1");
            frm.reportViewerImprimir.LocalReport.SetParameters(s1);
            ReportParameter s2 = new ReportParameter("s2", "Sesión 2");
            frm.reportViewerImprimir.LocalReport.SetParameters(s2);
            ReportParameter s3 = new ReportParameter("s3", "Sesión 3");
            frm.reportViewerImprimir.LocalReport.SetParameters(s3);
            ReportParameter s4 = new ReportParameter("s4", "Sesión 4");
            frm.reportViewerImprimir.LocalReport.SetParameters(s4);
            ReportParameter s5 = new ReportParameter("s5", "Sesión 5");
            frm.reportViewerImprimir.LocalReport.SetParameters(s5);
            ReportParameter s6 = new ReportParameter("s6", "Sesión 6");
            frm.reportViewerImprimir.LocalReport.SetParameters(s6);


            if (listDetalle1.Count != 0)
            {
                ReportParameter dts1 = new ReportParameter("dts1", "false");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts1);
            }
            else
            {
                ReportParameter dts1 = new ReportParameter("dts1", "true");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts1);
            }

            if (listDetalle2.Count != 0)
            {
                ReportParameter dts2 = new ReportParameter("dts2", "false");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts2);
            }
            else
            {
                ReportParameter dts2 = new ReportParameter("dts2", "true");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts2);
            }
            if (listDetalle3.Count != 0)
            {
                ReportParameter dts3 = new ReportParameter("dts3", "false");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts3);
            }
            else
            {
                ReportParameter dts3 = new ReportParameter("dts3", "true");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts3);
            }
            if (listDetalle4.Count != 0)
            {
                ReportParameter dts4 = new ReportParameter("dts4", "false");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts4);
            }
            else
            {
                ReportParameter dts4 = new ReportParameter("dts4", "true");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts4);
            }
            if (listDetalle5.Count != 0)
            {
                ReportParameter dts5 = new ReportParameter("dts5", "false");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts5);
            }
            else
            {
                ReportParameter dts5 = new ReportParameter("dts5", "true");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts5);
            }
            if (listDetalle6.Count != 0)
            {
                ReportParameter dts6 = new ReportParameter("dts6", "false");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts6);
            }
            else
            {
                ReportParameter dts6 = new ReportParameter("dts6", "true");
                frm.reportViewerImprimir.LocalReport.SetParameters(dts6);
            }
            #endregion

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
                    string querySesion = "SELECT tipodetalleejercicio.nombre as 'Tipo Ejercicio', ejercicios.nombre, detalleplanejercicios.intensidad, detalleplanejercicios.series, detalleplanejercicios.repeticiones, detalleplanejercicios.observacionesEC as 'Observaciones' FROM ejercicios JOIN detalleplanejercicios ON ejercicios.id = detalleplanejercicios.idEjercicio JOIN tipodetalleejercicio ON tipodetalleejercicio.id = detalleplanejercicios.idTipoDetalle WHERE detalleplanejercicios.nroPlan = 1 AND detalleplanejercicios.dniSocio = 15000111 AND detalleplanejercicios.nroSesion = " + nroSesion + " ORDER BY detalleplanejercicios.idTipoDetalle";
                    //string queryEC = "SELECT ejercicios.nombre, detalleplanejercicios.observacionesEC, detalleplanejercicios.idTipoDetalle FROM ejercicios JOIN detalleplanejercicios ON ejercicios.id = detalleplanejercicios.idEjercicio WHERE detalleplanejercicios.nroPlan = 9 AND detalleplanejercicios.dniSocio = 15000111 AND detalleplanejercicios.nroSesion = " + nroSesion + " AND detalleplanejercicios.idTipoDetalle = 1";
                    m.LlenarGridReporte(dg, querySesion);
                }

                grillas.Add(dg);

            }
        }

        
    }
}
