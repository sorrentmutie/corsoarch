using DemoWeb.Data;
using DemoWeb.Models;

namespace DemoWeb.Interfaces;

public class UnitOfWork
{
    private readonly NorthwindContext context;
    private readonly IData<Category, CategoriaDTO, int> categoriesData;
    private readonly IData<Product, ProductDTO, int> productData;

    public UnitOfWork(NorthwindContext context)
    {
        this.context = context;
        categoriesData = new GenericNorthwindData<Category, CategoriaDTO, int>(context);
        productData = new GenericNorthwindData<Product, ProductDTO, int>(context);
    }
}
