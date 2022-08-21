
namespace Tasker
{
    partial class frmEdit
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtP = new System.Windows.Forms.DateTimePicker();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numPlannedHours = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dataSet11 = new Tasker.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlannedHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 38);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cipher";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCipher
            // 
            this.txtCipher.Location = new System.Drawing.Point(164, 12);
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(112, 20);
            this.txtCipher.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(58, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hyperlink";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(164, 64);
            this.txtLink.MaxLength = 1000;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(586, 20);
            this.txtLink.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(164, 195);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(586, 179);
            this.txtDescription.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(58, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(58, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cost";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(58, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Planned for";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtP
            // 
            this.dtP.CustomFormat = "DD.MM.YYYY";
            this.dtP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtP.Location = new System.Drawing.Point(164, 90);
            this.dtP.Name = "dtP";
            this.dtP.Size = new System.Drawing.Size(112, 20);
            this.dtP.TabIndex = 9;
            this.dtP.Value = new System.DateTime(2021, 2, 13, 0, 0, 0, 0);
            // 
            // numCost
            // 
            this.numCost.DecimalPlaces = 2;
            this.numCost.InterceptArrowKeys = false;
            this.numCost.Location = new System.Drawing.Point(164, 116);
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(112, 20);
            this.numCost.TabIndex = 10;
            this.numCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(58, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Priority";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Not Set",
            "Low",
            "Medium",
            "High",
            "Emergency"});
            this.cbPriority.Location = new System.Drawing.Point(164, 142);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(112, 21);
            this.cbPriority.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numPlannedHours
            // 
            this.numPlannedHours.InterceptArrowKeys = false;
            this.numPlannedHours.Location = new System.Drawing.Point(164, 169);
            this.numPlannedHours.Name = "numPlannedHours";
            this.numPlannedHours.Size = new System.Drawing.Size(112, 20);
            this.numPlannedHours.TabIndex = 16;
            this.numPlannedHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(58, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Planned hours";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.EnforceConstraints = false;
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.numPlannedHours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numCost);
            this.Controls.Add(this.dtP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "frmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editing task";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlannedHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtP;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numPlannedHours;
        private System.Windows.Forms.Label label8;
        private DataSet1 dataSet11;
    }
}