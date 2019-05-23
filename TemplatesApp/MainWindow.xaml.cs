using System.Collections.Generic;
using System.Windows;

namespace TemplatesApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> names = new List<string>
            {
              "Pikachu", "Naruto", "Sasuke" ,"Барнаби Мармадюк Алоизий Бенджи Кобвеб Дартаньян Эгберт Феликс Гаспар Гумберт Игнатий Джейден Каспер Лерой Максимилиан Недди Объяхулу Пепин Кьюллиам Розенкранц Секстон Тедди Апвуд Виватма Уэйленд Ксилон Ярдли Закари Усански"
            };

            listBox.ItemsSource = names;

            dataGrid.ItemsSource = new List<object> { new  { Id = 1, Name = "Арбуз", Price = 100000 }, new { Id = 1, Name = "Картошка", Price = 100000 } };
        }

    }
}
