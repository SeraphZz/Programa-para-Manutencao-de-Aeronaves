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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange600, Primary.DeepOrange900, Primary.DeepOrange300, Accent.DeepOrange400, TextShade.WHITE);
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

        private void materialMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=aereo_db;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM aeronaves WHERE matricula_aeronave LIKE '" + materialMaskedTextBox1.Text + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close(); 
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=aereo_db;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM aeronaves WHERE frota_aeronave LIKE '" + materialComboBox1.Text + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(materialTextBox21.Text) || string.IsNullOrWhiteSpace(materialComboBox2.Text))
            {
               MaterialMessageBox.Show("Por favor, insira a matrícula da aeronave.");
            }
            else
            {
                try
                {
                    string conexao = "server=localhost;database=aereo_db;uid=root;pwd=;";
                    MySqlConnection con = new MySqlConnection(conexao);
                    con.Open();
                    string query = "INSERT INTO aeronaves (matricula_aeronave, frota_aeronave) VALUES (@matricula_aeronave, @frota_aeronave)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@matricula_aeronave", materialTextBox21.Text);
                    cmd.Parameters.AddWithValue("@frota_aeronave", materialComboBox2.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    pegar_dados_aeronaves();
                    materialTextBox21.Clear();
                    materialComboBox2.SelectedIndex = -1;
                    MaterialMessageBox.Show("Aeronave cadastrada com sucesso!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
    }
}
