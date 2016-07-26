namespace MainClient
{
    partial class ClientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.butCalculate = new System.Windows.Forms.Button();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.textBoxValueA = new System.Windows.Forms.MaskedTextBox();
            this.textBoxValueB = new System.Windows.Forms.MaskedTextBox();
            this.statusMainStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripLblConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblHuman = new System.Windows.Forms.Label();
            this.butGetHuman = new System.Windows.Forms.Button();
            this.lblHumanName = new System.Windows.Forms.Label();
            this.lblHumanAge = new System.Windows.Forms.Label();
            this.lblHumanSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxHumanId = new System.Windows.Forms.MaskedTextBox();
            this.timerCheckConnection = new System.Windows.Forms.Timer(this.components);
            this.lblCar = new System.Windows.Forms.Label();
            this.lblCurrentCar = new System.Windows.Forms.Label();
            this.butGetCar = new System.Windows.Forms.Button();
            this.toolStripLblConnectionType = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusMainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // butCalculate
            // 
            this.butCalculate.Location = new System.Drawing.Point(104, 102);
            this.butCalculate.Name = "butCalculate";
            this.butCalculate.Size = new System.Drawing.Size(75, 23);
            this.butCalculate.TabIndex = 0;
            this.butCalculate.Text = "Calculate";
            this.butCalculate.UseVisualStyleBackColor = true;
            this.butCalculate.Click += new System.EventHandler(this.butCalculate_Click);
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(132, 41);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(22, 24);
            this.lblPlus.TabIndex = 1;
            this.lblPlus.Text = "+";
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(133, 189);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(0, 13);
            this.lblSolution.TabIndex = 4;
            // 
            // lblCalculation
            // 
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculation.Location = new System.Drawing.Point(132, 141);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(22, 24);
            this.lblCalculation.TabIndex = 5;
            this.lblCalculation.Text = "=";
            // 
            // textBoxValueA
            // 
            this.textBoxValueA.Location = new System.Drawing.Point(12, 40);
            this.textBoxValueA.Mask = "00000";
            this.textBoxValueA.Name = "textBoxValueA";
            this.textBoxValueA.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueA.TabIndex = 8;
            this.textBoxValueA.ValidatingType = typeof(int);
            // 
            // textBoxValueB
            // 
            this.textBoxValueB.Location = new System.Drawing.Point(169, 41);
            this.textBoxValueB.Mask = "00000";
            this.textBoxValueB.Name = "textBoxValueB";
            this.textBoxValueB.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueB.TabIndex = 9;
            this.textBoxValueB.ValidatingType = typeof(int);
            // 
            // statusMainStrip
            // 
            this.statusMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblConnection,
            this.lblStatusConnection,
            this.toolStripLblConnectionType});
            this.statusMainStrip.Location = new System.Drawing.Point(0, 265);
            this.statusMainStrip.Name = "statusMainStrip";
            this.statusMainStrip.Size = new System.Drawing.Size(607, 22);
            this.statusMainStrip.SizingGrip = false;
            this.statusMainStrip.TabIndex = 10;
            this.statusMainStrip.Text = "statusStrip";
            // 
            // toolStripLblConnection
            // 
            this.toolStripLblConnection.Name = "toolStripLblConnection";
            this.toolStripLblConnection.Size = new System.Drawing.Size(72, 17);
            this.toolStripLblConnection.Text = "Connection:";
            // 
            // lblStatusConnection
            // 
            this.lblStatusConnection.Name = "lblStatusConnection";
            this.lblStatusConnection.Size = new System.Drawing.Size(0, 17);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(333, 44);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 13);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Enter Id";
            // 
            // lblHuman
            // 
            this.lblHuman.AutoSize = true;
            this.lblHuman.Location = new System.Drawing.Point(411, 9);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.Size = new System.Drawing.Size(41, 13);
            this.lblHuman.TabIndex = 14;
            this.lblHuman.Text = "Human";
            // 
            // butGetHuman
            // 
            this.butGetHuman.Location = new System.Drawing.Point(489, 41);
            this.butGetHuman.Name = "butGetHuman";
            this.butGetHuman.Size = new System.Drawing.Size(75, 23);
            this.butGetHuman.TabIndex = 15;
            this.butGetHuman.Text = "Get human";
            this.butGetHuman.UseVisualStyleBackColor = true;
            this.butGetHuman.Click += new System.EventHandler(this.butGetHuman_Click);
            // 
            // lblHumanName
            // 
            this.lblHumanName.AutoSize = true;
            this.lblHumanName.Location = new System.Drawing.Point(415, 78);
            this.lblHumanName.Name = "lblHumanName";
            this.lblHumanName.Size = new System.Drawing.Size(0, 13);
            this.lblHumanName.TabIndex = 16;
            // 
            // lblHumanAge
            // 
            this.lblHumanAge.AutoSize = true;
            this.lblHumanAge.Location = new System.Drawing.Point(415, 101);
            this.lblHumanAge.Name = "lblHumanAge";
            this.lblHumanAge.Size = new System.Drawing.Size(0, 13);
            this.lblHumanAge.TabIndex = 17;
            // 
            // lblHumanSex
            // 
            this.lblHumanSex.AutoSize = true;
            this.lblHumanSex.Location = new System.Drawing.Point(415, 128);
            this.lblHumanSex.Name = "lblHumanSex";
            this.lblHumanSex.Size = new System.Drawing.Size(0, 13);
            this.lblHumanSex.TabIndex = 18;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(339, 101);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 19;
            this.lblAge.Text = "Age";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(339, 128);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 13);
            this.lblSex.TabIndex = 20;
            this.lblSex.Text = "Sex:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(339, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name:";
            // 
            // textBoxHumanId
            // 
            this.textBoxHumanId.Location = new System.Drawing.Point(383, 41);
            this.textBoxHumanId.Mask = "00000";
            this.textBoxHumanId.Name = "textBoxHumanId";
            this.textBoxHumanId.Size = new System.Drawing.Size(100, 20);
            this.textBoxHumanId.TabIndex = 22;
            this.textBoxHumanId.ValidatingType = typeof(int);
            // 
            // timerCheckConnection
            // 
            this.timerCheckConnection.Enabled = true;
            this.timerCheckConnection.Interval = 3000;
            this.timerCheckConnection.Tick += new System.EventHandler(this.timerCheckConnection_Tick);
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Segoe WP Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.Location = new System.Drawing.Point(164, 189);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(121, 30);
            this.lblCar.TabIndex = 23;
            this.lblCar.Text = "Current Car:";
            // 
            // lblCurrentCar
            // 
            this.lblCurrentCar.AutoSize = true;
            this.lblCurrentCar.Font = new System.Drawing.Font("Segoe WP Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.lblCurrentCar.Location = new System.Drawing.Point(291, 189);
            this.lblCurrentCar.Name = "lblCurrentCar";
            this.lblCurrentCar.Size = new System.Drawing.Size(0, 30);
            this.lblCurrentCar.TabIndex = 24;
            // 
            // butGetCar
            // 
            this.butGetCar.Location = new System.Drawing.Point(239, 222);
            this.butGetCar.Name = "butGetCar";
            this.butGetCar.Size = new System.Drawing.Size(75, 23);
            this.butGetCar.TabIndex = 25;
            this.butGetCar.Text = "Get car";
            this.butGetCar.UseVisualStyleBackColor = true;
            this.butGetCar.Click += new System.EventHandler(this.butGetCar_Click);
            // 
            // toolStripLblConnectionType
            // 
            this.toolStripLblConnectionType.Name = "toolStripLblConnectionType";
            this.toolStripLblConnectionType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripLblConnectionType.Size = new System.Drawing.Size(36, 17);
            this.toolStripLblConnectionType.Text = "None";
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 287);
            this.Controls.Add(this.butGetCar);
            this.Controls.Add(this.lblCurrentCar);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.textBoxHumanId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblHumanSex);
            this.Controls.Add(this.lblHumanAge);
            this.Controls.Add(this.lblHumanName);
            this.Controls.Add(this.butGetHuman);
            this.Controls.Add(this.lblHuman);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.statusMainStrip);
            this.Controls.Add(this.textBoxValueB);
            this.Controls.Add(this.textBoxValueA);
            this.Controls.Add(this.lblCalculation);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.butCalculate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestClient";
            this.statusMainStrip.ResumeLayout(false);
            this.statusMainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCalculate;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Label lblCalculation;
        private System.Windows.Forms.MaskedTextBox textBoxValueA;
        private System.Windows.Forms.MaskedTextBox textBoxValueB;
        private System.Windows.Forms.StatusStrip statusMainStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLblConnection;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusConnection;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblHuman;
        private System.Windows.Forms.Button butGetHuman;
        private System.Windows.Forms.Label lblHumanName;
        private System.Windows.Forms.Label lblHumanAge;
        private System.Windows.Forms.Label lblHumanSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox textBoxHumanId;
        private System.Windows.Forms.Timer timerCheckConnection;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblCurrentCar;
        private System.Windows.Forms.Button butGetCar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLblConnectionType;
    }
}