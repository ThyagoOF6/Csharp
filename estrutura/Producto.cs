namespace estrutura
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity) {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double total() {
            return Price * Quantity;
        }

        public void updatePrice(double percentage) {
            Price = Price * (1 + percentage / 100.0);
        }


        public override string ToString()
        {
            return Name + ", $" + Price.ToString("F2") + ", " + Quantity;
        }
    }
}