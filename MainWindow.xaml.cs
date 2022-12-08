using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Triad triad1 = new Triad();
        Triad triad2 = new Triad();
        Triad triad3 = new Triad();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SumOfTriads_Click(object sender, RoutedEventArgs e)
        {
            GetTriadsValue();
            triad3 = triad1.SumOfNum(triad1, triad2);
            MessageBox.Show($"Новая тройка:({triad1.One} + {triad2.One}, {triad1.Two} + {triad2.Two}, {triad1.Three} + {triad2.Three}) = ({triad3.One}, {triad3.Two}, {triad3.Three})", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void GetTriadsValue()
        {
            int.TryParse(valueOneTriad1.Text, out int valOneTriad1);
            int.TryParse(valueTwoTriad1.Text, out int valTwoTriad1);
            int.TryParse(valueThreeTriad1.Text, out int valThreeTriad1);

            triad1.One = valOneTriad1;
            triad1.Two = valTwoTriad1;
            triad1.Three = valThreeTriad1;

            int.TryParse(valueOneTriad2.Text, out int valOneTriad2);
            int.TryParse(valueTwoTriad2.Text, out int valTwoTriad2);
            int.TryParse(valueThreeTriad2.Text, out int valThreeTriad2);

            triad2.One = valOneTriad2;
            triad2.Two = valTwoTriad2;
            triad2.Three = valThreeTriad2;
        }

        private void PowOfNumUsr_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(UsrValue.Text, out int valUsrValue))
            {
                GetTriadsValue();
                triad3 = triad1.PowOfNum(valUsrValue, triad1);
                MessageBox.Show($"Первая тройка:({triad1.One} * {valUsrValue}, {triad1.Two} * {valUsrValue}, {triad1.Three} * {valUsrValue}) = ({triad3.One}, {triad3.Two}, {triad3.Three})", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
                triad3 = triad2.PowOfNum(valUsrValue, triad2);
                MessageBox.Show($"Вторая тройка:({triad2.One} * {valUsrValue}, {triad2.Two} * {valUsrValue}, {triad2.Three} * {valUsrValue}) = ({triad3.One}, {triad3.Two}, {triad3.Three})", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Значение не может быть пустым");
                UsrValue.Focus();
            }
        }

        private void SumOfNumUsr_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(UsrValue.Text, out int valUsrValue))
            {
                GetTriadsValue();
                triad3 = triad1.SumOfNum(valUsrValue, triad1);
                MessageBox.Show($"Первая тройка:({triad1.One} + {valUsrValue}, {triad1.Two} + {valUsrValue}, {triad1.Three} + {valUsrValue}) = ({triad3.One}, {triad3.Two}, {triad3.Three})", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
                triad3 = triad2.SumOfNum(valUsrValue, triad2);
                MessageBox.Show($"Вторая тройка:({triad2.One} + {valUsrValue}, {triad2.Two} + {valUsrValue}, {triad2.Three} + {valUsrValue}) = ({triad3.One}, {triad3.Two}, {triad3.Three})", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Значение не может быть пустым");
                UsrValue.Focus();
            }
        }

        private void CompareTriads_Click(object sender, RoutedEventArgs e)
        {
            GetTriadsValue();
            if (triad1.CompareTriad(triad1, triad2))
            {
                MessageBox.Show("Двойки равны");
            }
            else
            {
                MessageBox.Show("Двойки не равны");
            }
        }

        private void TaskBut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Агеев Алексей\nЗадание: . Использовать класс Triad (тройка чисел). Разработать операцию для сложения \nтриады с числом. Разработать операцию для сложения элементов одой триады с \nдругой триадой.", "Вариант 12", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AppClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            UsrValue.Clear();
            valueOneTriad1.Clear();
            valueTwoTriad1.Clear();
            valueThreeTriad1.Clear();
            valueOneTriad2.Clear();
            valueTwoTriad2.Clear();
            valueThreeTriad2.Clear();
            UsrValue.Focus();
        }

        private void SumOfUserTriadWithOperator_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(UsrValue.Text, out int userVal))
            {
                GetTriadsValue();

                triad3 = triad1 + userVal;
                MessageBox.Show($"Первая тройка:({triad1.One} + {userVal}, {triad1.Two} + {userVal}, {triad1.Three} + {userVal}) = ({triad3.One}, {triad3.Two}, {triad3.Three})", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);

                triad3 = triad2 + userVal;
                MessageBox.Show($"Вторая тройка:({triad2.One} + {userVal}, {triad2.Two} + {userVal}, {triad2.Three} + {userVal}) = ({triad3.One}, {triad3.Two}, {triad3.Three})", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Значение не может быть пустым");
                UsrValue.Focus();
            }
        }

        private void SumOfTriadsWithOperator_Click(object sender, RoutedEventArgs e)
        {
            GetTriadsValue();
            triad3 = triad1 + triad2;
            MessageBox.Show($"Первая тройка:({triad1.One} + {triad2.One}, {triad1.Two} + {triad2.Two}, {triad1.Three} + {triad2.Three}) = ({triad3.One}, {triad3.Two}, {triad3.Three})", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
