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

namespace Threadd
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, EventArgs e)
        {
           Thread threadA, threadb, threadc, threadd;
           
            ThreadStart yey = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart tet = new ThreadStart(MyThreadClass.Thread2);
          
            threadA = new Thread(yey);
            threadb = new Thread(tet);
            threadc = new Thread(yey);
            threadd = new Thread(tet);

            threadA.Name = "Thread A process: ";
            threadb.Name = "Thread B process: ";
            threadc.Name = "Thread C process: ";
            threadd.Name = "Thread D process: ";

            threadA.Priority = ThreadPriority.Highest;
            threadb.Priority = ThreadPriority.Normal;
            threadc.Priority = ThreadPriority.AboveNormal;
            threadd.Priority = ThreadPriority.BelowNormal;

            Console.WriteLine("-Thread Start-");
            // Thread1
            threadA.Start();
            threadb.Start();
            threadc.Start();
            threadd.Start();

            threadc.Join();
            threadA.Join();
            threadb.Join();
            threadd.Join();

            ThreadLabel.Text = "-End of Thread-";
            Console.WriteLine(ThreadLabel.Text.ToString());
        
    }

        private void ThreadLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
