using System;
using System.Collections.Generic;
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
    /// SidebarView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SidebarView : UserControl
    {
        public SidebarView()
        {
            InitializeComponent();
        }

        private void MenuListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 1. 나(사이드바)를 담고 있는 메인 창(MainWindow) 찾아오기
            // (경고용 빨간 줄이 뜬다면 상단에 using Exam; 을 추가해야 할 수도 있어)
            var mainWindow = Window.GetWindow(this) as MainWindow;

            if (mainWindow != null)
            {
                // 2. 사용자가 몇 번째 메뉴를 눌렀는지 번호 확인 (0번부터 시작)
                int selectedIndex = MenuListBox.SelectedIndex;

                // 3. 번호에 따라 메인 도화지(MainContentArea) 내용물 갈아 끼우기!
                switch (selectedIndex)
                {
                    case 0: // [0번] 첫 번째 메뉴: 현황판 (방금 만든 학생 모니터링 뷰)
                        mainWindow.MainContentArea.Content = new StudentBoardView();
                        break;

                    case 1: // [1번] 두 번째 메뉴: 파일 배포
                        mainWindow.MainContentArea.Content = new FileReady();
                        break;

                    case 2: // [2번] 세 번째 메뉴: 시험 시작/종료
                        mainWindow.MainContentArea.Content = new ExaminationView();
                        break;
                    case 3:
                        mainWindow.MainContentArea.Content = new ProcessView();
                        break;
                    case 4:
                        mainWindow.MainContentArea.Content = new RollcallView();
                        break;
                    case 5:
                        mainWindow.MainContentArea.Content = new QuizView();
                        break;


                        // ... 나머지 메뉴들도 이런 식으로 뷰를 만들어서 추가하면 돼!
                }
            }
        }
    }
}
