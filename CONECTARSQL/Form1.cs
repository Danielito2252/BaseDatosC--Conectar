//Agregar Librerias de conexion

using System.Data.SqlClient;
using System.Data;

namespace CONECTARSQL
{
    public partial class Form1 : Form
    {
        //Conexion a la BD
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            SqlDataAdapter da= new SqlDataAdapter("select * from Products",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this .dataGridView1.DataSource = dt;
        }
    }
}
