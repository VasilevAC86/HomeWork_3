using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal class VebSite
    {
        public VebSite() { }
        public string name_ { get; set; } // имя
        public string path_ { get; set; } // путь
        public string description_ { get; set; } // описание сайта
        public string ip_ { get; set; } // ip-адрес        
        public string Name() { return name_; } // Доступ к полю name_
        public string Path() { return path_; } // Доступ к полю path_
        public string Description () { return description_; } // Доступ к полю description_
        public string Ip() { return ip_; } // Доступ к полю ip_
    }
}
