using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormAuth.Models
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ProductDetail Detail { get; set; }
    }

    public class ProductDetail
    {
        public int productdetailid { get; set; }
        public int RRP { get; set; }
        public string Supplier { get; set; }
    }

}