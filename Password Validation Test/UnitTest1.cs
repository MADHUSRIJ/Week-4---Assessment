using Password_Validation;

namespace Password_Validation_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForShortPassword()
        {
            Program program = new Program();
            Result ActualResult = program.CheckPassword("P1zz@");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Password is too Short"
            };
            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestForLongPassword()
        {
            Program program = new Program();
            Result ActualResult = program.CheckPassword("P1zz@1aA@eaD%LpfxqDfKcDSP1zz@1aA@eaD%LpfxqDfKcDS");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Password is too Long"
            };
            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestForNotContainingUpperCasePassword()
        {
            Program program = new Program();
            Result ActualResult = program.CheckPassword("p1zz@za");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Password doesn't contain uppercase"
            };
            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestForNotContainingLowerCasePassword()
        {
            Program program = new Program();
            Result ActualResult = program.CheckPassword("P@SD1ZZF@");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Password doesn't contain lowercase"
            };
            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestForNotContainingNumberPassword()
        {
            Program program = new Program();
            Result ActualResult = program.CheckPassword("PqwsPzz@");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Password doesn't contain number"
            };
            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestForContainingNonAllowedSpecialCharacterPassword()
        {
            Program program = new Program();
            Result ActualResult = program.CheckPassword("||qQwi12@");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Special Character Mentioned is not allowed"
            };
            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestForContainingMoreThanTwoPassword()
        {
            Program program = new Program();
            Result ActualResult = program.CheckPassword("P1@zzz@1PP");
            Result ExpectedResult = new Result()
            {
                Status = false,
                Message = "Password contains more than 2 repeated characters"
            };
            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        [TestMethod]
        public void TestForValidPassword()
        {
            Program program = new Program();
            Result ActualResult = program.CheckPassword("Bd@1310");
            Result ExpectedResult = new Result()
            {
                Status = true,
                Message = "Password is Ok"
            };
            Assert.AreEqual(ExpectedResult.Status, ActualResult.Status);
            Assert.AreEqual(ExpectedResult.Message, ActualResult.Message);
        }

        
    }
}