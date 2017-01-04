namespace ClearPath
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.lbPath = new System.Windows.Forms.Label();
            this.btnClearNow = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.nfiMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbOnWinStart = new System.Windows.Forms.CheckBox();
            this.nudCleanDays = new System.Windows.Forms.NumericUpDown();
            this.lbClean = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCleanDays)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(12, 12);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(80, 23);
            this.btnChoosePath.TabIndex = 0;
            this.btnChoosePath.Text = "Choose Path";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(59, 47);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(33, 13);
            this.lbPath.TabIndex = 1;
            this.lbPath.Text = "None";
            // 
            // btnClearNow
            // 
            this.btnClearNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearNow.Location = new System.Drawing.Point(145, 138);
            this.btnClearNow.Name = "btnClearNow";
            this.btnClearNow.Size = new System.Drawing.Size(75, 23);
            this.btnClearNow.TabIndex = 2;
            this.btnClearNow.Text = "Clear Now!";
            this.btnClearNow.UseVisualStyleBackColor = true;
            this.btnClearNow.Click += new System.EventHandler(this.btnClearNow_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(248, 138);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(58, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // nfiMain
            // 
            this.nfiMain.Icon = ((System.Drawing.Icon)(resources.GetObject("nfiMain.Icon")));
            this.nfiMain.Text = "Clear Machine";
            this.nfiMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nfiMain_MouseClick);
            // 
            // cbOnWinStart
            // 
            this.cbOnWinStart.AutoSize = true;
            this.cbOnWinStart.Location = new System.Drawing.Point(166, 12);
            this.cbOnWinStart.Name = "cbOnWinStart";
            this.cbOnWinStart.Size = new System.Drawing.Size(140, 17);
            this.cbOnWinStart.TabIndex = 5;
            this.cbOnWinStart.Text = "Run on windows startup";
            this.cbOnWinStart.UseVisualStyleBackColor = true;
            // 
            // nudCleanDays
            // 
            this.nudCleanDays.Location = new System.Drawing.Point(12, 83);
            this.nudCleanDays.Name = "nudCleanDays";
            this.nudCleanDays.Size = new System.Drawing.Size(39, 20);
            this.nudCleanDays.TabIndex = 6;
            this.nudCleanDays.ValueChanged += new System.EventHandler(this.nudCleanDays_ValueChanged);
            // 
            // lbClean
            // 
            this.lbClean.AutoSize = true;
            this.lbClean.Location = new System.Drawing.Point(57, 85);
            this.lbClean.Name = "lbClean";
            this.lbClean.Size = new System.Drawing.Size(97, 13);
            this.lbClean.TabIndex = 7;
            this.lbClean.Text = "Clean every 0 days";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 173);
            this.Controls.Add(this.lbClean);
            this.Controls.Add(this.nudCleanDays);
            this.Controls.Add(this.cbOnWinStart);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnClearNow);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.btnChoosePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clear Machine";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudCleanDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Button btnClearNow;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.NotifyIcon nfiMain;
        private System.Windows.Forms.CheckBox cbOnWinStart;
        private System.Windows.Forms.NumericUpDown nudCleanDays;
        private System.Windows.Forms.Label lbClean;
    }
}

