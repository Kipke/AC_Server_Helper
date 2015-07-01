using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AC_Server_Helper {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        #region event handlers
        private void Form1_Load(object sender, EventArgs e) {
            update();
        }

        private void inButton_Click(object sender, EventArgs e) {
            var p = AvailableBox.SelectedItem;
            SelectedBox.Items.Add(p);
            var v = SelectedBox.Items.Count;
            var s = selectedLabel.Text.Split('/');
            s[0] = v.ToString();
            selectedLabel.Text = s[0] + "/" + s[1];
        }

        private void outButton_Click(object sender, EventArgs e) {
            var p = SelectedBox.SelectedItem;
            SelectedBox.Items.Remove(p);
            if (SelectedBox.SelectedIndex < 0 && SelectedBox.Items.Count > 0)
                SelectedBox.SelectedIndex = 0;
            var v = SelectedBox.Items.Count;
            var s = selectedLabel.Text.Split('/');
            s[0] = v.ToString();
            selectedLabel.Text = s[0] + "/" + s[1];
        }

        private void selectMainPathButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog fdd = new FolderBrowserDialog();
            System.Windows.Forms.DialogResult r = fdd.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
                mainPathBox.Text = fdd.SelectedPath.ToString();
            update();
        }

        private void selectServerPathButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog fdd = new FolderBrowserDialog();
            System.Windows.Forms.DialogResult r = fdd.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
                serverPathBox.Text = fdd.SelectedPath.ToString();
            update();
        }

        private void mainPathBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r')
                update();
        }

        private void serverPathBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r')
                update();
        }

        private void createFileButton_Click(object sender, EventArgs e) {
            // Get the cars
            Dictionary<string, int> cars = new Dictionary<string, int>();
            foreach (string v in SelectedBox.Items) {
                if (cars.ContainsKey(v)) {
                    cars[v]++;
                }
                else {
                    cars.Add(v, 1);
                }
            }
            if (cars.Count == 0) {
                // No Cars
                MessageBox.Show("No Cars Selected", "AC Server File Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (trackBox.Text == "") {
                // No track
                MessageBox.Show("No Track Selected", "AC Server File Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numClientsBox.Value != SelectedBox.Items.Count) {
                if (MessageBox.Show("Not the Correct amount of cars selected", "AC Server File Helper", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;
            }
            var pathServer = serverPathBox.Text;
            int i = 0;
            StreamWriter swE = new StreamWriter(pathServer + @"\cfg\entry_list.ini", false);
            foreach (string s in cars.Keys) {
                string[] skins = CarSkins(mainPathBox.Text, s);
                string[] entryList = new string[0];
                entryList = AddCarToEntries(entryList, i, i + cars[s], s, skins);
                foreach (string t in entryList) {
                    swE.WriteLine(t);
                }
                i += cars[s];
            }
            // EntryList done
            swE.Close();

            // Start writing server_cfg
            StreamWriter swS = new StreamWriter(pathServer + @"\cfg\server_cfg.ini", false);
            swS.WriteLine("[SERVER]");
            swS.WriteLine("NAME={0}", nameBox.Text);
            string carString = "";
            foreach (string c in cars.Keys) {
                carString += c + ";";
            }
            carString = carString.Remove(carString.Length - 1);
            swS.WriteLine("CARS={0}", carString);
            swS.WriteLine("TRACK={0}", trackBox.SelectedItem);
            // 8 --> -90 18 --> 90 
            // -90 = 08:00 | -64 = 09:00 | -48 = 10:00 | -32 = 11:00 | -16 = 12:00 | 0 = 13:00 | 16 = 14:00 | 32 = 15:00 | 48 = 16:00 | 64 = 17:00 | 90 = 18:00
            int n = (int)(((int)timeBox.Value - 8) * 9 - 90);
            swS.WriteLine("SUN_ANGLE={0}", n);
            swS.WriteLine("MAX_CLIENTS={0}", numClientsBox.Value);
            swS.WriteLine("RACE_OVER_TIME=60");
            swS.WriteLine("ALLOWED_TYRES_OUT=3");
            swS.WriteLine("UDP_PORT={0}", udpBox.Text);
            swS.WriteLine("TCP_PORT={0}", tcpBox.Text);
            swS.WriteLine("HTTP_PORT={0}", httpBox.Text);
            swS.WriteLine("PASSWORD={0}", passwordBox.Text);
            swS.WriteLine("LOOP_MODE=1");
            swS.WriteLine("REGISTER_TO_LOBBY=1");
            swS.WriteLine("PICKUP_MODE_ENABLED=1");
            swS.WriteLine("SLEEP_TIME=1");
            swS.WriteLine("VOTING_QUORUM=75");
            swS.WriteLine("VOTE_DURATION=20");
            swS.WriteLine("BLACKLIST_MODE=0");
            swS.WriteLine("TC_ALLOWED={0}", Convert.ToInt32(TCBox.CheckState));
            swS.WriteLine("ABS_ALLOWED={0}", Convert.ToInt32(ABSBox.CheckState));
            swS.WriteLine("STABILITY_ALLOWED={0}", Convert.ToInt32(SCBox.CheckState));
            swS.WriteLine("AUTOCLUTCH_ALLOWED={0}", Convert.ToInt32(ACBox.CheckState));
            swS.WriteLine("DAMAGE_MULTIPLIER={0}", DamageMultBox.Value);
            swS.WriteLine("FUEL_RATE={0}", FuelMultBox.Value);
            swS.WriteLine("TYRE_WEAR_RATE={0}", TyreWearMultBox.Value);
            swS.WriteLine("CLIENT_SEND_INTERVAL_HZ=20");
            swS.WriteLine("USE_FLOW_CONTROL=0");
            swS.WriteLine("TYRE_BLANKETS_ALLOWED=1");
            swS.WriteLine("ADMIN_PASSWORD={0}", AdminPass.Text);
            swS.WriteLine("");
            swS.WriteLine("[DYNAMIC TRACK]");
            swS.WriteLine("SESSION_START=90");
            swS.WriteLine("RANDOMNESS=1");
            swS.WriteLine("LAP_GAIN=1");
            swS.WriteLine("SESSION_TRANSFER=50");
            swS.WriteLine("");
            if (practiceCheck.Checked && practiceTimeBox.Value != 0) {
                swS.WriteLine("[PRACTICE]");
                swS.WriteLine("NAME=Practice");
                swS.WriteLine("TIME={0}", practiceTimeBox.Value);
                swS.WriteLine("WAIT_TIME=60");
                swS.WriteLine("");
            }
            if (qualifyingCheck.Checked && qualifyingTimeBox.Value != 0) {
                swS.WriteLine("[QUALIFY]");
                swS.WriteLine("NAME=Qualify");
                swS.WriteLine("TIME={0}", qualifyingTimeBox.Value);
                swS.WriteLine("WAIT_TIME=60");
                swS.WriteLine("");
            }
            if (raceCheck.Checked && raceLapsBox.Value != 0) {
                swS.WriteLine("[RACE]");
                swS.WriteLine("NAME=Race");
                swS.WriteLine("LAPS={0}", raceLapsBox.Value);
                swS.WriteLine("WAIT_TIME=60");
                swS.WriteLine("");
            }
            // All Done!
            swS.Close();
            MessageBox.Show("Files Succesfully created!", "AC Server File Helper", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void numClientsBox_ValueChanged(object sender, EventArgs e) {
            var v = numClientsBox.Value;
            var s = selectedLabel.Text.Split('/');
            s[1] = v.ToString();
            selectedLabel.Text = s[0] + "/" + s[1];
        }
        #endregion

        #region helpers
        private void update(object sender, EventArgs e) { update(); }
        private void update() {
            try {
                var track = TrackList(mainPathBox.Text);
                trackBox.Items.AddRange(track);
                var cars = CarList(mainPathBox.Text);
                AvailableBox.Items.Clear();
                for (int i = 0; i < cars.Length; i++) {
                    AvailableBox.Items.Add(cars[i]);
                }
            }
            catch { }
        }

        private static string[] TrackList(string acBasePath) {
            var path = acBasePath + @"\content\tracks";
            var t = Directory.GetDirectories(path);

            for (int i = 0; i < t.Length; i++) {
                t[i] = t[i].Remove(0, path.Length + 1);
            }
            return t;
        }
        private static string[] CarList(string acBasePath) {
            var path = acBasePath + @"\content\cars";
            var t = Directory.GetDirectories(path);

            for (int i = 0; i < t.Length; i++) {
                t[i] = t[i].Remove(0, path.Length + 1);
            }
            return t;
        }
        private static string[] CarSkins(string acBasePath, string car) {
            var path = acBasePath + @"\content\cars\" + car + @"\skins";
            var t = Directory.GetDirectories(path);

            for (int i = 0; i < t.Length; i++) {
                t[i] = t[i].Remove(0, path.Length + 1);
            }
            return t;
        }
        private static string[] EntryListEntry(int number, string car, string skin) {
            string[] retVal = new string[8];
            retVal[0] = String.Format("[CAR_{0}]", number);
            retVal[1] = String.Format("DRIVERNAME=");
            retVal[2] = String.Format("TEAM=");
            retVal[3] = String.Format("MODEL={0}", car);
            retVal[4] = String.Format("SKIN={0}", skin);
            retVal[5] = String.Format("GUID=");
            retVal[6] = String.Format("SPECTATOR_MODE=0");
            retVal[7] = "";
            return retVal;
        }
        private static string[] AddCarToEntries(string[] entryList, int startIndex, int endIndex, string car, string[] skins) {
            var retVal = new List<string>(entryList);
            for (int i = startIndex; i < endIndex; i++) {
                var entry = EntryListEntry(i, car, skins[i % skins.Length]);
                retVal.AddRange(entry);
            }
            return retVal.ToArray();
        }
        #endregion


    }
}
