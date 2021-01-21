using System;
using System.Collections;

namespace GoFDesignPattern.FactoryMethod
{
    public class IDCardFactory : Factory
    {
        private ArrayList owners = new ArrayList();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            owners.Add(((IDCard)product).GetOwner());
        }

        public ArrayList GetOwners()
        {
            return owners;
        }
    }
}
