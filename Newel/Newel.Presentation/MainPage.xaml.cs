using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Newel.Presentation
{
    public partial class MainPage : ContentPage
    {
        private NewelDbContext _context;
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            _context = new NewelDbContext();
            _context.Database.Migrate();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}