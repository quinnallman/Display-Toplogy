using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDisplayAPI.DisplayConfig;
using WindowsDisplayAPI.Native;

namespace Display_Toplogy {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void displayPathInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            this.comboBox1.Items.Clear();
            var adapters = WindowsDisplayAPI.DisplayAdapter.GetDisplayAdapters();
            foreach (object o in adapters)
                this.comboBox1.Items.Add(o);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            this.propertyGrid1.SelectedObject = this.comboBox1.SelectedItem;
        }

        private void connectedDisplaysToolStripMenuItem_Click(object sender, EventArgs e) {
            this.comboBox1.Items.Clear();
            var displays = WindowsDisplayAPI.Display.GetDisplays();
            foreach (object o in displays)
                this.comboBox1.Items.Add(o);
        }

        private void displaySourcesToolStripMenuItem_Click_1(object sender, EventArgs e) {
            this.comboBox1.Items.Clear();
            var sources = WindowsDisplayAPI.DisplayConfig.PathDisplaySource.GetDisplaySources();
            foreach (object o in sources)
                this.comboBox1.Items.Add(o);
        }

        private void displayTargetsToolStripMenuItem_Click(object sender, EventArgs e) {
            this.comboBox1.Items.Clear();
            var targets = WindowsDisplayAPI.DisplayConfig.PathDisplayTarget.GetDisplayTargets();
            foreach (object o in targets)
                this.comboBox1.Items.Add(o);
        }

        private void displayActivePathsToolStripMenuItem_Click(object sender, EventArgs e) {
            int minX = int.MaxValue, minY = int.MaxValue, maxX = int.MinValue, maxY = int.MinValue;

            this.comboBox1.Items.Clear();
            PathInfo[] activePaths = WindowsDisplayAPI.DisplayConfig.PathInfo.GetActivePaths();
            foreach (PathInfo o in activePaths) {
                this.comboBox1.Items.Add(o);
                if (o.Position.X < minX)
                    minX = o.Position.X;
                if (o.Position.X + o.Resolution.Width > maxX)
                    maxX = o.Position.X + o.Resolution.Width;
                if (o.Position.Y - o.Resolution.Height < minY)
                    minY = o.Position.Y - o.Resolution.Height;
                if (o.Position.Y > maxY)
                    maxY = o.Position.Y;
            }

            Console.WriteLine("(" + minX + ", " + minY + ") => (" + maxX + ", " + maxY + ")");
        }

        private void displayAllPathsToolStripMenuItem_Click(object sender, EventArgs e) {
            this.comboBox1.Items.Clear();
            var allPaths = WindowsDisplayAPI.DisplayConfig.PathInfo.GetAllPaths();
            foreach (object o in allPaths)
                this.comboBox1.Items.Add(o);
        }

        private void displayCurrentTopologyToolStripMenuItem_Click(object sender, EventArgs e) {
            this.comboBox1.Items.Clear();
            var currentTopology = WindowsDisplayAPI.DisplayConfig.PathInfo.GetCurrentTopology();
            Console.WriteLine(currentTopology);
        }

        private void alignedGridToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutManager lm = new LayoutManager();
            lm.Show();
        }
    }
}
