using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Salsify.Api.Modal
{
    public class modeldata
    {
        public string SKU { get; set; }
        [JsonProperty("salsify:digital_assets")]
        public List<imagedata> Image { get; set; }
        [JsonProperty("Product Title")]
        public string ProductTitle { get; set; }
        public string Vendor { get; set; }
    }
    public class imagedata
    {

        [JsonProperty("salsify:url")]
        public string MainImage { get; set; }
    }

    public class ProductListDTO
    {
        public List<modeldata> data { get; set; }

    }
}
