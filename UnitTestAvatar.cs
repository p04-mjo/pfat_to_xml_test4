using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pfat_to_xml_comprehensive;


namespace pfat_to_xml_test4
{
    [TestClass]
    public class UnitTestAvatar
    {

        [TestMethod]
        public void Avatar_a_street_test1()
        {
            // Arrange
            Person person = new Person();
            

            // Act
            person.A("A|street|city|zip");

            //Assert
            Assert.AreEqual("street", person.Get_street());
        }

        [TestMethod]
        public void Avatar_a_city_test1()
        {
            // Arrange
            Person person = new Person();


            // Act
            person.A("A|street|city|zip");

            //Assert
            Assert.AreEqual("city", person.Get_city());
        }
        [TestMethod]
        public void Avatar_a_zip_test1()
        {
            // Arrange
            Person person = new Person();


            // Act
            person.A("A|street|city|zip");

            //Assert
            Assert.AreEqual("zip", person.Get_zip());
        }
        [TestMethod]
        public void Avatar_a_zip_test2()
        {
            // Arrange
            Person person = new Person();


            // Act
            person.A("A|street|city");

            //Assert
            Assert.AreEqual("", person.Get_zip());
        }

        [TestMethod]
        public void Avatar_t_cell_test1()
        {
            // Arrange
            Person person = new Person();


            // Act
            person.T("T|cell|landline");

            //Assert
            Assert.AreEqual("cell", person.Get_cell());
        }


        [TestMethod]
        public void Avatar_t_landline_test2()
        {
            // Arrange
            Person person = new Person();


            // Act
            person.T("T|cell|landline");

            //Assert
            Assert.AreEqual("landline", person.Get_landline());
        }


    }
}