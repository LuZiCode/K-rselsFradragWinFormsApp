using NUnit.Framework;
using MyLibrary;

namespace KørselFradragTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FradragTestVed28Km()
        {
            //Arrange 
            CalculateFradrag fradrag = new CalculateFradrag();

            //Act
            double intValue = fradrag.RunCalulationOfFradrag(28, 218); 
            //Assert
            Assert.AreEqual(490, intValue);
        }

        [Test]
        public void FradragTestVed24Km()
        {
            //Arrange 
            CalculateFradrag fradrag = new CalculateFradrag();

            //Act
            double intValue = fradrag.RunCalulationOfFradrag(24, 218);
            //Assert
            Assert.AreEqual(0, intValue);
        }

        [Test]
        public void FradragTestVed140Km()
        {
            //Arrange 
            CalculateFradrag fradrag = new CalculateFradrag();

            //Act
            var intValue = fradrag.RunCalulationOfFradrag(140, 218);
            //Assert
            Assert.AreEqual(12977, intValue);
        }

        [Test]
        public void FradragTestVed180Km()
        {
            //Arrange 
            CalculateFradrag fradrag = new CalculateFradrag();

            //Act
            var intValue = fradrag.RunCalulationOfFradrag(180, 218);
            //Assert
            Assert.AreEqual(15426, intValue);
        }
    }
}