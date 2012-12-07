using System;

namespace ISP_Conformation
{
    internal class TelogicalImage
    {
        public TelogicalImage(string name, string path)
        {
            Name = name;
            Path = path;
        }
        public String Name { get; set; }

        public String Path { get; set; }
    }
}