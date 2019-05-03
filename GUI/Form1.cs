using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Globalization;
using System.Diagnostics;
using System.Device.Location;


namespace GUI
{
    public partial class Form1 : Form
    {
        private Transport T = new Transport();
        private GeoCoordinateWatcher Watcher = new GeoCoordinateWatcher();
        private bool StartTxtPreview = true;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Fragt Die API nach Stationen und füllt die respektive (Arrival/Start) ListBox
        /// </summary>
        public void GetListStations(TextBox Box)
        {
            Stations StationList = T.GetStations(Box.Text);
            List<string> StartList = new List<string>();
            foreach (Station SearchedStation in StationList.StationList)
            {
                if (SearchedStation.Id != null) 
                StartList.Add(SearchedStation.Name);
            }
            if (Box.Name == "StartTxt")
            {
                StartLstBox.DataSource = null;
                StartLstBox.DataSource = StartList;
            }
            if (Box.Name == "ArrivalTxt")
            {
                ArrivalLstBox.DataSource = null;
                ArrivalLstBox.DataSource = StartList;
            }
        }
        /// <summary>
        /// Vervollstaendigt die Labels über die respektive (Arrival/Start) TextBox mit die Namen der Station
        /// </summary>
        private void StartLabelUpdate(ListBox LstBox, Keys Key)
        {
            String StringKey = Key.ToString();

            if (LstBox.SelectedIndex < LstBox.Items.Count - 1 && StringKey == "Down")
                LstBox.SelectedIndex++;

            if (LstBox.SelectedIndex > -1 && StringKey == "Up")
                LstBox.SelectedIndex--;

            if (LstBox.SelectedIndex >= 0 && LstBox.Name == "StartLstBox")
                StartLbl.Text = "Startstation:" + LstBox.SelectedItem.ToString();

            if ((LstBox.SelectedIndex == -1 || StartTxt.Text == "") && LstBox.Name == "StartLstBox")
                StartLbl.Text = "Startstation";

            if (LstBox.SelectedIndex >= 0 && LstBox.Name == "ArrivalLstBox")
                ArrivalLbl.Text = "Zielstation:" + LstBox.SelectedItem.ToString();

            if ((LstBox.SelectedIndex == -1 || ArrivalTxt.Text == "") && LstBox.Name == "ArrivalLstBox")
                ArrivalLbl.Text = "Zielstation";
        }
        /// <summary>
        /// Prueft ob es Text Hat in die TextBox, und Schaltet Ein/Ab die respektive (Connections/StationBoard) Buttons
        /// </summary>
        private void TextExistProof()
        {
            Form form1 = new Form1();
            if (ArrivalTxt.TextLength > 0 && StartTxt.TextLength > 0)
            {
                ConnectionsBtn.Enabled = true;
                ConnectionsBtn.BackColor = Color.PaleGreen;
                form1.AcceptButton = ConnectionsBtn;
            }        
            else
            { 
                    ConnectionsBtn.Enabled = false;
                    ConnectionsBtn.BackColor = Color.Transparent;
            }
            if (ArrivalTxt.TextLength <= 0 && StartTxt.TextLength > 0)
            {
                StationBoardBtn.Enabled = true;
                StationBoardBtn.BackColor = Color.PaleGreen;
                form1.AcceptButton = StationBoardBtn;
            }
            else
            {
                StationBoardBtn.BackColor = Color.Transparent;
                StationBoardBtn.Enabled = false;
            }
            if (ArrivalTxt.TextLength == 0)
                ArrivalLstBox.DataSource = null;
            if (StartTxt.TextLength == 0)
                StartLstBox.DataSource = null;
        }
        /// <summary>
        /// Prueft welchen RadioButton Selektiert ist
        /// </summary>
        private void RadioBtnCheck()
        {
            if (NowRadio.Checked)
            {
                HourTxt.Enabled = false;
                MinuteTxt.Enabled = false;
                DateBox.Enabled = false;
            }
            else
            {
                HourTxt.Enabled = true;
                MinuteTxt.Enabled = true;
                DateBox.Enabled = true;
            }
        }
        private void OnFormLoad(object sender, EventArgs e)
        {
            ArrivalLstBox.Items.Add("Um Verbindungen zu suchen,");
            ArrivalLstBox.Items.Add("Ziel Text Box auch ausfüllen");
            StartLstBox.Items.Add("Um die Stationboard anzuzeigen");
            StartLstBox.Items.Add("zuerst Station hier suchen und");
            StartLstBox.Items.Add("auswählen");
            StartTxt.Text = "Tippe Hier";

            NowRadio.Checked = true;
            ConnectionsBtn.Enabled = false;
            StationBoardBtn.Enabled = false;
            StationBoardBtn.BackColor = Color.Transparent;
            RadioBtnCheck();

            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.AutoPopDelay = 5000;
            ToolTip1.InitialDelay = 500;
            ToolTip1.ReshowDelay = 500;
            ToolTip1.ShowAlways = true;
            ToolTip1.SetToolTip(this.SwitchBtn, "Wechselt Abfahrt und Ankunfts Suchbegriffen");
        }

