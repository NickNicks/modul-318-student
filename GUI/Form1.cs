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

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnButtonCLick(object sender, EventArgs e)
        {
            Transport t = new Transport();

            Stations mystations = t.GetStations("Luz");
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            foreach (TextBox s in groupBox1.Controls)
            {
                string TxtBoxName = s.Name;
                GetListStations(TxtBoxName);
            }
        }
        public void GetListStations(string TxtBoxName)
        {
            Transport T = new Transport();
            Stations S = T.GetStations(TxtBoxName);
            List<string> StartList = new List<string>();
            foreach (Station s in S.StationList)
            {
                StartList.Add(s.Name);
            }
            StartLstBox.DataSource = null;
            StartLstBox.DataSource = StartList;
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrivalLstBox.Items.Add("Um Verbindungen zu suchen");
            ArrivalLstBox.Items.Add("Ziel Text Box ausfüllen");
        }
    }
}
