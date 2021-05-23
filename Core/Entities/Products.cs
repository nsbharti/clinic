namespace Core.Entities
{
    public class Products: BaseEntitiy
    {
        public string ProductName { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public string PictureURL { get; set; }
        public ProductType ProductType { get; set; }

        public int ProductTypeId { get; set; }

        public ProductBrand ProductBrand { get; set; }

        public int ProductBrandId { get; set; }
    }
}