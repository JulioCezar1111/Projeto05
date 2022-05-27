
namespace PortaSerial
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxPortCom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFechar = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.btnConectar = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.btnDesconectar = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.pilotoCom = new MfgControl.AdvancedHMI.Controls.PilotLight();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txbRxData = new System.Windows.Forms.TextBox();
            this.txbA0 = new System.Windows.Forms.TextBox();
            this.txbA1 = new System.Windows.Forms.TextBox();
            this.txbA2 = new System.Windows.Forms.TextBox();
            this.txbA3 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pilotoSt = new MfgControl.AdvancedHMI.Controls.PilotLight();
            this.momemtaryButton2 = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.momemtaryButton1 = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tank4 = new MfgControl.AdvancedHMI.Controls.Tank();
            this.tank3 = new MfgControl.AdvancedHMI.Controls.Tank();
            this.tank2 = new MfgControl.AdvancedHMI.Controls.Tank();
            this.tank1 = new MfgControl.AdvancedHMI.Controls.Tank();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnEM4 = new MfgControl.AdvancedHMI.Controls.PilotLight();
            this.btnEM3 = new MfgControl.AdvancedHMI.Controls.PilotLight();
            this.btnEM2 = new MfgControl.AdvancedHMI.Controls.PilotLight();
            this.btnEM1 = new MfgControl.AdvancedHMI.Controls.PilotLight();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxPortCom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Porta Com";
            // 
            // cbxPortCom
            // 
            this.cbxPortCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPortCom.FormattingEnabled = true;
            this.cbxPortCom.Location = new System.Drawing.Point(6, 25);
            this.cbxPortCom.Name = "cbxPortCom";
            this.cbxPortCom.Size = new System.Drawing.Size(170, 28);
            this.cbxPortCom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxBaudRate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baud Rate";
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(6, 25);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(170, 28);
            this.cbxBaudRate.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFechar);
            this.groupBox3.Controls.Add(this.btnConectar);
            this.groupBox3.Controls.Add(this.btnDesconectar);
            this.groupBox3.Controls.Add(this.pilotoCom);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 298);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controle";
            // 
            // btnFechar
            // 
            this.btnFechar.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnFechar.Location = new System.Drawing.Point(99, 158);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnFechar.Size = new System.Drawing.Size(87, 127);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // btnConectar
            // 
            this.btnConectar.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnConectar.Location = new System.Drawing.Point(99, 25);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnConectar.Size = new System.Drawing.Size(87, 127);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "CONECT";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click_1);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Blue;
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnDesconectar.Location = new System.Drawing.Point(6, 25);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnDesconectar.Size = new System.Drawing.Size(87, 127);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "DESCONECT";
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click_1);
            // 
            // pilotoCom
            // 
            this.pilotoCom.Blink = false;
            this.pilotoCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilotoCom.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotoCom.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotoCom.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.pilotoCom.Location = new System.Drawing.Point(6, 158);
            this.pilotoCom.Name = "pilotoCom";
            this.pilotoCom.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotoCom.Size = new System.Drawing.Size(87, 127);
            this.pilotoCom.TabIndex = 0;
            this.pilotoCom.Text = "OFF";
            this.pilotoCom.Value = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txbRxData
            // 
            this.txbRxData.Enabled = false;
            this.txbRxData.Location = new System.Drawing.Point(11, 19);
            this.txbRxData.Name = "txbRxData";
            this.txbRxData.Size = new System.Drawing.Size(194, 20);
            this.txbRxData.TabIndex = 5;
            // 
            // txbA0
            // 
            this.txbA0.Enabled = false;
            this.txbA0.Location = new System.Drawing.Point(72, 19);
            this.txbA0.Name = "txbA0";
            this.txbA0.Size = new System.Drawing.Size(64, 20);
            this.txbA0.TabIndex = 6;
            // 
            // txbA1
            // 
            this.txbA1.Enabled = false;
            this.txbA1.Location = new System.Drawing.Point(164, 19);
            this.txbA1.Name = "txbA1";
            this.txbA1.Size = new System.Drawing.Size(64, 20);
            this.txbA1.TabIndex = 7;
            // 
            // txbA2
            // 
            this.txbA2.Enabled = false;
            this.txbA2.Location = new System.Drawing.Point(250, 19);
            this.txbA2.Name = "txbA2";
            this.txbA2.Size = new System.Drawing.Size(64, 20);
            this.txbA2.TabIndex = 8;
            // 
            // txbA3
            // 
            this.txbA3.Enabled = false;
            this.txbA3.Location = new System.Drawing.Point(340, 19);
            this.txbA3.Name = "txbA3";
            this.txbA3.Size = new System.Drawing.Size(64, 20);
            this.txbA3.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txbRxData);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 448);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 46);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Protocolo";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txbA0);
            this.groupBox6.Controls.Add(this.txbA1);
            this.groupBox6.Controls.Add(this.txbA2);
            this.groupBox6.Controls.Add(this.txbA3);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(229, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(419, 54);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pacotes";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pilotoSt);
            this.groupBox7.Controls.Add(this.momemtaryButton2);
            this.groupBox7.Controls.Add(this.momemtaryButton1);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(479, 401);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(172, 98);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sistema";
            // 
            // pilotoSt
            // 
            this.pilotoSt.Blink = false;
            this.pilotoSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilotoSt.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotoSt.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotoSt.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.pilotoSt.Location = new System.Drawing.Point(112, 23);
            this.pilotoSt.Name = "pilotoSt";
            this.pilotoSt.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotoSt.Size = new System.Drawing.Size(47, 69);
            this.pilotoSt.TabIndex = 4;
            this.pilotoSt.Text = "OFF";
            this.pilotoSt.Value = false;
            // 
            // momemtaryButton2
            // 
            this.momemtaryButton2.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Blue;
            this.momemtaryButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.momemtaryButton2.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.momemtaryButton2.Location = new System.Drawing.Point(59, 23);
            this.momemtaryButton2.Name = "momemtaryButton2";
            this.momemtaryButton2.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.momemtaryButton2.Size = new System.Drawing.Size(47, 69);
            this.momemtaryButton2.TabIndex = 5;
            this.momemtaryButton2.Text = "DN";
            this.momemtaryButton2.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // momemtaryButton1
            // 
            this.momemtaryButton1.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green;
            this.momemtaryButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.momemtaryButton1.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.momemtaryButton1.Location = new System.Drawing.Point(6, 23);
            this.momemtaryButton1.Name = "momemtaryButton1";
            this.momemtaryButton1.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.momemtaryButton1.Size = new System.Drawing.Size(47, 69);
            this.momemtaryButton1.TabIndex = 4;
            this.momemtaryButton1.Text = "EN";
            this.momemtaryButton1.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tank4);
            this.groupBox4.Controls.Add(this.tank3);
            this.groupBox4.Controls.Add(this.tank2);
            this.groupBox4.Controls.Add(this.tank1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(229, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 288);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Painel de Instrumentação";
            // 
            // tank4
            // 
            this.tank4.Location = new System.Drawing.Point(317, 41);
            this.tank4.MaxValue = 1030;
            this.tank4.MinValue = 0;
            this.tank4.Name = "tank4";
            this.tank4.Size = new System.Drawing.Size(87, 199);
            this.tank4.TabIndex = 3;
            this.tank4.TankContentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tank4.Text = "tank4";
            this.tank4.Value = 0F;
            this.tank4.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tank3
            // 
            this.tank3.Location = new System.Drawing.Point(216, 41);
            this.tank3.MaxValue = 1030;
            this.tank3.MinValue = 0;
            this.tank3.Name = "tank3";
            this.tank3.Size = new System.Drawing.Size(87, 199);
            this.tank3.TabIndex = 2;
            this.tank3.TankContentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tank3.Text = "tank3";
            this.tank3.Value = 0F;
            this.tank3.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tank2
            // 
            this.tank2.Location = new System.Drawing.Point(111, 41);
            this.tank2.MaxValue = 1030;
            this.tank2.MinValue = 0;
            this.tank2.Name = "tank2";
            this.tank2.Size = new System.Drawing.Size(87, 199);
            this.tank2.TabIndex = 1;
            this.tank2.TankContentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tank2.Text = "tank2";
            this.tank2.Value = 0F;
            this.tank2.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tank1
            // 
            this.tank1.Location = new System.Drawing.Point(6, 41);
            this.tank1.MaxValue = 1030;
            this.tank1.MinValue = 0;
            this.tank1.Name = "tank1";
            this.tank1.Size = new System.Drawing.Size(87, 199);
            this.tank1.TabIndex = 0;
            this.tank1.TankContentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tank1.Text = "tank1";
            this.tank1.Value = 0F;
            this.tank1.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnEM4);
            this.groupBox8.Controls.Add(this.btnEM3);
            this.groupBox8.Controls.Add(this.btnEM2);
            this.groupBox8.Controls.Add(this.btnEM1);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(229, 401);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(244, 98);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Emergência";
            // 
            // btnEM4
            // 
            this.btnEM4.Blink = false;
            this.btnEM4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEM4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.btnEM4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.btnEM4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.btnEM4.Location = new System.Drawing.Point(191, 23);
            this.btnEM4.Name = "btnEM4";
            this.btnEM4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.btnEM4.Size = new System.Drawing.Size(47, 69);
            this.btnEM4.TabIndex = 9;
            this.btnEM4.Text = "EM4";
            this.btnEM4.Value = false;
            // 
            // btnEM3
            // 
            this.btnEM3.Blink = false;
            this.btnEM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEM3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.btnEM3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.btnEM3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.btnEM3.Location = new System.Drawing.Point(138, 24);
            this.btnEM3.Name = "btnEM3";
            this.btnEM3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.btnEM3.Size = new System.Drawing.Size(47, 69);
            this.btnEM3.TabIndex = 8;
            this.btnEM3.Text = "EM3";
            this.btnEM3.Value = false;
            // 
            // btnEM2
            // 
            this.btnEM2.Blink = false;
            this.btnEM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEM2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.btnEM2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.btnEM2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.btnEM2.Location = new System.Drawing.Point(85, 23);
            this.btnEM2.Name = "btnEM2";
            this.btnEM2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.btnEM2.Size = new System.Drawing.Size(47, 69);
            this.btnEM2.TabIndex = 7;
            this.btnEM2.Text = "EM2";
            this.btnEM2.Value = false;
            // 
            // btnEM1
            // 
            this.btnEM1.Blink = false;
            this.btnEM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEM1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.btnEM1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.btnEM1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.btnEM1.Location = new System.Drawing.Point(32, 23);
            this.btnEM1.Name = "btnEM1";
            this.btnEM1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.btnEM1.Size = new System.Drawing.Size(47, 69);
            this.btnEM1.TabIndex = 6;
            this.btnEM1.Text = "EM1";
            this.btnEM1.Value = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 503);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxPortCom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.IO.Ports.SerialPort serialPort1;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnFechar;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnConectar;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnDesconectar;
        private MfgControl.AdvancedHMI.Controls.PilotLight pilotoCom;
        private System.Windows.Forms.TextBox txbRxData;
        private System.Windows.Forms.TextBox txbA0;
        private System.Windows.Forms.TextBox txbA1;
        private System.Windows.Forms.TextBox txbA2;
        private System.Windows.Forms.TextBox txbA3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private MfgControl.AdvancedHMI.Controls.PilotLight pilotoSt;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton momemtaryButton2;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton momemtaryButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MfgControl.AdvancedHMI.Controls.Tank tank4;
        private MfgControl.AdvancedHMI.Controls.Tank tank3;
        private MfgControl.AdvancedHMI.Controls.Tank tank2;
        private MfgControl.AdvancedHMI.Controls.Tank tank1;
        private System.Windows.Forms.GroupBox groupBox8;
        private MfgControl.AdvancedHMI.Controls.PilotLight btnEM4;
        private MfgControl.AdvancedHMI.Controls.PilotLight btnEM3;
        private MfgControl.AdvancedHMI.Controls.PilotLight btnEM2;
        private MfgControl.AdvancedHMI.Controls.PilotLight btnEM1;
    }
}

