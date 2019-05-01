namespace GUI
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
            this.StartTxt = new System.Windows.Forms.TextBox();
            this.ArrivalTxt = new System.Windows.Forms.TextBox();
            this.ArrivalLstBox = new System.Windows.Forms.ListBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ConnectionsBtn = new System.Windows.Forms.Button();
            this.ConnectionLstBox = new System.Windows.Forms.ListBox();
            this.Connections = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StationBoardBtn = new System.Windows.Forms.Button();
            this.StartLstBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartTxt
            // 
            this.StartTxt.Location = new System.Drawing.Point(6, 19);
            this.StartTxt.Name = "StartTxt";
            this.StartTxt.Size = new System.Drawing.Size(100, 20);
            this.StartTxt.TabIndex = 0;
            // 
            // ArrivalTxt
            // 
            this.ArrivalTxt.Location = new System.Drawing.Point(184, 19);
            this.ArrivalTxt.Name = "ArrivalTxt";
            this.ArrivalTxt.Size = new System.Drawing.Size(100, 20);
            this.ArrivalTxt.TabIndex = 1;
            // 
            // ArrivalLstBox
            // 
            this.ArrivalLstBox.FormattingEnabled = true;
            this.ArrivalLstBox.Location = new System.Drawing.Point(325, 97);
            this.ArrivalLstBox.Name = "ArrivalLstBox";
            this.ArrivalLstBox.Size = new System.Drawing.Size(174, 121);
            this.ArrivalLstBox.TabIndex = 3;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(531, 97);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(82, 23);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Suche";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.OnSearchClick);
            // 
            // ConnectionsBtn
            // 
            this.ConnectionsBtn.Location = new System.Drawing.Point(531, 126);
            this.ConnectionsBtn.Name = "ConnectionsBtn";
            this.ConnectionsBtn.Size = new System.Drawing.Size(82, 23);
            this.ConnectionsBtn.TabIndex = 5;
            this.ConnectionsBtn.Text = "Verbindungen";
            this.ConnectionsBtn.UseVisualStyleBackColor = true;
            this.ConnectionsBtn.Click += new System.EventHandler(this.OnConnectionsClick);
            // 
            // ConnectionLstBox
            // 
            this.ConnectionLstBox.FormattingEnabled = true;
            this.ConnectionLstBox.Location = new System.Drawing.Point(141, 250);
            this.ConnectionLstBox.Name = "ConnectionLstBox";
            this.ConnectionLstBox.Size = new System.Drawing.Size(567, 147);
            this.ConnectionLstBox.TabIndex = 6;
            // 
            // Connections
            // 
            this.Connections.AutoSize = true;
            this.Connections.Location = new System.Drawing.Point(138, 234);
            this.Connections.Name = "Connections";
            this.Connections.Size = new System.Drawing.Size(73, 13);
            this.Connections.TabIndex = 7;
            this.Connections.Text = "Verbindungen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Startstation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Zielstation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ArrivalTxt);
            this.groupBox1.Controls.Add(this.StartTxt);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(141, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // StationBoardBtn
            // 
            this.StationBoardBtn.Location = new System.Drawing.Point(531, 155);
            this.StationBoardBtn.Name = "StationBoardBtn";
            this.StationBoardBtn.Size = new System.Drawing.Size(82, 23);
            this.StationBoardBtn.TabIndex = 11;
            this.StationBoardBtn.Text = "Station Board";
            this.StationBoardBtn.UseVisualStyleBackColor = true;
            this.StationBoardBtn.Click += new System.EventHandler(this.OnStationBoardClick);
            // 
            // StartLstBox
            // 
            this.StartLstBox.FormattingEnabled = true;
            this.StartLstBox.Location = new System.Drawing.Point(141, 97);
            this.StartLstBox.Name = "StartLstBox";
            this.StartLstBox.Size = new System.Drawing.Size(174, 121);
            this.StartLstBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartLstBox);
            this.Controls.Add(this.StationBoardBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Connections);
            this.Controls.Add(this.ConnectionLstBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectionsBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ArrivalLstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartTxt;
        private System.Windows.Forms.TextBox ArrivalTxt;
        private System.Windows.Forms.ListBox ArrivalLstBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ConnectionsBtn;
        private System.Windows.Forms.ListBox ConnectionLstBox;
        private System.Windows.Forms.Label Connections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StationBoardBtn;
        private System.Windows.Forms.ListBox StartLstBox;
    }
}

