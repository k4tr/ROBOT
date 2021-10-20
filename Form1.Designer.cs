
namespace ROBOT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.менюшка = new System.Windows.Forms.GroupBox();
            this.игровое_поле = new System.Windows.Forms.PictureBox();
            this.микрочел = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.игровое_поле)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.микрочел)).BeginInit();
            this.SuspendLayout();
            // 
            // менюшка
            // 
            this.менюшка.BackColor = System.Drawing.Color.OliveDrab;
            this.менюшка.Dock = System.Windows.Forms.DockStyle.Left;
            this.менюшка.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.менюшка.Location = new System.Drawing.Point(0, 0);
            this.менюшка.Name = "менюшка";
            this.менюшка.Size = new System.Drawing.Size(210, 566);
            this.менюшка.TabIndex = 0;
            this.менюшка.TabStop = false;
            this.менюшка.Text = "менюшка";
            // 
            // игровое_поле
            // 
            this.игровое_поле.BackColor = System.Drawing.Color.Cornsilk;
            this.игровое_поле.Dock = System.Windows.Forms.DockStyle.Fill;
            this.игровое_поле.Location = new System.Drawing.Point(210, 0);
            this.игровое_поле.Name = "игровое_поле";
            this.игровое_поле.Size = new System.Drawing.Size(648, 566);
            this.игровое_поле.TabIndex = 1;
            this.игровое_поле.TabStop = false;
            this.игровое_поле.Click += new System.EventHandler(this.игровое_поле_Click);
            // 
            // микрочел
            // 
            this.микрочел.BackColor = System.Drawing.Color.DarkKhaki;
            this.микрочел.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("микрочел.BackgroundImage")));
            this.микрочел.Image = ((System.Drawing.Image)(resources.GetObject("микрочел.Image")));
            this.микрочел.Location = new System.Drawing.Point(492, 0);
            this.микрочел.Name = "микрочел";
            this.микрочел.Size = new System.Drawing.Size(271, 488);
            this.микрочел.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.микрочел.TabIndex = 2;
            this.микрочел.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(858, 566);
            this.Controls.Add(this.микрочел);
            this.Controls.Add(this.игровое_поле);
            this.Controls.Add(this.менюшка);
            this.Name = "Form1";
            this.Text = "микрочел_движется";
            ((System.ComponentModel.ISupportInitialize)(this.игровое_поле)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.микрочел)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox менюшка;
        private System.Windows.Forms.PictureBox игровое_поле;
        private System.Windows.Forms.PictureBox микрочел;
    }
}

