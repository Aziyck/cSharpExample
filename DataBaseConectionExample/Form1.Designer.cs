namespace DataBaseConectionExample
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
            this.user_name_add_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_surname_add_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_GB = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.users_LW = new System.Windows.Forms.ListView();
            this.user_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.add_BTN = new System.Windows.Forms.Button();
            this.update_GB = new System.Windows.Forms.GroupBox();
            this.update_BTN = new System.Windows.Forms.Button();
            this.user_name_update_TB = new System.Windows.Forms.TextBox();
            this.user_surname_update_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_BTN = new System.Windows.Forms.Button();
            this.add_GB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.update_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_name_add_TB
            // 
            this.user_name_add_TB.Location = new System.Drawing.Point(94, 32);
            this.user_name_add_TB.Name = "user_name_add_TB";
            this.user_name_add_TB.Size = new System.Drawing.Size(151, 20);
            this.user_name_add_TB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // user_surname_add_TB
            // 
            this.user_surname_add_TB.Location = new System.Drawing.Point(94, 58);
            this.user_surname_add_TB.Name = "user_surname_add_TB";
            this.user_surname_add_TB.Size = new System.Drawing.Size(151, 20);
            this.user_surname_add_TB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // add_GB
            // 
            this.add_GB.Controls.Add(this.add_BTN);
            this.add_GB.Controls.Add(this.user_name_add_TB);
            this.add_GB.Controls.Add(this.user_surname_add_TB);
            this.add_GB.Controls.Add(this.label2);
            this.add_GB.Controls.Add(this.label3);
            this.add_GB.Location = new System.Drawing.Point(12, 12);
            this.add_GB.Name = "add_GB";
            this.add_GB.Size = new System.Drawing.Size(271, 122);
            this.add_GB.TabIndex = 6;
            this.add_GB.TabStop = false;
            this.add_GB.Text = "Insert";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delete_BTN);
            this.groupBox2.Controls.Add(this.users_LW);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 231);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tables";
            // 
            // users_LW
            // 
            this.users_LW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.user_id,
            this.user_name,
            this.user_surname});
            this.users_LW.FullRowSelect = true;
            this.users_LW.HideSelection = false;
            this.users_LW.Location = new System.Drawing.Point(6, 19);
            this.users_LW.MultiSelect = false;
            this.users_LW.Name = "users_LW";
            this.users_LW.Size = new System.Drawing.Size(259, 177);
            this.users_LW.TabIndex = 0;
            this.users_LW.UseCompatibleStateImageBehavior = false;
            this.users_LW.View = System.Windows.Forms.View.Details;
            this.users_LW.SelectedIndexChanged += new System.EventHandler(this.users_LW_SelectedIndexChanged);
            // 
            // user_id
            // 
            this.user_id.Text = "ID";
            this.user_id.Width = 29;
            // 
            // user_name
            // 
            this.user_name.Text = "Name";
            this.user_name.Width = 111;
            // 
            // user_surname
            // 
            this.user_surname.Text = "Surname";
            this.user_surname.Width = 115;
            // 
            // add_BTN
            // 
            this.add_BTN.Location = new System.Drawing.Point(94, 84);
            this.add_BTN.Name = "add_BTN";
            this.add_BTN.Size = new System.Drawing.Size(151, 23);
            this.add_BTN.TabIndex = 8;
            this.add_BTN.Text = "Add";
            this.add_BTN.UseVisualStyleBackColor = true;
            this.add_BTN.Click += new System.EventHandler(this.add_BTN_Click);
            // 
            // update_GB
            // 
            this.update_GB.Controls.Add(this.update_BTN);
            this.update_GB.Controls.Add(this.user_name_update_TB);
            this.update_GB.Controls.Add(this.user_surname_update_TB);
            this.update_GB.Controls.Add(this.label1);
            this.update_GB.Controls.Add(this.label4);
            this.update_GB.Location = new System.Drawing.Point(300, 12);
            this.update_GB.Name = "update_GB";
            this.update_GB.Size = new System.Drawing.Size(271, 122);
            this.update_GB.TabIndex = 9;
            this.update_GB.TabStop = false;
            this.update_GB.Text = "Update";
            // 
            // update_BTN
            // 
            this.update_BTN.Enabled = false;
            this.update_BTN.Location = new System.Drawing.Point(94, 84);
            this.update_BTN.Name = "update_BTN";
            this.update_BTN.Size = new System.Drawing.Size(151, 23);
            this.update_BTN.TabIndex = 8;
            this.update_BTN.Text = "Update";
            this.update_BTN.UseVisualStyleBackColor = true;
            this.update_BTN.Click += new System.EventHandler(this.update_BTN_Click);
            // 
            // user_name_update_TB
            // 
            this.user_name_update_TB.Enabled = false;
            this.user_name_update_TB.Location = new System.Drawing.Point(94, 32);
            this.user_name_update_TB.Name = "user_name_update_TB";
            this.user_name_update_TB.Size = new System.Drawing.Size(151, 20);
            this.user_name_update_TB.TabIndex = 3;
            // 
            // user_surname_update_TB
            // 
            this.user_surname_update_TB.Enabled = false;
            this.user_surname_update_TB.Location = new System.Drawing.Point(94, 58);
            this.user_surname_update_TB.Name = "user_surname_update_TB";
            this.user_surname_update_TB.Size = new System.Drawing.Size(151, 20);
            this.user_surname_update_TB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surname";
            // 
            // delete_BTN
            // 
            this.delete_BTN.Enabled = false;
            this.delete_BTN.Location = new System.Drawing.Point(114, 202);
            this.delete_BTN.Name = "delete_BTN";
            this.delete_BTN.Size = new System.Drawing.Size(151, 23);
            this.delete_BTN.TabIndex = 9;
            this.delete_BTN.Text = "Delete";
            this.delete_BTN.UseVisualStyleBackColor = true;
            this.delete_BTN.Click += new System.EventHandler(this.delete_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update_GB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.add_GB);
            this.Name = "Form1";
            this.Text = "App";
            this.add_GB.ResumeLayout(false);
            this.add_GB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.update_GB.ResumeLayout(false);
            this.update_GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox user_name_add_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_surname_add_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox add_GB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView users_LW;
        private System.Windows.Forms.ColumnHeader user_id;
        private System.Windows.Forms.ColumnHeader user_name;
        private System.Windows.Forms.ColumnHeader user_surname;
        private System.Windows.Forms.Button add_BTN;
        private System.Windows.Forms.Button delete_BTN;
        private System.Windows.Forms.GroupBox update_GB;
        private System.Windows.Forms.Button update_BTN;
        private System.Windows.Forms.TextBox user_name_update_TB;
        private System.Windows.Forms.TextBox user_surname_update_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

