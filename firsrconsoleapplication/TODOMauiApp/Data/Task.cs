using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOMauiApp.Data
{
    public class TaskItem : BindableObject
    {
        public string Title { get; set; }
        private bool isCompleted { get; set; }

        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; OnPropertyChanged(); }
        }
    }
}
