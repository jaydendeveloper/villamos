using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace villanyos
{
    public partial class Form1 : Form
    {

        Dictionary<string, TramLine> tramLines = new Dictionary<string, TramLine>();
        TramLine longestTramLine = new TramLine();
        TramLine shortestTramLine = new TramLine();
        public struct TramLine
        {
            public string line;
            public List<Stop> stops;
            public int time;
        }

        public struct Stop
        {
            public string name;
            public int timeToNextStop;
        }


        string fileName = "./data.txt";
        public Form1()
        {
            InitializeComponent();

            fileNameBox.Text = fileName;

            comboBox1.Visible = false;
        }



        private void fileNameBtn_Click(object sender, EventArgs e)
        {
            fileName = fileNameBox.Text;

            readData();

            getLongestAndShortestLine();
        }

        void getLongestAndShortestLine()
        {
            int max = 0;
            int min = int.MaxValue;

            foreach (string lineNumber in tramLines.Keys)
            {
                int time = 0;
                foreach (Stop stop in tramLines[lineNumber].stops)
                {                   
                    time += stop.timeToNextStop;
                }


                if(time > max)
                {
                    max = time;
                    longestTramLine.line = lineNumber;
                }

                if(time < min)
                {
                    min = time;
                    shortestTramLine.line = lineNumber;
                }
            }
        }

        void readData()
        {
            string[] file = File.ReadAllLines(fileName);

            foreach (string line in file)
            {
                string[] spl = line.Split(';');
                string tramNumber = spl[0];
                string stop = spl[1];
                int timeToNext =int.Parse(spl[2]);

                if (!comboBox1.Items.Contains(tramNumber))
                {
                    comboBox1.Items.Add(tramNumber);
                }

                TramLine tramLine = new TramLine
                {
                    line = tramNumber,
                    stops = new List<Stop>(),
                    time = 0
                };
                Stop tramStop = new Stop
                {
                    name = stop,
                    timeToNextStop = timeToNext
                };

                tramLine.stops.Add(tramStop);

                if (tramLines.ContainsKey(tramNumber))
                {
                    tramLines[tramNumber].stops.Add(tramStop);
                }
                else
                {
                    tramLines.Add(tramNumber, tramLine);
                }

                comboBox1.Visible = true;
                fileNameBtn.Visible = false;
                fileNameBox.Visible = false;
            }
        }

        void printData(string tramNumber)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(tramNumber + "-es vonal:");
            int time = 0;

            foreach (Stop stop in tramLines[tramNumber].stops)
            {
                Console.WriteLine(time);
                lineLabel.Text = tramNumber;
                tripLabel.Text = tramLines[tramNumber].stops[0].name + " - " + tramLines[tramNumber].stops[tramLines[tramNumber].stops.Count -1].name;


                listBox1.Items.Add(stop.name + " - " + time + "'");
                time+=stop.timeToNextStop;
                Console.WriteLine(time);
            }

            tripTime.Text = "Menetidő: " + (time) + " perc";

            if(longestTramLine.line != tramNumber && shortestTramLine.line != tramNumber)
            {
                isShortestOrLongest.Text = "";
            }

            if(longestTramLine.line == tramNumber)
            {
                isShortestOrLongest.Text = "Ez a leghosszabb villamosvonal";
            }
            if(shortestTramLine.line == tramNumber)
            {
                isShortestOrLongest.Text = "Ez a legrövidebb villamosvonal";
            } 
        }

        private void készítőToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gyalog Patrik");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tramNumber = comboBox1.SelectedItem.ToString();
            Console.Write(tramNumber);
            printData(tramNumber);
        }
    }
}
