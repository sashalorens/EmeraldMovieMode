using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EmeraldMovieMode
{
    public partial class Form1 : Form
    {
        private int SC_MONITORPOWER = 0xF170;
        private uint WM_SYSCOMMAND = 0x0112;

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        public Form1()
        {
            InitializeComponent();
            // start minimized
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void OnSleepClick(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
            SendMessage(this.Handle, WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (IntPtr)2);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
