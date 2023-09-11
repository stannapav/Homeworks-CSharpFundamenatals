using finalProject;
using finalProject.Classes;

namespace finalProjectTest
{
    [TestClass]
    public class animalPlay
    {
        [TestMethod]
        public void catPlayFullHappy_Mouse_Mouse_Ball()
        {
            Cat cat = new Cat();

            cat.Play(Games.Mouse);
            Assert.AreEqual(cat.Happiness, 7);
            cat.Play(Games.Mouse);
            Assert.AreEqual(cat.Happiness, 14);
            string happyCat = cat.Play(Games.Ball);
            Assert.AreEqual(cat.Happiness, 19);

            string expectedHappy = $" is happy and purring. Liked {Games.Ball}";
            Assert.AreEqual(happyCat, expectedHappy);
        }

        [TestMethod]
        public void dogPlayFullHappy_Fetch_Fetch_Walk()
        {
            Dog dog = new Dog();

            dog.Play(Games.Fetch);
            Assert.AreEqual(dog.Happiness, 6);
            dog.Play(Games.Fetch);
            Assert.AreEqual(dog.Happiness, 12);
            string happyDog = dog.Play(Games.Walk);
            Assert.AreEqual(dog.Happiness, 17);

            string expectedHappy = $" is happy and wagging it's tail. Liked {Games.Walk}";
            Assert.AreEqual(happyDog, expectedHappy);
        }

        [TestMethod]
        public void catOverPlay()
        {
            Cat cat = new Cat();

            cat.Play(Games.Mouse);
            cat.Play(Games.Mouse);
            cat.Play(Games.Mouse);
            cat.Play(Games.Mouse);
            string exostedCat = cat.Play(Games.Mouse);

            string expectedCat = $" is happy but exosted. Liked {Games.Mouse}";
            Assert.AreEqual(exostedCat, expectedCat);
        }

        [TestMethod]
        public void dogOverPlay()
        {
            Dog dog = new Dog();

            dog.Play(Games.Fetch);
            dog.Play(Games.Fetch);
            dog.Play(Games.Fetch);
            dog.Play(Games.Fetch);
            dog.Play(Games.Fetch);
            string exostedDog = dog.Play(Games.Fetch);

            string expectedDog = $" is happy but exosted. Liked {Games.Fetch}";
            Assert.AreEqual(exostedDog, expectedDog);
        }

        [TestMethod]
        public void catPlay_FetchNoLike_MouseLike_WalkNoLike_BallLike()
        {
            Cat cat = new Cat();

            string expectedFetch = $" isn't happy. Didn't liked {Games.Fetch}";
            string catFetch = cat.Play(Games.Fetch);
            Assert.AreEqual(catFetch, expectedFetch);

            string expectedMouse = $" isn't happy. Liked {Games.Mouse}";
            string catMouse = cat.Play(Games.Mouse);
            Assert.AreEqual(catMouse, expectedMouse);

            string expectedWalk = $" isn't happy. Didn't liked {Games.Walk}";
            string catWalk = cat.Play(Games.Walk);
            Assert.AreEqual(catWalk, expectedWalk);

            string expectedBall = $" is a lil bit happy. Liked {Games.Ball}";
            string catBall = cat.Play(Games.Ball);
            Assert.AreEqual(catBall, expectedBall);
        }

        [TestMethod]
        public void dogPlay_FetchLike_MouseNoLike_WalkLike_BallLike()
        {
            Dog dog = new Dog();

            string expectedFetch = $" is a lil bit happy. Liked {Games.Fetch}";
            string dogFetch = dog.Play(Games.Fetch);
            Assert.AreEqual(dogFetch, expectedFetch);

            string expectedMouse = $" isn't happy. Didn't liked {Games.Mouse}";
            string dogMouse = dog.Play(Games.Mouse);
            Assert.AreEqual(dogMouse, expectedMouse);

            string expectedWalk = $" is a lil bit happy. Liked {Games.Walk}";
            string dogWalk = dog.Play(Games.Walk);
            Assert.AreEqual(dogWalk, expectedWalk);

            string expectedBall = $" is a lil bit happy. Liked {Games.Ball}";
            string dogBall = dog.Play(Games.Ball);
            Assert.AreEqual(dogBall, expectedBall);
        }
    }
}