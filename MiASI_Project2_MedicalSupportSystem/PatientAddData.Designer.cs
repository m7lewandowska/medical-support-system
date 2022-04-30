
namespace MiASI_Project2_MedicalSupportSystem
{
    partial class PatientAddData
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
            this.loginName_LB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pregnancies_TB = new System.Windows.Forms.TextBox();
            this.glucose_TB = new System.Windows.Forms.TextBox();
            this.insulin_TB = new System.Windows.Forms.TextBox();
            this.bmi_TB = new System.Windows.Forms.TextBox();
            this.age_TB = new System.Windows.Forms.TextBox();
            this.skinThickness_TB = new System.Windows.Forms.TextBox();
            this.diabetesPedigree_TB = new System.Windows.Forms.TextBox();
            this.bloodPressure_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backAddData_BTN = new System.Windows.Forms.Button();
            this.addAddData_BTN = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginName_LB
            // 
            this.loginName_LB.AutoSize = true;
            this.loginName_LB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginName_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.loginName_LB.Location = new System.Drawing.Point(186, 11);
            this.loginName_LB.Name = "loginName_LB";
            this.loginName_LB.Size = new System.Drawing.Size(66, 15);
            this.loginName_LB.TabIndex = 11;
            this.loginName_LB.Text = "loginName";
            this.toolTip1.SetToolTip(this.loginName_LB, "Logout");
            this.loginName_LB.Click += new System.EventHandler(this.loginName_LB_Click);
            this.loginName_LB.MouseEnter += new System.EventHandler(this.loginName_LB_MouseEnter);
            this.loginName_LB.MouseLeave += new System.EventHandler(this.loginName_LB_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(125, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "SYSTEM |";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(68, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "SUPPORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "MEDICAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiASI_Project2_MedicalSupportSystem.Properties.Resources.addlogo;
            this.pictureBox1.Location = new System.Drawing.Point(366, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(207, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 51);
            this.label3.TabIndex = 13;
            this.label3.Text = "ADD MEDICAL DATA";
            // 
            // pregnancies_TB
            // 
            this.pregnancies_TB.Location = new System.Drawing.Point(209, 219);
            this.pregnancies_TB.Name = "pregnancies_TB";
            this.pregnancies_TB.Size = new System.Drawing.Size(155, 23);
            this.pregnancies_TB.TabIndex = 14;
            // 
            // glucose_TB
            // 
            this.glucose_TB.Location = new System.Drawing.Point(209, 268);
            this.glucose_TB.Name = "glucose_TB";
            this.glucose_TB.Size = new System.Drawing.Size(155, 23);
            this.glucose_TB.TabIndex = 15;
            // 
            // insulin_TB
            // 
            this.insulin_TB.Location = new System.Drawing.Point(497, 219);
            this.insulin_TB.Name = "insulin_TB";
            this.insulin_TB.Size = new System.Drawing.Size(155, 23);
            this.insulin_TB.TabIndex = 16;
            // 
            // bmi_TB
            // 
            this.bmi_TB.Location = new System.Drawing.Point(497, 268);
            this.bmi_TB.Name = "bmi_TB";
            this.bmi_TB.Size = new System.Drawing.Size(155, 23);
            this.bmi_TB.TabIndex = 17;
            // 
            // age_TB
            // 
            this.age_TB.Location = new System.Drawing.Point(497, 323);
            this.age_TB.Name = "age_TB";
            this.age_TB.Size = new System.Drawing.Size(155, 23);
            this.age_TB.TabIndex = 18;
            // 
            // skinThickness_TB
            // 
            this.skinThickness_TB.Location = new System.Drawing.Point(497, 375);
            this.skinThickness_TB.Name = "skinThickness_TB";
            this.skinThickness_TB.Size = new System.Drawing.Size(155, 23);
            this.skinThickness_TB.TabIndex = 19;
            // 
            // diabetesPedigree_TB
            // 
            this.diabetesPedigree_TB.Location = new System.Drawing.Point(209, 375);
            this.diabetesPedigree_TB.Name = "diabetesPedigree_TB";
            this.diabetesPedigree_TB.Size = new System.Drawing.Size(155, 23);
            this.diabetesPedigree_TB.TabIndex = 20;
            // 
            // bloodPressure_TB
            // 
            this.bloodPressure_TB.Location = new System.Drawing.Point(209, 323);
            this.bloodPressure_TB.Name = "bloodPressure_TB";
            this.bloodPressure_TB.Size = new System.Drawing.Size(155, 23);
            this.bloodPressure_TB.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(132, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pregnancies:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(151, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Glucose:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(118, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "BloodPressure:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(408, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "SkinThickness:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(446, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Insulin:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(460, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "BMI:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(49, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Diabetes Pedigree Function:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(460, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Age:";
            // 
            // backAddData_BTN
            // 
            this.backAddData_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.backAddData_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backAddData_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backAddData_BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.backAddData_BTN.Location = new System.Drawing.Point(292, 447);
            this.backAddData_BTN.Name = "backAddData_BTN";
            this.backAddData_BTN.Size = new System.Drawing.Size(104, 35);
            this.backAddData_BTN.TabIndex = 30;
            this.backAddData_BTN.Text = "BACK";
            this.backAddData_BTN.UseVisualStyleBackColor = false;
            this.backAddData_BTN.Click += new System.EventHandler(this.backAddData_BTN_Click);
            // 
            // addAddData_BTN
            // 
            this.addAddData_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(136)))));
            this.addAddData_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addAddData_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addAddData_BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.addAddData_BTN.Location = new System.Drawing.Point(408, 447);
            this.addAddData_BTN.Name = "addAddData_BTN";
            this.addAddData_BTN.Size = new System.Drawing.Size(104, 35);
            this.addAddData_BTN.TabIndex = 31;
            this.addAddData_BTN.Text = "ADD";
            this.addAddData_BTN.UseVisualStyleBackColor = false;
            this.addAddData_BTN.Click += new System.EventHandler(this.addAddData_BTN_Click);
            // 
            // PatientAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.addAddData_BTN);
            this.Controls.Add(this.backAddData_BTN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bloodPressure_TB);
            this.Controls.Add(this.diabetesPedigree_TB);
            this.Controls.Add(this.skinThickness_TB);
            this.Controls.Add(this.age_TB);
            this.Controls.Add(this.bmi_TB);
            this.Controls.Add(this.insulin_TB);
            this.Controls.Add(this.glucose_TB);
            this.Controls.Add(this.pregnancies_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginName_LB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "PatientAddData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD DATA | MEDICAL SUPPORT SYSTEM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginName_LB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pregnancies_TB;
        private System.Windows.Forms.TextBox glucose_TB;
        private System.Windows.Forms.TextBox insulin_TB;
        private System.Windows.Forms.TextBox bmi_TB;
        private System.Windows.Forms.TextBox age_TB;
        private System.Windows.Forms.TextBox skinThickness_TB;
        private System.Windows.Forms.TextBox diabetesPedigree_TB;
        private System.Windows.Forms.TextBox bloodPressure_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button backAddData_BTN;
        private System.Windows.Forms.Button addAddData_BTN;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}