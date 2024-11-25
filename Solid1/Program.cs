using System.Collections.Generic;
//Принцип єдиної відповідальності
class Item
{
}
namespace Solid1
{
    class Order
    {
        private List<Item> itemList = new List<Item>();

        public IReadOnlyList<Item> ItemList => itemList;

        public void CalculateTotalSum() {/*...*/}
        public void AddItem(Item item) => itemList.Add(item);
        public void DeleteItem(Item item) => itemList.Remove(item);
        public int GetItemCount() => itemList.Count;
    }

    // Клас для збереження/завантаження замовлення
    class OrderRepository
    {
        public void Load(Order order) {/*...*/}
        public void Save(Order order) {/*...*/}
        public void Update(Order order) {/*...*/}
        public void Delete(Order order) {/*...*/}
    }

    // Клас для відображення замовлення
    class OrderPrinter
    {
        public void PrintOrder(Order order) {/*...*/}
        public void ShowOrder(Order order) {/*...*/}
    }
    class Program
    {
        static void Main()
        {
        }
    }
}
