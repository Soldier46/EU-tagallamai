using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU_tagallamai
{
    class eu
    {
        public string orszag { get; set; }
        public DateTime dátum { get; set; }

       
        public eu(string sör)
        {
            string[] s = sör.Split(';');
            orszag = s[0];
            dátum =Convert.ToDateTime(s[1]);
        
        
        }



    }
}
