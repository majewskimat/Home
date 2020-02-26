//#define My_Debug

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zestrzel_Majka.Properties;

namespace Zestrzel_Majka
{
    
    public partial class ZestrzelMajka : Form
    {
        int WynikNum = 6;
        int KrewNum = 3;
        bool _krew = false;

        int gameFrame = 0;
        int krewTime = 0;

        int trafienia = 0;
        int miss = 0;
        int ilośćStrzałów = 0;
        double sredniaTrafien = 0;
#if My_Debug
        int _cursX = 0;
        int _cursY = 0;
#endif

        CMajek majek;
        CKrew krew;
        Cmenu menu;
        Cwynik wynik;

        Random rnd = new Random();
        public ZestrzelMajka()
        {
            InitializeComponent();

            Bitmap b = new Bitmap(Resources.celownik);
            this.Cursor = CustomCursor.CreateCursor(b, b.Height / 2, b.Width / 2);
            majek = new CMajek(){Left = -500,Top = -600};
            wynik = new Cwynik() { Left = 0, Top = 0 };
            krew = new CKrew();
            menu = new Cmenu() { Left = 750, Top = 10 };
        }
        
        private void timerGameLoop_Tick(object sender, EventArgs e)
        {
            if (gameFrame >= WynikNum)
            {
                UpdateMajek();
                gameFrame = 0;
            }
            if (_krew)
            {
                if (krewTime >= KrewNum)
                {
                    _krew = false;
                    krewTime = 0;
                    UpdateMajek();
                }
                krewTime++;
            }
            gameFrame++;
            this.Refresh();
        }

        private void UpdateMajek()
        {
            majek.Update(
                rnd.Next(60, 900),
                rnd.Next(150, 350)
                );
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;

            if (_krew == true)
            {
                krew.DrawImage(dc);
            }
            else
            {
                majek.DrawImage(dc);
            }
            
            menu.DrawImage(dc);
            wynik.DrawImage(dc);
#if My_Debug
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "X = " + _cursX.ToString() + " : " + " Y = " + _cursY.ToString(), _font,
                new Rectangle(0, 0, 200, 20), Color.White, flags);

#endif
            TextFormatFlags flags = TextFormatFlags.Left;
            Font _font = new System.Drawing.Font("ArialBlack", 16, FontStyle.Bold);
            TextRenderer.DrawText(e.Graphics, "Strzały: " + ilośćStrzałów.ToString(), _font, new Rectangle(30, 35, 140, 35), Color.White, flags);
            TextRenderer.DrawText(e.Graphics, "Trafienia: " + trafienia.ToString(), _font, new Rectangle(30, 60, 140, 35), Color.White, flags);
            TextRenderer.DrawText(e.Graphics, "Pudło: " + miss.ToString(), _font, new Rectangle(30, 85, 140, 35), Color.White, flags);
            TextRenderer.DrawText(e.Graphics, "Średnia: " + sredniaTrafien.ToString("F0") + "%", _font, new Rectangle(30, 110, 160, 35), Color.White, flags);
            majek.DrawImage(dc);
            base.OnPaint(e);
        }

        private void ZestrzelMajka_MouseMove(object sender, MouseEventArgs e)
        {
#if My_Debug
            _cursX = e.X;
            _cursY = e.Y;
#endif
            this.Refresh();
        }

        private void ZestrzelMajka_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > 772 && e.X < 881 && e.Y > 6 && e.Y < 38)
            {
                timerGameLoop.Start();
            }
            else if (e.X > 772 && e.X < 881 && e.Y > 43 && e.Y < 75)
            {
                timerGameLoop.Stop();
                
            }
            else if (e.X > 772 && e.X < 881 && e.Y > 80 && e.Y < 113)
            {
                Application.Restart();
            }
            else if (e.X > 772 && e.X < 881 && e.Y > 120 && e.Y < 153)
            {
                Application.Exit();
            }
            else
            {
                if (majek.Trafienie(e.X, e.Y))
                {
                    _krew = true;
                    krew.Left = majek.Left;
                    krew.Top = majek.Top;

                    trafienia++;
                }
                else
                {
                    miss++;
                }
                
                ilośćStrzałów = trafienia + miss;
                sredniaTrafien = (double)trafienia / (double)ilośćStrzałów * 100.0;
            }
            Gun();
        }

        private void Gun()
        {
            SoundPlayer simpleSound = new SoundPlayer(Resources.Ak);

            simpleSound.Play();
        }

        
    }
}
