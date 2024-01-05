using Xunit;
using System;
namespace Inventory.Test{
    public class ProductTest{
        [Fact]
        public void Test1(){
            //arrange
            Product p1 = new Product(1,"Mouse", 10, 2000.50);
            //act
            //assert
            Assert.True(p1.UpdatePrice(1000.50));
            Assert.Equal(1000.50, p1.getPrice());
            Assert.Equal(10, p1.getQuantity());
            Assert.True(p1.IsInStock());
        }
        [Fact]
        public void Test2(){
            Product p2 = new Product(2,"Desktop", 50, 20000);
            bool updateStock1=p2.UpdateStock(-10);
            bool updateStock2= p2.UpdateStock(-100);
            bool updatePrice1=p2.UpdatePrice(30000);
            Assert.True(updateStock1);
            Assert.False(updateStock2);
            Assert.True(p2.IsInStock());
            Assert.Equal(40,p2.getQuantity());
            Assert.True(updatePrice1);
            Assert.Equal(30000,p2.getPrice());
        }
    }
}