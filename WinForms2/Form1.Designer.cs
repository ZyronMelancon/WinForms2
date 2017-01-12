namespace WinForms2
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
            this.P1ATKButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.P1LVLProg = new System.Windows.Forms.ProgressBar();
            this.P1LVL = new System.Windows.Forms.Label();
            this.P1HPProg = new System.Windows.Forms.ProgressBar();
            this.P1HP = new System.Windows.Forms.Label();
            this.P1ATK = new System.Windows.Forms.Label();
            this.P1DEF = new System.Windows.Forms.Label();
            this.EndTurn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // P1ATKButton
            // 
            this.P1ATKButton.Location = new System.Drawing.Point(12, 150);
            this.P1ATKButton.Name = "P1ATKButton";
            this.P1ATKButton.Size = new System.Drawing.Size(75, 51);
            this.P1ATKButton.TabIndex = 0;
            this.P1ATKButton.Text = "Attack";
            this.P1ATKButton.UseVisualStyleBackColor = true;
            this.P1ATKButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Defend";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // P1LVLProg
            // 
            this.P1LVLProg.Location = new System.Drawing.Point(12, 258);
            this.P1LVLProg.Name = "P1LVLProg";
            this.P1LVLProg.Size = new System.Drawing.Size(156, 10);
            this.P1LVLProg.TabIndex = 2;
            // 
            // P1LVL
            // 
            this.P1LVL.AutoSize = true;
            this.P1LVL.Location = new System.Drawing.Point(65, 271);
            this.P1LVL.Name = "P1LVL";
            this.P1LVL.Size = new System.Drawing.Size(45, 13);
            this.P1LVL.TabIndex = 4;
            this.P1LVL.Text = "Level: 1";
            // 
            // P1HPProg
            // 
            this.P1HPProg.Location = new System.Drawing.Point(12, 226);
            this.P1HPProg.Name = "P1HPProg";
            this.P1HPProg.Size = new System.Drawing.Size(156, 10);
            this.P1HPProg.TabIndex = 5;
            // 
            // P1HP
            // 
            this.P1HP.AutoSize = true;
            this.P1HP.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.P1HP.Location = new System.Drawing.Point(58, 239);
            this.P1HP.Name = "P1HP";
            this.P1HP.Size = new System.Drawing.Size(62, 13);
            this.P1HP.TabIndex = 6;
            this.P1HP.Text = "Health: 100";
            // 
            // P1ATK
            // 
            this.P1ATK.AutoSize = true;
            this.P1ATK.Location = new System.Drawing.Point(25, 204);
            this.P1ATK.Name = "P1ATK";
            this.P1ATK.Size = new System.Drawing.Size(46, 13);
            this.P1ATK.TabIndex = 7;
            this.P1ATK.Text = "ATK: 20";
            // 
            // P1DEF
            // 
            this.P1DEF.AutoSize = true;
            this.P1DEF.Location = new System.Drawing.Point(105, 204);
            this.P1DEF.Name = "P1DEF";
            this.P1DEF.Size = new System.Drawing.Size(46, 13);
            this.P1DEF.TabIndex = 8;
            this.P1DEF.Text = "DEF: 10";
            // 
            // EndTurn
            // 
            this.EndTurn.Location = new System.Drawing.Point(12, 299);
            this.EndTurn.Name = "EndTurn";
            this.EndTurn.Size = new System.Drawing.Size(156, 28);
            this.EndTurn.TabIndex = 25;
            this.EndTurn.Text = "End Turn";
            this.EndTurn.UseVisualStyleBackColor = true;
            this.EndTurn.Click += new System.EventHandler(this.EndTurn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 339);
            this.Controls.Add(this.EndTurn);
            this.Controls.Add(this.P1DEF);
            this.Controls.Add(this.P1ATK);
            this.Controls.Add(this.P1HP);
            this.Controls.Add(this.P1HPProg);
            this.Controls.Add(this.P1LVL);
            this.Controls.Add(this.P1LVLProg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.P1ATKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RPG thingy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button P1ATKButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar P1LVLProg;
        private System.Windows.Forms.Label P1LVL;
        private System.Windows.Forms.ProgressBar P1HPProg;
        private System.Windows.Forms.Label P1HP;
        private System.Windows.Forms.Label P1ATK;
        private System.Windows.Forms.Label P1DEF;
        private System.Windows.Forms.Button EndTurn;
    }
}

