using System;

namespace MathQuiz1._0
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDisplay = new System.Windows.Forms.Label();
            this.Q1_LeftLabel = new System.Windows.Forms.Label();
            this.sign1 = new System.Windows.Forms.Label();
            this.Q1_RightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.NumericUpDown();
            this.answer2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Q2_RightLabel = new System.Windows.Forms.Label();
            this.sign2 = new System.Windows.Forms.Label();
            this.Q2_LeftLabel = new System.Windows.Forms.Label();
            this.answer3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Q3_RightLabel = new System.Windows.Forms.Label();
            this.sign3 = new System.Windows.Forms.Label();
            this.Q3_LeftLabel = new System.Windows.Forms.Label();
            this.answer4 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.Q4_RightLabel = new System.Windows.Forms.Label();
            this.sign4 = new System.Windows.Forms.Label();
            this.Q4_LeftLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.answer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer4)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(311, 86);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time Left";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateDisplay
            // 
            this.dateDisplay.AutoSize = true;
            this.dateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDisplay.Location = new System.Drawing.Point(180, 38);
            this.dateDisplay.Name = "dateDisplay";
            this.dateDisplay.Size = new System.Drawing.Size(188, 25);
            this.dateDisplay.TabIndex = 4;
            this.dateDisplay.Text = "24-September-2022";
            // 
            // Q1_LeftLabel
            // 
            this.Q1_LeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1_LeftLabel.Location = new System.Drawing.Point(48, 162);
            this.Q1_LeftLabel.Name = "Q1_LeftLabel";
            this.Q1_LeftLabel.Size = new System.Drawing.Size(80, 50);
            this.Q1_LeftLabel.TabIndex = 5;
            this.Q1_LeftLabel.Text = "A";
            this.Q1_LeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sign1
            // 
            this.sign1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign1.Location = new System.Drawing.Point(134, 167);
            this.sign1.Name = "sign1";
            this.sign1.Size = new System.Drawing.Size(80, 50);
            this.sign1.TabIndex = 6;
            this.sign1.Text = "+";
            this.sign1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q1_RightLabel
            // 
            this.Q1_RightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1_RightLabel.Location = new System.Drawing.Point(220, 162);
            this.Q1_RightLabel.Name = "Q1_RightLabel";
            this.Q1_RightLabel.Size = new System.Drawing.Size(80, 50);
            this.Q1_RightLabel.TabIndex = 7;
            this.Q1_RightLabel.Text = "B";
            this.Q1_RightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer1
            // 
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1.Location = new System.Drawing.Point(400, 167);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(100, 41);
            this.answer1.TabIndex = 1;
            this.answer1.ValueChanged += new System.EventHandler(this.answer1_ValueChanged);
            this.answer1.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // answer2
            // 
            this.answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2.Location = new System.Drawing.Point(400, 227);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(100, 41);
            this.answer2.TabIndex = 2;
            this.answer2.ValueChanged += new System.EventHandler(this.answer2_ValueChanged);
            this.answer2.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 50);
            this.label3.TabIndex = 13;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q2_RightLabel
            // 
            this.Q2_RightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q2_RightLabel.Location = new System.Drawing.Point(220, 222);
            this.Q2_RightLabel.Name = "Q2_RightLabel";
            this.Q2_RightLabel.Size = new System.Drawing.Size(79, 50);
            this.Q2_RightLabel.TabIndex = 12;
            this.Q2_RightLabel.Text = "B";
            this.Q2_RightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sign2
            // 
            this.sign2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign2.Location = new System.Drawing.Point(135, 227);
            this.sign2.Name = "sign2";
            this.sign2.Size = new System.Drawing.Size(79, 50);
            this.sign2.TabIndex = 11;
            this.sign2.Text = "-";
            this.sign2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q2_LeftLabel
            // 
            this.Q2_LeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q2_LeftLabel.Location = new System.Drawing.Point(48, 222);
            this.Q2_LeftLabel.Name = "Q2_LeftLabel";
            this.Q2_LeftLabel.Size = new System.Drawing.Size(79, 50);
            this.Q2_LeftLabel.TabIndex = 10;
            this.Q2_LeftLabel.Text = "A";
            this.Q2_LeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer3
            // 
            this.answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3.Location = new System.Drawing.Point(399, 291);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(100, 41);
            this.answer3.TabIndex = 3;
            this.answer3.ValueChanged += new System.EventHandler(this.answer3_ValueChanged);
            this.answer3.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(305, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 50);
            this.label8.TabIndex = 18;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q3_RightLabel
            // 
            this.Q3_RightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q3_RightLabel.Location = new System.Drawing.Point(220, 282);
            this.Q3_RightLabel.Name = "Q3_RightLabel";
            this.Q3_RightLabel.Size = new System.Drawing.Size(80, 50);
            this.Q3_RightLabel.TabIndex = 17;
            this.Q3_RightLabel.Text = "B";
            this.Q3_RightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sign3
            // 
            this.sign3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign3.Location = new System.Drawing.Point(133, 282);
            this.sign3.Name = "sign3";
            this.sign3.Size = new System.Drawing.Size(80, 50);
            this.sign3.TabIndex = 16;
            this.sign3.Text = "x";
            this.sign3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q3_LeftLabel
            // 
            this.Q3_LeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q3_LeftLabel.Location = new System.Drawing.Point(47, 282);
            this.Q3_LeftLabel.Name = "Q3_LeftLabel";
            this.Q3_LeftLabel.Size = new System.Drawing.Size(80, 50);
            this.Q3_LeftLabel.TabIndex = 15;
            this.Q3_LeftLabel.Text = "A";
            this.Q3_LeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer4
            // 
            this.answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4.Location = new System.Drawing.Point(399, 350);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(100, 41);
            this.answer4.TabIndex = 4;
            this.answer4.ValueChanged += new System.EventHandler(this.answer4_ValueChanged);
            this.answer4.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(305, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 50);
            this.label12.TabIndex = 23;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q4_RightLabel
            // 
            this.Q4_RightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q4_RightLabel.Location = new System.Drawing.Point(220, 345);
            this.Q4_RightLabel.Name = "Q4_RightLabel";
            this.Q4_RightLabel.Size = new System.Drawing.Size(80, 50);
            this.Q4_RightLabel.TabIndex = 22;
            this.Q4_RightLabel.Text = "B";
            this.Q4_RightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sign4
            // 
            this.sign4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign4.Location = new System.Drawing.Point(133, 345);
            this.sign4.Name = "sign4";
            this.sign4.Size = new System.Drawing.Size(80, 50);
            this.sign4.TabIndex = 21;
            this.sign4.Text = "/";
            this.sign4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q4_LeftLabel
            // 
            this.Q4_LeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q4_LeftLabel.Location = new System.Drawing.Point(47, 345);
            this.Q4_LeftLabel.Name = "Q4_LeftLabel";
            this.Q4_LeftLabel.Size = new System.Drawing.Size(80, 50);
            this.Q4_LeftLabel.TabIndex = 20;
            this.Q4_LeftLabel.Text = "A";
            this.Q4_LeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.AutoSize = true;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(200, 433);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(127, 39);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start Quiz";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 499);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Q4_RightLabel);
            this.Controls.Add(this.sign4);
            this.Controls.Add(this.Q4_LeftLabel);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Q3_RightLabel);
            this.Controls.Add(this.sign3);
            this.Controls.Add(this.Q3_LeftLabel);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Q2_RightLabel);
            this.Controls.Add(this.sign2);
            this.Controls.Add(this.Q2_LeftLabel);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Q1_RightLabel);
            this.Controls.Add(this.sign1);
            this.Controls.Add(this.Q1_LeftLabel);
            this.Controls.Add(this.dateDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Erik Birch\'s Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.answer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateDisplay;
        private System.Windows.Forms.Label Q1_LeftLabel;
        private System.Windows.Forms.Label sign1;
        private System.Windows.Forms.Label Q1_RightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown answer1;
        private System.Windows.Forms.NumericUpDown answer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Q2_RightLabel;
        private System.Windows.Forms.Label sign2;
        private System.Windows.Forms.Label Q2_LeftLabel;
        private System.Windows.Forms.NumericUpDown answer3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Q3_RightLabel;
        private System.Windows.Forms.Label sign3;
        private System.Windows.Forms.Label Q3_LeftLabel;
        private System.Windows.Forms.NumericUpDown answer4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Q4_RightLabel;
        private System.Windows.Forms.Label sign4;
        private System.Windows.Forms.Label Q4_LeftLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

