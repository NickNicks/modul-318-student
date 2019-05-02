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
            ListViewItem connection1 = new ListViewItem();
            connection1.Text = null;
            connection1.SubItems.Add(S.Name);
            connection1.SubItems.Add();
            listView1.Items.Add(connection1);
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
                List<string> ConnectionsList = new List<string>();
                
                foreach (Connection s in S.ConnectionList)
                {
                    DateTime Departure = DateTime.Parse(s.From.Departure);
                    DateTime Arrival = DateTime.Parse(s.To.Arrival);
                    ConnectionsList.Add("Abfahrt:"+ Departure.ToShortTimeString() + " Ankunft:" + Arrival.ToShortTimeString() + " Platform:" + s.From.Platform + " Verspätung:" + s.From.Delay);
                }
                ConnectionLstBox.DataSource = null;
                ConnectionLstBox.DataSource = ConnectionsList;
            }
        }

        private void OnStationBoardClick(object sender, EventArgs e)
        {
           
            List<string> StationBoardList = new List<string>();
            Stations S = T.GetStations(StartTxt.Text);
            if (StartLstBox.SelectedIndex >= 0)
            {
                Station WantedStation = S.StationList[StartLstBox.SelectedIndex];
                StationBoardRoot SB = T.GetStationBoard(WantedStation.Name, WantedStation.Id);
                foreach (StationBoard STemp in SB.Entries)
                {

                    StationBoardList.Add(STemp.Category + " " + STemp.Number + " " + STemp.To + " " + STemp.Operator + " " + STemp.Stop.Departure.ToShortTimeString());
                }
            }
            else
            {
                MessageBox.Show("Keine Station ausgewählt");
            }
           
            ConnectionLstBox.DataSource = StationBoardList;
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
            if (ConnectionLstBox.SelectedIndex >= 0)
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
            if (ConnectionLstBox.SelectedIndex >= 0)
            {
                var url = "mailto:Email@Eingeben.com?Subject=Nicht%20SBB%20App%20Erfindungen&body=" + ConnectionLstBox.SelectedItem.ToString();
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
    }
}
