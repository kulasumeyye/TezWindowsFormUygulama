namespace WinFormTez
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxVeri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOran = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAzalan = new System.Windows.Forms.TextBox();
            this.textBoxArtan = new System.Windows.Forms.TextBox();
            this.labelAzalan = new System.Windows.Forms.Label();
            this.labelArtan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "KELİMELERİN YILLARA GÖRE DAĞILIMLARI";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(34, 133);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Yillar";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(599, 339);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // comboBoxVeri
            // 
            this.comboBoxVeri.FormattingEnabled = true;
            this.comboBoxVeri.Location = new System.Drawing.Point(34, 95);
            this.comboBoxVeri.MaxDropDownItems = 20;
            this.comboBoxVeri.Name = "comboBoxVeri";
            this.comboBoxVeri.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVeri.TabIndex = 2;
            this.comboBoxVeri.SelectedIndexChanged += new System.EventHandler(this.comboBoxVeri_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(678, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kelimelerin Yıllara Göre Kullanım Oranı";
            // 
            // comboBoxOran
            // 
            this.comboBoxOran.FormattingEnabled = true;
            this.comboBoxOran.Location = new System.Drawing.Point(681, 162);
            this.comboBoxOran.Name = "comboBoxOran";
            this.comboBoxOran.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOran.TabIndex = 4;
            this.comboBoxOran.SelectedIndexChanged += new System.EventHandler(this.comboBoxOran_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // textBoxAzalan
            // 
            this.textBoxAzalan.Location = new System.Drawing.Point(681, 234);
            this.textBoxAzalan.Multiline = true;
            this.textBoxAzalan.Name = "textBoxAzalan";
            this.textBoxAzalan.Size = new System.Drawing.Size(121, 238);
            this.textBoxAzalan.TabIndex = 6;
            // 
            // textBoxArtan
            // 
            this.textBoxArtan.Location = new System.Drawing.Point(821, 234);
            this.textBoxArtan.Multiline = true;
            this.textBoxArtan.Name = "textBoxArtan";
            this.textBoxArtan.Size = new System.Drawing.Size(121, 238);
            this.textBoxArtan.TabIndex = 7;
            // 
            // labelAzalan
            // 
            this.labelAzalan.AutoSize = true;
            this.labelAzalan.Location = new System.Drawing.Point(684, 209);
            this.labelAzalan.Name = "labelAzalan";
            this.labelAzalan.Size = new System.Drawing.Size(35, 13);
            this.labelAzalan.TabIndex = 8;
            this.labelAzalan.Text = "label4";
            // 
            // labelArtan
            // 
            this.labelArtan.AutoSize = true;
            this.labelArtan.Location = new System.Drawing.Point(833, 209);
            this.labelArtan.Name = "labelArtan";
            this.labelArtan.Size = new System.Drawing.Size(35, 13);
            this.labelArtan.TabIndex = 9;
            this.labelArtan.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 500);
            this.Controls.Add(this.labelArtan);
            this.Controls.Add(this.labelAzalan);
            this.Controls.Add(this.textBoxArtan);
            this.Controls.Add(this.textBoxAzalan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxOran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxVeri);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxVeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAzalan;
        private System.Windows.Forms.TextBox textBoxArtan;
        private System.Windows.Forms.Label labelAzalan;
        private System.Windows.Forms.Label labelArtan;
    }
}

