using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft151assignment
{
    public partial class analysis : Form
    {
        public static analysis tempAnalysis = null;
        private int yearId;
        private Location location;
        public analysis(int inYearId, Location inLocation)
        {
            InitializeComponent();
            yearId = inYearId;
            location = inLocation;
            tempAnalysis = this;
        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {
            int numlinesV;
            int numlinesH;

            Point VlineStartPoint = new Point(20, 20);
            Point VlineEndPoint = new Point(20, 480);

            Point HlineStartPoint = new Point(15, 50);
            Point HlineEndPoint = new Point(575, 50);

            numlinesV = 12;
            numlinesH = 10;

            
            using (Graphics panelGraphics = panelDisplay.CreateGraphics())
            {
                //Draw grid
                using (Pen linePen = new Pen(Color.Black))
                {
                    for (int i = 0; i < numlinesV; i++)
                    {
                       panelGraphics.DrawLine(linePen, VlineStartPoint, VlineEndPoint);

                       VlineStartPoint.X = VlineStartPoint.X + 50;
                       VlineEndPoint.X = VlineEndPoint.X + 50;               
                    }
                    for (int i = 0; i < numlinesH; i++)
                    {
                        panelGraphics.DrawLine(linePen, HlineStartPoint,HlineEndPoint);
                        HlineStartPoint.Y = HlineStartPoint.Y + 50;
                        HlineEndPoint.Y = HlineEndPoint.Y + 50;
                    }                    
                }
                //Draw datalines
                using (Pen maxTempPen = new Pen(Color.Orange, 2))
                {                  
                    int currentLineX = 20;
                    for (int i = 0; i < 11; i++)
                    {   //Draw max temp
                        panelGraphics.DrawLine(maxTempPen, currentLineX , 350 - (Convert.ToSingle(location.getYear(yearId).getMonth(i).getMaximumTemp())),currentLineX + 50, 350 - (Convert.ToSingle(location.getYear(yearId).getMonth(i+1).getMaximumTemp())));
                        currentLineX = currentLineX + 50;
                    }
                    using(Pen key = new Pen(Color.Orange, 10))
                    {   //Draw Key
                        panelGraphics.DrawLine(key, 620, 50, 640, 50);
                    }
                }
                using (Pen minTempPen = new Pen(Color.Blue, 2))
                {
                    int currentLineX = 20;
                    for (int i = 0; i < 11; i++)
                    {   //Draw min temp
                        panelGraphics.DrawLine(minTempPen, currentLineX, 350 - (Convert.ToSingle(location.getYear(yearId).getMonth(i).getMinimumTemp())), currentLineX + 50, 350 - (Convert.ToSingle(location.getYear(yearId).getMonth(i + 1).getMinimumTemp())));
                        currentLineX = currentLineX + 50;
                    }
                    using (Pen key = new Pen(Color.Blue, 10))
                    {   //Draw Key
                        panelGraphics.DrawLine(key, 620, 100, 640, 100);
                    }
                }
                using (Pen frostDaysPen = new Pen(Color.Green, 2))
                {
                    int currentLineX = 20;
                    for (int i = 0; i < 11; i++)
                    {   //Draw Frost 
                        panelGraphics.DrawLine(frostDaysPen, currentLineX, 350 - (Convert.ToSingle(location.getYear(yearId).getMonth(i).getNumberOfDaysOfAirFrost())), currentLineX + 50, 350 - (Convert.ToSingle(location.getYear(yearId).getMonth(i + 1).getNumberOfDaysOfAirFrost())));
                        currentLineX = currentLineX + 50;
                    }
                    using (Pen key = new Pen(Color.Green, 10))
                    {   //Draw Key
                        panelGraphics.DrawLine(key, 620, 150, 640, 150);
                    }
                }
                using (Pen milsRainPen = new Pen(Color.Purple, 2))
                {
                    int currentLineX = 20;
                    for (int i = 0; i < 11; i++)
                    {   //Draw Rain
                        panelGraphics.DrawLine(milsRainPen, currentLineX, 350 - (Convert.ToSingle(location.getYear(yearId).getMonth(i).getMilsOfRainFall())), currentLineX + 50, 350 - (Convert.ToSingle(location.getYear(yearId).getMonth(i + 1).getMilsOfRainFall())));
                        currentLineX = currentLineX + 50;
                    }
                    using (Pen key = new Pen(Color.Purple, 10))
                    {   //Draw Key
                        panelGraphics.DrawLine(key, 620, 200, 640, 200);
                    }
                }
                using (Pen sunShinePen = new Pen(Color.Red, 2))
                {
                    int currentLineX = 20;
                    for (int i = 0; i < 11; i++)
                    {   //Draw Sun
                        panelGraphics.DrawLine(sunShinePen, currentLineX, 350 - (Convert.ToSingle(location.getYear(yearId).getMonth(i).getHoursOfSunShine())), currentLineX + 50, 350 - (Convert.ToSingle(location.getYear(yearId).getMonth(i + 1).getHoursOfSunShine())));
                        currentLineX = currentLineX + 50;
                    }
                    using (Pen key = new Pen(Color.Red, 10))
                    {   //Draw Key
                        panelGraphics.DrawLine(key, 620, 250, 640, 250);
                    }
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            tempAnalysis.Hide();
            Form1.keepForm1.Show();
        }
    }
}
