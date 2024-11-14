using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext:DbContext //entity'nin paketlerini kurduk
    {
        public DbSet<Category> Categories { get; set; } // Yeşil yazılı 'Category' C# tarafında kullandığımız class ın ismi; Beyaz renkli 'Categories' ise SQL'e yansıyacak olan tablo ismi :)
                                                        // yani yalın hali class çoğul hali tablo 
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
