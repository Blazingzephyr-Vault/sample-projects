namespace Formulas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.xMultiplier = new System.Windows.Forms.NumericUpDown();
            this.yMultiplier = new System.Windows.Forms.NumericUpDown();
            this.penThickness = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Draw);
            // 
            // xMultiplier
            // 
            this.xMultiplier.DecimalPlaces = 3;
            this.xMultiplier.Location = new System.Drawing.Point(550, 112);
            this.xMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xMultiplier.Name = "xMultiplier";
            this.xMultiplier.Size = new System.Drawing.Size(120, 23);
            this.xMultiplier.TabIndex = 2;
            this.xMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yMultiplier
            // 
            this.yMultiplier.DecimalPlaces = 3;
            this.yMultiplier.Location = new System.Drawing.Point(550, 141);
            this.yMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yMultiplier.Name = "yMultiplier";
            this.yMultiplier.Size = new System.Drawing.Size(120, 23);
            this.yMultiplier.TabIndex = 3;
            this.yMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // penThickness
            // 
            this.penThickness.DecimalPlaces = 3;
            this.penThickness.Location = new System.Drawing.Point(550, 170);
            this.penThickness.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.penThickness.Name = "penThickness";
            this.penThickness.Size = new System.Drawing.Size(120, 23);
            this.penThickness.TabIndex = 4;
            this.penThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penThickness.ValueChanged += new System.EventHandler(this.UpdateThickness);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Linear",
            "Parabola",
            "Cubic Parabola",
            "Hyperbola"});
            this.checkedListBox1.Location = new System.Drawing.Point(518, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(152, 94);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.GraphSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "T";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.penThickness);
            this.Controls.Add(this.yMultiplier);
            this.Controls.Add(this.xMultiplier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Formulas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penThickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private Button button1;
        private NumericUpDown xMultiplier;
        private NumericUpDown yMultiplier;
        private NumericUpDown penThickness;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}