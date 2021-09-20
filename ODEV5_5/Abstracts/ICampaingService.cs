using ODEV5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5_5.Abstracts
{
    interface ICampaingService
    {
        void Add(Campaing campaing);
        void Delete(Campaing campaing);
        void Update(Campaing campaing);
    }
}
