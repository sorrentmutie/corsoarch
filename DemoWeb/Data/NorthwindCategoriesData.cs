using DemoWeb.Interfaces;
using DemoWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWeb.Data;


public class GenericNorthwindData<T, U, TKey> : IData<T, U, TKey> where T : class
{
    private readonly NorthwindContext context;
    private DbSet<T> entities;

    public GenericNorthwindData(NorthwindContext context)
    {
        this.context = context;
        entities = context.Set<T>();
    }

    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public T Delete(TKey id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<U> EstraiCategorie()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> Get()
    {
        return entities;
    }

    public T? Get(TKey id)
    {
        throw new NotImplementedException();
    }

    public T Update(T entity)
    {
        throw new NotImplementedException();
    }
}



public class NorthwindCategoriesData : ICategoriesData
{
    private readonly NorthwindContext context;

    public NorthwindCategoriesData(NorthwindContext context)
    {
        this.context = context;
    }

    public void AddCategory(Category category)
    {
        context.Add(category);
        context.SaveChanges();
    }

    public Category DeleteCategory(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CategoriaDTO> EstraiCategorie()
    {
        return context.Categories.Select(c => new CategoriaDTO { Id = c.CategoryId, Nome = c.CategoryName,
          NumeroProdotti = c.Products.Count}).ToList();
    }

    public IEnumerable<Category> GetCategories()
    {
        return context.Categories.ToList();
    }

    public Category? GetCategory(int id)
    {
        return context.Categories.Find(id);
    }

    public Category UpdateCategory(Category category)
    {
        throw new NotImplementedException();
    }
}
