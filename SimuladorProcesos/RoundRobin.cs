using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorProcesos
{
    public class RoundRobin
    {
        DataGridView dataGridView;
        private List<Proceso> ListReaders = new List<Proceso>();

        //----------------RoundRobin Class Constructor-------------------
        public RoundRobin(ref DataGridView temp_dataGridView)
        {
            dataGridView = temp_dataGridView;
        }

        //----------------Main Round Robin Algorithm Method-------------------
        public void runRoundRobin(ref Proceso[] procesos, int quantum)
        {
            foreach (var proceso1 in procesos)
            {
                proceso1.TiempoRestante = proceso1.Tiempo;
            }
            while (true)
            {
                bool executionFinished = true;
                foreach (var task in procesos)
                    {
                    if (task.TypeProcess == 1)
                    {
                        ListReaders.Add(task);
                    }
                    else if (task.TypeProcess == 2)
                    {
                        if (ListReaders.Count > 0)
                        {
                            //grafica los que estan en ListReaders
                            Console.WriteLine("grafica los que estan en ListReaders");
                            while (true)
                            {
                                bool executionFinished1 = true;

                                foreach (var proceso in ListReaders)
                                {
                                    if (proceso.TiempoRestante == 0)
                                    {
                                        proceso.Estado = "COMPLETED";
                                        updateDataGridView(dataGridView, procesos);
                                    }

                                    else if (proceso.TiempoRestante > 0)
                                    {
                                        executionFinished1 = false;
                                        if (proceso.TiempoRestante > quantum)
                                        {
                                            proceso.Estado = "RUNNING";
   
                                            updateDataGridView(dataGridView, procesos);
                                            executionTimer(quantum);
                                            proceso.TiempoRestante = proceso.TiempoRestante - quantum;
                                            updateDataGridView(dataGridView, procesos);
                                        }

                                        else
                                        {
                                            while (proceso.IO > 0)
                                            {
                                                ioExecution(procesos, proceso.Id, proceso.IO);
                                                proceso.IO = proceso.IO - 1;
                                            }

                                            proceso.Estado = "RUNNING";
                                            updateDataGridView(dataGridView, procesos);
                                            executionTimer(proceso.TiempoRestante);

                                            proceso.TiempoRestante = 0;

                                            proceso.Estado = "COMPLETED";
                                            updateDataGridView(dataGridView, procesos);
                                        }
                                    }

                                    if (proceso.IO > 0)
                                    {
                                        ioExecution(procesos, proceso.Id, proceso.IO);
                                        proceso.IO = proceso.IO - 1;
                                    }
                                }
                                if (executionFinished1 == true)
                                {
                                    break;
                                }
                            }
                        }
                        /////////////////////////////////////////////////////
                        ///
                        ListReaders.Clear();
                        Console.WriteLine("ejecuta escritor");

                        while (task.TiempoRestante > 0)
                        {
                        if (task.TiempoRestante == 0)
                        {
                            task.Estado = "COMPLETED";
                            updateDataGridView(dataGridView, procesos);
                        }

                        else if (task.TiempoRestante > 0)
                        {
                            executionFinished = false;
                            if (task.TiempoRestante > quantum)
                            {

                                task.Estado = "RUNNING";
                                updateDataGridView(dataGridView, procesos);
                                executionTimer(quantum);

                                task.TiempoRestante = task.TiempoRestante - quantum;

                                task.Estado = "READY";
                                updateDataGridView(dataGridView, procesos);
                            }

                            else
                            {
                                while (task.IO > 0)
                                {
                                    ioExecution(procesos, task.Id, task.IO);
                                    task.IO = task.IO - 1;
                                }

                                task.Estado = "RUNNING";
                                updateDataGridView(dataGridView, procesos);
                                executionTimer(task.TiempoRestante);

                                task.TiempoRestante = 0;

                                task.Estado = "COMPLETED";
                                updateDataGridView(dataGridView, procesos);
                            }
                        }
                        }
                        if (task.IO > 0)
                        {
                            ioExecution(procesos, task.Id, task.IO);
                            task.IO = task.IO - 1;
                        }
                    }
                    }
                if (executionFinished == true)
                {
                    break;
                }
            }
        }
        public void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex].Name == "Estado")  //Si es la columna a evaluar
            {
                if (e.Value.ToString().Contains("RUNNING"))   //Si el valor de la celda contiene la palabra hora
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
        //----------------Update Data Grid View Method-------------------------------
        public void updateDataGridView(DataGridView dataGridView, Proceso[] procesos)
        {

            dataGridView.Rows.Clear();
            int numRows = 0;

            foreach (var proceso in procesos)
            {
                string LectOrWritter;

                if (proceso.TypeProcess == 1)
                {
                    LectOrWritter = "READER";
                }
                else
                {
                    LectOrWritter = "WRITTER";
                }

                string[] row = { proceso.Id.ToString(), proceso.Nombre, proceso.Estado, proceso.TiempoRestante.ToString(), LectOrWritter };
                dataGridView.Rows.Add(row);

                //if (proceso.Estado == "RUNNING")
                //{
                //    numRows = dataGridView.Rows.Count - 1;

                //}
            }
            //dataGridView.ClearSelection();
            //dataGridView.Rows[numRows].Selected = true;

        }
        //----------------Process IO Execution Method
        public void ioExecution(Proceso[] procesos, int id, int interupt)
        {
            //Change Process State to Waiting when it goes to IO
            foreach (var proceso in procesos)
            {
                if (proceso.Id == id && proceso.Estado != "COMPLETED")
                {
                    proceso.Estado = "WAITING";
                }
            }
            updateDataGridView(dataGridView, procesos);

            //Execute the IO for 1 second
            executionTimer(1);

            //Change Process back to Ready State after IO has completed
            foreach (var proceso in procesos)
            {
                if (proceso.Id == id && proceso.Estado != "COMPLETED")
                {
                    proceso.Estado = "READY";
                }
            }
            updateDataGridView(dataGridView, procesos);
        }

        //----------------Process Execution Timer Method
        public void executionTimer(int tempTime)
        {
            int executionTime = tempTime * 800;
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (executionTime == 0 || executionTime < 0)
            {
                return;
            }
            timer1.Interval = executionTime;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}