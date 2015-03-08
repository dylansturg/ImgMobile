using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgMobileLib.RequestService
{
    class ImgurRequest<T>
    {

        public ImgurRequest()
        {

        }

        public List<T> Response { get; set; }
        public String ETag { get; set; }

        public String Route { get; set; }

        public void Parse(string content)
        {
            T deserializedContent;
            try
            {
               deserializedContent = JsonConvert.DeserializeObject<T>(content);
            }
            catch (Exception)
            {
                deserializedContent = default(T);
            }

            List<T> result;
            if (deserializedContent == null)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<List<T>>(content);
                }
                catch (Exception)
                {
                    result = new List<T>();
                }
            }
            else
            {
                result = new List<T>();
                result.Add(deserializedContent);
            }

            Response = result;
        }
    }
}
