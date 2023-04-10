using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinThreads
{
    public partial class frmWInThreads : Form
    {

        Thread hilo;
        public frmWInThreads()
        {
            InitializeComponent();
        }
        
        private delegate void SetValueDelegate(int prValue);
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Delegado que hace referencia al metodo que tiene que ejecutar el hilo 
            ThreadStart delegadoPS = new ThreadStart(SubProceso1);
            //Creamos el hilo 
            hilo = new Thread(delegadoPS);
            //Ejecutamos el hilo
            hilo.Start();

            ThreadStart delegadoPS2 = new ThreadStart(SubProceso2);
            //Creamos el hilo 
            hilo = new Thread(delegadoPS2);
            //Ejecutamos el hilo
            hilo.Start();

            ThreadStart delegadoPS3 = new ThreadStart(SubProceso3);
            //Creamos el hilo 
            hilo = new Thread(delegadoPS3);
            //Ejecutamos el hilo
            hilo.Start();

            //hilo = new Thread(new ThreadStart(SubProceso1));
            //hilo.Start();
            //hilo = new Thread(new ThreadStart(SubProceso2));
            //hilo.Start();
            //hilo = new Thread(new ThreadStart(SubProceso3));
            //hilo.Start();

        }
        private void SetValue_pb1(int hecho)
        {

            if (pb1.InvokeRequired)
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_pb1);
                pb1.Invoke(delegado, new object[] { hecho });

            }
            else
            {
                pb1.Value = hecho;
            }
        }
        private void SetValue_pb2(int hecho)
        {

            if (pb2.InvokeRequired)
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_pb2);
                pb3.Invoke(delegado, new object[] { hecho });

            }
            else
            {
                pb2.Value = hecho;
            }
        }
        private void SetValue_pb3(int hecho)
        {

            if (pb3.InvokeRequired)
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_pb3);
                pb3.Invoke(delegado, new object[] { hecho });

            }
            else
            {
                pb3.Value = hecho;
            }
        }
        private void SubProceso3()
        {
            for (int i = 0; i < 101; i++)
            {
                pb3.Value = i;
                Thread.Sleep(70);

            }
        }

        private void SubProceso2()
        {

            for (int i = 0; i < 101; i++)
            {
                pb2.Value = i;
                Thread.Sleep(40);

            }
        }

        private void SubProceso1()
        {
            for (int i=0;i<101;i++)
            {
                pb1.Value = i;
                Thread.Sleep(20);

            }
        }
    }
}
