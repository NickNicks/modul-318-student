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
            this.StationBoardBtn = new System.Windows.Forms.Button();
            this.StartLstBox = new System.Windows.Forms.ListBox();
            this.PanelForRadioBtn = new System.Windows.Forms.Panel();
            this.LaterRadio = new System.Windows.Forms.RadioButton();
            this.NowRadio = new System.Windows.Forms.RadioButton();
            this.PanelForTxtBox = new System.Windows.Forms.Panel();
            this.DateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.PanelForRadioBtn.SuspendLayout();
            this.PanelForTxtBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartTxt
            // 
            this.StartTxt.Location = new System.Drawing.Point(0, 4);
            this.StartTxt.Name = "StartTxt";
            this.StartTxt.Size = new System.Drawing.Size(100, 20);
            this.StartTxt.TabIndex = 0;
            this.StartTxt.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // ArrivalTxt
            // 
            this.ArrivalTxt.Location = new System.Drawing.Point(184, 4);
            this.ArrivalTxt.Name = "ArrivalTxt";
            this.ArrivalTxt.Size = new System.Drawing.Size(100, 20);
            this.ArrivalTxt.TabIndex = 1;
            this.ArrivalTxt.TextChanged += new System.EventHandler(this.OnTextChange);
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
            this.SearchBtn.Location = new System.Drawing.Point(531, 139);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(154, 23);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Stationen Suchen";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.OnSearchClick);
            // 
            // ConnectionsBtn
            // 
            this.ConnectionsBtn.Location = new System.Drawing.Point(531, 168);
            this.ConnectionsBtn.Name = "ConnectionsBtn";
            this.ConnectionsBtn.Size = new System.Drawing.Size(154, 23);
            this.ConnectionsBtn.TabIndex = 5;
            this.ConnectionsBtn.Text = "Verbindungen Suchen";
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
            this.label1.Location = new System.Drawing.Point(138, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Startstation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Zielstation";
            // 
            // StationBoardBtn
            // 
            this.StationBoardBtn.Location = new System.Drawing.Point(531, 197);
            this.StationBoardBtn.Name = "StationBoardBtn";
            this.StationBoardBtn.Size = new System.Drawing.Size(154, 23);
            this.StationBoardBtn.TabIndex = 11;
            this.StationBoardBtn.Text = "Stationboard Anzeigen";
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
            // PanelForRadioBtn
            // 
            this.PanelForRadioBtn.Controls.Add(this.LaterRadio);
            this.PanelForRadioBtn.Controls.Add(this.NowRadio);
            this.PanelForRadioBtn.Location = new System.Drawing.Point(531, 39);
            this.PanelForRadioBtn.Name = "PanelForRadioBtn";
            this.PanelForRadioBtn.Size = new System.Drawing.Size(121, 49);
            this.PanelForRadioBtn.TabIndex = 13;
            // 
            // LaterRadio
            // 
            this.LaterRadio.AutoSize = true;
            this.LaterRadio.Location = new System.Drawing.Point(3, 26);
            this.LaterRadio.Name = "LaterRadio";
            this.LaterRadio.Size = new System.Drawing.Size(102, 17);
            this.LaterRadio.TabIndex = 1;
            this.LaterRadio.TabStop = true;
            this.LaterRadio.Text = "Späteren Datum";
            this.LaterRadio.UseVisualStyleBackColor = true;
            this.LaterRadio.CheckedChanged += new System.EventHandler(this.OnRadioCheckChange);
            // 
            // NowRadio
            // 
            this.NowRadio.AutoSize = true;
            this.NowRadio.Location = new System.Drawing.Point(3, 3);
            this.NowRadio.Name = "NowRadio";
            this.NowRadio.Size = new System.Drawing.Size(47, 17);
            this.NowRadio.TabIndex = 0;
            this.NowRadio.TabStop = true;
            this.NowRadio.Text = "Jetzt";
            this.NowRadio.UseVisualStyleBackColor = true;
            this.NowRadio.CheckedChanged += new System.EventHandler(this.OnRadioCheckChange);
            // 
            // PanelForTxtBox
            // 
            this.PanelForTxtBox.Controls.Add(this.StartTxt);
            this.PanelForTxtBox.Controls.Add(this.ArrivalTxt);
            this.PanelForTxtBox.Location = new System.Drawing.Point(141, 64);
            this.PanelForTxtBox.Name = "PanelForTxtBox";
            this.PanelForTxtBox.Size = new System.Drawing.Size(320, 27);
            this.PanelForTxtBox.TabIndex = 14;
            // 
            // DateTimeBox
            // 
            this.DateTimeBox.Location = new System.Drawing.Point(531, 97);
            this.DateTimeBox.Name = "DateTimeBox";
            this.DateTimeBox.Size = new System.Drawing.Size(200, 20);
            this.DateTimeBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 439);
            this.Controls.Add(this.DateTimeBox);
            this.Controls.Add(this.PanelForTxtBox);
            this.Controls.Add(this.PanelForRadioBtn);
            this.Controls.Add(this.StartLstBox);
            this.Controls.Add(this.StationBoardBtn);
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
            this.PanelForRadioBtn.ResumeLayout(false);
            this.PanelForRadioBtn.PerformLayout();
            this.PanelForTxtBox.ResumeLayout(false);
            this.PanelForTxtBox.PerformLayout();
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
        private System.Windows.Forms.Button StationBoardBtn;
        private System.Windows.Forms.ListBox StartLstBox;
        private System.Windows.Forms.Panel PanelForRadioBtn;
        private System.Windows.Forms.RadioButton LaterRadio;
        private System.Windows.Forms.RadioButton NowRadio;
        private System.Windows.Forms.Panel PanelForTxtBox;
        private System.Windows.Forms.DateTimePicker DateTimeBox;
    }
}

