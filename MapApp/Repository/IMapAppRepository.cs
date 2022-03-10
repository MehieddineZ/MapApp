using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapApp.Models.MapAppModel;

namespace MapApp.Repository
{
   public interface IMapAppRepository
    {
        MapAppResponse Getaddress(string city);
    }
}
