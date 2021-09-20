using ODEV5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5_5.Abstracts
{
     interface ICustomerService
    {
        void Save(Gamer  gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);

    }
}
