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
            NowRadio.Checked = true;
            ConnectionsBtn.Enabled = false;
            StationBoardBtn.Enabled = false;
            RadioBtnCheck();
            
        }

        private void OnConnectionsClick(object sender, EventArgs e)
        {

            if (StartLstBox.SelectedIndex >= 0 && ArrivalLstBox.SelectedIndex >= 0)
            {
                string Time = DateTime.Now.ToString("HH:mm");
                if (LaterRadio.Checked)
                {
                    Time = HourTxt.Text + ":" + MinuteTxt.Text;
                }                  
                DateTime DateTemp = DateTime.ParseExact((DateBox.Value.Date).ToString(), "dd/MM/yyyy HH:mm:ss", null);
                String Date = DateTemp.ToString("yyyy/MM/dd");
                Connections S = T.GetConnections(Convert.ToString(StartLstBox.SelectedItem), Convert.ToString(ArrivalLstBox.SelectedItem),Time , Convert.ToString(Date));
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("", 2, HorizontalAlignment.Left);
                listView1.Columns.Add("Abfahrt", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Ankunft", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Dauer(Minuten)", 135, HorizontalAlignment.Left);
                listView1.Columns.Add("Gleis", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Verspätung", 100, HorizontalAlignment.Left);
                

                foreach (Connection s in S.ConnectionList)
                {
                    DateTime Departure = DateTime.Parse(s.From.Departure);
                    DateTime Arrival = DateTime.Parse(s.To.Arrival);                   
                    ListViewItem connection1 = new ListViewItem();
                    
                    connection1.SubItems.Add(Departure.ToShortTimeString());
                    connection1.SubItems.Add(Arrival.ToShortTimeString());
                    connection1.SubItems.Add(s.Duration.Replace("00d00:",""));
                    connection1.SubItems.Add(s.From.Platform);
                    connection1.SubItems.Add(s.From.Delay.ToString());
                    
                    listView1.Items.Add(connection1);
                }
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
            HourTxt.Text = "";
        }

        private void OnMinuteEnter(object sender, EventArgs e)
        {
            MinuteTxt.Text = "";
        }

        private void OnStationMapBtnClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null)
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
            if (listView1.SelectedItems != null)
            {
                var url = "mailto:Email@Eingeben.com?Subject=Nicht%20SBB%20App%20Erfindungen&body=" + listView1.SelectedItems.ToString();
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
            System.Diagnostics.Process.Start("https://map.search.ch/@"+ Lat +" "+ Lon  +"?poi=haltestelle,zug&z=256");


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
            if(StartTxt.TextLength >= 3)
            GetListStations(StartTxt);          
        }

        private void OnArrivalTxtChange(object sender, EventArgs e)
        {
            TextExistProof();
            if (StartTxt.TextLength >= 3)
            GetListStations(ArrivalTxt);
        }

        private void OnHourTxtLeave(object sender, EventArgs e)
        {
            if (HourTxt.TextLength == 0)
                HourTxt.Text ="hh";
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OnListViewClick(object sender, MouseEventArgs e)
        {

        }
    }
}
