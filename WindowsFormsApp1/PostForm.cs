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
using System.Security.Policy;

namespace WindowsFormsApp1
{
    enum RowState
    {
        Existend,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class PostForm : Form
    {
        DataBase database = new DataBase();

        int selectedRow;

        public PostForm()
        {
            InitializeComponent();
        }

        private void CreateColumnsPost()
        {
            dataGridView1.Columns.Add("код_фирмы", "Код фирмы");
            dataGridView1.Columns.Add("название_фирмы", "Название фирмы");
            dataGridView1.Columns.Add("телефон", "Телефон");
            dataGridView1.Columns.Add("эл_почта", "Эл. почта");
            dataGridView1.Columns.Add("адрес_сайта", "Адрес сайта");
            dataGridView1.Columns.Add("запись_удалена", "Запись удалена");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }

        private void ReadStringRowPost(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),
                         record.GetString(1),
                         record.GetString(2),
                         record.GetString(3),
                         record.GetString(4),
                         record.GetBoolean(5),
                         RowState.ModifiedNew);
        }

        private void RefreshDataGridPost(DataGridView dgw) 
        {
            dgw.Rows.Clear();

            string queryString = $"select * from поставщик";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read()) 
            {
                ReadStringRowPost(dgw, reader);
            }

            reader.Close();
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                tbKod.Text = row.Cells[0].Value.ToString();
                tbNazv.Text = row.Cells[1].Value.ToString();
                tbTel.Text = row.Cells[2].Value.ToString();
                tbPochta.Text = row.Cells[3].Value.ToString();
                tbSite.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridPost(dataGridView1);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PostAddForm frm1 = new PostAddForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void PostForm_Load(object sender, EventArgs e)
        {
            CreateColumnsPost();
            RefreshDataGridPost(dataGridView1);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from поставщик where concat (код_фирмы, название_фирмы, телефон, эл_почта, адрес_сайта) like '%" + tbSearch.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while(reader.Read()) 
            {
                ReadStringRowPost(dgw, reader);
            }

            reader.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        public void Update()
        {
            database.openConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if(rowState == RowState.Existend) 
                {
                    continue;
                }

                if(rowState == RowState.Deleted) 
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deletedQuery = $"delete from [поставщик] where код_фирмы = '{id}'";

                    var comm = new SqlCommand(deletedQuery, database.getConnection());
                    comm.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var tel = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var pochta = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var site = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update поставщик set название_фирмы = '{name}', телефон = '{tel}', эл_почта = '{pochta}', адрес_сайта = '{site}' where код_фирмы = '{id}'";

                    var comm = new SqlCommand (changeQuery, database.getConnection());

                    comm.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        public void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = tbKod.Text;
            var name = tbNazv.Text;
            var tel = tbTel.Text;
            var pochta = tbPochta.Text;
            var site = tbSite.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRow].SetValues(id, name, tel, pochta, site);
                dataGridView1.Rows[selectedRow].Cells[6].Value = RowState.Modified;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Change();
        }
    }
}
