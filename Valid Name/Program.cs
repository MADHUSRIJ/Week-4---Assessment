namespace Valid_Name
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
            //Get name from user
            Console.Write("Enter Name:");
            string? NameString = Console.ReadLine();

            Program program = new Program();

            Result result = program.ValidateName(NameString!);

            Console.WriteLine(result.Message);
        }

        public Result ValidateName(string NameString)
        {
            Result result = new Result();

            string[] SplittedNames = NameString.Split(' ');

            
            bool ValidFirstName = false;
            bool ValidMiddleName = false;
            bool ValidLastName = false;

            int ExpandedFirstName = 0;
            int ExpandedMiddleName = 0;
            int ExpandedLastName = 0;


            for (int i = 0; i < SplittedNames.Length; i++)
            {
                if (i == 0)
                {
                    // Check if Name is in the format "H."
                    if (SplittedNames[i].Length == 2 && SplittedNames[i][1] == '.' && char.IsUpper(SplittedNames[i][0]))
                    {
                        ValidFirstName = true;
                    }

                    //Check if Name is in the Format "Herbert"
                    else if (SplittedNames[i].Length > 2 && char.IsUpper(SplittedNames[i][0]) && !SplittedNames[i].Contains('.'))
                    {
                        ValidFirstName = true;
                        ExpandedFirstName = 1;
                    }
                }
                if (i == 1)
                {
                    // Check if Name is in the format "H."
                    if (SplittedNames[i].Length == 2 && SplittedNames[i][1] == '.' && char.IsUpper(SplittedNames[i][0]))
                    {
                        ValidMiddleName = true;
                    }

                    //Check if Name is in the Format "Herbert"
                    else if (SplittedNames[i].Length > 2 && char.IsUpper(SplittedNames[i][0]) && !SplittedNames[i].Contains('.'))
                    {
                        ValidMiddleName = true;
                        ExpandedMiddleName = 1;
                    }
                }
                if (i == 2)
                {
                    // Check if Name is in the format "H."
                    if (SplittedNames[i].Length == 2 && SplittedNames[i][1] == '.' && char.IsUpper(SplittedNames[i][0]))
                    {
                        ValidLastName = true;
                    }

                    //Check if Name is in the Format "Herbert"
                    else if (SplittedNames[i].Length > 2 && char.IsUpper(SplittedNames[i][0]) && !SplittedNames[i].Contains('.'))
                    {
                        ValidLastName = true;
                        ExpandedLastName = 1;
                    }
                }
            }
            
            if(SplittedNames.Length == 2)
            {
                if (ValidFirstName && ValidMiddleName)
                {
                    if (ExpandedFirstName == 0 && ExpandedMiddleName == 1)
                    {
                        result.Status = true;
                        result.Message = "Name is Ok";
                        return result;
                    }
                }
            }

            if(SplittedNames.Length == 3)
            {
                if(ValidFirstName && ValidMiddleName && ValidLastName)
                {
                    if ((ExpandedFirstName == 0 && ExpandedMiddleName == 0 && ExpandedLastName == 1) ||
                        (ExpandedFirstName == 1 && ExpandedMiddleName == 0 && ExpandedLastName == 1) ||
                        (ExpandedFirstName == 1 && ExpandedMiddleName == 1 && ExpandedLastName == 1))
                    {
                        result.Status = true;
                        result.Message = "Name is Ok";
                        return result;
                    }
                }
            }


            result.Status = false;
            result.Message = "Name is not formatted properly";
            return result;
        }
    }
}