using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pfat_to_xml_comprehensive;


namespace pfat_to_xml_test4
{
    [TestClass]
    public class UnitTestPerson
    {
        [TestMethod]
        public void Person_constructor_test1()
        {
            Person person = new Person();

            Assert.IsInstanceOfType(person, typeof(Person));
        }

        [TestMethod]
        public void Person_f_firstname_test1()
        {
            // Arrange
            Person person = new Person();
            
            // Act
            person.P("P|förnamn|efternamn");

            //Assert
            Assert.AreEqual("förnamn", person.Get_firstname());
        }

        [TestMethod]
        public void Person_f_firstname_test2()
        {
            // Arrange
            Person person = new Person();

            // Act
            person.P("P"); // empty

            //Assert
            Assert.AreEqual("", person.Get_firstname());
        }

        [TestMethod]
        public void Person_f_lastname_test1()
        {
            // Arrange
            Person person = new Person();

            // Act
            person.P("P|förnamn|efternamn");

            //Assert
            Assert.AreEqual("efternamn", person.Get_lastname());
        }
    }
}