class Order : Product
{
    List<Product> _products = new List<Product>();
    // if you want store all items 
    List<Costumer> _costumers = new List<Costumer>();

    Product product = new Product();
    product.setProduct("id", "name", 1, 5);

}