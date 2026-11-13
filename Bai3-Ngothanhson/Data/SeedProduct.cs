namespace Bai3_Ngothanhson.Data
{
    public class SeedProduct
    {
        public static List<Models.Product> products = new List<Models.Product>
        {
            new Models.Product(){Id=1,Name="Product1",Price=36,Description="Niganiganiga",CategoryId=1},
            new Models.Product(){Id=2,Name="Product2",Price=36,Description="Niganiganiga",CategoryId=2},
            new Models.Product(){Id=3,Name="Product3",Price=36,Description="Niganiganiga",CategoryId=3}
        };
    }
}
