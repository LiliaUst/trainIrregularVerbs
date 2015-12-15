namespace TrainIrregularVerbs
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTrain = new System.Windows.Forms.Panel();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.lbRusVerbInd = new System.Windows.Forms.Label();
            this.lbPronuncVerb = new System.Windows.Forms.Label();
            this.lbEngVerb3Form = new System.Windows.Forms.Label();
            this.lbTrain = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.lbFromTo = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.btNext = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btPlay = new System.Windows.Forms.Button();
            this.tsAllVerbs = new System.Windows.Forms.ToolStripButton();
            this.linkSet = new System.Windows.Forms.LinkLabel();
            this.pnlTrain.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlTool.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTrain
            // 
            this.pnlTrain.Controls.Add(this.gbDetail);
            this.pnlTrain.Controls.Add(this.lbTrain);
            this.pnlTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrain.Location = new System.Drawing.Point(0, 41);
            this.pnlTrain.Name = "pnlTrain";
            this.pnlTrain.Size = new System.Drawing.Size(729, 209);
            this.pnlTrain.TabIndex = 0;
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.btPlay);
            this.gbDetail.Controls.Add(this.lbRusVerbInd);
            this.gbDetail.Controls.Add(this.lbPronuncVerb);
            this.gbDetail.Controls.Add(this.lbEngVerb3Form);
            this.gbDetail.Location = new System.Drawing.Point(18, 55);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(691, 146);
            this.gbDetail.TabIndex = 1;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Detail";
            // 
            // lbRusVerbInd
            // 
            this.lbRusVerbInd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRusVerbInd.AutoEllipsis = true;
            this.lbRusVerbInd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRusVerbInd.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbRusVerbInd.Location = new System.Drawing.Point(19, 111);
            this.lbRusVerbInd.Name = "lbRusVerbInd";
            this.lbRusVerbInd.Size = new System.Drawing.Size(655, 23);
            this.lbRusVerbInd.TabIndex = 2;
            this.lbRusVerbInd.Text = "получать";
            // 
            // lbPronuncVerb
            // 
            this.lbPronuncVerb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPronuncVerb.AutoEllipsis = true;
            this.lbPronuncVerb.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPronuncVerb.ForeColor = System.Drawing.Color.DimGray;
            this.lbPronuncVerb.Location = new System.Drawing.Point(50, 75);
            this.lbPronuncVerb.Name = "lbPronuncVerb";
            this.lbPronuncVerb.Size = new System.Drawing.Size(624, 23);
            this.lbPronuncVerb.TabIndex = 1;
            this.lbPronuncVerb.Text = "[ gou wˈent gˈɒn]";
            // 
            // lbEngVerb3Form
            // 
            this.lbEngVerb3Form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEngVerb3Form.AutoEllipsis = true;
            this.lbEngVerb3Form.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEngVerb3Form.Location = new System.Drawing.Point(17, 24);
            this.lbEngVerb3Form.Name = "lbEngVerb3Form";
            this.lbEngVerb3Form.Size = new System.Drawing.Size(655, 33);
            this.lbEngVerb3Form.TabIndex = 0;
            this.lbEngVerb3Form.Text = "go, went, gone";
            // 
            // lbTrain
            // 
            this.lbTrain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrain.AutoEllipsis = true;
            this.lbTrain.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTrain.ForeColor = System.Drawing.Color.Brown;
            this.lbTrain.Location = new System.Drawing.Point(12, 16);
            this.lbTrain.Name = "lbTrain";
            this.lbTrain.Size = new System.Drawing.Size(705, 36);
            this.lbTrain.TabIndex = 0;
            this.lbTrain.Text = "Она шла - She went";
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btStart);
            this.pnlControl.Controls.Add(this.lbFromTo);
            this.pnlControl.Controls.Add(this.pbProgress);
            this.pnlControl.Controls.Add(this.btNext);
            this.pnlControl.Controls.Add(this.btStop);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 250);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(729, 51);
            this.pnlControl.TabIndex = 1;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(327, 16);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbFromTo
            // 
            this.lbFromTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFromTo.AutoSize = true;
            this.lbFromTo.Location = new System.Drawing.Point(281, 22);
            this.lbFromTo.Name = "lbFromTo";
            this.lbFromTo.Size = new System.Drawing.Size(63, 13);
            this.lbFromTo.TabIndex = 4;
            this.lbFromTo.Text = "from 1 to 50";
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbProgress.Location = new System.Drawing.Point(99, 16);
            this.pbProgress.Maximum = 50;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(175, 23);
            this.pbProgress.Step = 1;
            this.pbProgress.TabIndex = 3;
            this.pbProgress.Value = 1;
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btNext.Location = new System.Drawing.Point(18, 16);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btStop.Location = new System.Drawing.Point(634, 16);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 0;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Irregular Verbs";
            // 
            // pnlTool
            // 
            this.pnlTool.Controls.Add(this.linkSet);
            this.pnlTool.Controls.Add(this.toolStrip1);
            this.pnlTool.Controls.Add(this.label3);
            this.pnlTool.Controls.Add(this.linkLabel2);
            this.pnlTool.Controls.Add(this.label2);
            this.pnlTool.Controls.Add(this.linkLabel1);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(729, 41);
            this.pnlTool.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = ">";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(104, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(62, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Past Simple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ">";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAllVerbs});
            this.toolStrip1.Location = new System.Drawing.Point(636, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(84, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btPlay
            // 
            this.btPlay.AutoSize = true;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPlay.Image = global::TrainIrregularVerbs.Properties.Resources.play16;
            this.btPlay.Location = new System.Drawing.Point(22, 75);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(28, 23);
            this.btPlay.TabIndex = 3;
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // tsAllVerbs
            // 
            this.tsAllVerbs.Image = global::TrainIrregularVerbs.Properties.Resources.browser;
            this.tsAllVerbs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsAllVerbs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAllVerbs.Name = "tsAllVerbs";
            this.tsAllVerbs.Size = new System.Drawing.Size(72, 22);
            this.tsAllVerbs.Text = "All verbs";
            this.tsAllVerbs.ToolTipText = "Open in browser";
            this.tsAllVerbs.Click += new System.EventHandler(this.tsAllVerbs_Click);
            // 
            // linkSet
            // 
            this.linkSet.AutoSize = true;
            this.linkSet.Location = new System.Drawing.Point(183, 9);
            this.linkSet.Name = "linkSet";
            this.linkSet.Size = new System.Drawing.Size(110, 13);
            this.linkSet.TabIndex = 7;
            this.linkSet.TabStop = true;
            this.linkSet.Text = "Top-52 irregular verbs";
            this.linkSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSet_LinkClicked);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btStop;
            this.ClientSize = new System.Drawing.Size(729, 301);
            this.Controls.Add(this.pnlTrain);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.pnlControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training Irregular Verbs";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTrain.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTrain;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbTrain;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Label lbRusVerbInd;
        private System.Windows.Forms.Label lbPronuncVerb;
        private System.Windows.Forms.Label lbEngVerb3Form;
        private System.Windows.Forms.Label lbFromTo;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAllVerbs;
        private System.Windows.Forms.LinkLabel linkSet;
    }
}

