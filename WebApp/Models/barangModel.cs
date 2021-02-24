using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class barangModel
    {

        private static databaseEntities db = new databaseEntities();
        public DbSet<BARANG> b { get; set; }
        public string product_id { get; set; }
        public string produkName { get; set; }
        public int? price{ get; set; }

        public static IEnumerable<WebApp.Models.barangModel> getData(string pencarian) {

            var query = from b in db.BARANGs
                        select new barangModel
                        {
                            product_id = b.product_id,
                            produkName = b.product_name,
                            price = b.price
                        };
            if (pencarian == "")
            {
                return query.ToList();
            }
            else {
                return query.ToList().Where(b => b.product_id.Contains(pencarian) || b.produkName.Contains(pencarian));
                //return null;
            }
            

        }
    }
}