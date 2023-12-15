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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Autorize : Form
    {
        DataBase dataBase = new DataBase();
        private string text = String.Empty;
        private int failedAttemps = 0;

        public Autorize()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            EnableCaptcha();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbPsw.UseSystemPasswordChar = true;
            pswClose.Visible = false;
            tbLog.MaxLength = 25;
            tbPsw.MaxLength = 25;

            pbCaptcha.Image = this.CreateImage(pbCaptcha.Width, pbCaptcha.Height);

            //btnRefresh.Visible = false;
            //pbCaptcha.Visible = false;
            //tbCaptcha.Visible = false;
            //btnOk.Visible = false;
        }

        private void EnableCaptcha()
        {
            btnRefresh.Visible = true;
            pbCaptcha.Visible = true;
            tbCaptcha.Visible = true;
            btnOk.Visible = true;

            pbCaptcha.Image = CreateImage(pbCaptcha.Width, pbCaptcha.Height);
        }


        private void btn_enter_Click(object sender, EventArgs e)
        {
            var loginUser = tbLog.Text;
            var pswUser = tbPsw.Text;

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable table = new DataTable();

            //string queryString = $"select логин, пароль from пользователи where логин = '{loginUser}' and пароль = '{pswUser}'";

            //SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            if (/*table.Rows.Count == 1*/ loginUser == "rr")
            {
                MessageBox.Show("Вы вошли.", "Успешно.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PostForm frm1 = new PostForm();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                failedAttemps++;

                if (failedAttemps == 1)
                {
                    MessageBox.Show("Неверные учетные данные. Пожалуйста, попробуйте еще раз.");
                }
                else if (failedAttemps == 2)
                {
                    MessageBox.Show("Лимит ошибок превышен! Решите captcha, чтобы выполнить вход");
                    EnableCaptcha();
                }
                else if (failedAttemps >= 3)
                {
                    MessageBox.Show("Лимит ошибок привышен! Доступ к авторизации заблокирован на 3 минуты.");
                    BlockAuthentication();
                }
            }
        }

        public Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            // Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            // Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            // Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                               Brushes.Red,
                               Brushes.RoyalBlue,
                               Brushes.Green };

            // Укажем, где рисовать
            Graphics g = Graphics.FromImage((System.Drawing.Image)result);

            // Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            // Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 4; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            // Нарисуем сгенерированный текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            // Добавим немного помех
            // Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            // Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }


        private void pswOpen_Click(object sender, EventArgs e)
        {
            tbPsw.UseSystemPasswordChar = false;
            pswOpen.Visible = false;
            pswClose.Visible = true;
        }

        private void pswClose_Click(object sender, EventArgs e)
        {
            tbPsw.UseSystemPasswordChar = true;
            pswOpen.Visible = true;
            pswClose.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pbCaptcha.Image = this.CreateImage(pbCaptcha.Width, pbCaptcha.Height);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbCaptcha.Text == this.text)
            {
                MessageBox.Show("Верно!");
                failedAttemps = 0;
            }
            else
            {
                MessageBox.Show("Ошибка! Попробуйте еще раз.");
                failedAttemps++;
                if (failedAttemps >= 2)
                {
                    BlockAuthentication();
                }
            }
        }

        public void BlockAuthentication()
        {
            btnOk.Enabled = false;

            Timer timer = new Timer();
            timer.Interval = 180000; // 3 минуты
            timer.Tick += (sender, e) =>
            {
                btnOk.Enabled = true;
                timer.Stop();
            };

            timer.Start();
        }

    }
}
