namespace EFSpace
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
            this.buttonGetData = new System.Windows.Forms.Button();
            this.buttonUpdateDBData = new System.Windows.Forms.Button();
            this.comboBoxPlanet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxV1 = new System.Windows.Forms.TextBox();
            this.textBoxV2 = new System.Windows.Forms.TextBox();
            this.buttonUpdatePlanetList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(12, 100);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(152, 23);
            this.buttonGetData.TabIndex = 0;
            this.buttonGetData.Text = "Get Data";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.ButtonGetData_Click);
            // 
            // buttonUpdateDBData
            // 
            this.buttonUpdateDBData.Location = new System.Drawing.Point(391, 12);
            this.buttonUpdateDBData.Name = "buttonUpdateDBData";
            this.buttonUpdateDBData.Size = new System.Drawing.Size(139, 23);
            this.buttonUpdateDBData.TabIndex = 1;
            this.buttonUpdateDBData.Text = "UpdateDBData";
            this.buttonUpdateDBData.UseVisualStyleBackColor = true;
            this.buttonUpdateDBData.Click += new System.EventHandler(this.ButtonUpdateDBData_Click);
            // 
            // comboBoxPlanet
            // 
            this.comboBoxPlanet.FormattingEnabled = true;
            this.comboBoxPlanet.Location = new System.Drawing.Point(12, 37);
            this.comboBoxPlanet.Name = "comboBoxPlanet";
            this.comboBoxPlanet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlanet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Planet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "h";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(13, 72);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(120, 20);
            this.textBoxH.TabIndex = 5;
            this.textBoxH.Text = "0";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(212, 12);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "Calc";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "V1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "V2";
            // 
            // textBoxV1
            // 
            this.textBoxV1.Location = new System.Drawing.Point(239, 47);
            this.textBoxV1.Name = "textBoxV1";
            this.textBoxV1.Size = new System.Drawing.Size(100, 20);
            this.textBoxV1.TabIndex = 9;
            // 
            // textBoxV2
            // 
            this.textBoxV2.Location = new System.Drawing.Point(242, 77);
            this.textBoxV2.Name = "textBoxV2";
            this.textBoxV2.Size = new System.Drawing.Size(100, 20);
            this.textBoxV2.TabIndex = 10;
            // 
            // buttonUpdatePlanetList
            // 
            this.buttonUpdatePlanetList.Location = new System.Drawing.Point(12, 8);
            this.buttonUpdatePlanetList.Name = "buttonUpdatePlanetList";
            this.buttonUpdatePlanetList.Size = new System.Drawing.Size(121, 23);
            this.buttonUpdatePlanetList.TabIndex = 11;
            this.buttonUpdatePlanetList.Text = "UpdatePlanetList";
            this.buttonUpdatePlanetList.UseVisualStyleBackColor = true;
            this.buttonUpdatePlanetList.Click += new System.EventHandler(this.ButtonUpdatePlanetList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 135);
            this.Controls.Add(this.buttonUpdatePlanetList);
            this.Controls.Add(this.textBoxV2);
            this.Controls.Add(this.textBoxV1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPlanet);
            this.Controls.Add(this.buttonUpdateDBData);
            this.Controls.Add(this.buttonGetData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.Button buttonUpdateDBData;
        private System.Windows.Forms.ComboBox comboBoxPlanet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxV1;
        private System.Windows.Forms.TextBox textBoxV2;
        private System.Windows.Forms.Button buttonUpdatePlanetList;
    }
}

