using ShopTask.Models;

namespace ShopTask.Abstract;

public interface IDrinkShop<T> where T : Product
{
    void AddProduct(T product);
    void SellProduct(string name, int quantity);
    void DisplayProducts();
    void ShowIncome();
}
