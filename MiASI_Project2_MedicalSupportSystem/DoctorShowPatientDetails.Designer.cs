
namespace MiASI_Project2_MedicalSupportSystem
{
    partial class DoctorShowPatientDetails
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.patientDetailsName_LB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backShowList_BTN = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bloodPressure_TB = new System.Windows.Forms.TextBox();
            this.diabetesPedigree_TB = new System.Windows.Forms.TextBox();
            this.skinThickness_TB = new System.Windows.Forms.TextBox();
            this.age_TB = new System.Windows.Forms.TextBox();
            this.bmi_TB = new System.Windows.Forms.TextBox();
            this.insulin_TB = new System.Windows.Forms.TextBox();
            this.glucose_TB = new System.Windows.Forms.TextBox();
            this.pregnancies_TB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.patientOutcome_LB = new System.Windows.Forms.Label();
            this.patientDetails_PNL = new System.Windows.Forms.Panel();
            this.noData_LB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.patientDetails_PNL.SuspendLayout();
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
            // patientDetailsName_LB
            // 
            this.patientDetailsName_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientDetailsName_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.patientDetailsName_LB.Location = new System.Drawing.Point(-2, 109);
            this.patientDetailsName_LB.Name = "patientDetailsName_LB";
            this.patientDetailsName_LB.Size = new System.Drawing.Size(788, 51);
            this.patientDetailsName_LB.TabIndex = 13;
            this.patientDetailsName_LB.Text = "PATIENT NAME";
            this.patientDetailsName_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiASI_Project2_MedicalSupportSystem.Properties.Resources.userlogo;
            this.pictureBox1.Location = new System.Drawing.Point(366, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(354, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Patient Details";
            // 
            // backShowList_BTN
            // 
            this.backShowList_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.backShowList_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backShowList_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backShowList_BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.backShowList_BTN.Location = new System.Drawing.Point(332, 479);
            this.backShowList_BTN.Name = "backShowList_BTN";
            this.backShowList_BTN.Size = new System.Drawing.Size(104, 35);
            this.backShowList_BTN.TabIndex = 64;
            this.backShowList_BTN.Text = "BACK";
            this.backShowList_BTN.UseVisualStyleBackColor = false;
            this.backShowList_BTN.Click += new System.EventHandler(this.backShowList_BTN_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(424, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 63;
            this.label12.Text = "Age:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(13, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 15);
            this.label11.TabIndex = 62;
            this.label11.Text = "Diabetes Pedigree Function:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(424, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 61;
            this.label10.Text = "BMI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(410, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 60;
            this.label9.Text = "Insulin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(372, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 59;
            this.label8.Text = "SkinThickness:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(82, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "BloodPressure:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(115, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 57;
            this.label5.Text = "Glucose:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(96, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "Pregnancies:";
            // 
            // bloodPressure_TB
            // 
            this.bloodPressure_TB.Enabled = false;
            this.bloodPressure_TB.Location = new System.Drawing.Point(173, 141);
            this.bloodPressure_TB.Name = "bloodPressure_TB";
            this.bloodPressure_TB.Size = new System.Drawing.Size(155, 23);
            this.bloodPressure_TB.TabIndex = 55;
            // 
            // diabetesPedigree_TB
            // 
            this.diabetesPedigree_TB.Enabled = false;
            this.diabetesPedigree_TB.Location = new System.Drawing.Point(173, 193);
            this.diabetesPedigree_TB.Name = "diabetesPedigree_TB";
            this.diabetesPedigree_TB.Size = new System.Drawing.Size(155, 23);
            this.diabetesPedigree_TB.TabIndex = 54;
            // 
            // skinThickness_TB
            // 
            this.skinThickness_TB.Enabled = false;
            this.skinThickness_TB.Location = new System.Drawing.Point(461, 193);
            this.skinThickness_TB.Name = "skinThickness_TB";
            this.skinThickness_TB.Size = new System.Drawing.Size(155, 23);
            this.skinThickness_TB.TabIndex = 53;
            // 
            // age_TB
            // 
            this.age_TB.Enabled = false;
            this.age_TB.Location = new System.Drawing.Point(461, 141);
            this.age_TB.Name = "age_TB";
            this.age_TB.Size = new System.Drawing.Size(155, 23);
            this.age_TB.TabIndex = 52;
            // 
            // bmi_TB
            // 
            this.bmi_TB.Enabled = false;
            this.bmi_TB.Location = new System.Drawing.Point(461, 86);
            this.bmi_TB.Name = "bmi_TB";
            this.bmi_TB.Size = new System.Drawing.Size(155, 23);
            this.bmi_TB.TabIndex = 51;
            // 
            // insulin_TB
            // 
            this.insulin_TB.Enabled = false;
            this.insulin_TB.Location = new System.Drawing.Point(461, 37);
            this.insulin_TB.Name = "insulin_TB";
            this.insulin_TB.Size = new System.Drawing.Size(155, 23);
            this.insulin_TB.TabIndex = 50;
            // 
            // glucose_TB
            // 
            this.glucose_TB.Enabled = false;
            this.glucose_TB.Location = new System.Drawing.Point(173, 86);
            this.glucose_TB.Name = "glucose_TB";
            this.glucose_TB.Size = new System.Drawing.Size(155, 23);
            this.glucose_TB.TabIndex = 49;
            // 
            // pregnancies_TB
            // 
            this.pregnancies_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pregnancies_TB.Enabled = false;
            this.pregnancies_TB.Location = new System.Drawing.Point(173, 37);
            this.pregnancies_TB.Name = "pregnancies_TB";
            this.pregnancies_TB.Size = new System.Drawing.Size(155, 23);
            this.pregnancies_TB.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(307, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 66;
            this.label13.Text = "Outcome:";
            // 
            // patientOutcome_LB
            // 
            this.patientOutcome_LB.AutoSize = true;
            this.patientOutcome_LB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientOutcome_LB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            this.patientOutcome_LB.Location = new System.Drawing.Point(366, 200);
            this.patientOutcome_LB.Name = "patientOutcome_LB";
            this.patientOutcome_LB.Size = new System.Drawing.Size(72, 19);
            this.patientOutcome_LB.TabIndex = 67;
            this.patientOutcome_LB.Text = "DIABETES";
            // 
            // patientDetails_PNL
            // 
            this.patientDetails_PNL.Controls.Add(this.insulin_TB);
            this.patientDetails_PNL.Controls.Add(this.pregnancies_TB);
            this.patientDetails_PNL.Controls.Add(this.glucose_TB);
            this.patientDetails_PNL.Controls.Add(this.label12);
            this.patientDetails_PNL.Controls.Add(this.bmi_TB);
            this.patientDetails_PNL.Controls.Add(this.label11);
            this.patientDetails_PNL.Controls.Add(this.age_TB);
            this.patientDetails_PNL.Controls.Add(this.label10);
            this.patientDetails_PNL.Controls.Add(this.skinThickness_TB);
            this.patientDetails_PNL.Controls.Add(this.label9);
            this.patientDetails_PNL.Controls.Add(this.diabetesPedigree_TB);
            this.patientDetails_PNL.Controls.Add(this.label8);
            this.patientDetails_PNL.Controls.Add(this.bloodPressure_TB);
            this.patientDetails_PNL.Controls.Add(this.label3);
            this.patientDetails_PNL.Controls.Add(this.label4);
            this.patientDetails_PNL.Controls.Add(this.label5);
            this.patientDetails_PNL.Location = new System.Drawing.Point(43, 220);
            this.patientDetails_PNL.Name = "patientDetails_PNL";
            this.patientDetails_PNL.Size = new System.Drawing.Size(661, 253);
            this.patientDetails_PNL.TabIndex = 68;
            // 
            // noData_LB
            // 
            this.noData_LB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noData_LB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.noData_LB.Location = new System.Drawing.Point(-2, 298);
            this.noData_LB.Name = "noData_LB";
            this.noData_LB.Size = new System.Drawing.Size(788, 37);
            this.noData_LB.TabIndex = 69;
            this.noData_LB.Text = "NO MEDICAL DATA";
            this.noData_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoctorShowPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.noData_LB);
            this.Controls.Add(this.patientOutcome_LB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.backShowList_BTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.patientDetailsName_LB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginName_LB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientDetails_PNL);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "DoctorShowPatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PATIENT DETAILS | MEDICAL SUPPORT SYSTEM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.patientDetails_PNL.ResumeLayout(false);
            this.patientDetails_PNL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginName_LB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label patientDetailsName_LB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backShowList_BTN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bloodPressure_TB;
        private System.Windows.Forms.TextBox diabetesPedigree_TB;
        private System.Windows.Forms.TextBox skinThickness_TB;
        private System.Windows.Forms.TextBox age_TB;
        private System.Windows.Forms.TextBox bmi_TB;
        private System.Windows.Forms.TextBox insulin_TB;
        private System.Windows.Forms.TextBox glucose_TB;
        private System.Windows.Forms.TextBox pregnancies_TB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label patientOutcome_LB;
        private System.Windows.Forms.Panel patientDetails_PNL;
        private System.Windows.Forms.Label noData_LB;
    }
}