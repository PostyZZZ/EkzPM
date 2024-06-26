﻿namespace EkzPM
{
    partial class Student
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
            this.dataGridViewAppl = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvl_education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name_parent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educational_institution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.use_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAppl
            // 
            this.dataGridViewAppl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.lvl_education,
            this.full_name,
            this.passport_details,
            this.snils,
            this.email,
            this.phone_number,
            this.full_name_parent,
            this.educational_institution,
            this.use_points,
            this.speciality,
            this.status});
            this.dataGridViewAppl.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAppl.Name = "dataGridViewAppl";
            this.dataGridViewAppl.Size = new System.Drawing.Size(1355, 150);
            this.dataGridViewAppl.TabIndex = 0;
            this.dataGridViewAppl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 35;
            // 
            // lvl_education
            // 
            this.lvl_education.HeaderText = "Уровень образования";
            this.lvl_education.Name = "lvl_education";
            // 
            // full_name
            // 
            this.full_name.HeaderText = "ФИО";
            this.full_name.Name = "full_name";
            this.full_name.Width = 140;
            // 
            // passport_details
            // 
            this.passport_details.HeaderText = "Паспортные данные";
            this.passport_details.Name = "passport_details";
            this.passport_details.Width = 120;
            // 
            // snils
            // 
            this.snils.HeaderText = "СНИЛС";
            this.snils.Name = "snils";
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.Width = 120;
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "Номер телефона";
            this.phone_number.Name = "phone_number";
            this.phone_number.Width = 115;
            // 
            // full_name_parent
            // 
            this.full_name_parent.HeaderText = "ФИО родителя";
            this.full_name_parent.Name = "full_name_parent";
            this.full_name_parent.Width = 140;
            // 
            // educational_institution
            // 
            this.educational_institution.HeaderText = "Учебное заведение, которое окончил";
            this.educational_institution.Name = "educational_institution";
            this.educational_institution.Width = 110;
            // 
            // use_points
            // 
            this.use_points.HeaderText = "Баллы ЕГЭ, средний балл аттестата/диплома";
            this.use_points.Name = "use_points";
            this.use_points.Width = 60;
            // 
            // speciality
            // 
            this.speciality.HeaderText = "Специальность";
            this.speciality.Name = "speciality";
            this.speciality.Width = 160;
            // 
            // status
            // 
            this.status.HeaderText = "Статус заявки";
            this.status.Name = "status";
            this.status.Width = 110;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 450);
            this.Controls.Add(this.dataGridViewAppl);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAppl;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvl_education;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn snils;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name_parent;
        private System.Windows.Forms.DataGridViewTextBoxColumn educational_institution;
        private System.Windows.Forms.DataGridViewTextBoxColumn use_points;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}