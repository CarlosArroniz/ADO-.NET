namespace ADO.Net
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
            this.TB_name = new System.Windows.Forms.TextBox();
            this.TB_Lastname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TB_Role = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dg = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(12, 28);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(100, 20);
            this.TB_name.TabIndex = 0;
            this.TB_name.TextChanged += new System.EventHandler(this.TB_name_TextChanged);
            // 
            // TB_Lastname
            // 
            this.TB_Lastname.Location = new System.Drawing.Point(118, 28);
            this.TB_Lastname.Name = "TB_Lastname";
            this.TB_Lastname.Size = new System.Drawing.Size(100, 20);
            this.TB_Lastname.TabIndex = 1;
            this.TB_Lastname.TextChanged += new System.EventHandler(this.TB_Lastname_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TB_Role
            // 
            this.TB_Role.Location = new System.Drawing.Point(224, 28);
            this.TB_Role.Name = "TB_Role";
            this.TB_Role.Size = new System.Drawing.Size(100, 20);
            this.TB_Role.TabIndex = 4;
            this.TB_Role.TextChanged += new System.EventHandler(this.TB_Role_TextChanged);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(13, 9);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(35, 13);
            this.nombre.TabIndex = 5;
            this.nombre.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lastname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Role";
            // 
            // Dg
            // 
            this.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg.Location = new System.Drawing.Point(12, 124);
            this.Dg.Name = "Dg";
            this.Dg.Size = new System.Drawing.Size(544, 150);
            this.Dg.TabIndex = 8;
            this.Dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(400, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Previous";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(238, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "First";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(319, 280);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Last";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(118, 57);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(224, 57);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(100, 23);
            this.BT_Delete.TabIndex = 16;
            this.BT_Delete.Text = "Delete";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 310);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.TB_Role);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_Lastname);
            this.Controls.Add(this.TB_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.TextBox TB_Lastname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB_Role;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button BT_Delete;
    }
}

