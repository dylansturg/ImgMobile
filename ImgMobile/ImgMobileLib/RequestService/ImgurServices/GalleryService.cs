using ImgMobileLib.Models;
using ImgMobileLib.RequestService.ImgurServices.ImgurRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ImgMobileLib.RequestService.ImgurServices
{
    class GalleryService
    {
        #region Parameters
        public class Parameters
        {
            public enum Section
            {
                Hot, Top, User
            }

            public enum Sort
            {
                Viral, Top, Time, Rising
            }

            public enum Window
            {
                Day, Week, Month, Year, All
            }


        }
        #endregion

        public ImgurApiService Service { get; set; }

        public GalleryRequest GalleryRequest()
        {
            var result = new GalleryRequest()
            {
                Page = 0,
                Section = Parameters.Section.Hot,
                Sort = Parameters.Sort.Viral,
                Window = Parameters.Window.Day,
            };

            return result;
        }

        public async Task<List<Gallery>> ExecuteRequestAsync(ImgurRequest galleryRequest)
        {
            ImgurRequest<Gallery> imgurResponse = null;
            using (var client = new HttpClient())
            {
                ImgurRequest<Object> cachedRequest;
                ImgurRouteCache.TryGetCached(galleryRequest.Route, out cachedRequest);

                var httpRequest = new HttpRequestMessage(galleryRequest.Method, galleryRequest.Request);
                httpRequest.Headers.Add("Authorization", Service.AuthorizationHeader());
                if (cachedRequest != null)
                {
                    httpRequest.Headers.IfNoneMatch.Add(new System.Net.Http.Headers.EntityTagHeaderValue(cachedRequest.ETag));
                }

                var response = await client.SendAsync(httpRequest);

                switch (response.StatusCode)
                {
                    case System.Net.HttpStatusCode.OK:
                        imgurResponse = new ImgurRequest<Gallery>();
                        imgurResponse.Parse(await response.Content.ReadAsStringAsync());

                        ImgurRouteCache.Add(new ImgurRequest<Object>
                        {
                            ETag = imgurResponse.ETag,
                            Response = imgurResponse.Response.OfType<Object>().ToList(),
                            Route = imgurResponse.Route,
                        });
                        break;
                    case System.Net.HttpStatusCode.NotModified:
                        imgurResponse = new ImgurRequest<Gallery>()
                        {
                            ETag = cachedRequest.ETag,
                            Route = cachedRequest.Route,
                        };
                        List<Gallery> convertedResponse = new List<Gallery>();
                        if (cachedRequest.Response != null)
                        {
                            convertedResponse = cachedRequest.Response.OfType<Gallery>().ToList();
                        }
                        imgurResponse.Response = convertedResponse;

                        break;
                }
            }
            
            return imgurResponse != null ? imgurResponse.Response : new List<Gallery>();
        }
    }
}
