using Accord.Statistics.Running;
using System;

namespace AimmyWPF
{
    internal class PredictionManager
    {
        public int PredX = 0;
        public int PredY = 0;

        public void GetShalloePredictionX(int CurrentX, int PrevX, int EnemyWidth, int EnemyHeight)
        {

            var xVelocity = CurrentX - PrevX;
            var EnemySize = EnemyWidth * EnemyHeight;
            //var ScreenResolution = WinAPICaller.ScreenWidth * WinAPICaller.ScreenHeight;
            var ScreenResolution = 640 * 640;
            var EnemyDistance = (1 - (EnemySize / ScreenResolution));

            var BulletSpeed = 10;

            PredX = System.Windows.Forms.Cursor.Position.X + (xVelocity * (EnemyDistance * BulletSpeed));
        }

        public void GetShalloePredictionY(int CurrentY, int PrevY, int EnemyWidth, int EnemyHeight)
        {

            var yVelocity = CurrentY - PrevY;
            var EnemySize = EnemyWidth * EnemyHeight;
            //var ScreenResolution = WinAPICaller.ScreenWidth * WinAPICaller.ScreenHeight;
            var ScreenResolution = 640 * 640;
            var EnemyDistance = (1 - (EnemySize / ScreenResolution));

            var BulletSpeed = 1;

            PredY = System.Windows.Forms.Cursor.Position.Y + (yVelocity * (EnemyDistance * BulletSpeed));
        }
    }
}