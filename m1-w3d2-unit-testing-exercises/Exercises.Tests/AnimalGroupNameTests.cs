using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        [TestMethod]
        public void AnimalNameWithGroup()
        {
           
            AnimalGroupName animalGroup = new AnimalGroupName();  //arrange to access Object AnimalGroupName
            string nameHerd = animalGroup.GetHerd("crow"); // action to produce string from "Get Herd" exercise 
            Assert.AreEqual("Murder", nameHerd); //assertion to compare that string produced matches appropriate herd name
        }
        [TestMethod]
        public void AnimalNameNotFound()
        {

            AnimalGroupName animalGroup = new AnimalGroupName();  //arrange to access Object AnimalGroupName
            string nameHerd = animalGroup.GetHerd("zebra"); // action to produce string from "Get Herd" exercise 
            Assert.AreEqual("unknown", nameHerd); //assertion to compare that string produced matches appropriate herd name, in this case, animal not found, unknown
        }
    }

}
