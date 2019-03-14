using Revolvo.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.UI
{
    class LogoRotation
    {
        public static Image Logo { get; private set; }

        private static int CurrentAngle = 0;

        private static int Speed = 0;

        public static void SetLogo(Image logo)
        {
            Logo = logo;
        }

        public static void Rotate(Image logo, double speed = 1)
        {
            var addedAngle = CurrentAngle + (int)(speed * 10);
            if (addedAngle >= 360) addedAngle = 0;

            Logo = RevolvoImg.RotateImage(logo, addedAngle);
            CurrentAngle = addedAngle;
            Logo = RevolvoImg.RotateImage(Logo, CurrentAngle);
        }
    }
}
