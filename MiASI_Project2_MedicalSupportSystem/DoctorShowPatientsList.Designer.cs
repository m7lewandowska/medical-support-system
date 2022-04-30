
namespace MiASI_Project2_MedicalSupportSystem
{
    partial class DoctorShowPatientsList
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.patientsList_FP = new System.Windows.Forms.FlowLayoutPanel();
            this.backHomeDoctor_BTN = new System.Windows.Forms.Button();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(258, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 51);
            this.label3.TabIndex = 13;
            this.label3.Text = "PATIENTS LIST";
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
            // patientsList_FP
            // 
            this.patientsList_FP.Location = new System.Drawing.Point(68, 176);
            this.patientsList_FP.Name = "patientsList_FP";
            this.patientsList_FP.Size = new System.Drawing.Size(656, 299);
            this.patientsList_FP.TabIndex = 14;
            // 
            // backHomeDoctor_BTN
            // 
            this.backHomeDoctor_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.backHomeDoctor_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backHomeDoctor_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backHomeDoctor_BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.backHomeDoctor_BTN.Location = new System.Drawing.Point(357, 493);
            this.backHomeDoctor_BTN.Name = "backHomeDoctor_BTN";
            this.backHomeDoctor_BTN.Size = new System.Drawing.Size(104, 35);
            this.backHomeDoctor_BTN.TabIndex = 48;
            this.backHomeDoctor_BTN.Text = "BACK";
            this.backHomeDoctor_BTN.UseVisualStyleBackColor = false;
            this.backHomeDoctor_BTN.Click += new System.EventHandler(this.backHomeDoctor_BTN_Click);
            // 
            // DoctorShowPatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.backHomeDoctor_BTN);
            this.Controls.Add(this.patientsList_FP);
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
            this.Name = "DoctorShowPatientsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PATIENTS LIST | MEDICAL SUPPORT SYSTEM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginName_LB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel patientsList_FP;
        private System.Windows.Forms.Button backHomeDoctor_BTN;
    }
}