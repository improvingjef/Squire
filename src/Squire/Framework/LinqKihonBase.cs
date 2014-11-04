using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Squire.Framework
{
    [TestFixture]
    public abstract class LinqKihonBase : BaseKihon
    {
        [Test]
        public void Select_the_Something_property_from_list_test()
        {
            //arrange
            var product = new Product() { Something = 1 };
            var list = new List<Product>()
                           {
                               product
                           };



            //act
            var item = Select_the_Something_property_from_list(list);

            //assert
            Assert.AreEqual(product.Something, item.SingleOrDefault());
        }

        [Test]
        public void Filter_the_products_where_something_is_equal_to_2_from_list_test()
        {
            //arrange
            var product = new Product() { Something = 2 };
            var list = new List<Product>()
                           {
                               product,
                               new Product(){Something = 1}
                           };



            //act
            var item = Filter_the_products_where_something_is_equal_to_2_from_list(list);

            //assert
            Assert.AreEqual(1, item.Count());
        }

        [Test]
        public void Order_the_list_by_the_something_property_test()
        {
            //arrange
            var product = new Product() { Something = 2 };
            var list = new List<Product>()
                           {
                               product,
                               new Product(){Something = 1}
                           };



            //act
            IEnumerable<Product> item = Order_the_list_by_the_something_property(list);

            //assert
            Assert.AreEqual(list[1], item.FirstOrDefault());
            Assert.AreEqual(list[0], item.LastOrDefault());
        }


        [Test]
        public void Order_the_list_by_the_something_property_descending_test()
        {
            //arrange
            var product = new Product() { Something = 2 };
            var list = new List<Product>()
                           {
                               product,
                               new Product(){Something = 1}
                           };



            //act
            IEnumerable<Product> item = Order_the_list_by_the_something_property_descending(list);

            //assert
            Assert.AreEqual(list[0], item.FirstOrDefault());
            Assert.AreEqual(list[1], item.LastOrDefault());
        }

        [Test]
        public void Flatten_the_children_into_a_single_file_line_and_return_their_names_in_alphabetical_order()
        {
            var parents = new List<Parent>
            {
                new Parent
                {
                    Children = new List<Child>
                    {
                        new Child
                        {
                            Name = "Charlie"
                        },

                        new Child
                        {
                            Name = "Frank"
                        },
                    }
                },
                new Parent
                {
                    Children = new List<Child>
                    {
                        new Child
                        {
                            Name = "Zelda"
                        },
                        new Child
                        {
                            Name = "Jimbo"
                        },
                        new Child
                        {
                            Name = "Margaret"
                        },
                    }
                },

                new Parent
                {
                    Children = new List<Child>
                    {
                        new Child
                        {
                            Name = "Ben"
                        },

                        new Child
                        {
                            Name = "Annie"
                        },
                    }
                },

            };

            var names = Flatten_the_children_into_a_single_file_line_and_return_their_names_in_alphabetical_order(parents);
            Assert.AreEqual(7, names.Count());
            Assert.AreEqual(new string[] { "Annie", "Ben", "Charlie", "Frank", "Jimbo", "Margaret", "Zelda" }, names.ToArray());
        }

        protected abstract IEnumerable<string> Flatten_the_children_into_a_single_file_line_and_return_their_names_in_alphabetical_order(List<Parent> parents);

        protected abstract IEnumerable<Product> Order_the_list_by_the_something_property_descending(List<Product> list);
        protected abstract IEnumerable<Product> Order_the_list_by_the_something_property(List<Product> list);
        protected abstract IEnumerable<Product> Filter_the_products_where_something_is_equal_to_2_from_list(List<Product> list);
        protected abstract IEnumerable<int> Select_the_Something_property_from_list(List<Product> list);
    }

    public class Parent
    {
        public List<Child> Children { get; set; }
    }

    public class Child
    {
        public string Name { get; set; }
    }

    public class Product
    {
        public int Something { get; set; }
    }
}