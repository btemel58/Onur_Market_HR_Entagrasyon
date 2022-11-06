
using System;
using System.Collections.Generic;
using System.Text;

namespace Onur_Market_HR_Entagrasyon
{
    public class TokenRequestBody
    {
        public string username { get; set; }
        public string password { get; set; }

        public TokenRequestBody()
        {
            this.username = "mesut.sevinc";
            this.password = "mesut1234+";
        }
    }
}
