namespace MultiThreading
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
			this.Venteværelse_Listbox = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_Status = new System.Windows.Forms.TextBox();
			this.textBox_Patient = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Start_Knap = new System.Windows.Forms.Button();
			this.Status_Listbox = new System.Windows.Forms.ListBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.TextBoxStatus2 = new System.Windows.Forms.TextBox();
			this.textBox_Patient2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// Venteværelse_Listbox
			// 
			this.Venteværelse_Listbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Venteværelse_Listbox.FormattingEnabled = true;
			this.Venteværelse_Listbox.Location = new System.Drawing.Point(18, 412);
			this.Venteværelse_Listbox.Name = "Venteværelse_Listbox";
			this.Venteværelse_Listbox.Size = new System.Drawing.Size(291, 234);
			this.Venteværelse_Listbox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(97, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Status";
			// 
			// textBox_Status
			// 
			this.textBox_Status.Location = new System.Drawing.Point(146, 85);
			this.textBox_Status.Name = "textBox_Status";
			this.textBox_Status.ReadOnly = true;
			this.textBox_Status.Size = new System.Drawing.Size(148, 20);
			this.textBox_Status.TabIndex = 4;
			// 
			// textBox_Patient
			// 
			this.textBox_Patient.Location = new System.Drawing.Point(146, 111);
			this.textBox_Patient.Name = "textBox_Patient";
			this.textBox_Patient.ReadOnly = true;
			this.textBox_Patient.Size = new System.Drawing.Size(148, 20);
			this.textBox_Patient.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(93, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Patient";
			// 
			// Start_Knap
			// 
			this.Start_Knap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Start_Knap.Location = new System.Drawing.Point(12, 14);
			this.Start_Knap.Name = "Start_Knap";
			this.Start_Knap.Size = new System.Drawing.Size(302, 50);
			this.Start_Knap.TabIndex = 8;
			this.Start_Knap.Text = "Start";
			this.Start_Knap.UseVisualStyleBackColor = true;
			this.Start_Knap.Click += new System.EventHandler(this.button1_Click);
			// 
			// Status_Listbox
			// 
			this.Status_Listbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Status_Listbox.FormattingEnabled = true;
			this.Status_Listbox.Location = new System.Drawing.Point(339, 81);
			this.Status_Listbox.Name = "Status_Listbox";
			this.Status_Listbox.Size = new System.Drawing.Size(273, 572);
			this.Status_Listbox.TabIndex = 9;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(123, 318);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.ReadOnly = true;
			this.numericUpDown1.Size = new System.Drawing.Size(185, 20);
			this.numericUpDown1.TabIndex = 11;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(120, 300);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Hastighed: Patient";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(104, 139);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Hastighed: Tandlæge";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(217, 137);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.ReadOnly = true;
			this.numericUpDown2.Size = new System.Drawing.Size(77, 20);
			this.numericUpDown2.TabIndex = 14;
			this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(97, 198);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Status";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(93, 224);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 13);
			this.label10.TabIndex = 19;
			this.label10.Text = "Patient";
			// 
			// TextBoxStatus2
			// 
			this.TextBoxStatus2.Location = new System.Drawing.Point(146, 195);
			this.TextBoxStatus2.Name = "TextBoxStatus2";
			this.TextBoxStatus2.ReadOnly = true;
			this.TextBoxStatus2.Size = new System.Drawing.Size(148, 20);
			this.TextBoxStatus2.TabIndex = 17;
			// 
			// textBox_Patient2
			// 
			this.textBox_Patient2.Location = new System.Drawing.Point(146, 221);
			this.textBox_Patient2.Name = "textBox_Patient2";
			this.textBox_Patient2.ReadOnly = true;
			this.textBox_Patient2.Size = new System.Drawing.Size(148, 20);
			this.textBox_Patient2.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(101, 249);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Hastighed: Tandlæge";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(217, 247);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.ReadOnly = true;
			this.numericUpDown3.Size = new System.Drawing.Size(77, 20);
			this.numericUpDown3.TabIndex = 21;
			this.numericUpDown3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MultiThreading.Properties.Resources.MultiThreading_GUI1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(641, 675);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.textBox_Status);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.TextBoxStatus2);
			this.Controls.Add(this.textBox_Patient);
			this.Controls.Add(this.textBox_Patient2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.Venteværelse_Listbox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Status_Listbox);
			this.Controls.Add(this.Start_Knap);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDown2);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Tandlægerne Smil simulering";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Venteværelse_Listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Patient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Start_Knap;
        private System.Windows.Forms.ListBox Status_Listbox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Patient2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        public System.Windows.Forms.TextBox textBox_Status;
        public System.Windows.Forms.TextBox TextBoxStatus2;
    }
}

