namespace Assignment_5._3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSerialize = new System.Windows.Forms.Button();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.CmbFormats = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnDsrBinary = new System.Windows.Forms.Button();
            this.btnDsrXML = new System.Windows.Forms.Button();
            this.btnDsrJson = new System.Windows.Forms.Button();
            this.grpStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(595, 196);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(133, 37);
            this.btnSerialize.TabIndex = 0;
            this.btnSerialize.Text = "Serialize!";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // grpStudent
            // 
            this.grpStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpStudent.BackgroundImage")));
            this.grpStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpStudent.Controls.Add(this.lblName);
            this.grpStudent.Controls.Add(this.lblID);
            this.grpStudent.Controls.Add(this.txtAddress);
            this.grpStudent.Controls.Add(this.lblAddress);
            this.grpStudent.Controls.Add(this.txtName);
            this.grpStudent.Controls.Add(this.txtID);
            this.grpStudent.Location = new System.Drawing.Point(35, 180);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(298, 179);
            this.grpStudent.TabIndex = 1;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Details";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Student Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(87, 20);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Student ID";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(174, 147);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 26);
            this.txtAddress.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(174, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 4;
            // 
            // CmbFormats
            // 
            this.CmbFormats.FormattingEnabled = true;
            this.CmbFormats.Location = new System.Drawing.Point(402, 165);
            this.CmbFormats.Name = "CmbFormats";
            this.CmbFormats.Size = new System.Drawing.Size(121, 28);
            this.CmbFormats.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddress.Location = new System.Drawing.Point(6, 153);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 22);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // btnDsrBinary
            // 
            this.btnDsrBinary.Location = new System.Drawing.Point(595, 245);
            this.btnDsrBinary.Name = "btnDsrBinary";
            this.btnDsrBinary.Size = new System.Drawing.Size(148, 45);
            this.btnDsrBinary.TabIndex = 8;
            this.btnDsrBinary.Text = "Deserialize";
            this.btnDsrBinary.UseVisualStyleBackColor = true;
            this.btnDsrBinary.Visible = false;
            this.btnDsrBinary.Click += new System.EventHandler(this.btnDsrBinary_Click);
            // 
            // btnDsrXML
            // 
            this.btnDsrXML.Location = new System.Drawing.Point(595, 314);
            this.btnDsrXML.Name = "btnDsrXML";
            this.btnDsrXML.Size = new System.Drawing.Size(148, 45);
            this.btnDsrXML.TabIndex = 9;
            this.btnDsrXML.Text = "Deserialize";
            this.btnDsrXML.UseVisualStyleBackColor = true;
            this.btnDsrXML.Visible = false;
            this.btnDsrXML.Click += new System.EventHandler(this.btnDsrXML_Click);
            // 
            // btnDsrJson
            // 
            this.btnDsrJson.Location = new System.Drawing.Point(595, 365);
            this.btnDsrJson.Name = "btnDsrJson";
            this.btnDsrJson.Size = new System.Drawing.Size(148, 45);
            this.btnDsrJson.TabIndex = 10;
            this.btnDsrJson.Text = "Deserialize";
            this.btnDsrJson.UseVisualStyleBackColor = true;
            this.btnDsrJson.Visible = false;
            this.btnDsrJson.Click += new System.EventHandler(this.btnDsrJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDsrJson);
            this.Controls.Add(this.btnDsrXML);
            this.Controls.Add(this.btnDsrBinary);
            this.Controls.Add(this.CmbFormats);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.btnSerialize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.ComboBox CmbFormats;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnDsrBinary;
        private System.Windows.Forms.Button btnDsrXML;
        private System.Windows.Forms.Button btnDsrJson;
    }
}

