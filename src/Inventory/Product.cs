using System.Data;

namespace Inventory{
    public class Product{

        public Product(){
            this.id=-1;
            this.name=string.Empty;
            this.quantity=0;
            this.price=0.0;
        }
        public Product(int id, string name,int quantity,double price){
            this.id=id;
            this.name=name;
            this.quantity=quantity;
            this.price=price;
        }

        public int getQuantity(){
            return this.quantity;
        }
        public double getPrice(){
            return this.price;
        }

        public string getName(){
            return this.name;
        }

        public int getId(){
            return this.id;
        }

        public bool IsInStock(){
            return (this.quantity >0 ? true: false);
        }
        public bool UpdateStock(int quantity){
            int updatedQuantity = this.quantity + quantity;
            if(updatedQuantity <0){
                System.Console.WriteLine("Cannot update the quantitiy");
                return false;
            }
            this.quantity = updatedQuantity;
            System.Console.WriteLine($"Updated quantity: {this.quantity}");
            return true;
            
        }

        public bool UpdatePrice(double price){
            if(price < 0){
                System.Console.WriteLine("Price must be positive");
                return false;
            }
            this.price=price;
            System.Console.WriteLine($"Update price: {this.price}");
            return true;
        }
        private int id;
        private string name;
        private int quantity;
        private double price;
    }
}