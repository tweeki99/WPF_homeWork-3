using DevOne.Security.Cryptography.BCrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityApp.Services
{
    public class CryptoService
    {
        public static string HashPassword(string password)
        {
            return BCryptHelper.HashPassword(password, BCryptHelper.GenerateSalt());
        }
        public static bool VerifyPassword(string candidatePassword, string hashedPassword)
        {
            return BCryptHelper.CheckPassword(candidatePassword, hashedPassword);
        }
    }
}

