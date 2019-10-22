namespace LetsPlay
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
            this.door1btn = new System.Windows.Forms.Button();
            this.door2btn = new System.Windows.Forms.Button();
            this.door3btn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.door4btn = new System.Windows.Forms.Button();
            this.door5btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // door1btn
            // 
            this.door1btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door1btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.door1btn.FlatAppearance.BorderSize = 0;
            this.door1btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door1btn.Location = new System.Drawing.Point(81, 126);
            this.door1btn.Name = "door1btn";
            this.door1btn.Size = new System.Drawing.Size(92, 184);
            this.door1btn.TabIndex = 0;
            this.door1btn.UseVisualStyleBackColor = true;
            this.door1btn.Click += new System.EventHandler(this.Door1btn_Click);
            // 
            // door2btn
            // 
            this.door2btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door2btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.door2btn.FlatAppearance.BorderSize = 0;
            this.door2btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door2btn.Location = new System.Drawing.Point(183, 126);
            this.door2btn.Name = "door2btn";
            this.door2btn.Size = new System.Drawing.Size(92, 184);
            this.door2btn.TabIndex = 1;
            this.door2btn.UseVisualStyleBackColor = true;
            this.door2btn.Click += new System.EventHandler(this.Door2btn_Click);
            // 
            // door3btn
            // 
            this.door3btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door3btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.door3btn.FlatAppearance.BorderSize = 0;
            this.door3btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door3btn.Location = new System.Drawing.Point(285, 126);
            this.door3btn.Name = "door3btn";
            this.door3btn.Size = new System.Drawing.Size(92, 184);
            this.door3btn.TabIndex = 2;
            this.door3btn.UseVisualStyleBackColor = true;
            this.door3btn.Click += new System.EventHandler(this.Door3btn_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLbl.Location = new System.Drawing.Point(36, 32);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(576, 50);
            this.msgLbl.TabIndex = 3;
            this.msgLbl.Text = "Let\'s play the door challenge. \r\nChoose one of the doors and win your school grad" +
    "e!!!";
            this.msgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(280, 366);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(100, 41);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset Game\r\n";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // door4btn
            // 
            this.door4btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door4btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.door4btn.FlatAppearance.BorderSize = 0;
            this.door4btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door4btn.Location = new System.Drawing.Point(387, 126);
            this.door4btn.Name = "door4btn";
            this.door4btn.Size = new System.Drawing.Size(92, 184);
            this.door4btn.TabIndex = 5;
            this.door4btn.UseVisualStyleBackColor = true;
            this.door4btn.Click += new System.EventHandler(this.Door4btn_Click);
            // 
            // door5btn
            // 
            this.door5btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door5btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.door5btn.FlatAppearance.BorderSize = 0;
            this.door5btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door5btn.Location = new System.Drawing.Point(489, 126);
            this.door5btn.Name = "door5btn";
            this.door5btn.Size = new System.Drawing.Size(92, 184);
            this.door5btn.TabIndex = 6;
            this.door5btn.UseVisualStyleBackColor = true;
            this.door5btn.Click += new System.EventHandler(this.Door5btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.door5btn);
            this.Controls.Add(this.door4btn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.door3btn);
            this.Controls.Add(this.door2btn);
            this.Controls.Add(this.door1btn);
            this.Name = "Form1";
            this.Text = "Door Challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button door1btn;
        private System.Windows.Forms.Button door2btn;
        private System.Windows.Forms.Button door3btn;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button door4btn;
        private System.Windows.Forms.Button door5btn;
    }
}

