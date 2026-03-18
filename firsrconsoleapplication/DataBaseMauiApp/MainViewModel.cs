using PeopleTestClassLibrary;
using PeopleTestClassLibrary.DTO_s;
using DataBaseMauiApp.ViewModelModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseMauiApp
{
	internal class MainViewModel : BindableObject
	{
		public ObservableCollection<Person> People {  get; set; }

        private Person selectedPerson;
		public Person SelectedPerson
		{
			get { return selectedPerson; }
            set { selectedPerson = value; OnPropertyChanged(); }
		}

        private Person selectedPersonCopy;
		public Person SelectedPersonCopy
		{
            get { return selectedPersonCopy; }
			set { selectedPersonCopy = value; OnPropertyChanged(); }
        }



        private Command getAllPeople;
		public Command GetAllPeople
		{
			get
			{
				if (getAllPeople == null)
					getAllPeople = new Command(
						() =>
						{
                            People.Clear();
                            foreach (PersonDTO person in peopleRepository.GetAllPeopleDTO())
                            {
                                People.Add(new Person() { Id = person.Id, Name = person.Name, Surname = person.Surname, Age = person.Age});
                            }
                        }
						);
                return getAllPeople;

            }

		}



		private Command setNewParameters;
        public Command SetNewParameters
        {
            get
            {
                if (setNewParameters == null)
                    setNewParameters = new Command(
                        () =>
                        {
                            if (SelectedPersonCopy == null)
                                return;

                            int id = SelectedPerson.Id;
                            peopleRepository.UpdatePerson(SelectedPersonCopy.Id, SelectedPersonCopy.Name, SelectedPersonCopy.Surname, SelectedPersonCopy.Age);

                            SelectedPerson.Name = SelectedPersonCopy.Name;
                            SelectedPerson.Surname = SelectedPersonCopy.Surname;
                            SelectedPerson.Age = SelectedPersonCopy.Age;
                        }
                        );
                return setNewParameters;

            }

        }

        private Command selectionChange;
        public Command SelectionChange
        {
            get
            {
                if (selectionChange == null)
                    selectionChange = new Command(
                        () =>
                        {
                            SelectedPersonCopy = GetPersonCopy(SelectedPerson);
                        }
                        );
                return selectionChange;
            }

        }

        private PeopleRepository peopleRepository;
        public MainViewModel()
		{
            People = new ObservableCollection<Person>();
            peopleRepository = new PeopleRepository();
		}

        private Person GetPersonCopy(Person person)
        {
            if (person == null)
                return null;
            return new Person() { Id = person.Id, Name = person.Name, Surname = person.Surname, Age = person.Age };
        }
    }
}
