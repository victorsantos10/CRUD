namespace Proyecto2
{
    public partial class Form1 : Form
    {
        private bool Adding  = false;

        List<Contacto>contactolist=new List<Contacto>();
        public Form1()
        {
            InitializeComponent();
        }
        public class Contacto
        {
            public string ID { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string Direccion { get; set; }
            public string País { get; set; }
            public string Ciudad { get; set; }

        }
        
        private void BorrarControles()
        {
            IDTxt.Text = String.Empty;
            NameTxt.Text = String.Empty; 
            LastNameTxt.Text = String.Empty;    
            TelfTxt.Text = String.Empty;    
            MailTxt.Text = String.Empty;
            AdressTxt.Text = String.Empty;
            PaisTxt.Text = String.Empty;
            CityTxt.Text = String.Empty; 
        }
        private void EnableControls(bool enabled)
        {
            IDTxt.Enabled = enabled;
            NameTxt.Enabled = enabled;
            LastNameTxt.Enabled = enabled;
            TelfTxt.Enabled = enabled;
            MailTxt.Enabled = enabled;
            AdressTxt.Enabled = enabled;
            PaisTxt.Enabled = enabled;
            CityTxt.Enabled = enabled;
        }


        private void guardar()
        {
            if (Adding=true)
            {
                var contacto = new Contacto
                {
                    ID = IDTxt.Text,
                    Nombre = NameTxt.Text,
                    Apellido = LastNameTxt.Text,
                    Telefono = TelfTxt.Text,
                    Correo = MailTxt.Text,
                    Direccion = AdressTxt.Text,
                    País = PaisTxt.Text,
                    Ciudad = CityTxt.Text,
                };
                contactolist.Add(contacto);
                MessageBox.Show("Guardado");

                BorrarControles();
                button1.Enabled = true;
                BorrarBtn.Enabled = true;
                EditBtn.Enabled = true;
                recargar();
            }
        }

        private void recargar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contactolist;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardar();
            BorrarControles();
            EnableControls(true);
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                contactolist.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila");
            }
            recargar();
        }
    }

}