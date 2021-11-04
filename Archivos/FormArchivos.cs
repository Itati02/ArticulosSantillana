using System;
using System.IO;
using System.Windows.Forms;

namespace Archivos
{
    public partial class FormArchivos : Form
    {
        articulos[] arregloart;
        int art = 0;
        private object lstArreglos;
       
        public FormArchivos()
        {
            InitializeComponent();
            arregloart = new articulos[4];
        }
       
        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            if(dialogo.ShowDialog()== DialogResult.OK)
            {
                StreamReader Sr = new StreamReader(dialogo.FileName);
            }
        }
        private void BtnGuardar_click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter articulos = new StreamWriter(dialogo.FileName))
                {
                    for (int i = 0; i < arregloart.Length; i++)
                    {
                        if (arregloart[i] != null)
                        {
                            articulos.WriteAsync(arregloart[i].ToString());
                        }
                    }
                }
                

            }
        }
        private void FormArchivos_Load(object sender, EventArgs e)
        {

        }
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            articulos a = new articulos();
            a.Nombre=TxtNombre.Text;
            a.Precio=double.Parse(TxtPrecio.Text);
            arregloart[art++] = a;

            lstArreglos.Items.Add(arregloart[art]);
            art++;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
