namespace BookListApp.Models
{
    public class ColumnSeprator
    {
        public ColumnSeprator(int start, int end)
        {
            this.Start = start - 1;
            this.End = end - 1;
        }
        public int Start { get; set; }
        public int End { get; set; }
    }
}