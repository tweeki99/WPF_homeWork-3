using SecurityApp.Models;
using SecurityApp.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityApp.DataAccess
{
    public class DataInicializer : DropCreateDatabaseAlways<SecurityDataContext>
    {
        protected override void Seed(SecurityDataContext context)
        {
            context.Users.Add(new User
            {
                Login = "admin",
                Password = CryptoService.HashPassword("123"),
            });
        }
    }
}
