using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using SPZLAB7.Classes;

namespace SPZLAB7
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnectionWorkers = null;
        private SqlConnection sqlConnectionCompany = null;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand command;
        SqlDataAdapter adptCompany;
        DataTable dtCompany;
        SqlCommand commandCompany;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnectionWorkers = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString); // загрузка из App.config
            sqlConnectionWorkers.Open();
            sqlConnectionWorkers.Close();

            sqlConnectionCompany = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString); // загрузка из App.config
            sqlConnectionCompany.Open();
            sqlConnectionCompany.Close();
        }
        private void AddWorkerBtn_Click(object sender, EventArgs e) // Добавить Работника
        {
            sqlConnectionWorkers.Open();
            var addWorkerForm = new AddWorker();
            addWorkerForm.StartPosition = FormStartPosition.CenterParent;
            if (addWorkerForm.ShowDialog() == DialogResult.OK)
            {
                command = new SqlCommand
($"INSERT INTO Workers (Name, Surname, Salary) VALUES (N'{addWorkerForm.worker.Name}', N'{addWorkerForm.worker.Surname}', N'{addWorkerForm.worker.Salary}')", sqlConnectionWorkers);
                command.ExecuteNonQuery();
            }
            sqlConnectionWorkers.Close();
            ShowData();
        }
        private void ClearDBBtn_Click(object sender, EventArgs e) // Очистить БД
        {
            sqlConnectionWorkers.Open();
            command = new SqlCommand
($"TRUNCATE TABLE Workers", sqlConnectionWorkers);
            command.ExecuteNonQuery();
            sqlConnectionWorkers.Close();
            ShowData();
        }
        private void GetFromDBBtn_Click(object sender, EventArgs e) // Получить из БД
        {
            ShowData();
        }
        private void UpdateDBBtn_Click(object sender, EventArgs e) // Обновить БД
        {
            sqlConnectionWorkers.Open();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value == null)
                    break;
                command = new SqlCommand($"UPDATE Workers SET Name = {row.Cells[1].Value}, Surname = {row.Cells[2].Value}," +
                    $"Salary = {row.Cells[3].Value} WHERE Id = {row.Cells[0].Value}", sqlConnectionWorkers);
                command.ExecuteNonQuery();
            }
            sqlConnectionWorkers.Close();
            ShowData();
        }
        public void ShowData() // Получить
        {
            adpt = new SqlDataAdapter("SELECT * FROM Workers", sqlConnectionWorkers);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void AddCompanyBtn_Click(object sender, EventArgs e) // Добавить предприятие
        {
            sqlConnectionCompany.Open();
            var addCompanyForm = new AddCompany();
            addCompanyForm.StartPosition = FormStartPosition.CenterParent;
            if (addCompanyForm.ShowDialog() == DialogResult.OK)
            {
                commandCompany = new SqlCommand
($"INSERT INTO Companies (Company, AmountOfWorkers) VALUES ({addCompanyForm.company.Company}, {addCompanyForm.company.AmountOfWorkers})", sqlConnectionCompany);
                commandCompany.ExecuteNonQuery();
            }
            sqlConnectionCompany.Close();
            ShowDataCompany();
        }

        private void UpdateCompanyBtn_Click(object sender, EventArgs e) // Обновить БД предприятий
        {
            sqlConnectionCompany.Open();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[2].Value == null)
                    break;
                commandCompany = new SqlCommand($"UPDATE Companies SET Company = {row.Cells[1].Value}, AmountOfWorkers = {row.Cells[2].Value}" +
                    $"WHERE Id = {row.Cells[0].Value}", sqlConnectionCompany);
                commandCompany.ExecuteNonQuery();
            }
            sqlConnectionCompany.Close();
            ShowDataCompany();
        }

        private void LoadBDBtn_Click(object sender, EventArgs e) // Загрузить БД предприятий
        {
            ShowDataCompany();
        }

        private void ClearCompanyBtn_Click(object sender, EventArgs e) // Очистить БД предприятий
        {
            sqlConnectionCompany.Open();
            commandCompany = new SqlCommand
($"TRUNCATE TABLE Companies", sqlConnectionCompany);
            commandCompany.ExecuteNonQuery();
            sqlConnectionCompany.Close();
            ShowDataCompany();
        }
        public void ShowDataCompany() // Получить
        {
            adptCompany = new SqlDataAdapter("SELECT * FROM Companies", sqlConnectionCompany);
            dtCompany = new DataTable();
            adptCompany.Fill(dtCompany);
            dataGridView2.DataSource = dtCompany;
            dataGridView2.Columns["Id"].Visible = false;
        }
    }
}
