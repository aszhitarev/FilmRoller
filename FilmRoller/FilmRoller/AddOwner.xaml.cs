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

namespace FilmRoller
{
    /// <summary>
    /// Логика взаимодействия для AddOwner.xaml
    /// </summary>
    public partial class AddOwner : Window
    {
        public AddOwner()
        {
            InitializeComponent();
        }

        private void AddOwnerButton_Click(object sender, RoutedEventArgs e)
        {
            using (FilmRollerContext db = new FilmRollerContext())
            {
                Owner owner = new Owner
                {
                    OwnerName = OwnerName.Text
                };
                try
                {
                    db.Owners.Add(owner);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    StatusText.Text = ex.ToString();
                }

            }
        }
    }
}
