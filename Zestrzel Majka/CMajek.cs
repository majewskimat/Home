using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zestrzel_Majka.Properties;

namespace Zestrzel_Majka
{
    class CMajek : CImageBase
    {
        private Rectangle majekHotSpot = new Rectangle();
        public CMajek()
            : base (Resources.Majek)
        {
            majekHotSpot.X = Left + 20;
            majekHotSpot.Y = Top - 30;
            majekHotSpot.Width = 80;
            majekHotSpot.Height = 200;
        }
        
        public void Update(int X, int Y)
        {
            Left = X;
            Top = Y;
            majekHotSpot.X = Left + 20;
            majekHotSpot.Y = Top - 1;
        }
        public bool Trafienie(int X, int Y)
        {
            Rectangle c = new Rectangle(X, Y, 1, 1);

            if (majekHotSpot.Contains(c))
            {
                return true;
            }
            return false;
        }

        

        
    }
}
