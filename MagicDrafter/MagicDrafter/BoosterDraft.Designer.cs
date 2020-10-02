namespace MagicDrafter
{
    partial class BoosterDraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoosterDraft));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tslInstructions = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tspbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRandom = new System.Windows.Forms.ToolStripButton();
            this.tsbNewDraft = new System.Windows.Forms.ToolStripButton();
            this.tbWelcome = new System.Windows.Forms.TextBox();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslInstructions,
            this.toolStripSeparator5,
            this.tspbProgress});
            this.toolStrip2.Location = new System.Drawing.Point(0, 936);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(1288, 45);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tslInstructions
            // 
            this.tslInstructions.Name = "tslInstructions";
            this.tslInstructions.Size = new System.Drawing.Size(0, 42);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 45);
            // 
            // tspbProgress
            // 
            this.tspbProgress.Name = "tspbProgress";
            this.tspbProgress.Size = new System.Drawing.Size(200, 42);
            // 
            // pnlTable
            // 
            this.pnlTable.Location = new System.Drawing.Point(22, 52);
            this.pnlTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(630, 877);
            this.pnlTable.TabIndex = 4;
            this.pnlTable.Visible = false;
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(141, 38);
            this.xToolStripMenuItem.Text = "1X";
            // 
            // xToolStripMenuItem1
            // 
            this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            this.xToolStripMenuItem1.Size = new System.Drawing.Size(141, 38);
            this.xToolStripMenuItem1.Text = "2X";
            // 
            // xToolStripMenuItem2
            // 
            this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
            this.xToolStripMenuItem2.Size = new System.Drawing.Size(141, 38);
            this.xToolStripMenuItem2.Text = "3X";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRandom,
            this.tsbNewDraft});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1288, 39);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRandom
            // 
            this.tsbRandom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRandom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbRandom.Image = ((System.Drawing.Image)(resources.GetObject("tsbRandom.Image")));
            this.tsbRandom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRandom.Name = "tsbRandom";
            this.tsbRandom.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbRandom.Size = new System.Drawing.Size(167, 36);
            this.tsbRandom.Text = "Random Pick";
            this.tsbRandom.Click += new System.EventHandler(this.tsbRandom_Click);
            // 
            // tsbNewDraft
            // 
            this.tsbNewDraft.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNewDraft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewDraft.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewDraft.Image")));
            this.tsbNewDraft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewDraft.Name = "tsbNewDraft";
            this.tsbNewDraft.Size = new System.Drawing.Size(127, 36);
            this.tsbNewDraft.Text = "New Draft";
            this.tsbNewDraft.Click += new System.EventHandler(this.tsbNewDraft_Click);
            // 
            // tbWelcome
            // 
            this.tbWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWelcome.Location = new System.Drawing.Point(296, 171);
            this.tbWelcome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbWelcome.Multiline = true;
            this.tbWelcome.Name = "tbWelcome";
            this.tbWelcome.ReadOnly = true;
            this.tbWelcome.Size = new System.Drawing.Size(780, 662);
            this.tbWelcome.TabIndex = 6;
            this.tbWelcome.TabStop = false;
            this.tbWelcome.Text = resources.GetString("tbWelcome.Text");
            // 
            // BoosterDraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 981);
            this.Controls.Add(this.tbWelcome);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(366, 421);
            this.Name = "BoosterDraft";
            this.Text = "Magic Draft Picker";
            this.Load += new System.EventHandler(this.BoosterDraft_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewDraft;
        private System.Windows.Forms.ToolStripLabel tslInstructions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripProgressBar tspbProgress;
        private System.Windows.Forms.ToolStripButton tsbRandom;
        private System.Windows.Forms.TextBox tbWelcome;
    }
}

