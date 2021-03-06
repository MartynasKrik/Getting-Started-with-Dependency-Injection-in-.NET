using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PeopleViewer.Presentation.Tests
{
    [TestClass]
    public class PeopleViewModelTests
    {
        [TestMethod]
        public void People_OnRefreshPeople_IsPopulated()
        {
            //Arrange
            var viewModel = new PeopleViewModel(new FakeReader());

            //Act
            viewModel.RefreshPeople();

            //Assert
            Assert.IsNotNull(viewModel.People);
            Assert.AreEqual(2, viewModel.People.Count());
        }

        [TestMethod]
        public void People_OnClearPeople_IsEmpty()
        {
            //Arrange
            var reader = new FakeReader();
            var viewModel = new PeopleViewModel(reader);
            viewModel.RefreshPeople();
            Assert.IsNotNull(viewModel.People, "Invalid Arrangement");
            Assert.AreEqual(2, viewModel.People.Count(), "Invalid Arrangement");

            //Act
            viewModel.ClearPeople();

            //Assert
            Assert.AreEqual(0, viewModel.People.Count());
        }
    }
}
