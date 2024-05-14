namespace arduino
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
            this.components = new System.ComponentModel.Container();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonUpdatePorts = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.MySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxTumba = new System.Windows.Forms.GroupBox();
            this.buttonOnTumba = new System.Windows.Forms.Button();
            this.groupBoxTrenash = new System.Windows.Forms.GroupBox();
            this.buttonOnTrenaz = new System.Windows.Forms.Button();
            this.groupBoxSvet = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonOnSvet = new System.Windows.Forms.Button();
            this.groupBoxProector = new System.Windows.Forms.GroupBox();
            this.buttonOffProector = new System.Windows.Forms.Button();
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.buttonOnAll = new System.Windows.Forms.Button();
            this.groupBoxTumba.SuspendLayout();
            this.groupBoxTrenash.SuspendLayout();
            this.groupBoxSvet.SuspendLayout();
            this.groupBoxProector.SuspendLayout();
            this.groupBoxAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnect.Location = new System.Drawing.Point(12, 12);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(216, 51);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonUpdatePorts
            // 
            this.buttonUpdatePorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdatePorts.Location = new System.Drawing.Point(12, 69);
            this.buttonUpdatePorts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonUpdatePorts.Name = "buttonUpdatePorts";
            this.buttonUpdatePorts.Size = new System.Drawing.Size(216, 51);
            this.buttonUpdatePorts.TabIndex = 1;
            this.buttonUpdatePorts.Text = "Обновить список доступных портов";
            this.buttonUpdatePorts.UseVisualStyleBackColor = true;
            this.buttonUpdatePorts.Click += new System.EventHandler(this.buttonUpdatePorts_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(233, 38);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 2;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(233, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Порты";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxTumba
            // 
            this.groupBoxTumba.Controls.Add(this.buttonOnTumba);
            this.groupBoxTumba.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTumba.Location = new System.Drawing.Point(18, 129);
            this.groupBoxTumba.Name = "groupBoxTumba";
            this.groupBoxTumba.Size = new System.Drawing.Size(98, 59);
            this.groupBoxTumba.TabIndex = 4;
            this.groupBoxTumba.TabStop = false;
            this.groupBoxTumba.Text = "Тумба";
            // 
            // buttonOnTumba
            // 
            this.buttonOnTumba.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOnTumba.Location = new System.Drawing.Point(6, 19);
            this.buttonOnTumba.Name = "buttonOnTumba";
            this.buttonOnTumba.Size = new System.Drawing.Size(86, 23);
            this.buttonOnTumba.TabIndex = 7;
            this.buttonOnTumba.Text = "Вкл.";
            this.buttonOnTumba.UseVisualStyleBackColor = true;
            this.buttonOnTumba.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxTrenash
            // 
            this.groupBoxTrenash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxTrenash.Controls.Add(this.buttonOnTrenaz);
            this.groupBoxTrenash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTrenash.Location = new System.Drawing.Point(130, 129);
            this.groupBoxTrenash.Name = "groupBoxTrenash";
            this.groupBoxTrenash.Size = new System.Drawing.Size(98, 59);
            this.groupBoxTrenash.TabIndex = 5;
            this.groupBoxTrenash.TabStop = false;
            this.groupBoxTrenash.Text = "Тренаж";
            // 
            // buttonOnTrenaz
            // 
            this.buttonOnTrenaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOnTrenaz.Location = new System.Drawing.Point(6, 19);
            this.buttonOnTrenaz.Name = "buttonOnTrenaz";
            this.buttonOnTrenaz.Size = new System.Drawing.Size(86, 23);
            this.buttonOnTrenaz.TabIndex = 7;
            this.buttonOnTrenaz.Text = "Вкл.";
            this.buttonOnTrenaz.UseVisualStyleBackColor = true;
            this.buttonOnTrenaz.Click += new System.EventHandler(this.buttonOnTrenaz_Click);
            // 
            // groupBoxSvet
            // 
            this.groupBoxSvet.Controls.Add(this.groupBox4);
            this.groupBoxSvet.Controls.Add(this.buttonOnSvet);
            this.groupBoxSvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSvet.Location = new System.Drawing.Point(18, 194);
            this.groupBoxSvet.Name = "groupBoxSvet";
            this.groupBoxSvet.Size = new System.Drawing.Size(98, 59);
            this.groupBoxSvet.TabIndex = 6;
            this.groupBoxSvet.TabStop = false;
            this.groupBoxSvet.Text = "Свет";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(157, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // buttonOnSvet
            // 
            this.buttonOnSvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOnSvet.Location = new System.Drawing.Point(6, 19);
            this.buttonOnSvet.Name = "buttonOnSvet";
            this.buttonOnSvet.Size = new System.Drawing.Size(86, 23);
            this.buttonOnSvet.TabIndex = 9;
            this.buttonOnSvet.Text = "Вкл.";
            this.buttonOnSvet.UseVisualStyleBackColor = true;
            this.buttonOnSvet.Click += new System.EventHandler(this.buttonOnSvet_Click);
            // 
            // groupBoxProector
            // 
            this.groupBoxProector.Controls.Add(this.buttonOffProector);
            this.groupBoxProector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxProector.Location = new System.Drawing.Point(130, 194);
            this.groupBoxProector.Name = "groupBoxProector";
            this.groupBoxProector.Size = new System.Drawing.Size(98, 59);
            this.groupBoxProector.TabIndex = 0;
            this.groupBoxProector.TabStop = false;
            this.groupBoxProector.Text = "Проектор";
            // 
            // buttonOffProector
            // 
            this.buttonOffProector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOffProector.Location = new System.Drawing.Point(6, 19);
            this.buttonOffProector.Name = "buttonOffProector";
            this.buttonOffProector.Size = new System.Drawing.Size(86, 23);
            this.buttonOffProector.TabIndex = 12;
            this.buttonOffProector.Text = "Вкл.";
            this.buttonOffProector.UseVisualStyleBackColor = true;
            this.buttonOffProector.Click += new System.EventHandler(this.buttonOffProector_Click);
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Controls.Add(this.buttonOnAll);
            this.groupBoxAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAll.Location = new System.Drawing.Point(234, 129);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(98, 124);
            this.groupBoxAll.TabIndex = 7;
            this.groupBoxAll.TabStop = false;
            this.groupBoxAll.Text = "Вкл/Выкл все сразу";
            // 
            // buttonOnAll
            // 
            this.buttonOnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOnAll.Location = new System.Drawing.Point(6, 43);
            this.buttonOnAll.Name = "buttonOnAll";
            this.buttonOnAll.Size = new System.Drawing.Size(86, 44);
            this.buttonOnAll.TabIndex = 0;
            this.buttonOnAll.Text = "Вкл.";
            this.buttonOnAll.UseVisualStyleBackColor = true;
            this.buttonOnAll.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 320);
            this.Controls.Add(this.groupBoxAll);
            this.Controls.Add(this.groupBoxProector);
            this.Controls.Add(this.groupBoxSvet);
            this.Controls.Add(this.groupBoxTrenash);
            this.Controls.Add(this.groupBoxTumba);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.buttonUpdatePorts);
            this.Controls.Add(this.buttonConnect);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(376, 359);
            this.MinimumSize = new System.Drawing.Size(376, 359);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTumba.ResumeLayout(false);
            this.groupBoxTrenash.ResumeLayout(false);
            this.groupBoxSvet.ResumeLayout(false);
            this.groupBoxProector.ResumeLayout(false);
            this.groupBoxAll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonUpdatePorts;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.IO.Ports.SerialPort MySerialPort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxTumba;
        private System.Windows.Forms.GroupBox groupBoxTrenash;
        private System.Windows.Forms.GroupBox groupBoxSvet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBoxProector;
        private System.Windows.Forms.Button buttonOnTumba;
        private System.Windows.Forms.Button buttonOnTrenaz;
        private System.Windows.Forms.Button buttonOnSvet;
        private System.Windows.Forms.Button buttonOffProector;
        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.Button buttonOnAll;
    }
}

