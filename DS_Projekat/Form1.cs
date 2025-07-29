using DSBooking;

namespace DS_Projekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TO DO
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PacketClientPresenter pcp = new PacketClientPresenter();
            pcp.loadAllPackets();
        }
    }
}
