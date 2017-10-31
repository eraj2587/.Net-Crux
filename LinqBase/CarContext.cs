using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basics.LinqBase.Migrations;
using LinqBase;

namespace Basics.LinqBase
{
    class CarContext : DbContext
    {
        public CarContext()
        {
            Configuration.LazyLoadingEnabled = true;
                Configuration.ProxyCreationEnabled = true;
        }

        public CarContext(string connectionstring)
            : base(connectionstring)
        {
            //
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
         //   Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarContext, Configuration>(connectionstring));
           // Database.Initialize(true);
        }

        public IDbSet<Car> Cars { get; set; }
        public IDbSet<Tyre> Tyres { get; set; }
        public IDbSet<Showroom> Showroom { get; set; }

    }

    public class Car
    {
        public int CarId { get; set; }
        public string Color { get; set; }
        [MaxLength(50)]
        public string Company { get; set; }
        public virtual ICollection<Tyre> Tyres { get; set; }
    }
            
    public class Tyre
    {
        public int TyreId { get; set; }
        public int Size { get; set; }
    }


    public class Showroom
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }

}
