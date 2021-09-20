using ODEV5_5.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5_5.Entities
{
    class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }

    }
}
