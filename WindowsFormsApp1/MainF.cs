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
    enum RowState
    {
        Existend,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class MainF : Form
    {
        DataBase database = new DataBase();

        int selectedRow;

        public MainF()
        {
            CreateColumns();
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("код_товара", "Код Товара");
        }

        private void ReadStringRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Название фирмы:";
            lbl2.Text = "Телефон:";
            lbl3.Text = "Эл. почта:";
            lbl4.Text = "Адрес сайта:";
            lbl1.Visible = true;
            tb1.Visible = true;
            lbl2.Visible = true;
            tb2.Visible = true;
            lbl3.Visible = true;
            tb3.Visible = true;
            lbl4.Visible = true;
            tb4.Visible = true;
            lbl5.Visible = false;
            tb5.Visible = false;
            lbl6.Visible = false;
            tb6.Visible = false;
            lbl7.Visible = false;
            tb7.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Наименование:";
            lbl2.Text = "Цвет:";
            lbl3.Text = "Обивка:";
            lbl4.Text = "Мощность двигателя:";
            lbl5.Text = "Количество дверей:";
            lbl6.Text = "Коробка передач:";
            lbl7.Text = "Код фирмы:";
            lbl4.Visible = true;
            tb4.Visible = true;
            lbl5.Visible = true;
            tb5.Visible = true;
            lbl6.Visible = true;
            tb6.Visible = true;
            lbl7.Visible = true;
            tb7.Visible = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lbl1.Text = "ФИО:";
            lbl2.Text = "Телефон:";
            lbl3.Text = "Адрес:";
            lbl1.Visible = true;
            tb1.Visible = true;
            lbl2.Visible = true;
            tb2.Visible = true;
            lbl3.Visible = true;
            tb3.Visible = true;
            lbl4.Visible = false;
            tb4.Visible = false;
            lbl5.Visible = false;
            tb5.Visible = false;
            lbl6.Visible = false;
            tb6.Visible = false;
            lbl7.Visible = false;
            tb7.Visible = false;
        }

        private void прейскурантЦенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Год выпуска:";
            lbl2.Text = "Цена:";
            lbl3.Text = "Предпродажная подготовка:";
            lbl4.Text = "Транспортные издержки:";
            lbl1.Visible = true;
            tb1.Visible = true;
            lbl2.Visible = true;
            tb2.Visible = true;
            lbl3.Visible = true;
            tb3.Visible = true;
            lbl4.Visible = true;
            tb4.Visible = true;
            lbl5.Visible = false;
            tb5.Visible = false;
            lbl6.Visible = false;
            tb6.Visible = false;
            lbl7.Visible = false;
            tb7.Visible = false;
        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Номер договора:";
            lbl2.Text = "Дата покупки:";
            lbl3.Text = "Код модели:";
            lbl4.Text = "Код клиента:";
            lbl1.Visible = true;
            tb1.Visible = true;
            lbl2.Visible = true;
            tb2.Visible = true;
            lbl3.Visible = true;
            tb3.Visible = true;
            lbl4.Visible = true;
            tb4.Visible = true;
            lbl5.Visible = false;
            tb5.Visible = false;
            lbl6.Visible = false;
            tb6.Visible = false;
            lbl7.Visible = false;
            tb7.Visible = false;
        }

        private void MainF_Load(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            tb1.Visible = false;
            lbl2.Visible = false;
            tb2.Visible = false;
            lbl3.Visible = false;
            tb3.Visible = false;
            lbl4.Visible = false;
            tb4.Visible = false;
            lbl5.Visible = false;
            tb5.Visible = false;
            lbl6.Visible = false;
            tb6.Visible = false;
            lbl7.Visible = false;
            tb7.Visible = false;
        }

    }
}
