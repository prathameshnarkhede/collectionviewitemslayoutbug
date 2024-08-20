using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Item> Items { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<Item>
                {
                    new Item { Title = "Item 1", ImageUrl = "https://via.placeholder.com/150" },
                    new Item { Title = "Item 2", ImageUrl = "https://via.placeholder.com/150" },
                    new Item { Title = "Item 3", ImageUrl = "https://via.placeholder.com/150" },
                    new Item { Title = "Item 4", ImageUrl = "https://via.placeholder.com/150" },
                    new Item { Title = "Item 5", ImageUrl = "https://via.placeholder.com/150" },
                    new Item { Title = "Item 6", ImageUrl = "https://via.placeholder.com/150" }
                };

            BindingContext = this;
        }

        private void IncreaseSpan_Clicked(object sender, EventArgs e)
        {
            if (gridItemsLayout.Span < 10) // Set a maximum span limit if needed
            {
                gridItemsLayout.Span += 1;
            }
        }

        private void ReassignLayout_Clicked(object sender, EventArgs e)
        {
            if (gridItemsLayout.Span < 10) // Set a maximum span limit if needed
            {
                gridItemsLayout = new GridItemsLayout(3, ItemsLayoutOrientation.Vertical);
            }
        }
    }

}
