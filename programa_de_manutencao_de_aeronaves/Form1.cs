using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_de_manutencao_de_aeronaves
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent(); var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500, Primary.Pink600, Accent.Pink700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pegar_dados_aeronaves();
            pegar_dados_manutencao();
            pegar_dados_partes();
        }

        public void pegar_dados_aeronaves()
        {
            string conexao = "server=localhost;database=aereo_db;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            string query = "SELECT * FROM aeronaves";   
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id_aeronave"].HeaderText = "Código da Aeronave";
            dataGridView1.Columns["matricula_aeronave"].HeaderText = "Matrícula da Aeronave";
            dataGridView1.Columns["frota_aeronave"].HeaderText = "Modelo da Aeronave";

        }

        public void pegar_dados_partes()
        {
            string conexao = "server=localhost;database=aereo_db;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            string query = "SELECT * FROM partes";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView2.DataSource = dt;
        }

        public void pegar_dados_manutencao()
        {
            string conexao = "server=localhost;database=aereo_db;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            string query = "SELECT * FROM manutencao";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView3.DataSource = dt;

        }

    }
}
