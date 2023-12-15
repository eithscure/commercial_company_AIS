namespace WindowsFormsApp1
{
    partial class Autorize
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorize));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbPsw = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbCaptcha = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pswClose = new System.Windows.Forms.PictureBox();
            this.pswOpen = new System.Windows.Forms.PictureBox();
            this.pbCaptcha = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pswClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pswOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(79, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ваш логин и пароль.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(32, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(19, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // tbLog
            // 
            this.tbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbLog.Location = new System.Drawing.Point(99, 242);
            this.tbLog.Margin = new System.Windows.Forms.Padding(4);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(200, 24);
            this.tbLog.TabIndex = 3;
            // 
            // tbPsw
            // 
            this.tbPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbPsw.Location = new System.Drawing.Point(99, 279);
            this.tbPsw.Margin = new System.Windows.Forms.Padding(4);
            this.tbPsw.Name = "tbPsw";
            this.tbPsw.Size = new System.Drawing.Size(200, 24);
            this.tbPsw.TabIndex = 4;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEnter.Location = new System.Drawing.Point(140, 324);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 28);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // tbCaptcha
            // 
            this.tbCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCaptcha.Location = new System.Drawing.Point(148, 378);
            this.tbCaptcha.Margin = new System.Windows.Forms.Padding(4);
            this.tbCaptcha.Name = "tbCaptcha";
            this.tbCaptcha.Size = new System.Drawing.Size(212, 24);
            this.tbCaptcha.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRefresh.Location = new System.Drawing.Point(148, 411);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 44);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOk.Location = new System.Drawing.Point(259, 411);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(103, 44);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pswClose
            // 
            this.pswClose.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_eye_9283728;
            this.pswClose.Location = new System.Drawing.Point(308, 281);
            this.pswClose.Margin = new System.Windows.Forms.Padding(4);
            this.pswClose.Name = "pswClose";
            this.pswClose.Size = new System.Drawing.Size(28, 26);
            this.pswClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pswClose.TabIndex = 12;
            this.pswClose.TabStop = false;
            this.pswClose.Click += new System.EventHandler(this.pswClose_Click);
            // 
            // pswOpen
            // 
            this.pswOpen.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_font_eye_3917112;
            this.pswOpen.Location = new System.Drawing.Point(308, 279);
            this.pswOpen.Margin = new System.Windows.Forms.Padding(4);
            this.pswOpen.Name = "pswOpen";
            this.pswOpen.Size = new System.Drawing.Size(28, 26);
            this.pswOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pswOpen.TabIndex = 11;
            this.pswOpen.TabStop = false;
            this.pswOpen.Click += new System.EventHandler(this.pswOpen_Click);
            // 
            // pbCaptcha
            // 
            this.pbCaptcha.Location = new System.Drawing.Point(37, 378);
            this.pbCaptcha.Margin = new System.Windows.Forms.Padding(4);
            this.pbCaptcha.Name = "pbCaptcha";
            this.pbCaptcha.Size = new System.Drawing.Size(103, 78);
            this.pbCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCaptcha.TabIndex = 8;
            this.pbCaptcha.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_font_user_3917559;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Autorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 501);
            this.Controls.Add(this.pswOpen);
            this.Controls.Add(this.pswClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pbCaptcha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbCaptcha);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbPsw);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Autorize";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pswClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pswOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TextBox tbPsw;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbCaptcha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbCaptcha;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pswOpen;
        private System.Windows.Forms.PictureBox pswClose;
    }
}

