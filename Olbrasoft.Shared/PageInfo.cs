namespace Olbrasoft.Shared
{
    public class PageInfo
    {
        public int Size { get; }
        public int Number { get; }

        public PageInfo(int size = 10, int number = 1)
        {
            Size = size;
            Number = number;
        }
    }
}