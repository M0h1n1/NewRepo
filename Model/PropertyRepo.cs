using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace PropertyApp.Model
{
    public class PropertyRepo
    {
        public static List<Property> AllProperties => new List<Property>
        {
            new Property
            {
                Address = " Howard Avenue, Windsor",
                Price = 850550,
                DefaultImage = "https://i.pinimg.com/originals/80/e2/93/80e293b144175738141db62be2ace589.jpg",
                Images = new List<string>
                {
                    "https://i.pinimg.com/originals/01/11/09/011109123abda8b9232bca41ff79cc80.jpg",
                    "https://i.pinimg.com/originals/71/1c/7f/711c7fe24aa258b33b536fbf40057310.jpg",
                    "https://i.pinimg.com/originals/26/bc/1f/26bc1f7c7676c76eb2b495d142429814.jpg",
                    "https://i.pinimg.com/originals/64/16/58/641658d021d6cf8f9bc0b3236b966c03.jpg"
                }
            },
             new Property
            {
                Address = " Howard Avenue, Windsor",
                Price = 550487,
                DefaultImage = "https://i.pinimg.com/originals/92/98/a8/9298a8ec1875dc27007e5fa064fcc381.png",
                Images = new List<string>
                {
                    "https://i.pinimg.com/originals/48/66/cb/4866cbaef8f0a1838a01d0c039fd9948.jpg",
                    "https://i.pinimg.com/originals/2a/d3/37/2ad337a8332fd11acbeabaf2578cb44e.jpg",
                    "https://i.pinimg.com/originals/84/5a/fa/845afab40b4a32207c9791fd216b09dc.jpg",
                    "https://i.pinimg.com/originals/5f/a5/46/5fa546f5eea28ddd4fb2318af9e94223.jpg"
                }
            },
              new Property
            {
                Address = " Kenwick Road, Windsor",
                Price = 987452,
                DefaultImage = "https://i.pinimg.com/originals/76/30/ad/7630ad163c95cfbb072b607ea0a8e542.jpg",
                Images = new List<string>
                {
                    "https://i.pinimg.com/originals/71/f8/1b/71f81b3c102480d5feac4001e8c0aaa4.jpg",
                    "https://i.pinimg.com/originals/02/21/2c/02212c2bf0125803a49420fa841242e5.jpg",
                    "https://i.pinimg.com/originals/7e/75/a4/7e75a42c7d9518b59638eaa4dc559198.jpg",
                    "https://i.pinimg.com/originals/f8/ea/97/f8ea97781bdd90e77e47cd378b6b066a.jpg"
                }
            },
               new Property
            {
                Address = " Lepain Street, Windsor",
                Price = 665487,
                DefaultImage = "https://i.pinimg.com/originals/c4/5e/db/c45edb842b283d8bca7903ec7bbb5a2d.jpg",
                Images = new List<string>
                {
                    "https://i.pinimg.com/originals/01/11/09/011109123abda8b9232bca41ff79cc80.jpg",
                    "https://i.pinimg.com/originals/d6/0a/26/d60a262fb1f00fd6f00e2fe8e870a603.jpg",
                    "https://i.pinimg.com/originals/8d/f6/1c/8df61c1db2265acff78a9cddb79ccfd9.jpg",
                    "https://i.pinimg.com/originals/41/c4/93/41c493c98bae114c2f6bfb9be5d5f6cd.jpg"
                }
            },
                new Property
            {
                Address = " Sugarwood Crescent, Windsor",
                Price = 998758,
                DefaultImage = "https://i.pinimg.com/originals/20/56/d8/2056d875623d52efbd8b7d822a74e89f.jpg",
                Images = new List<string>
                {
                    "https://i.pinimg.com/originals/39/91/ef/3991ef3fbf89705846d81dcb1cbe2fb2.jpg",
                    "https://i.pinimg.com/originals/05/88/a2/0588a2d3432cd5efd822aae9b0001987.jpg",
                    "https://i.pinimg.com/originals/12/6f/1b/126f1b055b4a5c7cde5ab9b61d342f88.jpg",
                    "https://i.pinimg.com/originals/81/38/f8/8138f8888d5251dd3389b754bb580aab.jpg"
                }
            }

        };
        
    }
}
