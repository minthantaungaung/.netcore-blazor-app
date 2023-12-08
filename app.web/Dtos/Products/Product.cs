namespace app.web.Dtos.Products
{
    public class ProductDto
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? category { get; set; }
        public string? description { get; set; }
        public string? detaildescription { get; set; }
        public double price { get; set; }
        public string? currency { get; set; }
        public string? image_url { get; set; }
        public bool availability { get; set; }
        public List<string> colors { get; set; }
        public List<string> sizes { get; set; }

        //CustomFields
        public string? modalName => $"productModal{id}";
        public string? modalDataTarget => $"#productModal{id}";
    }

}
