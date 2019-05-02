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
        Transport T = new Transport();
        GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
        bool StartTxtPreview = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void OnButtonCLick(object sender, EventArgs e)
        {
            Stations mystations = T.GetStations("Luz");
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            foreach (TextBox s in PanelForTxtBox.Controls)
            {              
                GetListStations(s);
            }
        }
        public void GetListStations(TextBox Box)
        {
            Stations S = T.GetStations(Box.Text);
            List<string> StartList = new List<string>();         
            foreach (Station s in S.StationList)
            {
                StartList.Add(s.Name);
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
            RadioBtnCheck();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.SwitchBtn, "Wechselt Abfahrt und Ankunfts Suchbegriffen");
        }

        private void OnConnectionsClick(object sender, EventArgs e)
        {
            if (StartLstBox.SelectedIndex >= 0 && ArrivalLstBox.SelectedIndex >= 0)
            {               
                string Time = DateTime.Now.ToString("HH:mm");
                if (LaterRadio.Checked)
                {
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

                    Time = HourTxt.Text + ":" + MinuteTxt.Text;
                    
                }
                DateTime DateTemp = DateTime.ParseExact((DateBox.Value.Date).ToString(), "dd/MM/yyyy HH:mm:ss", null);
                String Date = DateTemp.ToString("yyyy/MM/dd");
                Connections S = T.GetConnections(Convert.ToString(StartLstBox.SelectedItem), Convert.ToString(ArrivalLstBox.SelectedItem), Time, Convert.ToString(Date));
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("", 2, HorizontalAlignment.Left);
                listView1.Columns.Add("Abfahrt", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Ankunft", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Dauer", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Gleis", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Verspätung", 100, HorizontalAlignment.Left);


                foreach (Connection s in S.ConnectionList)
                {
                    DateTime Departure = DateTime.Parse(s.From.Departure);
                    DateTime Arrival = DateTime.Parse(s.To.Arrival);
                    ListViewItem connection1 = new ListViewItem();

                    connection1.SubItems.Add(Departure.ToShortTimeString());
                    connection1.SubItems.Add(Arrival.ToShortTimeString());
                    connection1.SubItems.Add(s.Duration.Replace("00d", ""));
                    connection1.SubItems.Add(s.From.Platform);
                    connection1.SubItems.Add(s.From.Delay.ToString());

                    listView1.Items.Add(connection1);
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
                Station WantedStation = S.StationList[StartLstBox.SelectedIndex];
                StationBoardRoot SB = T.GetStationBoard(WantedStation.Name, WantedStation.Id);
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("", 2, HorizontalAlignment.Left);
                listView1.Columns.Add("Kategorie", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Nummer", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Bis", 135, HorizontalAlignment.Left);
                listView1.Columns.Add("Operator", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Abfahrt", 100, HorizontalAlignment.Left);
                foreach (StationBoard STemp in SB.Entries)
                {
                    ListViewItem connection1 = new ListViewItem();

                    connection1.SubItems.Add(STemp.Category);
                    connection1.SubItems.Add(STemp.Number);
                    connection1.SubItems.Add(STemp.To);
                    connection1.SubItems.Add(STemp.Operator);
                    connection1.SubItems.Add(STemp.Stop.Departure.ToShortTimeString());

                    listView1.Items.Add(connection1);
                }
            }
            else
            {
                MessageBox.Show("Keine Station ausgewählt");
            }
           
        }
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

        private void OnRadioCheckChange(object sender, EventArgs e)
        {
            RadioBtnCheck();
        }

        private void TextExistProof()
        {
            Form form1 = new Form1();
            if (ArrivalTxt.TextLength > 0 && StartTxt.TextLength > 0)
            {
                ConnectionsBtn.Enabled = true;
                form1.AcceptButton = ConnectionsBtn;
            }
            else
                ConnectionsBtn.Enabled = false;
            if (ArrivalTxt.TextLength <= 0 && StartTxt.TextLength > 0)
            {
                StationBoardBtn.Enabled = true;
                form1.AcceptButton = StationBoardBtn;
            }
            else
                StationBoardBtn.Enabled = false;

            if (ArrivalTxt.TextLength == 0)
                ArrivalLstBox.DataSource = null;
            if (StartTxt.TextLength == 0)
                StartLstBox.DataSource = null;
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

        private void OnStationMapBtnClick(object sender, EventArgs e)
        {
            if (StartLstBox.SelectedIndex != -1)
            {
                string query = StartLstBox.SelectedItem.ToString();
                query.Replace(" ", "+");
                System.Diagnostics.Process.Start("https://www.google.com/maps/search/" + query);
            }
            else
            {
                MessageBox.Show("Keine Station Ausgewählt");
            }

        }

        private void OnEmailShareBtnClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string mailbody = null;
               for (int index = 0; index <= item.SubItems.Count-1; index++){
                    mailbody += item.SubItems[index].Text + " ";
                }

                var url = "mailto:Email@Eingeben.com?Subject=Nicht%20SBB%20App%20Erfindungen&body=Komm%20Mit!:" + mailbody; 
                    
                Process.Start(url);
            }
            else
            {
                MessageBox.Show("Keine Station/Fahrt Ausgewählt");
            }
        }

        private void OnLocalMapsBtnClick(object sender, EventArgs e)
        {          

            // Do not suppress prompt, and wait 1000 milliseconds to start.
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            var whereat = watcher.Position.Location;

            var Lat = whereat.Latitude.ToString("0.000000");
            var Lon = whereat.Longitude.ToString("0.000000");
            if (Lat != "NaN" || Lon != "NaN")
                System.Diagnostics.Process.Start("https://map.search.ch/@" + Lat + " " + Lon + "?poi=haltestelle,zug&z=256");
            else
                MessageBox.Show("Eure Position konnte nicht gefunden werden");


        }

        private void OnSwitchBtnClick(object sender, EventArgs e)
        {
            string TempSwitch = StartTxt.Text;
            StartTxt.Text = ArrivalTxt.Text;
            ArrivalTxt.Text = TempSwitch;          
        }

        private void OnStartTxtChange(object sender, EventArgs e)
        {
            TextExistProof();
            if(StartTxt.TextLength >= 3 && StartTxt.Text != "Tippe Hier")
            GetListStations(StartTxt);
            StartLstBox.SelectedIndex = -1;
            
            StartLabelUpdate(StartLstBox, false, Keys.K);
        }

        private void OnArrivalTxtChange(object sender, EventArgs e)
        {
            TextExistProof();
            if (StartTxt.TextLength >= 3)
            GetListStations(ArrivalTxt);
            ArrivalLstBox.SelectedIndex = -1;
            StartLabelUpdate(ArrivalLstBox, false, Keys.K);
        }

        private void OnHourTxtLeave(object sender, EventArgs e)
        {
            HourTxt.ForeColor = Color.Gray;
            if (HourTxt.TextLength == 0)
                HourTxt.Text ="hh";
        }

        private void OnMinuteLeave(object sender, EventArgs e)
        {
            MinuteTxt.ForeColor = Color.Gray;
            if (MinuteTxt.TextLength == 0)
                MinuteTxt.Text = "mm";
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

                StartLabelUpdate(StartLstBox, false, e.KeyCode);

        }

        private void OnArrivalTxtKeyDown(object sender, KeyEventArgs e)
        {

                StartLabelUpdate(ArrivalLstBox, false, e.KeyCode);

        }
        private void StartLabelUpdate(ListBox LstBox, bool LstBoxCheck,Keys Key)
        {
            String StringKey = Key.ToString();

            if (LstBox.SelectedIndex < LstBox.Items.Count - 1 && StringKey == "Down" && LstBoxCheck == false)
                LstBox.SelectedIndex++;

            if (LstBox.SelectedIndex > -1 && StringKey == "Up" && LstBoxCheck == false)
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

        private void OnStartLstBoxKeyDown(object sender, KeyEventArgs e)
        {
                StartLabelUpdate(StartLstBox, true, e.KeyCode);
        }

        private void OnArrivalLstBoxKeyDown(object sender, KeyEventArgs e)
        {
            StartLabelUpdate(ArrivalLstBox, true, e.KeyCode);
        }
    }
}
