using MicrosoftToDo.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MicrosoftToDo.ViewModels
{
    public class MainViewModel
    {
        private ObservableCollection<MenuItem> menuItems;

        public ObservableCollection<MenuItem> MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }


        public MainViewModel()
        {
            MenuItems = new ObservableCollection<MenuItem>();
            MenuItems.Add(new MenuItem() { Icon = "\xe635", Name = "我的一天", Count = 1, BackColor = "#FF3E8E6C" });
            MenuItems.Add(new MenuItem() { Icon = "\xe6b6", Name = "重要", Count = 2, BackColor = "#FFAC395D" });
            MenuItems.Add(new MenuItem() { Icon = "\xe65b", Name = "已计划日程", Count = 0, BackColor = "#FF3E8E6C" });
            MenuItems.Add(new MenuItem() { Icon = "\xe614", Name = "已分配给你", Count = 0, BackColor = "#FFAC395D" });
            MenuItems.Add(new MenuItem() { Icon = "\xe755", Name = "任务", Count = 4, BackColor = "#FF3E8E6C" });
        }
    }
}
