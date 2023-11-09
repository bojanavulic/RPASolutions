
namespace CarsWindowsApp
{
    partial class MainForm
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
            this.lblCarName = new System.Windows.Forms.Label();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.lblMileage = new System.Windows.Forms.Label();
            this.txtNumberOfDoors = new System.Windows.Forms.TextBox();
            this.lblNumberOfDoors = new System.Windows.Forms.Label();
            this.lblCountryOfOrigin = new System.Windows.Forms.Label();
            this.cmbCountryOfOrigin = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.Location = new System.Drawing.Point(22, 25);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(106, 24);
            this.lblCarName.TabIndex = 0;
            this.lblCarName.Text = "Car name:";
            this.lblCarName.Click += new System.EventHandler(this.lblCarName_Click);
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(207, 25);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(145, 22);
            this.txtCarName.TabIndex = 1;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(22, 88);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 24);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color: ";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(207, 154);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(145, 22);
            this.txtMileage.TabIndex = 5;
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileage.Location = new System.Drawing.Point(22, 154);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(84, 24);
            this.lblMileage.TabIndex = 4;
            this.lblMileage.Text = "Mileage";
            // 
            // txtNumberOfDoors
            // 
            this.txtNumberOfDoors.Location = new System.Drawing.Point(207, 227);
            this.txtNumberOfDoors.Name = "txtNumberOfDoors";
            this.txtNumberOfDoors.Size = new System.Drawing.Size(145, 22);
            this.txtNumberOfDoors.TabIndex = 7;
            // 
            // lblNumberOfDoors
            // 
            this.lblNumberOfDoors.AutoSize = true;
            this.lblNumberOfDoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDoors.Location = new System.Drawing.Point(22, 227);
            this.lblNumberOfDoors.Name = "lblNumberOfDoors";
            this.lblNumberOfDoors.Size = new System.Drawing.Size(173, 24);
            this.lblNumberOfDoors.TabIndex = 6;
            this.lblNumberOfDoors.Text = "Number of doors:";
            // 
            // lblCountryOfOrigin
            // 
            this.lblCountryOfOrigin.AutoSize = true;
            this.lblCountryOfOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryOfOrigin.Location = new System.Drawing.Point(22, 302);
            this.lblCountryOfOrigin.Name = "lblCountryOfOrigin";
            this.lblCountryOfOrigin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCountryOfOrigin.Size = new System.Drawing.Size(164, 24);
            this.lblCountryOfOrigin.TabIndex = 8;
            this.lblCountryOfOrigin.Text = "Country of origin";
            // 
            // cmbCountryOfOrigin
            // 
            this.cmbCountryOfOrigin.FormattingEnabled = true;
            this.cmbCountryOfOrigin.Location = new System.Drawing.Point(207, 304);
            this.cmbCountryOfOrigin.Name = "cmbCountryOfOrigin";
            this.cmbCountryOfOrigin.Size = new System.Drawing.Size(145, 24);
            this.cmbCountryOfOrigin.TabIndex = 9;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(207, 97);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(145, 24);
            this.cmbColor.TabIndex = 10;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(26, 366);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(326, 50);
            this.btnAddCar.TabIndex = 11;
            this.btnAddCar.Text = "Add car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(26, 439);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(326, 50);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "Finish adding cars";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 550);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(477, 238);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 808);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbCountryOfOrigin);
            this.Controls.Add(this.lblCountryOfOrigin);
            this.Controls.Add(this.txtNumberOfDoors);
            this.Controls.Add(this.lblNumberOfDoors);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.lblCarName);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.TextBox txtNumberOfDoors;
        private System.Windows.Forms.Label lblNumberOfDoors;
        private System.Windows.Forms.Label lblCountryOfOrigin;
        private System.Windows.Forms.ComboBox cmbCountryOfOrigin;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

