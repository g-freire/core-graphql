namespace aspnetcoregraphql.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Cardbrand { get; set; }
        public double MerchantReference { get; set; }
        public double MCC { get; set; }


        Category Category { get; set;}
    }
}