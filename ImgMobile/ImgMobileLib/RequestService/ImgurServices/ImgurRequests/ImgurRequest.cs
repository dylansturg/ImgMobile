using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ImgMobileLib.RequestService.ImgurServices.ImgurRequests
{
    abstract class ImgurRequest
    {
        public String ApiBase
        {
            get
            {
                return "https://api.imgur.com/3";
            }
        }

        public HttpMethod Method
        {
            get
            {
                return HttpMethod.Get;
            }
        }

        public abstract String Route { get; }
        public abstract Uri Request { get; }
    }
}
