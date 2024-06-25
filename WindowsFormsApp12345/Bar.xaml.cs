using System.Windows.Controls;

namespace WindowsFormsApp12345
{
    /// <summary>
    /// Interaction logic for Bar.xaml
    /// </summary>
    public partial class Bar : UserControl
    {
        public int tank1_value, tank2_value, tank3_value;
        public Bar()
        {
            InitializeComponent();
        }
        public void change_value_tank1()
        {
            Processvalue.Height = tank1_value;
        }

        public void change_value_tank2()
        {
            Processvalue.Height = tank2_value;
        }

        public void change_value_tank3()
        {
            Processvalue.Height = tank3_value;
        }
    }
}
