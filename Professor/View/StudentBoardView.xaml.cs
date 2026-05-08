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
    /// StudentBoardView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StudentBoardView : UserControl
    {
        public StudentBoardView()
        {
            InitializeComponent();

            ObservableCollection<Student> dummyData = new ObservableCollection<Student>
            {
                new Student { StudentId = "20220001", Name = "김민준", Status = "대기" },
                new Student { StudentId = "20220002", Name = "이서연", Status = "대기" },
                new Student { StudentId = "20220003", Name = "박지훈", Status = "대기" },
                new Student { StudentId = "20220004", Name = "최수아", Status = "대기" },
                new Student { StudentId = "20220005", Name = "정도윤", Status = "대기" },
                new Student { StudentId = "20220006", Name = "강예은", Status = "접속" }, // 미접속!
                new Student { StudentId = "20220007", Name = "조현우", Status = "대기" },
                new Student { StudentId = "20220008", Name = "윤지아", Status = "대기" },
                new Student { StudentId = "20220001", Name = "김민준", Status = "대기" },
                new Student { StudentId = "20220002", Name = "이서연", Status = "대기" },
                new Student { StudentId = "20220003", Name = "박지훈", Status = "대기" },
                new Student { StudentId = "20220004", Name = "최수아", Status = "대기" },
                new Student { StudentId = "20220005", Name = "정도윤", Status = "대기" },
                new Student { StudentId = "20220006", Name = "강예은", Status = "접속" }, // 미접속!
                new Student { StudentId = "20220001", Name = "김민준", Status = "대기" },
                new Student { StudentId = "20220002", Name = "이서연", Status = "대기" },
                new Student { StudentId = "20220003", Name = "박지훈", Status = "대기" },
                new Student { StudentId = "20220004", Name = "최수아", Status = "대기" },
                new Student { StudentId = "20220005", Name = "정도윤", Status = "대기" },
                new Student { StudentId = "20220006", Name = "강예은", Status = "접속" } // 미접속!
            };

            // ItemsControl에 이 데이터를 바인딩(연결)
            StudentItemsControl.ItemsSource = dummyData;
        }
    }
public class Student
{
    public string Name { get; set; }
    public string StudentId { get; set; }
    public string Status { get; set; } // "대기" 또는 "미접속"
}
}
