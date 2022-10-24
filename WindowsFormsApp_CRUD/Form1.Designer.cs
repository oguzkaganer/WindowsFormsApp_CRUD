namespace WindowsFormsApp_CRUD
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_add = new System.Windows.Forms.TabPage();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbp_update = new System.Windows.Forms.TabPage();
            this.btn_up_save = new System.Windows.Forms.Button();
            this.txt_up_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_up_username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_up_lastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_up_firstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_get = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.tbp_delete = new System.Windows.Forms.TabPage();
            this.tbp_toList = new System.Windows.Forms.TabPage();
            this.cbx_list = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbp_add.SuspendLayout();
            this.tbp_update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.tbp_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_add);
            this.tabControl1.Controls.Add(this.tbp_update);
            this.tabControl1.Controls.Add(this.tbp_delete);
            this.tabControl1.Controls.Add(this.tbp_toList);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // tbp_add
            // 
            this.tbp_add.Controls.Add(this.btn_save);
            this.tbp_add.Controls.Add(this.txt_password);
            this.tbp_add.Controls.Add(this.label4);
            this.tbp_add.Controls.Add(this.txt_username);
            this.tbp_add.Controls.Add(this.label3);
            this.tbp_add.Controls.Add(this.txt_lastName);
            this.tbp_add.Controls.Add(this.label2);
            this.tbp_add.Controls.Add(this.txt_firstName);
            this.tbp_add.Controls.Add(this.label1);
            this.tbp_add.Location = new System.Drawing.Point(4, 22);
            this.tbp_add.Name = "tbp_add";
            this.tbp_add.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_add.Size = new System.Drawing.Size(778, 279);
            this.tbp_add.TabIndex = 0;
            this.tbp_add.Text = "Add";
            this.tbp_add.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(307, 215);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(171, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(378, 167);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password :";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(378, 122);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username :";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(378, 78);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(100, 20);
            this.txt_lastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name :";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(378, 34);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(100, 20);
            this.txt_firstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // tbp_update
            // 
            this.tbp_update.Controls.Add(this.btn_up_save);
            this.tbp_update.Controls.Add(this.txt_up_password);
            this.tbp_update.Controls.Add(this.label6);
            this.tbp_update.Controls.Add(this.txt_up_username);
            this.tbp_update.Controls.Add(this.label7);
            this.tbp_update.Controls.Add(this.txt_up_lastName);
            this.tbp_update.Controls.Add(this.label8);
            this.tbp_update.Controls.Add(this.txt_up_firstName);
            this.tbp_update.Controls.Add(this.label9);
            this.tbp_update.Controls.Add(this.btn_get);
            this.tbp_update.Controls.Add(this.label5);
            this.tbp_update.Controls.Add(this.txt_id);
            this.tbp_update.Controls.Add(this.dgv_list);
            this.tbp_update.Location = new System.Drawing.Point(4, 22);
            this.tbp_update.Name = "tbp_update";
            this.tbp_update.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_update.Size = new System.Drawing.Size(778, 279);
            this.tbp_update.TabIndex = 1;
            this.tbp_update.Text = "Update";
            this.tbp_update.UseVisualStyleBackColor = true;
            // 
            // btn_up_save
            // 
            this.btn_up_save.Location = new System.Drawing.Point(592, 207);
            this.btn_up_save.Name = "btn_up_save";
            this.btn_up_save.Size = new System.Drawing.Size(171, 23);
            this.btn_up_save.TabIndex = 17;
            this.btn_up_save.Text = "SAVE";
            this.btn_up_save.UseVisualStyleBackColor = true;
            this.btn_up_save.Click += new System.EventHandler(this.btn_up_save_Click);
            // 
            // txt_up_password
            // 
            this.txt_up_password.Location = new System.Drawing.Point(663, 159);
            this.txt_up_password.Name = "txt_up_password";
            this.txt_up_password.Size = new System.Drawing.Size(100, 20);
            this.txt_up_password.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Password :";
            // 
            // txt_up_username
            // 
            this.txt_up_username.Location = new System.Drawing.Point(663, 114);
            this.txt_up_username.Name = "txt_up_username";
            this.txt_up_username.Size = new System.Drawing.Size(100, 20);
            this.txt_up_username.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Username :";
            // 
            // txt_up_lastName
            // 
            this.txt_up_lastName.Location = new System.Drawing.Point(663, 70);
            this.txt_up_lastName.Name = "txt_up_lastName";
            this.txt_up_lastName.Size = new System.Drawing.Size(100, 20);
            this.txt_up_lastName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Last Name :";
            // 
            // txt_up_firstName
            // 
            this.txt_up_firstName.Location = new System.Drawing.Point(663, 26);
            this.txt_up_firstName.Name = "txt_up_firstName";
            this.txt_up_firstName.Size = new System.Drawing.Size(100, 20);
            this.txt_up_firstName.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "First Name :";
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(284, 238);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(123, 23);
            this.btn_get.TabIndex = 3;
            this.btn_get.Text = "OK";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID :";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(165, 240);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 1;
            // 
            // dgv_list
            // 
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(20, 16);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.Size = new System.Drawing.Size(540, 214);
            this.dgv_list.TabIndex = 0;
            // 
            // tbp_delete
            // 
            this.tbp_delete.Controls.Add(this.btn_delete);
            this.tbp_delete.Controls.Add(this.cbx_list);
            this.tbp_delete.Location = new System.Drawing.Point(4, 22);
            this.tbp_delete.Name = "tbp_delete";
            this.tbp_delete.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_delete.Size = new System.Drawing.Size(778, 279);
            this.tbp_delete.TabIndex = 2;
            this.tbp_delete.Text = "Delete";
            this.tbp_delete.UseVisualStyleBackColor = true;
            // 
            // tbp_toList
            // 
            this.tbp_toList.Location = new System.Drawing.Point(4, 22);
            this.tbp_toList.Name = "tbp_toList";
            this.tbp_toList.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_toList.Size = new System.Drawing.Size(778, 279);
            this.tbp_toList.TabIndex = 3;
            this.tbp_toList.Text = "To List";
            this.tbp_toList.UseVisualStyleBackColor = true;
            // 
            // cbx_list
            // 
            this.cbx_list.FormattingEnabled = true;
            this.cbx_list.Location = new System.Drawing.Point(32, 35);
            this.cbx_list.Name = "cbx_list";
            this.cbx_list.Size = new System.Drawing.Size(300, 21);
            this.cbx_list.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(32, 73);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(300, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 329);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbp_add.ResumeLayout(false);
            this.tbp_add.PerformLayout();
            this.tbp_update.ResumeLayout(false);
            this.tbp_update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.tbp_delete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbp_update;
        private System.Windows.Forms.TabPage tbp_delete;
        private System.Windows.Forms.TabPage tbp_toList;
        private System.Windows.Forms.Button btn_up_save;
        private System.Windows.Forms.TextBox txt_up_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_up_username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_up_lastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_up_firstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cbx_list;
    }
}

