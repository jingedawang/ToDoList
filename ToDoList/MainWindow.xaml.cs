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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using ToDoList.Model;

namespace ToDoList
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            XDocument xdoc = XDocument.Load(System.Environment.CurrentDirectory + @"\Data\data.xml");
            this.listViewToDoList.ItemsSource =
                from element in xdoc.Descendants("Item")
                select new ToDoItem()
                {
                    Content = element.Attribute("Content").Value,
                };
            
        }
    }
}
