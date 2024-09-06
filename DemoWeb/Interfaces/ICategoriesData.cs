using DemoWeb.Data;
using DemoWeb.Models;

namespace DemoWeb.Interfaces;

public interface ICategoriesData
{
    IEnumerable<Category> GetCategories();
    Category? GetCategory(int id);
    void AddCategory(Category category);
    Category UpdateCategory(Category category);
    Category DeleteCategory(int id);

    IEnumerable<CategoriaDTO> EstraiCategorie();
}

public interface IData<T, U, TKey> where T : class
{
    IEnumerable<T> Get();
    T? Get(TKey id);
    void Add(T entity);
    T Update(T entity);
    T Delete(TKey id);
    IEnumerable<U> EstraiCategorie();
}



