using PokeShop.DATA.EF.Models;//Grants access to Product

namespace PokeShop.UI.MVC.Models
{
    public class CartItemViewModel
    {
        public int Qty { get; set; }

        public Product Product { get; set; }
        //The above is an example of a concept called "Containment":
        //This is the use of a complex datatype as a field or property in another complex type

        //Complex datatypes: Any class with multiple properties (Prodcut, ContactViewModel, DateTime, etc.)
        //Primitive datatypes: Any class that stores ONLY a SINGLE value (int, bool, char, decimal, etc.)


        //Constructor (ctor)
        public CartItemViewModel(int qty, Product product)
        {
            //assign
            Qty = qty;
            Product = product;
        }
    }
}
