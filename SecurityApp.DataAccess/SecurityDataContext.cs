namespace SecurityApp.DataAccess
{
    using SecurityApp.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SecurityDataContext : DbContext , IDisposable
    {
        public SecurityDataContext()
             : base("name=SecurityContext")
        {
            Database.SetInitializer(new DataInicializer());
        }
        public virtual DbSet<User> Users { get; set; }
    }
}