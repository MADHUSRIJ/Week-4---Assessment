using Valid_Name;

namespace Valid_Name_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInvalidNameHerbert()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("Herbert");
            Result ExpectedResult = new Result() 
            {
                Status = false,
                Message = "Name is not formatted properly",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);  
        }

        [TestMethod]
        public void TestInvalidNameH_Wells()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("H Wells");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Name is not formatted properly",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestInvalidNameHDot_G_Wells()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("H. G Wells");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Name is not formatted properly",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestInvalidNamehDotWells()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("h. Wells");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Name is not formatted properly",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestInvalidNameHDotwells()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("H. wells");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Name is not formatted properly",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestInvalidNamehDotgDotWells()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("h. g. Wells");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Name is not formatted properly",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestInvalidNameHDotGeorgeDotWells()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("H. George Wells");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Name is not formatted properly",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestInvalidNameHDotGDotWDot()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("H. G. W.");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Name is not formatted properly",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestInvalidNameHerbDotGDotWells()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("Herb. G. Wells");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Name is not formatted properly",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestValidNameHDot_Wells()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("H. Wells");
            Result ExpectedResult = new Result()
            {
                Status = true,
                Message = "Name is Ok",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestValidNameHDot_GDot_Wells()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("H. G. Wells");
            Result ExpectedResult = new Result()
            {
                Status = true,
                Message = "Name is Ok",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestValidNameHerbert_GDot_Wells()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("Herbert G. Wells");
            Result ExpectedResult = new Result()
            {
                Status = true,
                Message = "Name is Ok",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }
        [TestMethod]
        public void TestValidNameHerbert_George_Wells()
        {
            Program program = new Program();
            Result ActualResult = program.ValidateName("Herbert George Wells");
            Result ExpectedResult = new Result()
            {
                Status = true,
                Message = "Name is Ok",
            };

            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }
    }
}