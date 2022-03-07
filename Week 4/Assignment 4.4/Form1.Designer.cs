namespace Assignment_4._4
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.Coffeegrid = new System.Windows.Forms.DataGridView();
            this.btnAddcoff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Coffeebox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblHotorIce = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtHorIce = new System.Windows.Forms.TextBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Coffeegrid)).BeginInit();
            this.Coffeebox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Coffeegrid
            // 
            this.Coffeegrid.BackgroundColor = System.Drawing.Color.Black;
            this.Coffeegrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Coffeegrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Coffeegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Coffeegrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Coffeegrid.Location = new System.Drawing.Point(128, 12);
            this.Coffeegrid.Name = "Coffeegrid";
            this.Coffeegrid.RowHeadersWidth = 62;
            this.Coffeegrid.RowTemplate.Height = 28;
            this.Coffeegrid.Size = new System.Drawing.Size(676, 190);
            this.Coffeegrid.TabIndex = 1;
            // 
            // btnAddcoff
            // 
            this.btnAddcoff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddcoff.BackgroundImage")));
            this.btnAddcoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddcoff.Font = new System.Drawing.Font("Niagara Engraved", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddcoff.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddcoff.Location = new System.Drawing.Point(685, 275);
            this.btnAddcoff.Name = "btnAddcoff";
            this.btnAddcoff.Size = new System.Drawing.Size(137, 80);
            this.btnAddcoff.TabIndex = 2;
            this.btnAddcoff.Text = "Add Menu Item";
            this.btnAddcoff.UseVisualStyleBackColor = true;
            this.btnAddcoff.Click += new System.EventHandler(this.btnAddcoff_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Niagara Engraved", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(685, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Niagara Engraved", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBack.Location = new System.Drawing.Point(685, 463);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 71);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Main";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Coffeebox
            // 
            this.Coffeebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Coffeebox.BackgroundImage")));
            this.Coffeebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Coffeebox.Controls.Add(this.cmbCountry);
            this.Coffeebox.Controls.Add(this.txtCname);
            this.Coffeebox.Controls.Add(this.txtHorIce);
            this.Coffeebox.Controls.Add(this.txtCid);
            this.Coffeebox.Controls.Add(this.lblCountry);
            this.Coffeebox.Controls.Add(this.lblHotorIce);
            this.Coffeebox.Controls.Add(this.lblCName);
            this.Coffeebox.Controls.Add(this.lblCid);
            this.Coffeebox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Coffeebox.Location = new System.Drawing.Point(56, 293);
            this.Coffeebox.Name = "Coffeebox";
            this.Coffeebox.Size = new System.Drawing.Size(431, 241);
            this.Coffeebox.TabIndex = 5;
            this.Coffeebox.TabStop = false;
            this.Coffeebox.Text = "Coffee Details";
            this.Coffeebox.Visible = false;
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.BackColor = System.Drawing.Color.Transparent;
            this.lblCid.Location = new System.Drawing.Point(3, 22);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(107, 30);
            this.lblCid.TabIndex = 0;
            this.lblCid.Text = "CoffeeId";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.BackColor = System.Drawing.Color.Transparent;
            this.lblCName.Location = new System.Drawing.Point(3, 84);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(155, 30);
            this.lblCName.TabIndex = 4;
            this.lblCName.Text = "Coffee Name";
            // 
            // lblHotorIce
            // 
            this.lblHotorIce.AutoSize = true;
            this.lblHotorIce.BackColor = System.Drawing.Color.Transparent;
            this.lblHotorIce.Location = new System.Drawing.Point(7, 150);
            this.lblHotorIce.Name = "lblHotorIce";
            this.lblHotorIce.Size = new System.Drawing.Size(137, 30);
            this.lblHotorIce.TabIndex = 5;
            this.lblHotorIce.Text = "Hot Or Iced";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Location = new System.Drawing.Point(7, 218);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(173, 30);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country of Orig";
            // 
            // txtCid
            // 
            this.txtCid.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCid.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCid.Location = new System.Drawing.Point(283, 26);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 26);
            this.txtCid.TabIndex = 7;
            // 
            // txtHorIce
            // 
            this.txtHorIce.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtHorIce.ForeColor = System.Drawing.SystemColors.Window;
            this.txtHorIce.Location = new System.Drawing.Point(283, 147);
            this.txtHorIce.Name = "txtHorIce";
            this.txtHorIce.Size = new System.Drawing.Size(100, 26);
            this.txtHorIce.TabIndex = 8;
            // 
            // txtCname
            // 
            this.txtCname.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCname.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCname.Location = new System.Drawing.Point(283, 88);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 26);
            this.txtCname.TabIndex = 9;
            // 
            // cmbCountry
            // 
            this.cmbCountry.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmbCountry.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(283, 207);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 28);
            this.cmbCountry.TabIndex = 10;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 590);
            this.Controls.Add(this.Coffeebox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddcoff);
            this.Controls.Add(this.Coffeegrid);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Coffeegrid)).EndInit();
            this.Coffeebox.ResumeLayout(false);
            this.Coffeebox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Coffeegrid;
        private System.Windows.Forms.Button btnAddcoff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox Coffeebox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblHotorIce;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtHorIce;
        private System.Windows.Forms.TextBox txtCid;
    }
}

