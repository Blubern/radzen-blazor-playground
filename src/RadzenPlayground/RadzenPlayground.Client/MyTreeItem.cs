namespace radzenplayground.Client
{
    public class MyTreeItem
    {
        public string Text { get; set; }

        public List<MyTreeItem> Items { get; set; } = new List<MyTreeItem>();

        public bool Expanded { get; set; }

        public bool HasChildren => Items.Any();
    }
}
