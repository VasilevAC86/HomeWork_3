using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal class Magazine
    {
        public Magazine() { }
        public string name_ { get; set; } // название
        public int year_ { get; set; } // год основания
        public string description_ { get; set; } // описание журнала
        public int phone_ { get; set; } // номер телефона
        public string mail_ { get; set; } // e-mail
        public string Name() { return name_; } // Доступ к полю name_
        public int Year() { return year_; } // Доступ к полю year_
        public string Description() { return description_; } // Доступ к полю description_
        public int Phone() { return phone_; } // Доступ к полю phone_
        public string Mail() { return mail_; } // Доступ к полю mail_
    }
}
