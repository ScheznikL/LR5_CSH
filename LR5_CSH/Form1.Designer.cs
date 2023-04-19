namespace LR5_CSH
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
            this.pNumberOfDepartments = new System.Windows.Forms.Panel();
            this.btInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDNumOfDepartm = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nUDNumOfDailyProd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDNumOfWorkers = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mTBSellingTime = new System.Windows.Forms.MaskedTextBox();
            this.btOpenSellings = new System.Windows.Forms.Button();
            this.lbAboutOpenSelling = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prBResourses = new System.Windows.Forms.ProgressBar();
            this.lbForResourses = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbForBankAccount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbSpentOnPayment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbCurrentProdNum = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btOpenLog = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbForStatus = new System.Windows.Forms.Label();
            this.lbRestoreStat = new System.Windows.Forms.Label();
            this.lbSelingStat = new System.Windows.Forms.Label();
            this.pNumberOfDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumOfDepartm)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumOfDailyProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumOfWorkers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pNumberOfDepartments
            // 
            this.pNumberOfDepartments.Controls.Add(this.btInfo);
            this.pNumberOfDepartments.Controls.Add(this.label1);
            this.pNumberOfDepartments.Controls.Add(this.nUDNumOfDepartm);
            this.pNumberOfDepartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNumberOfDepartments.Location = new System.Drawing.Point(0, 0);
            this.pNumberOfDepartments.Name = "pNumberOfDepartments";
            this.pNumberOfDepartments.Size = new System.Drawing.Size(540, 48);
            this.pNumberOfDepartments.TabIndex = 1;
            // 
            // btInfo
            // 
            this.btInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInfo.Location = new System.Drawing.Point(462, 0);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(75, 32);
            this.btInfo.TabIndex = 7;
            this.btInfo.Text = "Get info";
            this.btInfo.UseVisualStyleBackColor = false;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of departments";
            // 
            // nUDNumOfDepartm
            // 
            this.nUDNumOfDepartm.Location = new System.Drawing.Point(299, 16);
            this.nUDNumOfDepartm.Name = "nUDNumOfDepartm";
            this.nUDNumOfDepartm.Size = new System.Drawing.Size(75, 22);
            this.nUDNumOfDepartm.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 127);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nUDNumOfDailyProd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nUDNumOfWorkers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 118);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Amount of";
            // 
            // nUDNumOfDailyProd
            // 
            this.nUDNumOfDailyProd.Location = new System.Drawing.Point(132, 68);
            this.nUDNumOfDailyProd.Name = "nUDNumOfDailyProd";
            this.nUDNumOfDailyProd.Size = new System.Drawing.Size(75, 22);
            this.nUDNumOfDailyProd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Daily products";
            // 
            // nUDNumOfWorkers
            // 
            this.nUDNumOfWorkers.Location = new System.Drawing.Point(132, 40);
            this.nUDNumOfWorkers.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nUDNumOfWorkers.Name = "nUDNumOfWorkers";
            this.nUDNumOfWorkers.Size = new System.Drawing.Size(75, 22);
            this.nUDNumOfWorkers.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Workers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mTBSellingTime);
            this.panel1.Controls.Add(this.btOpenSellings);
            this.panel1.Controls.Add(this.lbAboutOpenSelling);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(260, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 125);
            this.panel1.TabIndex = 5;
            // 
            // mTBSellingTime
            // 
            this.mTBSellingTime.Enabled = false;
            this.mTBSellingTime.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTBSellingTime.Location = new System.Drawing.Point(122, 76);
            this.mTBSellingTime.Mask = "00:00";
            this.mTBSellingTime.Name = "mTBSellingTime";
            this.mTBSellingTime.Size = new System.Drawing.Size(49, 28);
            this.mTBSellingTime.TabIndex = 7;
            this.mTBSellingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTBSellingTime.ValidatingType = typeof(System.DateTime);
            // 
            // btOpenSellings
            // 
            this.btOpenSellings.BackColor = System.Drawing.Color.PaleGreen;
            this.btOpenSellings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOpenSellings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenSellings.Location = new System.Drawing.Point(94, 6);
            this.btOpenSellings.Name = "btOpenSellings";
            this.btOpenSellings.Size = new System.Drawing.Size(99, 39);
            this.btOpenSellings.TabIndex = 5;
            this.btOpenSellings.Text = "Open Selling";
            this.btOpenSellings.UseVisualStyleBackColor = false;
            this.btOpenSellings.Click += new System.EventHandler(this.btOpenSellings_Click);
            // 
            // lbAboutOpenSelling
            // 
            this.lbAboutOpenSelling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAboutOpenSelling.AutoSize = true;
            this.lbAboutOpenSelling.Location = new System.Drawing.Point(27, 48);
            this.lbAboutOpenSelling.Name = "lbAboutOpenSelling";
            this.lbAboutOpenSelling.Size = new System.Drawing.Size(233, 70);
            this.lbAboutOpenSelling.TabIndex = 8;
            this.lbAboutOpenSelling.Text = "Set a time period \r\nin which the purcheses will be happening\r\n\r\n\r\nsec:ms";
            this.lbAboutOpenSelling.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.BackColor = System.Drawing.Color.Transparent;
            this.btStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btStop.BackgroundImage")));
            this.btStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStop.FlatAppearance.BorderSize = 0;
            this.btStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btStop.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStop.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(475, 201);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(62, 46);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.Location = new System.Drawing.Point(170, 205);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(183, 39);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Start a factory";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.prBResourses);
            this.panel3.Controls.Add(this.lbForResourses);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lbForBankAccount);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 127);
            this.panel3.TabIndex = 3;
            // 
            // prBResourses
            // 
            this.prBResourses.ForeColor = System.Drawing.Color.Peru;
            this.prBResourses.Location = new System.Drawing.Point(45, 22);
            this.prBResourses.Maximum = 1000;
            this.prBResourses.Name = "prBResourses";
            this.prBResourses.Size = new System.Drawing.Size(180, 23);
            this.prBResourses.Step = 1;
            this.prBResourses.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prBResourses.TabIndex = 5;
            // 
            // lbForResourses
            // 
            this.lbForResourses.AutoSize = true;
            this.lbForResourses.BackColor = System.Drawing.Color.Transparent;
            this.lbForResourses.Location = new System.Drawing.Point(172, 46);
            this.lbForResourses.Name = "lbForResourses";
            this.lbForResourses.Size = new System.Drawing.Size(14, 14);
            this.lbForResourses.TabIndex = 7;
            this.lbForResourses.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(189, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = " $";
            // 
            // lbForBankAccount
            // 
            this.lbForBankAccount.AutoSize = true;
            this.lbForBankAccount.Location = new System.Drawing.Point(113, 85);
            this.lbForBankAccount.Name = "lbForBankAccount";
            this.lbForBankAccount.Size = new System.Drawing.Size(14, 14);
            this.lbForBankAccount.TabIndex = 9;
            this.lbForBankAccount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bank account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resourses";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.lbSpentOnPayment);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lbCurrentProdNum);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btOpenLog);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(260, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 125);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(243, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 44);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Orange;
            this.label13.Location = new System.Drawing.Point(211, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = " $";
            // 
            // lbSpentOnPayment
            // 
            this.lbSpentOnPayment.AutoSize = true;
            this.lbSpentOnPayment.Location = new System.Drawing.Point(149, 53);
            this.lbSpentOnPayment.Name = "lbSpentOnPayment";
            this.lbSpentOnPayment.Size = new System.Drawing.Size(14, 14);
            this.lbSpentOnPayment.TabIndex = 13;
            this.lbSpentOnPayment.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 14);
            this.label12.TabIndex = 12;
            this.label12.Text = "Spent on payment";
            // 
            // lbCurrentProdNum
            // 
            this.lbCurrentProdNum.AutoSize = true;
            this.lbCurrentProdNum.Location = new System.Drawing.Point(194, 23);
            this.lbCurrentProdNum.Name = "lbCurrentProdNum";
            this.lbCurrentProdNum.Size = new System.Drawing.Size(14, 14);
            this.lbCurrentProdNum.TabIndex = 11;
            this.lbCurrentProdNum.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 14);
            this.label11.TabIndex = 10;
            this.label11.Text = "Current amount of products";
            // 
            // btOpenLog
            // 
            this.btOpenLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpenLog.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btOpenLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOpenLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenLog.Location = new System.Drawing.Point(177, 87);
            this.btOpenLog.Name = "btOpenLog";
            this.btOpenLog.Size = new System.Drawing.Size(99, 35);
            this.btOpenLog.TabIndex = 7;
            this.btOpenLog.Text = "Open log";
            this.btOpenLog.UseVisualStyleBackColor = false;
            this.btOpenLog.Click += new System.EventHandler(this.btOpenLog_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Processing resourses...  ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(205, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Furniture Factory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status:";
            // 
            // lbForStatus
            // 
            this.lbForStatus.AutoSize = true;
            this.lbForStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbForStatus.Location = new System.Drawing.Point(48, 193);
            this.lbForStatus.Name = "lbForStatus";
            this.lbForStatus.Size = new System.Drawing.Size(36, 14);
            this.lbForStatus.TabIndex = 6;
            this.lbForStatus.Text = "None";
            // 
            // lbRestoreStat
            // 
            this.lbRestoreStat.AutoSize = true;
            this.lbRestoreStat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbRestoreStat.Location = new System.Drawing.Point(48, 229);
            this.lbRestoreStat.Name = "lbRestoreStat";
            this.lbRestoreStat.Size = new System.Drawing.Size(36, 14);
            this.lbRestoreStat.TabIndex = 7;
            this.lbRestoreStat.Text = "None";
            // 
            // lbSelingStat
            // 
            this.lbSelingStat.AutoSize = true;
            this.lbSelingStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbSelingStat.Location = new System.Drawing.Point(48, 210);
            this.lbSelingStat.Name = "lbSelingStat";
            this.lbSelingStat.Size = new System.Drawing.Size(36, 14);
            this.lbSelingStat.TabIndex = 8;
            this.lbSelingStat.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(540, 388);
            this.Controls.Add(this.lbSelingStat);
            this.Controls.Add(this.lbRestoreStat);
            this.Controls.Add(this.lbForStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pNumberOfDepartments);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Factory";
            this.pNumberOfDepartments.ResumeLayout(false);
            this.pNumberOfDepartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumOfDepartm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumOfDailyProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumOfWorkers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pNumberOfDepartments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDNumOfDepartm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDNumOfDailyProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDNumOfWorkers;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btOpenSellings;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbForBankAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbForResourses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar prBResourses;
        private System.Windows.Forms.Button btOpenLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbForStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbAboutOpenSelling;
        private System.Windows.Forms.MaskedTextBox mTBSellingTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCurrentProdNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbSpentOnPayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbRestoreStat;
        private System.Windows.Forms.Label lbSelingStat;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

