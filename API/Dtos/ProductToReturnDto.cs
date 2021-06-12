namespace API.Dtos
{
    public class ProductToReturnDto
    {
        public int Id { get; set; }
         public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureURL { get; set; }
        public string ProductType { get; set; }
        public string ProductBrand { get; set; }        
    }
}