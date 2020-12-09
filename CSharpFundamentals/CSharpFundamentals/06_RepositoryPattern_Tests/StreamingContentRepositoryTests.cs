using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class UnitTesStreamingContentRepositoryTests
    {
        //add method
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {       //arrange
            StreamingContentTests content = new StreamingContentTests();
            content.Title = ShouldSetCorrectString = "Toy Story";
            StreamingContentRepositoryTests repository = new UnitTesStreamingContentRepositoryTests();

            //Act --> Get/run teh code we want to test
            repository.AddcontentToList(content);
            StreamingContentTests contentFromDirectory = repository.GetContentByTitle("Toy Story)");


            //Assert ---> Use the assert class to verify the expected outcome
            Assert.IsNotNull(contentFromDirectory);


        }

        //update
    }
}
 