        private void OnConnectionsClick(object sender, EventArgs e)
        {
            //Kontrolliert ob 2 Stationen Selektiert sind
            if (StartLstBox.SelectedIndex >= 0 && ArrivalLstBox.SelectedIndex >= 0)
            {   
                
                string Time = DateTime.Now.ToString("HH:mm");

                //Kontrolliert ob LaterRadio Selektiert ist, falls nicht wird die Verbindungsabfrage mit DateTime.Now Geführt
                if (LaterRadio.Checked)
                {
                    //Prueft ob eingabe eigentlich minuten und stunden ist
                    bool HourValid = int.TryParse(HourTxt.Text, out int Hour);
                    bool MinuteValid = int.TryParse(MinuteTxt.Text, out int Minute);

                    if (HourValid == false && MinuteValid == false)
                    {
                        MessageBox.Show("Bitte Geben Sie Eine Zahl Ein");
                        return;
                    }

                    if (Hour <= 0 || Hour >= 24 || Minute <= 0 || Minute >= 60)
                    {
                        MessageBox.Show("Bitte Geben Sie Eine Richtige Zahl Ein");
                        return;
                    }
                    // Verbindung Stunden und Minuten TextBox
                    Time = HourTxt.Text + ":" + MinuteTxt.Text;                    
                }
                
                DateTime DateTemp = DateTime.ParseExact((DateBox.Value.Date).ToString(), "dd/MM/yyyy HH:mm:ss", null);
                String Date = DateTemp.ToString("yyyy/MM/dd");
                Connections SearchedConnections = T.GetConnections(Convert.ToString(StartLstBox.SelectedItem), Convert.ToString(ArrivalLstBox.SelectedItem), Time, Convert.ToString(Date));
                //Generiert Neue Listview mit Spalten
                CentralLstViw.Items.Clear();
                CentralLstViw.Columns.Clear();
                CentralLstViw.Columns.Add("", 2, HorizontalAlignment.Left);
                CentralLstViw.Columns.Add("Abfahrt", 100, HorizontalAlignment.Left);
                CentralLstViw.Columns.Add("Ankunft", 100, HorizontalAlignment.Left);
                CentralLstViw.Columns.Add("Dauer", 100, HorizontalAlignment.Left);
                CentralLstViw.Columns.Add("Gleis", 100, HorizontalAlignment.Left);
                CentralLstViw.Columns.Add("Verspätung", 100, HorizontalAlignment.Left);

                //Fuellung der Listview
                foreach (Connection ConnectionItem in SearchedConnections.ConnectionList)
                {
                    DateTime Departure = DateTime.Parse(ConnectionItem.From.Departure);
                    DateTime Arrival = DateTime.Parse(ConnectionItem.To.Arrival);
                    ListViewItem ConnectionView = new ListViewItem();

                    ConnectionView.SubItems.Add(Departure.ToShortTimeString());
                    ConnectionView.SubItems.Add(Arrival.ToShortTimeString());
                    ConnectionView.SubItems.Add(ConnectionItem.Duration.Replace("00d", ""));
                    ConnectionView.SubItems.Add(ConnectionItem.From.Platform);
                    ConnectionView.SubItems.Add(ConnectionItem.From.Delay.ToString());

                    CentralLstViw.Items.Add(ConnectionView);
                }
            }
            else
            {
                MessageBox.Show("Bitte Zwei Stationen Auswählen");
            }
        }

