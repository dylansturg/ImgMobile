using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImgMobileLib.RequestService.ImgurServices;

namespace ImgMobileLib.RequestService.ImgurServices.ImgurRequests
{
    class GalleryRequest : ImgurRequest
    {
        private String _routeFormat = "/gallery";

        public GalleryService.Parameters.Section Section {get; set;}
        public GalleryService.Parameters.Sort Sort { get; set; }
        public GalleryService.Parameters.Window Window { get; set; }

        public int Page { get; set; }

        public bool ShowViral { get; set; }

        public String Route
        {
            get
            {
                var routeBuilder = _routeFormat;
                routeBuilder += "/" + Section.ToString();
                routeBuilder += "/" + Sort.ToString();
                routeBuilder += "/" + Window.ToString();
                routeBuilder += "/" + Page.ToString();
                return routeBuilder;
            }
        }

        public Uri Request
        {
            get
            {
                var builder = new UriBuilder(ApiBase + Route);
                return builder.Uri;
            }
        }
    }
}
