
namespace Sprint2_Arduino
{
    partial class frmBalises
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtGrupsCicle = new System.Windows.Forms.TextBox();
            this.lblGroupCicle = new System.Windows.Forms.Label();
            this.grbActions = new System.Windows.Forms.GroupBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.lvDades = new System.Windows.Forms.ListView();
            this.chartDades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(292, 50);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.lblPort.Location = new System.Drawing.Point(61, 41);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(51, 30);
            this.lblPort.TabIndex = 7;
            this.lblPort.Text = "Port";
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(118, 50);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(126, 21);
            this.cmbPorts.TabIndex = 6;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(220, 36);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 13;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtGrupsCicle
            // 
            this.txtGrupsCicle.Location = new System.Drawing.Point(138, 36);
            this.txtGrupsCicle.Name = "txtGrupsCicle";
            this.txtGrupsCicle.Size = new System.Drawing.Size(62, 20);
            this.txtGrupsCicle.TabIndex = 10;
            this.txtGrupsCicle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OnlyNumbersAccept);
            // 
            // lblGroupCicle
            // 
            this.lblGroupCicle.AutoSize = true;
            this.lblGroupCicle.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupCicle.Location = new System.Drawing.Point(15, 26);
            this.lblGroupCicle.Name = "lblGroupCicle";
            this.lblGroupCicle.Size = new System.Drawing.Size(117, 30);
            this.lblGroupCicle.TabIndex = 9;
            this.lblGroupCicle.Text = "Grups Cicle";
            // 
            // grbActions
            // 
            this.grbActions.Controls.Add(this.txtDivisor);
            this.grbActions.Controls.Add(this.lblDivisor);
            this.grbActions.Controls.Add(this.lblGroupCicle);
            this.grbActions.Controls.Add(this.btnExecute);
            this.grbActions.Controls.Add(this.txtGrupsCicle);
            this.grbActions.Location = new System.Drawing.Point(66, 110);
            this.grbActions.Name = "grbActions";
            this.grbActions.Size = new System.Drawing.Size(316, 140);
            this.grbActions.TabIndex = 12;
            this.grbActions.TabStop = false;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(138, 91);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(62, 20);
            this.txtDivisor.TabIndex = 11;
            this.txtDivisor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OnlyNumbersAccept);
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisor.Location = new System.Drawing.Point(56, 81);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(76, 30);
            this.lblDivisor.TabIndex = 12;
            this.lblDivisor.Text = "Divisor";
            // 
            // lvDades
            // 
            this.lvDades.HideSelection = false;
            this.lvDades.Location = new System.Drawing.Point(432, 28);
            this.lvDades.Name = "lvDades";
            this.lvDades.Size = new System.Drawing.Size(161, 439);
            this.lvDades.TabIndex = 13;
            this.lvDades.UseCompatibleStateImageBehavior = false;
            // 
            // chartDades
            // 
            this.chartDades.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartDades.ChartAreas.Add(chartArea1);
            this.chartDades.Location = new System.Drawing.Point(7, 256);
            this.chartDades.Name = "chartDades";
            this.chartDades.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Datos";
            this.chartDades.Series.Add(series1);
            this.chartDades.Size = new System.Drawing.Size(419, 211);
            this.chartDades.TabIndex = 14;
            this.chartDades.Text = "chartDades";
            // 
            // frmBalises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(633, 496);
            this.Controls.Add(this.chartDades);
            this.Controls.Add(this.lvDades);
            this.Controls.Add(this.grbActions);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cmbPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBalises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuració de balises";
            this.grbActions.ResumeLayout(false);
            this.grbActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtGrupsCicle;
        private System.Windows.Forms.Label lblGroupCicle;
        private System.Windows.Forms.GroupBox grbActions;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.ListView lvDades;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDades;
    }
}

