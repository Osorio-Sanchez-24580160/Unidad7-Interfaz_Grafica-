namespace Proyecto_Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            label13 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            comboBoxBaudRate = new ComboBox();
            comboBoxPortSelection = new ComboBox();
            buttonRefresh = new Button();
            buttonConnect = new Button();
            labelBaudRate = new Label();
            labelCommunicationPort = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            btnFoward = new Button();
            btnStop = new Button();
            btnRight = new Button();
            btnBackward = new Button();
            btnLeft = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            label14 = new Label();
            pictureBox9 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 5);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 0;
            label1.Text = "Clock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(47, 27);
            label2.Name = "label2";
            label2.Size = new Size(95, 33);
            label2.TabIndex = 0;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(763, 472);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 69);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(443, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 94);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cerrau;
            pictureBox2.Location = new Point(501, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.escondido;
            pictureBox1.Location = new Point(435, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(16, 29);
            label3.Name = "label3";
            label3.Size = new Size(410, 33);
            label3.TabIndex = 0;
            label3.Text = "Panel de control del proyecto";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(8, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 268);
            panel3.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Gold;
            label13.Location = new Point(100, 246);
            label13.Name = "label13";
            label13.Size = new Size(80, 18);
            label13.TabIndex = 5;
            label13.Text = "22580379";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.YAEL;
            pictureBox8.Location = new Point(32, 218);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(56, 42);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 4;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.valentin;
            pictureBox7.Location = new Point(32, 170);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(56, 42);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.mario1;
            pictureBox6.Location = new Point(33, 120);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 42);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.gama_;
            pictureBox5.Location = new Point(33, 71);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.yo_;
            pictureBox4.Location = new Point(34, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Gold;
            label12.Location = new Point(98, 194);
            label12.Name = "label12";
            label12.Size = new Size(80, 18);
            label12.TabIndex = 2;
            label12.Text = "24580291";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gold;
            label11.Location = new Point(98, 144);
            label11.Name = "label11";
            label11.Size = new Size(80, 18);
            label11.TabIndex = 1;
            label11.Text = "24580137";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(94, 221);
            label8.Name = "label8";
            label8.Size = new Size(118, 25);
            label8.TabIndex = 0;
            label8.Text = "Yael González";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(94, 169);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 0;
            label7.Text = "Valentin Celis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(95, 116);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 0;
            label6.Text = "Mario Barron";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(95, 72);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 0;
            label5.Text = "Jesus Cepeda";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gold;
            label10.Location = new Point(98, 98);
            label10.Name = "label10";
            label10.Size = new Size(80, 18);
            label10.TabIndex = 0;
            label10.Text = "24580141";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gold;
            label9.Location = new Point(98, 47);
            label9.Name = "label9";
            label9.Size = new Size(80, 18);
            label9.TabIndex = 0;
            label9.Text = "24580160";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(95, 18);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 0;
            label4.Text = "César Osorio";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(comboBoxBaudRate);
            panel4.Controls.Add(comboBoxPortSelection);
            panel4.Controls.Add(buttonRefresh);
            panel4.Controls.Add(buttonConnect);
            panel4.Controls.Add(labelBaudRate);
            panel4.Controls.Add(labelCommunicationPort);
            panel4.Location = new Point(10, 283);
            panel4.Name = "panel4";
            panel4.Size = new Size(235, 259);
            panel4.TabIndex = 4;
            // 
            // comboBoxBaudRate
            // 
            comboBoxBaudRate.FormattingEnabled = true;
            comboBoxBaudRate.Location = new Point(21, 116);
            comboBoxBaudRate.Name = "comboBoxBaudRate";
            comboBoxBaudRate.Size = new Size(190, 33);
            comboBoxBaudRate.TabIndex = 2;
            // 
            // comboBoxPortSelection
            // 
            comboBoxPortSelection.FormattingEnabled = true;
            comboBoxPortSelection.Location = new Point(21, 51);
            comboBoxPortSelection.Name = "comboBoxPortSelection";
            comboBoxPortSelection.Size = new Size(190, 33);
            comboBoxPortSelection.TabIndex = 2;
            comboBoxPortSelection.SelectedIndexChanged += comboBoxPortSelection_SelectedIndexChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(46, 205);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(153, 35);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh Ports";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(46, 163);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(153, 35);
            buttonConnect.TabIndex = 1;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // labelBaudRate
            // 
            labelBaudRate.AutoSize = true;
            labelBaudRate.ForeColor = Color.Transparent;
            labelBaudRate.Location = new Point(17, 88);
            labelBaudRate.Name = "labelBaudRate";
            labelBaudRate.Size = new Size(96, 25);
            labelBaudRate.TabIndex = 0;
            labelBaudRate.Text = "Baud Rate:";
            // 
            // labelCommunicationPort
            // 
            labelCommunicationPort.AutoSize = true;
            labelCommunicationPort.ForeColor = Color.Transparent;
            labelCommunicationPort.Location = new Point(15, 22);
            labelCommunicationPort.Name = "labelCommunicationPort";
            labelCommunicationPort.Size = new Size(163, 25);
            labelCommunicationPort.TabIndex = 0;
            labelCommunicationPort.Text = "Comunication Port:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(251, 9);
            panel5.Name = "panel5";
            panel5.Size = new Size(186, 94);
            panel5.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo;
            pictureBox3.Location = new Point(42, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // btnFoward
            // 
            btnFoward.BackColor = Color.Turquoise;
            btnFoward.Location = new Point(45, 126);
            btnFoward.Name = "btnFoward";
            btnFoward.Size = new Size(117, 91);
            btnFoward.TabIndex = 6;
            btnFoward.Text = "izquierda";
            btnFoward.UseVisualStyleBackColor = false;
            btnFoward.Click += btnFoward_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.LightSeaGreen;
            btnStop.Location = new Point(177, 126);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(117, 91);
            btnStop.TabIndex = 6;
            btnStop.Text = "stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.Turquoise;
            btnRight.Location = new Point(177, 223);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(117, 91);
            btnRight.TabIndex = 6;
            btnRight.Text = "atras";
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += btnRight_Click;
            // 
            // btnBackward
            // 
            btnBackward.BackColor = Color.Turquoise;
            btnBackward.Location = new Point(310, 126);
            btnBackward.Name = "btnBackward";
            btnBackward.Size = new Size(117, 91);
            btnBackward.TabIndex = 6;
            btnBackward.Text = "derecha";
            btnBackward.UseVisualStyleBackColor = false;
            btnBackward.Click += btnBackward_Click;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.Turquoise;
            btnLeft.Location = new Point(177, 24);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(117, 91);
            btnLeft.TabIndex = 6;
            btnLeft.Text = "adelante";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(64, 64, 64);
            panel6.Controls.Add(btnLeft);
            panel6.Controls.Add(btnBackward);
            panel6.Controls.Add(btnRight);
            panel6.Controls.Add(btnStop);
            panel6.Controls.Add(btnFoward);
            panel6.Location = new Point(260, 203);
            panel6.Name = "panel6";
            panel6.Size = new Size(480, 338);
            panel6.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(64, 64, 64);
            panel7.Controls.Add(label14);
            panel7.Location = new Point(262, 114);
            panel7.Name = "panel7";
            panel7.Size = new Size(478, 79);
            panel7.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(31, 28);
            label14.Name = "label14";
            label14.Size = new Size(422, 33);
            label14.TabIndex = 3;
            label14.Text = "Control de carro por bluetooth";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.carro_moviendose;
            pictureBox9.Location = new Point(765, 159);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(228, 159);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 9;
            pictureBox9.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1038, 559);
            Controls.Add(pictureBox9);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Panel de control de Proyecto Final";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label4;
        private Label label10;
        private Label label12;
        private Label label11;
        private Panel panel4;
        private Button buttonRefresh;
        private Button buttonConnect;
        private Label labelBaudRate;
        private Label labelCommunicationPort;
        private ComboBox comboBoxBaudRate;
        private ComboBox comboBoxPortSelection;
        private Panel panel5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label13;
        private Button btnFoward;
        private Button btnStop;
        private Button btnRight;
        private Button btnBackward;
        private Button btnLeft;
        private Panel panel6;
        private Panel panel7;
        private Label label14;
        private PictureBox pictureBox9;
    }
}
