﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgMobileLib.RequestService
{
    class ImgurApiService
    {
        public String ClientId { protected get; set; }
        public String ClientSecret { protected get; set; }

        public ImgurApiService()
        {
        }

        public ImgurApiService(String id, String secret)
        {
            ClientId = id;
            ClientSecret = secret;
        }
    }
}
