using aspnetcoregraphql.Data;
using GraphQL.Types;

namespace aspnetcoregraphql.Models
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType(ICategoryRepository categoryRepository)
        {
            Field(x => x.Id).Description("Product id.");
            Field(x => x.Name).Description("Nome da loja");
            Field(x => x.Cardbrand, nullable: true).Description("Bandeira cadastrada");
            Field(x => x.MerchantReference).Description("Protocolo Adquirente");
            Field(x => x.MCC).Description("MCC loja.");

            Field<CategoryType>(
                "category", 
                resolve: context => categoryRepository.GetCategoryAsync(context.Source.CategoryId).Result
             );
        }
    }
}
