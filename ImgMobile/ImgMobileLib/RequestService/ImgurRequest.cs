using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgMobileLib.RequestService
{
    class ImgurRequest<T>
    {
        public String ApiClientId { get; set; }
        public String ApiClientSecret { get; set; }

        public List<T> Response { get; set; }
        public String ETag { get; set; }

        public async Task Execute()
        {

        }
    }
}
