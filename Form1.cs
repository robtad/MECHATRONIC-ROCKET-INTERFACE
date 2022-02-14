using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //  [DllImport("Gdi32.dll",EntryPoint = "CreateRoundRectRgn")]
        /* private static extern IntPtr CreateRoundRectRgn
             (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
             );*/

       
        public Form1()
        {
            InitializeComponent();
           // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = button1.Height;
            pnlNav.Top = button1.Top;
            pnlNav.Left = button1.Left;
            //button1.BackColor = Color.FromArgb(50, 184, 148);

        }

        public void loadForm (object Form)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button1.Height;
            pnlNav.Top = button1.Top;
            pnlNav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(50, 184, 148);
            loadForm(new ChildForms.DashboardForm());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button2.Height;
            pnlNav.Top = button2.Top;
            button2.BackColor = Color.FromArgb(50, 184, 148);
            loadForm(new ChildForms.GraphForm());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button3.Height;
            pnlNav.Top = button3.Top;
            button3.BackColor = Color.FromArgb(50, 184, 148);
            loadForm(new ChildForms.SpeedForm());


        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button4.Height;
            pnlNav.Top = button4.Top;
            button4.BackColor = Color.FromArgb(50, 184, 148);
            loadForm(new ChildForms.LocationForm());


        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button5.Height;
            pnlNav.Top = button5.Top;
            button5.BackColor = Color.FromArgb(50, 184, 148);
            loadForm(new ChildForms.videoForm());


        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button6.Height;
            pnlNav.Top = button6.Top;
            button6.BackColor = Color.FromArgb(50, 184, 148);
            loadForm(new ChildForms.AboutForm());


        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(25, 154, 118);
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(25, 154, 118);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(25, 154, 118);
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(25, 154, 118);
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(25, 154, 118);

        }

        private void button6_Leave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(25, 154, 118);

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}