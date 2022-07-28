namespace Product
{
    public interface IProduct
    {
        int Id { get; set; }
        string Type { get; set; }
        string Name { get; set; }
        int Price { get; set; }
        string Description { get; set; }
        int Quantity { get; set; }
        void Print();
    }
}
