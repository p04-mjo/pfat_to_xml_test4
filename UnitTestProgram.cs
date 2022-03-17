using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pfat_to_xml_comprehensive;
using System.IO;
using System.Collections.Generic; //list
using System.Xml.Linq; // read xml

namespace pfat_to_xml_test4
{
    [TestClass]
    public class UnitTestProgram
    {
        [TestMethod]
        public void BuildPersonList_test() // async dropped
        {
            // Arrange
            string[] testdata = {"P|Elof|Sundin"};
            Program program = new Program();

            // Act
            List<Person> people = program.BuildPersonList(testdata);

            // Assert
            Assert.AreEqual(people[0].Get_firstname(), "Elof");
        }
    }
}