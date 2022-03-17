using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pfat_to_xml_comprehensive;


namespace pfat_to_xml_test4
{
    [TestClass]
    public class UnitTestFamilyMember
    {
        [TestMethod]
        public void FamilyMember_constructor_test1()
        {
            FamilyMember familyMember = new FamilyMember();

            Assert.IsInstanceOfType(familyMember, typeof(FamilyMember));
        }

        [TestMethod]
        public void FamilyMember_f_dob_test1()
        {
            // Arrange
            FamilyMember familyMember = new FamilyMember();

            // Act
            familyMember.F("F|namn|1922");

            //Assert
            Assert.AreEqual("1922", familyMember.Get_dob());
        }

        [TestMethod]
        public void FamilyMember_f_dob_test2()
        {
            // Arrange
            FamilyMember familyMember = new FamilyMember();

            // Act
            familyMember.F("F"); //empty

            //Assert
            Assert.AreEqual("", familyMember.Get_dob());
        }

        [TestMethod]
        public void FamilyMember_f_name_test1()
        {
            // Arrange
            FamilyMember familyMember = new FamilyMember();

            // Act
            familyMember.F("F|namn|1922");

            //Assert
            Assert.AreEqual("namn", familyMember.Get_name());
        }
    }
}