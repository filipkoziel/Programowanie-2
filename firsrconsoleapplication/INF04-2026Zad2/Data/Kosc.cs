using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace INF04_2026Zad2.Data
{
    public class Kosc : BindableObject
    {
        public static int NumberOfDice;
        public List<string> imageNames = new List<string>(["kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png"]);
        public int numberThrown;
        public int imageFileIdentifier;
        private string imageName;

        public string ImageName
        {
            get { return imageName; }
            set { imageName = imageNames[imageFileIdentifier]; OnPropertyChanged();}
        }

        private bool available;

        public bool Available
        {
            get { return available; }
            set { available = value; OnPropertyChanged(); }
        }

        private double opacity;

        public double Opacity
        {
            get { return opacity; }
            set { if (Available)
                    opacity = 1.0;
                else
                    opacity = 0.5;
                OnPropertyChanged();
            }
        }


        public Kosc(int number)
        {
            if (!((int[])[1, 2, 3, 4, 5, 6]).Contains(number))
            {
                number = 0;
            }
            numberThrown = number;
            imageFileIdentifier = number;
            Available = true;
            ImageName = "kosc0.png";
            Opacity = 1.0;
            NumberOfDice++;
        }

        public Kosc()
        {
            Random rnd = new Random();
            int number = rnd.Next(1,6);
            numberThrown = number;
            imageFileIdentifier = number;
            Available = true;
            ImageName = "kosc0.png";
            Opacity = 1.0;
            NumberOfDice++;
        }

        public void throwDiceIfAvailable()
        {
            if (available)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 6);
                numberThrown = number;
                imageFileIdentifier = number;
                ImageName = "kosc0.png";
            }
        }


        private Command switchAvailability;
        public Command SwitchAvailability
        {
            get
            {
                if (switchAvailability == null)
                    switchAvailability = new Command(
                        () =>
                        {
                            Available = !available;
                            Opacity = 0;
                        }
                        );
                return switchAvailability;
            }
        }

    }
}
