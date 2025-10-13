using INF04_2023_01.Data;
using System.Collections.ObjectModel;
using System.Text;

namespace INF04_2023_01
{
    public partial class MainPage : ContentPage
    {
        public int CharacterNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ObservableCollection<string> PositionCollection { get; set; }
        public string SelectedPosition { get; set; }
        public bool IsCheckedLetters { get; set; }
        public bool IsCheckedNumbers { get; set; }
        public bool IsCheckedSpecial { get; set; }




        private Command generatePassword;
        public Command GeneratePassword
        {
            get
            {
                if (generatePassword == null)
                    generatePassword = new Command(
                        () =>
                        {
                            //RandomCharacter randomCharacter = new RandomCharacter();
                            //for (int i = 0; i < CharacterNumber; i++)
                            //{
                            //    if (i == 0 && IsCheckedLetters)
                            //        Password += RandomCharacter.GetUppercaseLetter();
                            //    else if (i == 1 && IsCheckedNumbers)
                            //        Password += RandomCharacter.GetNumber();
                            //    else if (i == 2 && IsCheckedSpecial)
                            //        Password += RandomCharacter.GetSpecial();
                            //    else
                            //        Password += RandomCharacter.GetLowercaseLetter();
                            //}

                            password = "";

                            StringBuilder passwordBuilder= new StringBuilder();
                            if (IsCheckedLetters)
                                passwordBuilder.Append(RandomCharacter.GetUppercaseLetter());
                            if (CharacterNumber - password.Length != 0 && IsCheckedNumbers)
                                passwordBuilder.Append(RandomCharacter.GetNumber());
                            if (CharacterNumber - password.Length != 0 && IsCheckedSpecial)
                                passwordBuilder.Append(RandomCharacter.GetSpecial());
                            for (int i = 0; i < CharacterNumber-password.Length; i++)
                                passwordBuilder.Append(RandomCharacter.GetLowercaseLetter());

                            password = string.Join("", passwordBuilder.ToString().OrderBy(c=> new Random().Next()));
                            DisplayAlert("", password, "OK");
                        }
                        );
                return generatePassword;
            }
        }

        private Command showPasswordInfo;
        public Command ShowPasswordInfo
        {
            get
            {
                if (showPasswordInfo == null)
                    showPasswordInfo = new Command(
                        () =>
                        {
                            string message = $"{Name} {Surname} {SelectedPosition} Hasło: {password}";
                            DisplayAlert("", message, "OK");
                        }
                        );
                return showPasswordInfo;
            }
        }

        private string password;
        private string passwordB;

        public MainPage()
        {
            PositionCollection = new ObservableCollection<string>()
            {
                "Kierownik",
                "Starszy programista",
                "Młodszy programista",
                "Tester"
            };

            IsCheckedLetters = true;

            InitializeComponent();
        }

    }
}
