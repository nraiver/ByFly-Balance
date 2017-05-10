namespace byfly_
{
    partial class MainForm
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
            this.balance = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.DaysBeforeShutdown = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(59, 12);
            this.balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(151, 20);
            this.balance.TabIndex = 0;
            this.balance.Text = "Актуальный баланс: #";
            // 
            // settingsButton
            // 
            this.settingsButton.AccessibleDescription = "";
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Image = global::byfly_.Properties.Resources.settings;
            this.settingsButton.Location = new System.Drawing.Point(6, 16);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(35, 35);
            this.settingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsButton.TabIndex = 1;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // DaysBeforeShutdown
            // 
            this.DaysBeforeShutdown.AutoSize = true;
            this.DaysBeforeShutdown.Location = new System.Drawing.Point(47, 32);
            this.DaysBeforeShutdown.Name = "DaysBeforeShutdown";
            this.DaysBeforeShutdown.Size = new System.Drawing.Size(163, 20);
            this.DaysBeforeShutdown.TabIndex = 2;
            this.DaysBeforeShutdown.Text = "Дней до отключения: #";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::byfly_.Properties.Resources.bt;
            this.pictureBox1.Location = new System.Drawing.Point(248, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 66);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DaysBeforeShutdown);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.balance);
            this.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ByFly";
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.Label DaysBeforeShutdown;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

