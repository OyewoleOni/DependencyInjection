using DependencyInjection;
using System;
using Xunit;

namespace DependencyInjectionTest
{
    public class OrdermanagerTest
    {
        [Fact]
        public void Test1()
        {
            var orderManger = new OrderManager();
            orderManger.Submit(Product.Keyboard, "1000100010001000", "0120");
            Assert.ThrowsAny<Exception>(() => orderManger.Submit(Product.Keyboard, "1000100010001000", "0120"));

        }
    }
}
