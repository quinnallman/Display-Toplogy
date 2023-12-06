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

namespace Display_Toplogy {
    public partial class LayoutManager : Form {
        public LayoutManager() {
            InitializeComponent();
            PathInfo[] activePaths = PathInfo.GetActivePaths();

            PathInfo[] newPaths = new PathInfo[activePaths.Length];
            newPaths[0] = new PathInfo(activePaths[0].DisplaySource, new Point(0, 0), new Size(activePaths[0].Resolution.Width, activePaths[0].Resolution.Height), activePaths[0].PixelFormat, activePaths[0].TargetsInfo);
            newPaths[1] = new PathInfo(activePaths[1].DisplaySource, new Point(1920, 0), new Size(activePaths[1].Resolution.Width, activePaths[1].Resolution.Height), activePaths[1].PixelFormat, activePaths[1].TargetsInfo);
            newPaths[2] = new PathInfo(activePaths[2].DisplaySource, new Point(-1920, 0), new Size(activePaths[2].Resolution.Width, activePaths[2].Resolution.Height), activePaths[2].PixelFormat, activePaths[2].TargetsInfo);
            newPaths[3] = new PathInfo(activePaths[3].DisplaySource, new Point(0, -1080), new Size(activePaths[3].Resolution.Width, activePaths[3].Resolution.Height), activePaths[3].PixelFormat, activePaths[3].TargetsInfo);
            newPaths[4] = new PathInfo(activePaths[4].DisplaySource, new Point(-1920, -1080), new Size(activePaths[4].Resolution.Width, activePaths[4].Resolution.Height), activePaths[4].PixelFormat, activePaths[4].TargetsInfo);
            newPaths[5] = new PathInfo(activePaths[5].DisplaySource, new Point(1920, -1080), new Size(activePaths[5].Resolution.Width, activePaths[5].Resolution.Height), activePaths[5].PixelFormat, activePaths[5].TargetsInfo);

            if (PathInfo.ValidatePathInfos(newPaths))
                PathInfo.ApplyPathInfos(newPaths);
            else
                Console.WriteLine("Could not validate paths");
        }
    }
}
