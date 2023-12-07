namespace Demo
{
    partial class frmSyncContext
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
            this.btnStartThread = new System.Windows.Forms.Button();
            this.lblThread1 = new System.Windows.Forms.Label();
            this.lblThread2 = new System.Windows.Forms.Label();
            this.btnBlocking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartThread
            // 
            this.btnStartThread.Location = new System.Drawing.Point(241, 141);
            this.btnStartThread.Name = "btnStartThread";
            this.btnStartThread.Size = new System.Drawing.Size(113, 57);
            this.btnStartThread.TabIndex = 0;
            this.btnStartThread.Text = "Press me";
            this.btnStartThread.UseVisualStyleBackColor = true;
            this.btnStartThread.Click += new System.EventHandler(this.btnStartThread_Click);
            this.btnStartThread.MouseEnter += new System.EventHandler(this.btnStartThread_MouseEnter);
            // 
            // lblThread1
            // 
            this.lblThread1.AutoSize = true;
            this.lblThread1.Location = new System.Drawing.Point(629, 79);
            this.lblThread1.Name = "lblThread1";
            this.lblThread1.Size = new System.Drawing.Size(49, 15);
            this.lblThread1.TabIndex = 1;
            this.lblThread1.Text = "Thread1";
            // 
            // lblThread2
            // 
            this.lblThread2.AutoSize = true;
            this.lblThread2.Location = new System.Drawing.Point(629, 116);
            this.lblThread2.Name = "lblThread2";
            this.lblThread2.Size = new System.Drawing.Size(49, 15);
            this.lblThread2.TabIndex = 2;
            this.lblThread2.Text = "Thread2";
            // 
            // btnBlocking
            // 
            this.btnBlocking.Location = new System.Drawing.Point(598, 141);
            this.btnBlocking.Name = "btnBlocking";
            this.btnBlocking.Size = new System.Drawing.Size(113, 57);
            this.btnBlocking.TabIndex = 3;
            this.btnBlocking.Text = "Blocking button";
            this.btnBlocking.UseVisualStyleBackColor = true;
            this.btnBlocking.Click += new System.EventHandler(this.btnBlocking_Click);
            // 
            // frmSyncContext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBlocking);
            this.Controls.Add(this.lblThread2);
            this.Controls.Add(this.lblThread1);
            this.Controls.Add(this.btnStartThread);
            this.Name = "frmSyncContext";
            this.Text = "Synchronization context";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStartThread;
        private Label lblThread1;
        private Label lblThread2;
        private Button btnBlocking;
    }
}