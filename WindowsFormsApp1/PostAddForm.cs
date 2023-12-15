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

namespace WindowsFormsApp1
{
    public partial class PostAddForm : Form
    {
        DataBase dataBase = new DataBase();

        public PostAddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = tbNazv.Text;
            var tel = tbTel.Text;
            var pochta = tbPochta.Text;
            var site = tbSite.Text;

            var addQuery = $"insert into поставщик (название_фирмы, телефон, эл_почта, адрес_сайта) values ('{name}', '{tel}', '{pochta}', '{site}')";

            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана.");

            dataBase.closeConnection();
        }
    }
}
