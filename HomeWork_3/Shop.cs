using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal class Shop
    {
        public Shop() { }
        public string name_ { get; set; } // название
        public string adress_ { get; set; } // адрес
        public string description_ { get; set; } // описание профиля магазина
        public int phone_ { get; set; } // номер телефона
        public string mail_ { get; set; } // e-mail
        public string Name() { return name_; } // Доступ к полю name_
        public string Adress() { return adress_; } // Доступ к полю adress_
        public string Description() { return description_; } // Доступ к полю description_
        public int Phone() { return phone_; } // Доступ к полю phone_
        public string Mail() { return mail_; } // Доступ к полю mail_
    }
}
