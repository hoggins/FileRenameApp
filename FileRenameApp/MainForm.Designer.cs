namespace FileRenameApp
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
      this._destFolderTb = new System.Windows.Forms.TextBox();
      this._browseBtn = new System.Windows.Forms.Button();
      this._nameFormatTb = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this._runBtn = new System.Windows.Forms.Button();
      this._formatTooltip = new System.Windows.Forms.ToolTip(this.components);
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this._outputListBox = new System.Windows.Forms.ListBox();
      this._consoleTimer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // _destFolderTb
      // 
      this._destFolderTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._destFolderTb.Location = new System.Drawing.Point(108, 15);
      this._destFolderTb.MaximumSize = new System.Drawing.Size(500, 20);
      this._destFolderTb.Name = "_destFolderTb";
      this._destFolderTb.Size = new System.Drawing.Size(206, 20);
      this._destFolderTb.TabIndex = 0;
      this._destFolderTb.WordWrap = false;
      // 
      // _browseBtn
      // 
      this._browseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this._browseBtn.Location = new System.Drawing.Point(320, 13);
      this._browseBtn.Name = "_browseBtn";
      this._browseBtn.Size = new System.Drawing.Size(65, 24);
      this._browseBtn.TabIndex = 1;
      this._browseBtn.Text = "Browse";
      this._browseBtn.UseVisualStyleBackColor = true;
      this._browseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
      // 
      // _nameFormatTb
      // 
      this._nameFormatTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._nameFormatTb.Location = new System.Drawing.Point(108, 41);
      this._nameFormatTb.Name = "_nameFormatTb";
      this._nameFormatTb.Size = new System.Drawing.Size(206, 20);
      this._nameFormatTb.TabIndex = 2;
      this._nameFormatTb.Text = "Item #n";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(90, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Rename in folder:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "File name format:";
      // 
      // _runBtn
      // 
      this._runBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this._runBtn.Location = new System.Drawing.Point(320, 67);
      this._runBtn.Name = "_runBtn";
      this._runBtn.Size = new System.Drawing.Size(65, 40);
      this._runBtn.TabIndex = 6;
      this._runBtn.Text = "Rum";
      this._runBtn.UseVisualStyleBackColor = true;
      this._runBtn.Click += new System.EventHandler(this.RunBtn_Click);
      // 
      // _formatTooltip
      // 
      this._formatTooltip.AutoPopDelay = 20000;
      this._formatTooltip.InitialDelay = 0;
      this._formatTooltip.ReshowDelay = 100;
      this._formatTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this._formatTooltip.ToolTipTitle = "Format info:";
      // 
      // progressBar
      // 
      this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBar.Location = new System.Drawing.Point(12, 67);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(302, 40);
      this.progressBar.TabIndex = 7;
      // 
      // _outputListBox
      // 
      this._outputListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._outputListBox.FormattingEnabled = true;
      this._outputListBox.Location = new System.Drawing.Point(12, 114);
      this._outputListBox.Name = "_outputListBox";
      this._outputListBox.Size = new System.Drawing.Size(373, 95);
      this._outputListBox.TabIndex = 8;
      // 
      // _consoleTimer
      // 
      this._consoleTimer.Enabled = true;
      this._consoleTimer.Interval = 300;
      this._consoleTimer.Tick += new System.EventHandler(this.ConsoleTimer_Tick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(397, 222);
      this.Controls.Add(this._outputListBox);
      this.Controls.Add(this.progressBar);
      this.Controls.Add(this._runBtn);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this._nameFormatTb);
      this.Controls.Add(this._browseBtn);
      this.Controls.Add(this._destFolderTb);
      this.Name = "MainForm";
      this.Text = "FileRenameApp";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox _destFolderTb;
    private System.Windows.Forms.Button _browseBtn;
    private System.Windows.Forms.TextBox _nameFormatTb;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button _runBtn;
    private System.Windows.Forms.ToolTip _formatTooltip;
    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.ListBox _outputListBox;
    private System.Windows.Forms.Timer _consoleTimer;
  }
}

