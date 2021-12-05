using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace FormW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mensagem(string msg)
        {
            listBox1.Items.Add(msg);
        
        }


        private void button1_Click(object sender, EventArgs e)
        {

            var cn = Sqlconnection();

            cn.ConnectingString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Produtos; Integrated Security = True; Pooling = False";

            cn.Open();

            Mensagem("Conexão Aberta");

            cn.Close();

            Mensagem("Conexão Fechada");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cn = Sqlconnection();

            cn.ConnectingString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Produtos; Integrated Security = True; Pooling = False";

            var cmd = new SqlCommand();

            cmd.Connection = cn
            cmd.CommandText = "SELECT * FROM Produtos";

            cn.Open();

            SqlDataReader reader = cmd.SqlDataReader();

            while (reader.Read())
            {
                string Produto = reader["NomeProduto"].toString();
                List.ITems.Add(nome);

            }

            reader.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cn = Sqlconnection();

            cn.ConnectingString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Produtos; Integrated Security = True; Pooling = False";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Produtos(IDproduto, NomeProduto, Categoria, Quantidade, preco) VALUES(@IdProduto, @NomeProduto, @Categoria, @Quantidade, @preco)";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@NomeProduto", NomeProduto);
            cmd.Parameters.AddWithValue("@Categoria", Categoria);
            cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@preco", preco);

            cn.Open();

            Mensagem("Conexão Aberta");

            cmd.ExecuteNonQuery();

            cn.Close();

            Mensagem("Conexão Fechada");
        }
    }
}
