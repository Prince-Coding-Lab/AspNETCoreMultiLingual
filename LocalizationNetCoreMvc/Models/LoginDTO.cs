using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationNetCoreMvc.Models
{
    public class LoginDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Language { get; set; }
    }
}
