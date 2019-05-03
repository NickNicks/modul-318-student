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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartTxt = new System.Windows.Forms.TextBox();
            this.ArrivalTxt = new System.Windows.Forms.TextBox();
            this.ArrivalLstBox = new System.Windows.Forms.ListBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ConnectionsBtn = new System.Windows.Forms.Button();
            this.ConnectionsLbl = new System.Windows.Forms.Label();
            this.StartLbl = new System.Windows.Forms.Label();
            this.ArrivalLbl = new System.Windows.Forms.Label();
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
            this.CentralLstViw = new System.Windows.Forms.ListView();
            this.PanelForRadioBtn.SuspendLayout();
            this.PanelForTxtBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartTxt
            // 
            this.StartTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.StartTxt.Location = new System.Drawing.Point(0, 4);
            this.StartTxt.Name = "StartTxt";
            this.StartTxt.Size = new System.Drawing.Size(133, 26);
            this.StartTxt.TabIndex = 0;
            this.StartTxt.TextChanged += new System.EventHandler(this.OnStartTxtChange);
            this.StartTxt.Enter += new System.EventHandler(this.OnStartTxtEnter);
            this.StartTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnStartTxtKeyDown);
            this.StartTxt.Leave += new System.EventHandler(this.OnStartTxtLeave);
            // 
            // ArrivalTxt
            // 
            this.ArrivalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalTxt.Location = new System.Drawing.Point(275, 3);
            this.ArrivalTxt.Name = "ArrivalTxt";
            this.ArrivalTxt.Size = new System.Drawing.Size(133, 26);
            this.ArrivalTxt.TabIndex = 1;
            this.ArrivalTxt.TextChanged += new System.EventHandler(this.OnArrivalTxtChange);
            this.ArrivalTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnArrivalTxtKeyDown);
            // 
            // ArrivalLstBox
            // 
            this.ArrivalLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.7F);
            this.ArrivalLstBox.FormattingEnabled = true;
            this.ArrivalLstBox.ItemHeight = 20;
            this.ArrivalLstBox.Location = new System.Drawing.Point(297, 85);
            this.ArrivalLstBox.Name = "ArrivalLstBox";
            this.ArrivalLstBox.Size = new System.Drawing.Size(239, 124);
            this.ArrivalLstBox.TabIndex = 14;
            this.ArrivalLstBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnArrivalLstBoxKeyDown);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(732, 76);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(154, 41);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Stationen Suchen";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.OnSearchClick);
            // 
            // ConnectionsBtn
            // 
            this.ConnectionsBtn.Location = new System.Drawing.Point(732, 123);
            this.ConnectionsBtn.Name = "ConnectionsBtn";
            this.ConnectionsBtn.Size = new System.Drawing.Size(154, 41);
            this.ConnectionsBtn.TabIndex = 5;
            this.ConnectionsBtn.Text = "Verbindungen Suchen";
            this.ConnectionsBtn.UseVisualStyleBackColor = true;
            this.ConnectionsBtn.Click += new System.EventHandler(this.OnConnectionsClick);
            // 
            // ConnectionsLbl
            // 
            this.ConnectionsLbl.AutoSize = true;
            this.ConnectionsLbl.Location = new System.Drawing.Point(19, 219);
            this.ConnectionsLbl.Name = "ConnectionsLbl";
            this.ConnectionsLbl.Size = new System.Drawing.Size(138, 13);
            this.ConnectionsLbl.TabIndex = 7;
            this.ConnectionsLbl.Text = "Verbindungen/Stationboard";
            // 
            // StartLbl
            // 
            this.StartLbl.AutoSize = true;
            this.StartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartLbl.Location = new System.Drawing.Point(19, 33);
            this.StartLbl.Name = "StartLbl";
            this.StartLbl.Size = new System.Drawing.Size(80, 17);
            this.StartLbl.TabIndex = 8;
            this.StartLbl.Text = "Startstation";
            // 
            // ArrivalLbl
            // 
            this.ArrivalLbl.AutoSize = true;
            this.ArrivalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ArrivalLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ArrivalLbl.Location = new System.Drawing.Point(294, 35);
            this.ArrivalLbl.Name = "ArrivalLbl";
            this.ArrivalLbl.Size = new System.Drawing.Size(73, 17);
            this.ArrivalLbl.TabIndex = 9;
            this.ArrivalLbl.Text = "Zielstation";
            // 
            // StationBoardBtn
            // 
            this.StationBoardBtn.BackColor = System.Drawing.Color.Transparent;
            this.StationBoardBtn.Location = new System.Drawing.Point(732, 167);
            this.StationBoardBtn.Name = "StationBoardBtn";
            this.StationBoardBtn.Size = new System.Drawing.Size(154, 41);
            this.StationBoardBtn.TabIndex = 11;
            this.StationBoardBtn.Text = "Stationboard Anzeigen";
            this.StationBoardBtn.UseVisualStyleBackColor = false;
            this.StationBoardBtn.Click += new System.EventHandler(this.OnStationBoardClick);
            // 
            // StartLstBox
            // 
            this.StartLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.7F);
            this.StartLstBox.FormattingEnabled = true;
            this.StartLstBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartLstBox.ItemHeight = 20;
            this.StartLstBox.Location = new System.Drawing.Point(22, 85);
            this.StartLstBox.Name = "StartLstBox";
            this.StartLstBox.Size = new System.Drawing.Size(239, 124);
            this.StartLstBox.TabIndex = 12;
            this.StartLstBox.Click += new System.EventHandler(this.OnStartLstBoxClick);
            this.StartLstBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnStartLstBoxKeyDown);
            // 
            // PanelForRadioBtn
            // 
            this.PanelForRadioBtn.Controls.Add(this.LaterRadio);
            this.PanelForRadioBtn.Controls.Add(this.NowRadio);
            this.PanelForRadioBtn.Location = new System.Drawing.Point(581, 85);
            this.PanelForRadioBtn.Name = "PanelForRadioBtn";
            this.PanelForRadioBtn.Size = new System.Drawing.Size(121, 49);
            this.PanelForRadioBtn.TabIndex = 13;
            // 
            // LaterRadio
            // 
            this.LaterRadio.AutoSize = true;
            this.LaterRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LaterRadio.Location = new System.Drawing.Point(3, 26);
            this.LaterRadio.Name = "LaterRadio";
            this.LaterRadio.Size = new System.Drawing.Size(101, 17);
            this.LaterRadio.TabIndex = 1;
            this.LaterRadio.TabStop = true;
            this.LaterRadio.Text = "Späteres Datum";
            this.LaterRadio.UseVisualStyleBackColor = true;
            this.LaterRadio.CheckedChanged += new System.EventHandler(this.OnRadioCheckChange);
            // 
            // NowRadio
            // 
            this.NowRadio.AutoSize = true;
            this.NowRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NowRadio.Location = new System.Drawing.Point(3, 3);
            this.NowRadio.Name = "NowRadio";
            this.NowRadio.Size = new System.Drawing.Size(93, 17);
            this.NowRadio.TabIndex = 0;
            this.NowRadio.TabStop = true;
            this.NowRadio.Text = "Jetzt Abfahren";
            this.NowRadio.UseVisualStyleBackColor = true;
            this.NowRadio.CheckedChanged += new System.EventHandler(this.OnRadioCheckChange);
            // 
            // PanelForTxtBox
            // 
            this.PanelForTxtBox.Controls.Add(this.StartTxt);
            this.PanelForTxtBox.Controls.Add(this.ArrivalTxt);
            this.PanelForTxtBox.Location = new System.Drawing.Point(22, 52);
            this.PanelForTxtBox.Name = "PanelForTxtBox";
            this.PanelForTxtBox.Size = new System.Drawing.Size(428, 32);
            this.PanelForTxtBox.TabIndex = 14;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(569, 169);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(133, 20);
            this.DateBox.TabIndex = 19;
            // 
            // HourTxt
            // 
            this.HourTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.HourTxt.Location = new System.Drawing.Point(601, 143);
            this.HourTxt.MaxLength = 2;
            this.HourTxt.Name = "HourTxt";
            this.HourTxt.Size = new System.Drawing.Size(31, 20);
            this.HourTxt.TabIndex = 18;
            this.HourTxt.Text = "hh";
            this.HourTxt.Enter += new System.EventHandler(this.OnHourTxtEnter);
            this.HourTxt.Leave += new System.EventHandler(this.OnHourTxtLeave);
            // 
            // MinuteTxt
            // 
            this.MinuteTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MinuteTxt.Location = new System.Drawing.Point(638, 143);
            this.MinuteTxt.MaxLength = 2;
            this.MinuteTxt.Name = "MinuteTxt";
            this.MinuteTxt.Size = new System.Drawing.Size(31, 20);
            this.MinuteTxt.TabIndex = 17;
            this.MinuteTxt.Text = "mm";
            this.MinuteTxt.Enter += new System.EventHandler(this.OnMinuteEnter);
            this.MinuteTxt.Leave += new System.EventHandler(this.OnMinuteLeave);
            // 
            // LocalMapsBtn
            // 
            this.LocalMapsBtn.Location = new System.Drawing.Point(732, 310);
            this.LocalMapsBtn.Name = "LocalMapsBtn";
            this.LocalMapsBtn.Size = new System.Drawing.Size(154, 41);
            this.LocalMapsBtn.TabIndex = 19;
            this.LocalMapsBtn.Text = "Lokale Karte Anzeigen";
            this.LocalMapsBtn.UseVisualStyleBackColor = true;
            this.LocalMapsBtn.Click += new System.EventHandler(this.OnLocalMapsBtnClick);
            // 
            // StationMapBtn
            // 
            this.StationMapBtn.Location = new System.Drawing.Point(732, 235);
            this.StationMapBtn.Name = "StationMapBtn";
            this.StationMapBtn.Size = new System.Drawing.Size(154, 41);
            this.StationMapBtn.TabIndex = 20;
            this.StationMapBtn.TabStop = false;
            this.StationMapBtn.Text = "Starttation Bei Maps Anzeigen";
            this.StationMapBtn.UseVisualStyleBackColor = true;
            this.StationMapBtn.Click += new System.EventHandler(this.OnStationMapBtnClick);
            // 
            // EmailShareBtn
            // 
            this.EmailShareBtn.Location = new System.Drawing.Point(732, 355);
            this.EmailShareBtn.Name = "EmailShareBtn";
            this.EmailShareBtn.Size = new System.Drawing.Size(154, 40);
            this.EmailShareBtn.TabIndex = 21;
            this.EmailShareBtn.Text = "Email Share";
            this.EmailShareBtn.UseVisualStyleBackColor = true;
            this.EmailShareBtn.Click += new System.EventHandler(this.OnEmailShareBtnClick);
            // 
            // SwitchBtn
            // 
            this.SwitchBtn.Location = new System.Drawing.Point(456, 57);
            this.SwitchBtn.Name = "SwitchBtn";
            this.SwitchBtn.Size = new System.Drawing.Size(54, 25);
            this.SwitchBtn.TabIndex = 22;
            this.SwitchBtn.Text = "<->";
            this.SwitchBtn.UseVisualStyleBackColor = true;
            this.SwitchBtn.Click += new System.EventHandler(this.OnSwitchBtnClick);
            // 
            // CentralLstViw
            // 
            this.CentralLstViw.Cursor = System.Windows.Forms.Cursors.Default;
            this.CentralLstViw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CentralLstViw.FullRowSelect = true;
            this.CentralLstViw.GridLines = true;
            this.CentralLstViw.HideSelection = false;
            this.CentralLstViw.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.CentralLstViw.Location = new System.Drawing.Point(22, 235);
            this.CentralLstViw.MultiSelect = false;
            this.CentralLstViw.Name = "CentralLstViw";
            this.CentralLstViw.Size = new System.Drawing.Size(666, 179);
            this.CentralLstViw.TabIndex = 23;
            this.CentralLstViw.UseCompatibleStateImageBehavior = false;
            this.CentralLstViw.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(921, 472);
            this.Controls.Add(this.CentralLstViw);
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
            this.Controls.Add(this.ArrivalLbl);
            this.Controls.Add(this.ConnectionsLbl);
            this.Controls.Add(this.StartLbl);
            this.Controls.Add(this.ConnectionsBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ArrivalLstBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Offizielle Nicht-SBB App";
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
        private System.Windows.Forms.Label ConnectionsLbl;
        private System.Windows.Forms.Label StartLbl;
        private System.Windows.Forms.Label ArrivalLbl;
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
        private System.Windows.Forms.ListView CentralLstViw;
    }
}

