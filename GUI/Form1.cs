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

namespace GUI
{
    public partial class Form1 : Form
    {
        Transport T = new Transport();
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

        private void Form1_Load(object sender, EventArgs e)
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
                    ConnectionsList.Add("Abfahrt:"+ Departure.ToShortTimeString() + " Ankunft:" + Arrival.ToShortTimeString() + " Platform:" + s.From.Arrival + " Verspätung:" + s.From.Delay);
                }
                ConnectionLstBox.DataSource = null;
                ConnectionLstBox.DataSource = ConnectionsList;
            }
        }

        private void OnStationBoardClick(object sender, EventArgs e)
        {
            List<string> StationBoardList = new List<string>();
            Stations S = T.GetStations(StartTxt.Text);
            Station WantedStation = S.StationList[StartLstBox.SelectedIndex];
            StationBoardRoot SB = T.GetStationBoard(WantedStation.Name, WantedStation.Id);

            foreach (StationBoard STemp in SB.Entries)
            {
              
                StationBoardList.Add(STemp.Name + " " + STemp.Category + " " + STemp.Number + " " + STemp.To + " " + STemp.Operator + " " + STemp.Stop.Departure.ToShortTimeString());
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

        private void OnTextChange(object sender, EventArgs e)
        {
            if (ArrivalTxt.TextLength > 0 && StartTxt.TextLength > 0)
                ConnectionsBtn.Enabled = true;
            else
                ConnectionsBtn.Enabled = false;
            if (ArrivalTxt.TextLength <= 0 && StartTxt.TextLength > 0 )
                StationBoardBtn.Enabled = true;
            else
                StationBoardBtn.Enabled = false;


        }

        private void OnHourTxtEnter(object sender, EventArgs e)
        {
            HourTxt.Text = "";
        }

        private void OnMinuteEnter(object sender, EventArgs e)
        {
            MinuteTxt.Text = "";
        }

        private void PanelForTxtBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
