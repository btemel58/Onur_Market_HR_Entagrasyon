using System;
using System.Collections.Generic;
using System.Text;

namespace Onur_Market_HR_Entagrasyon
{
    public class Token
    {
        public int statusCode { get; set; }
        public string message { get; set; }
        public Result result { get; set; }


    }
    public class Result
    {

        public string access_token { get; set; }
        public string uyumSecretKey { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
    }
}
