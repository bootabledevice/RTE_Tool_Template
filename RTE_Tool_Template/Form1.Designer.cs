namespace RTE_Tool_Template
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
            this.connectConsole = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.c3Status = new System.Windows.Forms.Label();
            this.c4Status = new System.Windows.Forms.Label();
            this.consoleStatus = new System.Windows.Forms.Label();
            this.c3Timer = new System.Windows.Forms.Timer(this.components);
            this.c4Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // connectConsole
            // 
            this.connectConsole.Location = new System.Drawing.Point(13, 13);
            this.connectConsole.Name = "connectConsole";
            this.connectConsole.Size = new System.Drawing.Size(116, 35);
            this.connectConsole.TabIndex = 0;
            this.connectConsole.Text = "Connect To Console";
            this.connectConsole.UseVisualStyleBackColor = true;
            this.connectConsole.Click += new System.EventHandler(this.connectConsole_Click);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(13, 54);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(116, 34);
            this.c1.TabIndex = 1;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.c1_Click);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(13, 94);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(116, 34);
            this.c2.TabIndex = 2;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.c2_Click);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(13, 134);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(116, 33);
            this.c3.TabIndex = 3;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.c3_Click);
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(13, 173);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(116, 33);
            this.c4.TabIndex = 4;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            this.c4.Click += new System.EventHandler(this.c4_Click);
            // 
            // c3Status
            // 
            this.c3Status.AutoSize = true;
            this.c3Status.Location = new System.Drawing.Point(135, 154);
            this.c3Status.Name = "c3Status";
            this.c3Status.Size = new System.Drawing.Size(57, 13);
            this.c3Status.TabIndex = 7;
            this.c3Status.Text = "Not Active";
            // 
            // c4Status
            // 
            this.c4Status.AutoSize = true;
            this.c4Status.Location = new System.Drawing.Point(135, 193);
            this.c4Status.Name = "c4Status";
            this.c4Status.Size = new System.Drawing.Size(57, 13);
            this.c4Status.TabIndex = 8;
            this.c4Status.Text = "Not Active";
            // 
            // consoleStatus
            // 
            this.consoleStatus.AutoSize = true;
            this.consoleStatus.Location = new System.Drawing.Point(135, 35);
            this.consoleStatus.Name = "consoleStatus";
            this.consoleStatus.Size = new System.Drawing.Size(79, 13);
            this.consoleStatus.TabIndex = 9;
            this.consoleStatus.Text = "Not Connected";
            // 
            // c3Timer
            // 
            this.c3Timer.Tick += new System.EventHandler(this.c3Timer_Tick);
            // 
            // c4Timer
            // 
            this.c4Timer.Tick += new System.EventHandler(this.c4Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 240);
            this.Controls.Add(this.consoleStatus);
            this.Controls.Add(this.c4Status);
            this.Controls.Add(this.c3Status);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.connectConsole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectConsole;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Label c3Status;
        private System.Windows.Forms.Label c4Status;
        private System.Windows.Forms.Label consoleStatus;
        private System.Windows.Forms.Timer c3Timer;
        private System.Windows.Forms.Timer c4Timer;
    }
}

