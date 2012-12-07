using System.Collections.Generic;

namespace InterfaceSegregationPrinciple
{
    internal interface ITelogicalService
    {
        void Print();
        void Draw(ISurface surface);
        TelogicalPaintBrush GetPaintBrush();
        TelogicalImage TakeSnapShot();
        void SendNotification(IEnumerable<User> users);
        void Save(TelogicalImage image);

    }
}