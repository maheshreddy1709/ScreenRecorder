namespace ScreenRecordingApp
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
            this.txtboxFileLocation = new System.Windows.Forms.TextBox();
            this.btnFiledialog = new System.Windows.Forms.Button();
            this.filedialog = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbltimeUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxFileLocation
            // 
            this.txtboxFileLocation.Location = new System.Drawing.Point(9, 24);
            this.txtboxFileLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxFileLocation.Name = "txtboxFileLocation";
            this.txtboxFileLocation.Size = new System.Drawing.Size(398, 20);
            this.txtboxFileLocation.TabIndex = 0;
            // 
            // btnFiledialog
            // 
            this.btnFiledialog.Location = new System.Drawing.Point(410, 20);
            this.btnFiledialog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiledialog.Name = "btnFiledialog";
            this.btnFiledialog.Size = new System.Drawing.Size(109, 27);
            this.btnFiledialog.TabIndex = 1;
            this.btnFiledialog.Text = "Open";
            this.btnFiledialog.UseVisualStyleBackColor = true;
            this.btnFiledialog.Click += new System.EventHandler(this.btnFiledialog_Click);
            // 
            // filedialog
            // 
            this.filedialog.FileName = "openFileDialog1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 63);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 30);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Recording";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(128, 63);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 30);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop Recording";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbltimeUpdate
            // 
            this.lbltimeUpdate.AutoSize = true;
            this.lbltimeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimeUpdate.Location = new System.Drawing.Point(288, 67);
            this.lbltimeUpdate.Name = "lbltimeUpdate";
            this.lbltimeUpdate.Size = new System.Drawing.Size(33, 20);
            this.lbltimeUpdate.TabIndex = 4;
            this.lbltimeUpdate.Text = "--:--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 135);
            this.Controls.Add(this.lbltimeUpdate);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnFiledialog);
            this.Controls.Add(this.txtboxFileLocation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "GRL Screen Recording Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxFileLocation;
        private System.Windows.Forms.Button btnFiledialog;
        private System.Windows.Forms.OpenFileDialog filedialog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbltimeUpdate;
    }
}