        private void OnStationBoardClick(object sender, EventArgs e)
        {
            Stations S = T.GetStations(StartTxt.Text);
            if (StartLstBox.SelectedIndex >= 0)
            {
                //Generiert Neue Listview mit Spalten und fragt die AP nach die Stationboard
                Station WantedStation = S.StationList[StartLstBox.SelectedIndex];
                StationBoardRoot SearchedStationBoard = T.GetStationBoard(WantedStation.Name, WantedStation.Id);

                CentralLstViw.Items.Clear();
                CentralLstViw.Columns.Clear();
                CentralLstViw.Columns.Add("", 2, HorizontalAlignment.Left);
                CentralLstViw.Columns.Add("Kategorie", 100, HorizontalAlignment.Left);
                CentralLstViw.Columns.Add("Nummer", 100, HorizontalAlignment.Left);
                CentralLstViw.Columns.Add("Bis", 135, HorizontalAlignment.Left);
                CentralLstViw.Columns.Add("Operator", 100, HorizontalAlignment.Left);
                CentralLstViw.Columns.Add("Abfahrt", 100, HorizontalAlignment.Left);

                //Fuellung der Listview
                foreach (StationBoard StationBoardTemp in SearchedStationBoard.Entries)
                {
                    ListViewItem Connection = new ListViewItem();

                    Connection.SubItems.Add(StationBoardTemp.Category);
                    Connection.SubItems.Add(StationBoardTemp.Number);
                    Connection.SubItems.Add(StationBoardTemp.To);
                    Connection.SubItems.Add(StationBoardTemp.Operator);
                    Connection.SubItems.Add(StationBoardTemp.Stop.Departure.ToShortTimeString());

                    CentralLstViw.Items.Add(Connection);
                }
            }
            else
            {
                MessageBox.Show("Keine Station ausgewählt");
            }     
        }

        //Oeffnet Search.ch maps in der Naehe der Selektierte Station
        private void OnStationMapBtnClick(object sender, EventArgs e)
        {
            if (StartLstBox.SelectedIndex != -1)
            {
                string Query = StartLstBox.SelectedItem.ToString();
                Query.Replace(" ", "+");
                System.Diagnostics.Process.Start("https://map.search.ch/" + Query + "?poi=haltestelle,zug&z=256");
            }
            else
            {
                MessageBox.Show("Keine Station Ausgewählt");
            }
        }

        //Generiert Mail Mit Infos ueber selektiertes Verbindung/Fahrt
        private void OnEmailShareBtnClick(object sender, EventArgs e)
        {
            if (CentralLstViw.SelectedItems.Count != 0)
            {
                ListViewItem Item = CentralLstViw.SelectedItems[0];
                string Mailbody = null;

               for (int Index = 0; Index <= Item.SubItems.Count-1; Index++){
                    Mailbody += Item.SubItems[Index].Text + " ";
                }
                var Url = "mailto:Email@Eingeben.com?Subject=Nicht%20SBB%20App%20Erfindungen&body=Komm%20Mit!:" + Mailbody; 
                    
                Process.Start(Url);
            }
            else
            {
                MessageBox.Show("Keine Station/Fahrt Ausgewählt");
            }
        }

