using finalProject;
using finalProject.Classes;

namespace finalProjectTest
{
    [TestClass]
    public class animalFeed
    {
        [TestMethod]
        public void catFeedFull_Meat_Fish_Feed_Vegetable()
        {
            Cat cat = new Cat();

            cat.Feed(Food.Meat);
            Assert.AreEqual(cat.Fullness, 5);
            cat.Feed(Food.Fish);
            Assert.AreEqual(cat.Fullness, 8);
            cat.Feed(Food.Feed);
            Assert.AreEqual(cat.Fullness, 14);
            string full = cat.Feed(Food.Vegetable);
            Assert.AreEqual(cat.Fullness, 15);

            string expected = " is full and happy so their are purring";
            Assert.AreEqual(expected, full);
        }

        [TestMethod]
        public void dogFeedFull_Meat_Meat_Fish_Feed_Vegetable()
        {
            Dog dog = new Dog();

            dog.Feed(Food.Meat);
            Assert.AreEqual(dog.Fullness, 5);
            dog.Feed(Food.Meat);
            Assert.AreEqual(dog.Fullness, 10);
            dog.Feed(Food.Fish);
            Assert.AreEqual(dog.Fullness, 13);
            dog.Feed(Food.Feed);
            Assert.AreEqual(dog.Fullness, 19);
            string full = dog.Feed(Food.Vegetable);
            Assert.AreEqual(dog.Fullness, 20);

            string expected = " is full and happy so their tail is wagging";
            Assert.AreEqual(expected, full);
        }

        [TestMethod]
        public void catOverFeed()
        {
            Cat cat = new Cat();

            cat.Feed(Food.Meat);
            Assert.AreEqual(cat.Fullness, 5);
            cat.Feed(Food.Meat);
            Assert.AreEqual(cat.Fullness, 10);
            cat.Feed(Food.Meat);
            Assert.AreEqual(cat.Fullness, 15);
            cat.Feed(Food.Meat);
            Assert.AreEqual(cat.Fullness, 20);
            string overFeed =  cat.Feed(Food.Meat);
            Assert.AreEqual(cat.Fullness, 15);

            string expected = " puked because you gave it too much food";
            Assert.AreEqual(expected, overFeed);
        }

        [TestMethod]
        public void dogOverFeed()
        {
            Dog dog = new Dog();

            dog.Feed(Food.Meat);
            Assert.AreEqual(dog.Fullness, 5);
            dog.Feed(Food.Meat);
            Assert.AreEqual(dog.Fullness, 10);
            dog.Feed(Food.Meat);
            Assert.AreEqual(dog.Fullness, 15);
            dog.Feed(Food.Meat);
            Assert.AreEqual(dog.Fullness, 20);
            dog.Feed(Food.Meat);
            Assert.AreEqual(dog.Fullness, 25);
            string overFeed = dog.Feed(Food.Meat);
            Assert.AreEqual(dog.Fullness, 20);


            string expected = " puked because you gave it too much food";
            Assert.AreEqual(expected, overFeed);
        }

        [TestMethod]
        public void catEat_MeatFishFeedLike_VegetableNoLike()
        {
            Cat cat = new Cat();

            string expectLikeMeat = $" ate {Food.Meat} and liked it";
            string likeMeat = cat.Feed(Food.Meat);
            Assert.AreEqual(likeMeat, expectLikeMeat);

            string expectLikeFish = $" ate {Food.Fish} and liked it";
            string likeFish = cat.Feed(Food.Fish);
            Assert.AreEqual(likeFish, expectLikeFish);

            string expectLikeFeed = $" ate {Food.Feed} and liked it";
            string likeFeed = cat.Feed(Food.Feed);
            Assert.AreEqual(likeFeed, expectLikeFeed);

            cat.Fullness -= 10;
            string expectNoLikeVegetable = $" ate {Food.Vegetable} and didnt quite liked";
            string NoLikeVegetable = cat.Feed(Food.Vegetable);
            Assert.AreEqual(NoLikeVegetable, expectNoLikeVegetable); 
        }

        [TestMethod]
        public void dogEat_MeatFishFeedLike_VegetableNoLike()
        {
            Dog dog = new Dog();

            string expectLikeMeat = $" ate {Food.Meat} and liked it";
            string likeMeat = dog.Feed(Food.Meat);
            Assert.AreEqual(likeMeat, expectLikeMeat);

            string expectLikeFish = $" ate {Food.Fish} and liked it";
            string likeFish = dog.Feed(Food.Fish);
            Assert.AreEqual(likeFish, expectLikeFish);

            string expectLikeFeed = $" ate {Food.Feed} and liked it";
            string likeFeed = dog.Feed(Food.Feed);
            Assert.AreEqual(likeFeed, expectLikeFeed);

            string expectNoLikeVegetable = $" ate {Food.Vegetable} and didnt quite liked";
            string NoLikeVegetable = dog.Feed(Food.Vegetable);
            Assert.AreEqual(NoLikeVegetable, expectNoLikeVegetable);
        }
    }
}