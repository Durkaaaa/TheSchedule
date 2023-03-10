using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TheSchedule.Entities;
using TheSchedule.Serves;
using TheSchedule.View.Pages;

namespace TheSchedule.ViewModel.Pages
{
    public class SchedulePageViewModel : ViewModelBase
    {
        private List<Schedule> _monday;

        public List<Schedule> Monday
        {
            get => _monday;
            set => Set(ref _monday, value, nameof(Monday));
        }

        private List<Schedule> _tuesday;

        public List<Schedule> Tuesday
        {
            get => _tuesday;
            set => Set(ref _tuesday, value, nameof(Tuesday));
        }

        private List<Schedule> _wednesday;

        public List<Schedule> Wednesday
        {
            get => _wednesday;
            set => Set(ref _wednesday, value, nameof(Wednesday));
        }


        private List<Schedule> _thursday;

        public List<Schedule> Thursday
        {
            get => _thursday;
            set => Set(ref _thursday, value, nameof(Thursday));
        }

        private List<Schedule> _friday;

        public List<Schedule> Friday
        {
            get => _friday;
            set => Set(ref _friday, value, nameof(Friday));
        }




        public SchedulePageViewModel(Class @class)
        {
            Monday = new ScheduleServes().GetDay(@class, 1);
            Tuesday = new ScheduleServes().GetDay(@class, 2);
            Wednesday = new ScheduleServes().GetDay(@class, 3);
            Thursday = new ScheduleServes().GetDay(@class, 4);
            Friday = new ScheduleServes().GetDay(@class, 5);
        }


    }
}
