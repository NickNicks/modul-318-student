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
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.HourTxt = new System.Windows.Forms.TextBox();
            this.MinuteTxt = new System.Windows.Forms.TextBox();
            this.LocalMapsBtn = new System.Windows.Forms.Button();
            this.StationMapBtn = new System.Windows.Forms.Button();
            this.EmailShareBtn = new System.Windows.Forms.Button();
            this.SwitchBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanelForRadioBtn.SuspendLayout();
            this.PanelForTxtBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartTxt
            // 
            this.StartTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTxt.Location = new System.Drawing.Point(0, 4);
            this.StartTxt.Name = "StartTxt";
            this.StartTxt.Size = new System.Drawing.Size(100, 26);
            this.StartTxt.TabIndex = 0;
            this.StartTxt.TextChanged += new System.EventHandler(this.OnStartTxtChange);
            // 
            // ArrivalTxt
            // 
            this.ArrivalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalTxt.Location = new System.Drawing.Point(249, 4);
            this.ArrivalTxt.Name = "ArrivalTxt";
            this.ArrivalTxt.Size = new System.Drawing.Size(100, 26);
            this.ArrivalTxt.TabIndex = 1;
            this.ArrivalTxt.TextChanged += new System.EventHandler(this.OnArrivalTxtChange);
            // 
            // ArrivalLstBox
            // 
            this.ArrivalLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalLstBox.FormattingEnabled = true;
            this.ArrivalLstBox.ItemHeight = 20;
            this.ArrivalLstBox.Location = new System.Drawing.Point(325, 97);
            this.ArrivalLstBox.Name = "ArrivalLstBox";
            this.ArrivalLstBox.Size = new System.Drawing.Size(239, 124);
            this.ArrivalLstBox.TabIndex = 3;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(665, 139);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(154, 23);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Stationen Suchen";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.OnSearchClick);
            // 
            // ConnectionsBtn
            // 
            this.ConnectionsBtn.Location = new System.Drawing.Point(665, 168);
            this.ConnectionsBtn.Name = "ConnectionsBtn";
            this.ConnectionsBtn.Size = new System.Drawing.Size(154, 23);
            this.ConnectionsBtn.TabIndex = 5;
            this.ConnectionsBtn.Text = "Verbindungen Suchen";
            this.ConnectionsBtn.UseVisualStyleBackColor = true;
            this.ConnectionsBtn.Click += new System.EventHandler(this.OnConnectionsClick);
            // 
            // ConnectionLstBox
            // 
            this.ConnectionLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.ConnectionLstBox.FormattingEnabled = true;
            this.ConnectionLstBox.ItemHeight = 26;
            this.ConnectionLstBox.Location = new System.Drawing.Point(76, 262);
            this.ConnectionLstBox.Name = "ConnectionLstBox";
            this.ConnectionLstBox.Size = new System.Drawing.Size(566, 134);
            this.ConnectionLstBox.TabIndex = 6;
            // 
            // Connections
            // 
            this.Connections.AutoSize = true;
            this.Connections.Location = new System.Drawing.Point(73, 246);
            this.Connections.Name = "Connections";
            this.Connections.Size = new System.Drawing.Size(73, 13);
            this.Connections.TabIndex = 7;
            this.Connections.Text = "Verbindungen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
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
            this.StationBoardBtn.Location = new System.Drawing.Point(665, 197);
            this.StationBoardBtn.Name = "StationBoardBtn";
            this.StationBoardBtn.Size = new System.Drawing.Size(154, 23);
            this.StationBoardBtn.TabIndex = 11;
            this.StationBoardBtn.Text = "Stationboard Anzeigen";
            this.StationBoardBtn.UseVisualStyleBackColor = true;
            this.StationBoardBtn.Click += new System.EventHandler(this.OnStationBoardClick);
            // 
            // StartLstBox
            // 
            this.StartLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLstBox.FormattingEnabled = true;
            this.StartLstBox.ItemHeight = 20;
            this.StartLstBox.Location = new System.Drawing.Point(76, 97);
            this.StartLstBox.Name = "StartLstBox";
            this.StartLstBox.Size = new System.Drawing.Size(239, 124);
            this.StartLstBox.TabIndex = 12;
            // 
            // PanelForRadioBtn
            // 
            this.PanelForRadioBtn.Controls.Add(this.LaterRadio);
            this.PanelForRadioBtn.Controls.Add(this.NowRadio);
            this.PanelForRadioBtn.Location = new System.Drawing.Point(665, 25);
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
            this.PanelForTxtBox.Location = new System.Drawing.Point(76, 64);
            this.PanelForTxtBox.Name = "PanelForTxtBox";
            this.PanelForTxtBox.Size = new System.Drawing.Size(385, 32);
            this.PanelForTxtBox.TabIndex = 14;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(665, 109);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(133, 20);
            this.DateBox.TabIndex = 16;
            // 
            // HourTxt
            // 
            this.HourTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.HourTxt.Location = new System.Drawing.Point(665, 83);
            this.HourTxt.MaxLength = 2;
            this.HourTxt.Name = "HourTxt";
            this.HourTxt.Size = new System.Drawing.Size(31, 20);
            this.HourTxt.TabIndex = 17;
            this.HourTxt.Text = "hh";
            this.HourTxt.Enter += new System.EventHandler(this.OnHourTxtEnter);
            this.HourTxt.Leave += new System.EventHandler(this.OnHourTxtLeave);
            // 
            // MinuteTxt
            // 
            this.MinuteTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MinuteTxt.Location = new System.Drawing.Point(702, 83);
            this.MinuteTxt.MaxLength = 2;
            this.MinuteTxt.Name = "MinuteTxt";
            this.MinuteTxt.Size = new System.Drawing.Size(31, 20);
            this.MinuteTxt.TabIndex = 18;
            this.MinuteTxt.Text = "mm";
            this.MinuteTxt.Enter += new System.EventHandler(this.OnMinuteEnter);
            // 
            // LocalMapsBtn
            // 
            this.LocalMapsBtn.Location = new System.Drawing.Point(665, 226);
            this.LocalMapsBtn.Name = "LocalMapsBtn";
            this.LocalMapsBtn.Size = new System.Drawing.Size(154, 23);
            this.LocalMapsBtn.TabIndex = 19;
            this.LocalMapsBtn.Text = "Lokale Karte Anzeigen";
            this.LocalMapsBtn.UseVisualStyleBackColor = true;
            this.LocalMapsBtn.Click += new System.EventHandler(this.OnLocalMapsBtnClick);
            // 
            // StationMapBtn
            // 
            this.StationMapBtn.Location = new System.Drawing.Point(662, 291);
            this.StationMapBtn.Name = "StationMapBtn";
            this.StationMapBtn.Size = new System.Drawing.Size(154, 47);
            this.StationMapBtn.TabIndex = 20;
            this.StationMapBtn.Text = "Station Bei Maps Anzeigen";
            this.StationMapBtn.UseVisualStyleBackColor = true;
            this.StationMapBtn.Click += new System.EventHandler(this.OnStationMapBtnClick);
            // 
            // EmailShareBtn
            // 
            this.EmailShareBtn.Location = new System.Drawing.Point(662, 344);
            this.EmailShareBtn.Name = "EmailShareBtn";
            this.EmailShareBtn.Size = new System.Drawing.Size(154, 47);
            this.EmailShareBtn.TabIndex = 21;
            this.EmailShareBtn.Text = "Email Share";
            this.EmailShareBtn.UseVisualStyleBackColor = true;
            this.EmailShareBtn.Click += new System.EventHandler(this.OnEmailShareBtnClick);
            // 
            // SwitchBtn
            // 
            this.SwitchBtn.Location = new System.Drawing.Point(217, 39);
            this.SwitchBtn.Name = "SwitchBtn";
            this.SwitchBtn.Size = new System.Drawing.Size(54, 25);
            this.SwitchBtn.TabIndex = 22;
            this.SwitchBtn.Text = "<->";
            this.SwitchBtn.UseVisualStyleBackColor = true;
            this.SwitchBtn.Click += new System.EventHandler(this.OnSwitchBtnClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(76, 428);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(566, 131);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "hello";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "wa";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "ga";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 590);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SwitchBtn);
            this.Controls.Add(this.EmailShareBtn);
            this.Controls.Add(this.StationMapBtn);
            this.Controls.Add(this.LocalMapsBtn);
            this.Controls.Add(this.MinuteTxt);
            this.Controls.Add(this.HourTxt);
            this.Controls.Add(this.DateBox);
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
            this.Load += new System.EventHandler(this.OnFormLoad);
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
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.TextBox HourTxt;
        private System.Windows.Forms.TextBox MinuteTxt;
        private System.Windows.Forms.Button LocalMapsBtn;
        private System.Windows.Forms.Button StationMapBtn;
        private System.Windows.Forms.Button EmailShareBtn;
        private System.Windows.Forms.Button SwitchBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

