class Product
{
    protected string _productid;
    protected string _product_name;
    protected double _product_price;
    protected int _product_quantity;

    protected double _product_total_price;

    // public Product(string id, string name, double price, int quantity)
    // {
    //     _product_id = id;
    //     _product_name = name;
    //     _product_price = price;
    //     _product_quantity = quantity;
    // }

    public void setProduct(string p_id, string name, double price, int quantity)
    {
        _productid = p_id;
        _product_name = name;
        _product_price = price;
        _product_quantity = quantity;
    }

    public void calculateTotalPrice()
    {
        _product_total_price = _product_price * _product_quantity;
    }

}