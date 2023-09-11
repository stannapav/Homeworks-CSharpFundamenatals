using finalProject.Classes;

namespace finalProjectTest
{
    [TestClass]
    public class animalToString
    {
        [TestMethod]
        public void catToString_NameDiana_BreedBritish_Age11_FurColorGray()
        {
            string name = "Diana", breed = "British", furColor = "Gray";
            int age = 11;
            Cat cat = new Cat(name, breed, furColor, age);

            string expected = $"This cats name: {name}\n" +
                $"Age: {age}\n" +
                $"Breed: {breed}\n" +
            $"Color of fur: {furColor}\n" +
                $"{name} happiness: {0} \n" +
                $"{name} fullness: {0} ";

            Assert.AreEqual(expected, cat.ToString());
        }

        [TestMethod]
        public void dogToString_NameJustin_BreedJork_Age1_FurColorWhite()
        {
            string name = "Justin", breed = "Jork", furColor = "White";
            int age = 1;
            Dog dog = new Dog(name, breed, furColor, age);

            string expected = $"This dogs name: {name}\n" +
                $"Age: {age}\n" +
                $"Breed: {breed}\n" +
            $"Color of fur: {furColor}\n" +
                $"{name} happiness: {0} \n" +
                $"{name} fullness: {0} ";

            Assert.AreEqual(expected, dog.ToString());
        }
    }
}