using Valid_Name;

namespace Valid_Name_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInvalidName_Herbert()
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
        public void TestInvalidName_H_Wells()
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
        public void TestInvalidName_HDot_G_Wells()
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
        public void TestInvalidName_hDot_Wells()
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
        public void TestInvalidName_HDot_wells()
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
        public void TestInvalidName_hDot_gDot_Wells()
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
        public void TestInvalidName_HDot_GeorgeDot_Wells()
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
        public void TestInvalidName_HDot_GDot_WDot()
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
        public void TestInvalidName_HerbDot_GDot_Wells()
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
        public void TestValidName_HDot_Wells()
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
        public void TestValidName_HDot_GDot_Wells()
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
        public void TestValidName_Herbert_GDot_Wells()
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
        public void TestValidName_Herbert_George_Wells()
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