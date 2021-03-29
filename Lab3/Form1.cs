using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private int closestNeighbours;

        internal Point iPointToDrag;
        bool bDragFlag;

        private int searchRadius;
        private Pen radiusPen;

        int formWidth, formHeight;

        internal int radius; internal int GetRadius() { return radius; }

        List<Point> arRedPoints;
        internal bool isRedsSelected;

        List<Point> arBluePoints;
        internal bool isBluesSelected;

        private Point candidate;
        internal bool isCandidateSelected;
        internal bool isCandidateSet;


        public Form1()
        {
            closestNeighbours = 5;
          

            InitializeComponent();
            DoubleBuffered = true;
            radius = 5;

            searchRadius = 0;
            radiusPen = new Pen(Color.White, 1);

            isRedsSelected = true;
            bDragFlag = false;
            formWidth = this.Width;
            formHeight = this.Height;

            arRedPoints = new List<Point>();
            isRedsSelected = true;

            arBluePoints = new List<Point>();

            isCandidateSet = false;

            Paint += new PaintEventHandler(Form1_Paint);
            MouseDown += button1_MouseDown;


            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            MouseUp += MouseUpper;

            MouseMove += new MouseEventHandler(MouseMoving);
  
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            try
            {        
                
                    foreach (var x in arRedPoints)
                    {
                        int xCentered = x.X - radius;
                        int yCentered = x.Y - radius;

                        g.FillEllipse(Brushes.Red, new Rectangle(xCentered, yCentered, radius * 2, radius * 2));
                        
                    }

                    foreach (var x in arBluePoints)
                    {
                        int xCentered = x.X - radius;
                        int yCentered = x.Y - radius;

                        g.FillEllipse(Brushes.Blue, new Rectangle(xCentered, yCentered, radius * 2, radius * 2));

                    }

                    if (isCandidateSet)
                    {
                        int xCentered = candidate.X - radius;
                        int yCentered = candidate.Y - radius;
                        g.FillEllipse(Brushes.White, new Rectangle(xCentered, yCentered, radius * 2, radius * 2));
                        g.DrawEllipse(radiusPen
                            , candidate.X - searchRadius, candidate.Y - searchRadius
                            , searchRadius * 2, searchRadius * 2);


                      }


            }
            catch (Exception) { g.Clear(System.Drawing.SystemColors.ActiveCaption); }
        }

       

        void ClearScreen()
        {
            arRedPoints = new List<Point>();
            arBluePoints = new List<Point>();
            isCandidateSet = false;
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }
        void button1_MouseDown(object sender, MouseEventArgs e)
        {
           
            for (int i = 0; i < arRedPoints.Count ; i++)
            {
                if (((arRedPoints[i].X-radius < e.Location.X) && (arRedPoints[i].X + 2 * radius > e.Location.X)) &&
                    ((arRedPoints[i].Y-radius < e.Location.Y) && (arRedPoints[i].Y + 2 * radius > e.Location.Y)))
                {
                    setReds();
                    bDragFlag =true;
                    Cursor = Cursors.Hand;
                    iPointToDrag = arRedPoints[i];
                    arRedPoints.Remove(iPointToDrag);
                    Refresh();
                    return;
                }
            }
            for (int i = 0; i < arBluePoints.Count; i++)
            {
                if (((arBluePoints[i].X - radius < e.Location.X) && (arBluePoints[i].X + 2 * radius > e.Location.X)) &&
                    ((arBluePoints[i].Y - radius < e.Location.Y) && (arBluePoints[i].Y + 2 * radius > e.Location.Y)))
                {
                    setBlues();
                    bDragFlag = true;
                    Cursor = Cursors.Hand;
                    iPointToDrag = arBluePoints[i];
                    arBluePoints.Remove(iPointToDrag);
                    Refresh();
                    return;
                }
            }
            
            if(isRedsSelected) 
            {arRedPoints.Add(new Point(e.Location.X, e.Location.Y)); Refresh();return;}
            if(isBluesSelected)
            {arBluePoints.Add(new Point(e.Location.X, e.Location.Y)); Refresh();return;}
            
            if (isCandidateSelected)
            {
                candidate = new Point(e.Location.X, e.Location.Y);
                isCandidateSet = true;
            }
            Refresh();
        }

        void MouseMoving(object sender, MouseEventArgs e)
        {
            if (bDragFlag)
            {
                iPointToDrag.X = e.Location.X;
                iPointToDrag.Y = e.Location.Y;                             

            }
        }

        void MouseUpper(object sender, MouseEventArgs e)
        {
            if (bDragFlag)
            {
                Cursor = Cursors.Cross;
                if(isRedsSelected) arRedPoints.Add(iPointToDrag);
                if(isBluesSelected) arBluePoints.Add(iPointToDrag);
                bDragFlag = false;
                Refresh();
            }
        }


        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             switch (e.KeyCode)
              {
                
                case (Keys.Escape):
                    ClearScreen(); break;
                case (Keys.Oemplus):
               
                
                default:break;
              }

               e.Handled = true;
          
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
          
            Refresh();


        }
        


        private void redsButton_Click(object sender, EventArgs e)
        {
            setReds();
        }

        void setReds()
        {
            isCandidateSelected = false;
            isBluesSelected = false;
            isRedsSelected = true;
        }

        private void bluesButton_Click(object sender, EventArgs e)
        {
            setBlues();
        }

        void setBlues()
        {
            isCandidateSelected = false;
            isBluesSelected = true;
            isRedsSelected = false;
        }
        private void candidateButton_Click(object sender, EventArgs e)
        {
            setCandidate();
        }

        void setCandidate()

        {
            isCandidateSelected = true;
            isBluesSelected = false;
            isRedsSelected = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            getResult();
        }

        private void getResult()
        {
            String resultMessage = "";
            if (isCandidateSet)
            {
                
                List<Neighbour> neighbours = new List<Neighbour>();
                int id = 0;
                foreach(var x in arRedPoints)
                    neighbours.Add(new Neighbour(++id,matchDistance(candidate,x),"red"));
                foreach (var x in arBluePoints)
                    neighbours.Add(new Neighbour(++id, matchDistance(candidate, x), "blue"));

                neighbours = neighbours.OrderBy(x => x.distanceToCandidate)
                    .Take(closestNeighbours).ToList();


                int longestDistance = (int)neighbours.Last().distanceToCandidate+radius;
                for (searchRadius = 0; searchRadius < longestDistance; searchRadius++) Refresh();
                searchRadius = 0;

                int reds = neighbours.Where(x => x.label == "red").Count();
                int blues = neighbours.Where(x => x.label == "blue").Count();

                
                if (reds > blues) resultMessage = "Candidate is classified as red";
                if (reds < blues) resultMessage = "Candidate is classified as blue";
                if (reds == blues)
                {
                    if (neighbours.First().label=="red") resultMessage = "Candidate is classified as red";
                    if (neighbours.First().label == "blue") resultMessage = "Candidate is classified as blue";
                }

            }
            else
            {
                resultMessage = "Please, set a candidate";
            }

            MessageBox.Show(
                resultMessage,
                "Result:",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(neighborsComboBox.Text, out closestNeighbours)) ;

            else neighborsComboBox.Text = "Put here int";
        }

        internal double matchDistance(Point a, Point b)
        {
            double xdif = a.X - b.X;
            double ydif = a.Y - b.Y;
            return Math.Sqrt(xdif * xdif + ydif * ydif);
        }

    }

    class myPointDelta
    {
        public int x, y;
        public myPointDelta(int X, int Y) { x = X; y = Y; }
    }
    class Neighbour
    {
        public int id;
        public double distanceToCandidate;
        public String label;

        public Neighbour(int id, double dist, String label)
        {
            this.id = id;
            this.distanceToCandidate = dist;
            this.label = label;
        }
    }

}
