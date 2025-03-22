using System.IO.Ports;
namespace practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort puerto = new SerialPort("COM7", 9600);

        
        private void button1_Click(object sender, EventArgs e)
        {
            puerto.Open();
            puerto.Write("1");
            puerto.Close();
            label1.BackColor = Color.Green;
            txtEstado.Text = "El led esta encendido";

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            puerto.Open();
            puerto.Write("0");
            puerto.Close();
            label1.BackColor = Color.Red;
            txtEstado.Text = "el Led esta apagado";
        }
    }
}