        //Koordinaten von geraet identifizieren und auf search.ch suchen
        private void OnLocalMapsBtnClick(object sender, EventArgs e)
        {          
            Watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            var Whereat = Watcher.Position.Location;

            var Lat = Whereat.Latitude.ToString("0.000000");
            var Lon = Whereat.Longitude.ToString("0.000000");
            if (Lat != "NaN" || Lon != "NaN")
                System.Diagnostics.Process.Start("https://map.search.ch/@" + Lat + " " + Lon + "?poi=haltestelle,zug&z=256");
            else
                MessageBox.Show("Eure Position konnte nicht gefunden werden");
        }

        //Tauscht der Inhalt zwiscen StartTxt und ArrivalTxt
        private void OnSwitchBtnClick(object sender, EventArgs e)
        {
            if (StartTxt.Text != "Tippe Hier")
            {
                string TempSwitch = StartTxt.Text;
                StartTxt.Text = ArrivalTxt.Text;
                ArrivalTxt.Text = TempSwitch;
            }
        }

        //Sucht Automatisch nach Stationen nachdem der Benutzer mehr als 3 Zeichen eingibt
        private void OnStartTxtChange(object sender, EventArgs e)
        {
            TextExistProof();
            if(StartTxt.TextLength >= 3 && StartTxt.Text != "Tippe Hier")
            GetListStations(StartTxt);
            StartLstBox.SelectedIndex = -1;          
            StartLabelUpdate(StartLstBox, Keys.K);
        }

        private void OnArrivalTxtChange(object sender, EventArgs e)
        {
            TextExistProof();
            if (StartTxt.TextLength >= 3)
            GetListStations(ArrivalTxt);
            ArrivalLstBox.SelectedIndex = -1;
            StartLabelUpdate(ArrivalLstBox, Keys.K);
        }

        private void OnHourTxtLeave(object sender, EventArgs e)
        {
            if (HourTxt.TextLength == 0)
                HourTxt.Text ="hh";
            HourTxt.ForeColor = Color.Gray;
        }

        private void OnMinuteTxtLeave(object sender, EventArgs e)
        {
            if (MinuteTxt.TextLength == 0)
                MinuteTxt.Text = "mm";
            MinuteTxt.ForeColor = Color.Gray;
        }

        private void OnStartTxtEnter(object sender, EventArgs e)
        {
            StartTxt.ForeColor = Color.Black;
            if (StartTxtPreview == true)
                StartTxt.Text = "";
            StartTxtPreview = false;
        }

        private void OnStartTxtLeave(object sender, EventArgs e)
        {
            StartTxt.ForeColor = Color.Black;
        }

        private void OnStartTxtKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                StationBoardBtn.PerformClick();
            
            StartLabelUpdate(StartLstBox, e.KeyCode);
        }

        private void OnArrivalTxtKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ConnectionsBtn.PerformClick();

            StartLabelUpdate(ArrivalLstBox, e.KeyCode);
        }

        private void OnStartLstBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)           
                e.Handled = true;
            

            if (e.KeyCode == Keys.Enter)
                StationBoardBtn.PerformClick();

            StartLabelUpdate(StartLstBox, e.KeyCode);
        }

        private void OnArrivalLstBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                e.Handled = true;

            if (e.KeyCode == Keys.Enter)
                ConnectionsBtn.PerformClick();

            StartLabelUpdate(ArrivalLstBox, e.KeyCode);
        }

        private void OnStartLstBoxClick(object sender, EventArgs e)
        {
            StartLabelUpdate(StartLstBox, Keys.K);
        }
        private void OnRadioCheckChange(object sender, EventArgs e)
        {
            RadioBtnCheck();
        }

        private void OnHourTxtEnter(object sender, EventArgs e)
        {
            HourTxt.ForeColor = Color.Black;
            HourTxt.Text = "";
        }

        private void OnMinuteEnter(object sender, EventArgs e)
        {
            MinuteTxt.ForeColor = Color.Black;
            MinuteTxt.Text = "";
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            foreach (TextBox TxtBox in PanelForTxtBox.Controls)
            {
                GetListStations(TxtBox);
            }
        }

        private void OnTimeTxtKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ConnectionsBtn.PerformClick();
        }
    }
}
