
namespace beadando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.salaryNormalNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.salarySZJA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.salaryTBA = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.salaryNetto = new System.Windows.Forms.NumericUpDown();
            this.calculateItButton = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nev = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.DomainUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.positionButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.twentyFive = new System.Windows.Forms.CheckBox();
            this.checkBoxMarried = new System.Windows.Forms.CheckBox();
            this.restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNormalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarySZJA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryTBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNetto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(451, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add meg a bruttó béred:";
            // 
            // salaryNormalNumeric
            // 
            this.salaryNormalNumeric.Location = new System.Drawing.Point(671, 20);
            this.salaryNormalNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.salaryNormalNumeric.Name = "salaryNormalNumeric";
            this.salaryNormalNumeric.Size = new System.Drawing.Size(120, 23);
            this.salaryNormalNumeric.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(451, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ebből SZJA:";
            // 
            // salarySZJA
            // 
            this.salarySZJA.Location = new System.Drawing.Point(671, 69);
            this.salarySZJA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.salarySZJA.Name = "salarySZJA";
            this.salarySZJA.Size = new System.Drawing.Size(120, 23);
            this.salarySZJA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(451, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Egyéni járulék:";
            // 
            // salaryTBA
            // 
            this.salaryTBA.Location = new System.Drawing.Point(671, 103);
            this.salaryTBA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.salaryTBA.Name = "salaryTBA";
            this.salaryTBA.Size = new System.Drawing.Size(120, 23);
            this.salaryTBA.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(451, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nettóba átszámítva:";
            // 
            // salaryNetto
            // 
            this.salaryNetto.Location = new System.Drawing.Point(671, 139);
            this.salaryNetto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.salaryNetto.Name = "salaryNetto";
            this.salaryNetto.Size = new System.Drawing.Size(120, 23);
            this.salaryNetto.TabIndex = 7;
            // 
            // calculateItButton
            // 
            this.calculateItButton.Location = new System.Drawing.Point(600, 210);
            this.calculateItButton.Name = "calculateItButton";
            this.calculateItButton.Size = new System.Drawing.Size(170, 25);
            this.calculateItButton.TabIndex = 8;
            this.calculateItButton.Text = "Számítás";
            this.calculateItButton.UseVisualStyleBackColor = true;
            this.calculateItButton.Click += new System.EventHandler(this.calculateItButton_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(12, 210);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(170, 25);
            this.buttonWrite.TabIndex = 9;
            this.buttonWrite.Text = "Mentés txt fájlban";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(24, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 19);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Munkavállaó neve:";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(227, 48);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(163, 23);
            this.nev.TabIndex = 12;
            // 
            // position
            // 
            this.position.AccessibleName = "";
            this.position.Location = new System.Drawing.Point(227, 98);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(163, 23);
            this.position.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 19);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Munkavállaó pozíciója:";
            // 
            // positionButton
            // 
            this.positionButton.Location = new System.Drawing.Point(111, 139);
            this.positionButton.Name = "positionButton";
            this.positionButton.Size = new System.Drawing.Size(170, 25);
            this.positionButton.TabIndex = 15;
            this.positionButton.Text = "Pozició betöltése";
            this.positionButton.UseVisualStyleBackColor = true;
            this.positionButton.Click += new System.EventHandler(this.positionButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sabolc szoftverfejlesztő cég bérkalk";
            // 
            // twentyFive
            // 
            this.twentyFive.AutoSize = true;
            this.twentyFive.Location = new System.Drawing.Point(668, 183);
            this.twentyFive.Name = "twentyFive";
            this.twentyFive.Size = new System.Drawing.Size(123, 19);
            this.twentyFive.TabIndex = 17;
            this.twentyFive.Text = "25 év alatti vagyok";
            this.twentyFive.UseVisualStyleBackColor = true;
            // 
            // checkBoxMarried
            // 
            this.checkBoxMarried.AutoSize = true;
            this.checkBoxMarried.Location = new System.Drawing.Point(552, 183);
            this.checkBoxMarried.Name = "checkBoxMarried";
            this.checkBoxMarried.Size = new System.Drawing.Size(81, 19);
            this.checkBoxMarried.TabIndex = 18;
            this.checkBoxMarried.Text = "Friss házas";
            this.checkBoxMarried.UseVisualStyleBackColor = true;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(600, 270);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(170, 25);
            this.restartButton.TabIndex = 19;
            this.restartButton.Text = "Újrakezdés";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 305);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.checkBoxMarried);
            this.Controls.Add(this.twentyFive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.positionButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.position);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.calculateItButton);
            this.Controls.Add(this.salaryNetto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salaryTBA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salarySZJA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salaryNormalNumeric);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bérkalkulátor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryNormalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarySZJA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryTBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNetto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown salaryNormalNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown salarySZJA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown salaryTBA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown salaryNetto;
        private System.Windows.Forms.Button calculateItButton;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.DomainUpDown position;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button positionButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox twentyFive;
        private System.Windows.Forms.CheckBox checkBoxMarried;
        private System.Windows.Forms.Button restartButton;
    }
}

