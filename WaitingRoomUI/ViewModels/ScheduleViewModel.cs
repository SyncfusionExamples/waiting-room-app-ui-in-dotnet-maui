using System.Collections.ObjectModel;
using WaitingRoomUI.Models;

namespace WaitingRoomUI.ViewModels
{
	public class ScheduleViewModel
	{
        private ObservableCollection<Schedule> scheduleCollection;

        public ObservableCollection<Schedule> Schedule
        {
            get { return scheduleCollection; ; }
            set { scheduleCollection = value; }
        }

        internal void GenerateInfo()
        {
            scheduleCollection = new ObservableCollection<Schedule>();
            scheduleCollection.Add(new Schedule { Time = "1:40 PM", Picture="", Minutes= "16 minutes", Description= "Maybe you want to make your waiting more pleasant?", PlayBasket=true, ReadArticle=false });
            scheduleCollection.Add(new Schedule { Time = "1:25 PM", Picture = "", Minutes = "25 minutes", Description = "We are actively preparing for your visit. Thank you for your patience. Our dedicated team is ensuring a smooth, efficient, and prompt service for you.", PlayBasket = false, ReadArticle = true });
            scheduleCollection.Add(new Schedule { Time = "1:28 PM", Picture = "", Minutes = "20 minutes", Description = "Maybe you want to make your waiting more pleasant?", PlayBasket = true, ReadArticle = false });
        }

        public ScheduleViewModel()
		{
            GenerateInfo();
		}
	}
}

