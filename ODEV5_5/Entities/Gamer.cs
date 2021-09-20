using ODEV5_5.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5_5.Entities
{
    class Gamer:IEntity
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
