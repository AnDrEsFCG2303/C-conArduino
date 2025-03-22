using System.ComponentModel;
using System.IO.Ports;
namespace radar
{
    //cambio para repositorio
    public partial class Form1 : Form
    {
        int WIDTH = 350, HEIGHT = 350, HAND = 175;
        int u =0;
        int distancia = 0;
        int cx, cy;
        Bitmap bmp;
        Graphics g;
        List<Point> detecciones = new List<Point>();

        public Form1()
        {
            InitializeComponent();

            puerto.DataReceived += new SerialDataReceivedEventHandler(DatosRecibidos);
            puerto.Open();

            cx = WIDTH / 2;
            cy = HEIGHT / 2;
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);
            this.BackColor = Color.Black;

            
        }

        SerialPort puerto = new SerialPort("COM7", 9600);
        private void DatosRecibidos(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = puerto.ReadLine(); 
                this.Invoke(new MethodInvoker(() => ProcesarDatos(data)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer datos: " + ex.Message);
            }
        }

        private void ProcesarDatos(string data)
        {
            // Ejemplo de entrada: "Posicion: 45°, Distancia: 20 cm"
            string[] partes = data.Split(',');

            if (partes.Length == 2)
            {
                string posicionTexto = partes[0].Trim();
                string distanciaTexto = partes[1].Trim();

                if (int.TryParse(posicionTexto, out int posicion) && int.TryParse(distanciaTexto, out int dist))
                {
                    txtValorMotor.Text = posicion.ToString();
                    txtvalorRadar.Text = dist.ToString();

                    u = posicion;
                    distancia = dist;
                    if (distancia > 0 && distancia < 200)
                    {
                        int px = cx + (int)((HAND * distancia / 200.0) * Math.Sin(Math.PI * u / 180));
                        int py = cy - (int)((HAND * distancia / 200.0) * Math.Cos(Math.PI * u / 180));

                        detecciones.Add(new Point(px, py));
                    }
                    if (u >= 360 || u<=0)
                    {
                        detecciones.Clear();
                    }

                    pictureBox1.Invalidate();

                }
            }
            g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);
            Pen P = new Pen(Color.Green, 1f);

            // Dibujar círculos del radar
            g.DrawEllipse(P, 0, 0, WIDTH, HEIGHT);
            g.DrawEllipse(P, 80, 80, WIDTH - 160, HEIGHT - 160);

            // Dibujar líneas guías
            g.DrawLine(P, new Point(cx, 0), new Point(cx, HEIGHT));
            g.DrawLine(P, new Point(0, cy), new Point(WIDTH, cy));

            // Dibujar la línea del radar
            int x = cx + (int)(HAND * Math.Sin(Math.PI * u / 180));
            int y = cy - (int)(HAND * Math.Cos(Math.PI * u / 180));
            g.DrawLine(new Pen(Color.Lime, 2f), new Point(cx, cy), new Point(x, y));

            foreach (var punto in detecciones)
            {
                g.FillEllipse(Brushes.Red, punto.X - 3, punto.Y - 3, 6, 6);
            }

            pictureBox1.Image = bmp;

            P.Dispose();
            g.Dispose();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            puerto.Write("+10");

        }

        private void btnDisminuar_Click(object sender, EventArgs e)
        {

            puerto.Write("-10");

        }

        private void boxValorIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string textoBox = boxValorIngreso.Text;
                int valorIngreso = int.Parse(textoBox);
                puerto.Write(textoBox);
                boxValorIngreso.Clear();


            }
        }

        private void btnAutomatico_Click(object sender, EventArgs e)
        {

            puerto.Write("A");

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {

            puerto.Write("-1");

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        }
    }