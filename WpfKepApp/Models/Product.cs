using System;

namespace WpfKepApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public Product(string name, decimal price, decimal discount)
        {
            Name = name;
            Price = price;
            Discount = discount;
        }

        public Product() : this("Новий товар", 0, 0) { }

        public string GetFormattedDiscount{ 
            get => Discount == 0 ? "Немає" : Discount.ToString() + "%";
        }
        public string GetPriceAfterDiscount
        {
            get => Price * (100 - Discount) /100 + "";
        }
        public override string ToString()
        {
            return $"{Name} - Ціна без знижки: {Price}, Знижка: {GetFormattedDiscount}, " +
                $"Остаточна ціна: {GetPriceAfterDiscount}";
        }
    }
}