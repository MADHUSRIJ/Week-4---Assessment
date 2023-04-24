namespace Password_Validation
{
    public class Result
    {
        public bool Status { get; set; }
        public string? Message { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Get the Password from user
            Console.Write("Enter your password: ");
            string? PasswordString = Console.ReadLine();

            Program program = new Program();

            Result result = program.CheckPassword(PasswordString!);

            Console.WriteLine(result.Message);

        }

        public Result CheckPassword(string PasswordString)
        {
            // Result is the class which contains the status and reason as Message
            // to tell whether the password is valid or not
            Result result = new Result();

            //Check the length of the password

            //Less than 6
            if (PasswordString.Length < 6)
            {
                result.Status = false;
                result.Message = "Password is too Short";
                return result;
            }

            //Greater than 24
            if (PasswordString.Length > 24)
            {
                result.Status = false;
                result.Message = "Password is too Long";
                return result;
            }

            String AllowedSpecialCharacters = "! @ # $ % ^ & * ( ) + = _ - { } : ; \" ' ? < > , .";
            bool UpperCase = false;
            bool LowerCase = false;
            bool Number = false;

            //Check for Uppercase, Lowercase, Numbers and allowed special characters in Password
            foreach (char character in PasswordString)
            {
                if (Char.IsUpper(character))
                {
                    UpperCase = true;
                }
                if (Char.IsLower(character))
                {
                    LowerCase = true;
                }
                if (Char.IsNumber(character))
                {
                    Number = true;
                }
                if (!Char.IsLetterOrDigit(character))
                {
                    if(!AllowedSpecialCharacters.Contains(character))
                    {
                        result.Status = false;
                        result.Message = "Special Character Mentioned is not allowed";
                        return result;
                    }
                }
                if (UpperCase && LowerCase && Number)
                {
                    break;
                }
            }

            if (!UpperCase)
            {
                result.Status = false;
                result.Message = "Password doesn't contain uppercase";
                return result;
            }

            if (!LowerCase)
            {
                result.Status = false;
                result.Message = "Password doesn't contain lowercase";
                return result;
            }

            if (!Number)
            {
                result.Status = false;
                result.Message = "Password doesn't contain number";
                return result;
            }

            



            //Check of more than 2 repeated character
            if (CheckForMoreThanTwoRepeatedCharacters(PasswordString))
            {
                result.Status = false;
                result.Message = "Password contains more than 2 repeated characters";
                return result;
            }

            result.Status = true;
            result.Message = "Password is Ok";
            return result;
        }

        public bool CheckForMoreThanTwoRepeatedCharacters(string PasswordString)
        {
            int Count = 1;
            Char PreviousCharacter = PasswordString[0];

            for(int PasswordStringIndex = 1; PasswordStringIndex<PasswordString.Length; PasswordStringIndex++)
            {
                if (Count > 2)
                {
                    return true;
                }
                if (PasswordString[PasswordStringIndex] == PreviousCharacter)
                {
                    Count++;
                }
                else
                {
                    Count = 0;
                    PreviousCharacter = PasswordString[PasswordStringIndex];
                }
                
            }
            return false;
        }
    }

}