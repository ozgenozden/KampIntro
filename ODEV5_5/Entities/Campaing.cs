using ODEV5_5.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5_5.Entities
{
    class Campaing:IEntity
    {
        public int Id { get; set; }
        public string CampaingName { get; set; }
        public int Percentage { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
