using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_Module6_TP1.Models.BO;

namespace WebApplication_Module6_TP1.Models.ViewModel
{
    public class SamouraiVM
    {
        public Samourai samourai {get; set;}
        public List<Arme> armesList { get; set; }
        public int selectArmeId { get; set; }

    }
}