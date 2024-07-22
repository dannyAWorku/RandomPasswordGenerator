namespace RandomPasswordGenerator
{
    public class Generator
    {
        public int NumberOfPassword { get; set; }
        public string[] Password { get; }
        Random random = new Random();


        public Generator( int numberOfPassword) 
        { 
            NumberOfPassword = numberOfPassword;
            Password = new string[NumberOfPassword];
            char[] SpecialChars = new char[] { '@','#','$','%','&','*'};            
            for (int i = 0; i < NumberOfPassword; i++)
            {
                var Upper = char.ConvertFromUtf32(random.Next(65, 91));
                var Lower1 = char.ConvertFromUtf32(random.Next(97, 122));
                var Lower2 = char.ConvertFromUtf32(random.Next(97, 122));
                char SpecialChar = SpecialChars[random.Next(0, 6)];
                int FourDigit = random.Next(1000, 10000);
                Password[i] = Upper + SpecialChar + FourDigit.ToString() + Lower1 + Lower2;
            }
        }

        public string[] GetPasswords()
        {
            return Password;
        }  

    }
}
