using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Configuration
{

    //AutServera istek yapacak uygulamalar
    public class Client
    {
        public  string Id { get; set; }
        public  string Secret { get; set; }
        public  List<String> Audiences { get; set; }//Hangi apiye erişecek bilgisini tutan propertysi

    }
}
