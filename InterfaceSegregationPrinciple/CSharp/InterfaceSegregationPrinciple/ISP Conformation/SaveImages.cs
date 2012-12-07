using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP_Conformation
{
    class SaveImages : ISaveImages
    {
        public void Save(TelogicalImage image)
        {
            Console.WriteLine("Lets save this propreitary telogical image {0}, to {1}", image.Name, image.Path);
        }
    }
}
