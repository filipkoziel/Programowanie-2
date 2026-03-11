using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseMauiApp.Model;
using PeopleTestClassLibrary;
using PeopleTestClassLibrary.Models;

namespace DataBaseMauiApp
{
	internal class MainViewModel : BindableObject
	{
		public List<Person> People
		{
			get { return dataRepository.people; }
			set { dataRepository.people = value; OnPropertyChanged(); }
		}

		public Person SelectedPerson
		{
			get { return dataRepository.selectedPerson; }
            set { dataRepository.selectedPerson = value; OnPropertyChanged(); }
		}

		public Person SelectedPersonCopy
		{
            get { return dataRepository.selectedPersonCopy; }
			set { dataRepository.selectedPersonCopy = value; OnPropertyChanged(); }
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
							People = peopleRepository.GetAllPeople();
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
							int id = SelectedPerson.Id;
							peopleRepository.UpdateName(id, SelectedPersonCopy.Name);
                            peopleRepository.UpdateSurname(id, SelectedPersonCopy.Surname);
                            peopleRepository.UpdateAge(id, SelectedPersonCopy.Age);
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
                            SelectedPersonCopy = new Person
                            {
                                Id = SelectedPerson.Id,
                                Name = SelectedPerson.Name,
                                Surname = SelectedPerson.Surname,
                                Age = SelectedPerson.Age
                            };
                        }
                        );
                return selectionChange;

            }

        }

        private DataRepository dataRepository;
        private PeopleRepository peopleRepository;
        public MainViewModel()
		{
			peopleRepository = new PeopleRepository();
			dataRepository = new DataRepository();
		}
	}
}
