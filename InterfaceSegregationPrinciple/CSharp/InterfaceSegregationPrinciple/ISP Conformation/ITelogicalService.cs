using System.Collections.Generic;

namespace ISP_Conformation
{
    internal interface ITelogicalService
    {
        void Print();
        void Draw(ISurface surface);
        TelogicalPaintBrush GetPaintBrush();
        TelogicalImage TakeSnapShot();
    }
}