namespace UI
{
    partial class RadForm1
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.firstname_add = new Telerik.WinControls.UI.RadTextBox();
            this.lastname_add = new Telerik.WinControls.UI.RadTextBox();
            this.ID_update = new Telerik.WinControls.UI.RadTextBox();
            this.lastname_update = new Telerik.WinControls.UI.RadTextBox();
            this.firstname_update = new Telerik.WinControls.UI.RadTextBox();
            this.GridView = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.add_button = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.update_button = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.del_button = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            this.sel_button = new Telerik.WinControls.UI.RadButton();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.ID_sel = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.firstname_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastname_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastname_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstname_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.del_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            this.radGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sel_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_sel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname_add
            // 
            this.firstname_add.Location = new System.Drawing.Point(114, 76);
            this.firstname_add.Name = "firstname_add";
            this.firstname_add.Size = new System.Drawing.Size(100, 20);
            this.firstname_add.TabIndex = 0;
            // 
            // lastname_add
            // 
            this.lastname_add.Location = new System.Drawing.Point(114, 31);
            this.lastname_add.Name = "lastname_add";
            this.lastname_add.Size = new System.Drawing.Size(100, 20);
            this.lastname_add.TabIndex = 1;
            // 
            // ID_update
            // 
            this.ID_update.Location = new System.Drawing.Point(147, 21);
            this.ID_update.Name = "ID_update";
            this.ID_update.Size = new System.Drawing.Size(100, 20);
            this.ID_update.TabIndex = 2;
            // 
            // lastname_update
            // 
            this.lastname_update.Location = new System.Drawing.Point(147, 47);
            this.lastname_update.Name = "lastname_update";
            this.lastname_update.Size = new System.Drawing.Size(100, 20);
            this.lastname_update.TabIndex = 1;
            // 
            // firstname_update
            // 
            this.firstname_update.Location = new System.Drawing.Point(147, 73);
            this.firstname_update.Name = "firstname_update";
            this.firstname_update.Size = new System.Drawing.Size(100, 20);
            this.firstname_update.TabIndex = 1;
            // 
            // GridView
            // 
            this.GridView.AutoSizeRows = true;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.Location = new System.Drawing.Point(0, 348);
            // 
            // 
            // 
            this.GridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(933, 218);
            this.GridView.TabIndex = 3;
            this.GridView.Text = "radGridView1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.add_button);
            this.radGroupBox1.Controls.Add(this.lastname_add);
            this.radGroupBox1.Controls.Add(this.firstname_add);
            this.radGroupBox1.HeaderText = "增";
            this.radGroupBox1.Location = new System.Drawing.Point(21, 31);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(311, 155);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "增";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(30, 76);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(57, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "FirstName";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(30, 31);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(56, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "LastName";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(79, 118);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(85, 24);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "增";
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.update_button);
            this.radGroupBox2.Controls.Add(this.radLabel5);
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.ID_update);
            this.radGroupBox2.Controls.Add(this.lastname_update);
            this.radGroupBox2.Controls.Add(this.firstname_update);
            this.radGroupBox2.HeaderText = "改";
            this.radGroupBox2.Location = new System.Drawing.Point(502, 41);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(347, 145);
            this.radGroupBox2.TabIndex = 5;
            this.radGroupBox2.Text = "改";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(123, 108);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(82, 24);
            this.update_button.TabIndex = 5;
            this.update_button.Text = "改";
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(19, 75);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(57, 18);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "FirstName";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(19, 49);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(56, 18);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "LastName";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(19, 23);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(17, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "ID";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.del_button);
            this.radGroupBox3.HeaderText = "删";
            this.radGroupBox3.Location = new System.Drawing.Point(21, 209);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(311, 125);
            this.radGroupBox3.TabIndex = 6;
            this.radGroupBox3.Text = "删";
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(79, 57);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(85, 24);
            this.del_button.TabIndex = 3;
            this.del_button.Text = "删";
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox4.Controls.Add(this.sel_button);
            this.radGroupBox4.Controls.Add(this.radLabel6);
            this.radGroupBox4.Controls.Add(this.ID_sel);
            this.radGroupBox4.HeaderText = "查";
            this.radGroupBox4.Location = new System.Drawing.Point(502, 209);
            this.radGroupBox4.Name = "radGroupBox4";
            this.radGroupBox4.Size = new System.Drawing.Size(347, 125);
            this.radGroupBox4.TabIndex = 5;
            this.radGroupBox4.Text = "查";
            // 
            // sel_button
            // 
            this.sel_button.Location = new System.Drawing.Point(123, 57);
            this.sel_button.Name = "sel_button";
            this.sel_button.Size = new System.Drawing.Size(85, 24);
            this.sel_button.TabIndex = 3;
            this.sel_button.Text = "查";
            this.sel_button.Click += new System.EventHandler(this.sel_button_Click);
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(28, 23);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(17, 18);
            this.radLabel6.TabIndex = 4;
            this.radLabel6.Text = "ID";
            // 
            // ID_sel
            // 
            this.ID_sel.Location = new System.Drawing.Point(147, 21);
            this.ID_sel.Name = "ID_sel";
            this.ID_sel.Size = new System.Drawing.Size(100, 20);
            this.ID_sel.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 566);
            this.Controls.Add(this.radGroupBox4);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.GridView);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firstname_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastname_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastname_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstname_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.del_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            this.radGroupBox4.ResumeLayout(false);
            this.radGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sel_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_sel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox firstname_add;
        private Telerik.WinControls.UI.RadTextBox lastname_add;
        private Telerik.WinControls.UI.RadTextBox ID_update;
        private Telerik.WinControls.UI.RadTextBox lastname_update;
        private Telerik.WinControls.UI.RadTextBox firstname_update;
        private Telerik.WinControls.UI.RadGridView GridView;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton add_button;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadButton update_button;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton del_button;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private Telerik.WinControls.UI.RadButton sel_button;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox ID_sel;
    }
}