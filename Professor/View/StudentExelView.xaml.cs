using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Exam.View
{
    /// <summary>
    /// StudentExelView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StudentExelView : UserControl
    {
        public StudentExelView()
        {
            InitializeComponent();
            var dummyData = new ObservableCollection<RollCallStudent>
            {
                new RollCallStudent { StudentId = "20220001", Name = "김민준", Seat = "1번", Status = "대기", Response = "-" },
                new RollCallStudent { StudentId = "20220002", Name = "이서연", Seat = "2번", Status = "대기", Response = "-" },
                new RollCallStudent { StudentId = "20220003", Name = "박지훈", Seat = "3번", Status = "대기", Response = "-" },
                new RollCallStudent { StudentId = "20220004", Name = "최수아", Seat = "4번", Status = "대기", Response = "-" },
                new RollCallStudent { StudentId = "20220005", Name = "정도윤", Seat = "5번", Status = "대기", Response = "-" },
                new RollCallStudent { StudentId = "20220006", Name = "강예은", Seat = "6번", Status = "미접속", Response = "-" },
                new RollCallStudent { StudentId = "20220007", Name = "조현우", Seat = "7번", Status = "대기", Response = "-" }
            };

            StudentListView.ItemsSource = dummyData;
        }
    }

    // 데이터 모델 클래스
    public class RollCallStudent
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Seat { get; set; }
        public string Status { get; set; }
        public string Response { get; set; }
    }
}
