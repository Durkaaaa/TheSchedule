using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TheSchedule.Date;
using TheSchedule.Entities;
using TheSchedule.View.Pages;

namespace TheSchedule.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Frame _frame = new Frame();

        public Frame Frame
        {
            get => _frame;
            set => Set(ref _frame, value, nameof(Frame));
        }



        private List<Class> _class;

        public List<Class> Class
        {
            get => _class;
            set => Set(ref _class, value, nameof(Class));
        }

        private Class _selectedClass;

        public Class SelectedClass
        {
            get => _selectedClass;
            set
            {
                if (value != null)
                {
                    Set(ref _selectedClass, value, nameof(SelectedClass));
                    Frame.Content = new SchedulePage(value);
                }
            }
        }


        public MainWindowViewModel()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Class = db.Classes.ToList();
            }
        }
    }
}
