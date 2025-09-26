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
using QuestPDF;

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
            pegar_dados_partes();
            pegar_dados_manutencao();
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
            dataGridView3.DataSource = dt;
            dt.Load(reader);
            .Columns["id_task"].HeaderText = "ID da Task";
            dataGridView3.Columns["ATA"].HeaderText = "ATA da Task";
            dataGridView3.Columns["descricao_task"].HeaderText = "Descrição da Task";
            dataGridView3.Columns["part_on"].HeaderText = "Part On";
            dataGridView3.Columns["sn_on"].HeaderText = "S/N On";
            dataGridView3.Columns["part_off"].HeaderText = "Part Off";
            dataGridView3.Columns["sn_off"].HeaderText = "S/N Off"
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
            dataGridView2.Columns["id_parte"].HeaderText = "Código da Parte";
            dataGridView2.Columns["descricao_parte"].HeaderText = "Descrição da Parte";
            dataGridView2.Columns["part_number"].HeaderText = "Part Number";
            dataGridView2.Columns["serial_number"].HeaderText = "Serial Number";
            dataGridView2.Columns["condition"].HeaderText = "Condição da Parte";

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

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            materialComboBox1.SelectedIndex = -1;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(matricula_txt.Text) || string.IsNullOrWhiteSpace(frota_combo.Text))
            {
                MaterialMessageBox.Show("Por favor, insira a matrícula da aeronave.");
                return;
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
                    cmd.Parameters.AddWithValue("@matricula_aeronave", matricula_txt.Text);
                    cmd.Parameters.AddWithValue("@frota_aeronave", frota_combo.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    pegar_dados_aeronaves();
                    matricula_txt.Clear();
                    frota_combo.SelectedIndex = -1;
                    MaterialMessageBox.Show("Aeronave cadastrada com sucesso!");
                }
                catch (Exception Ex)
                {
                    MaterialMessageBox.Show(Ex.Message);
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(part_desc.Text) || string.IsNullOrWhiteSpace(pn_text.Text) || string.IsNullOrWhiteSpace(sn_text.Text) || string.IsNullOrWhiteSpace(cond_combo.Text))
            {
                MaterialMessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            else
                try
                {
                    string conexao = "server=localhost;database=aereo_db;uid=root;pwd=;";
                    MySqlConnection con = new MySqlConnection(conexao);
                    con.Open();
                    string query = "INSERT INTO partes (descricao_parte, part_number, serial_number, `condition`) VALUES (@descricao_parte, @part_number, @serial_number, @condition)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@descricao_parte", part_desc.Text);
                    cmd.Parameters.AddWithValue("@part_number", pn_text.Text);
                    cmd.Parameters.AddWithValue("@serial_number", sn_text.Text);
                    cmd.Parameters.AddWithValue("@condition", cond_combo.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    pegar_dados_partes();
                    matricula_txt.Clear();
                    frota_combo.SelectedIndex = -1;
                    MaterialMessageBox.Show("Parte cadastrada com sucesso!");
                }
                catch (Exception Ex)
                {
                    MaterialMessageBox.Show(Ex.Message);
                }
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=aereo_db;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM partes WHERE part_number LIKE '%" + materialTextBox1.Text + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=aereo_db;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM partes WHERE serial_number LIKE '%" + materialTextBox2.Text + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

    }
}