using System;

namespace Olbrasoft.Shared.Pagination
{
    public class Paging : IPaging
    {
        public int NumberOfPages { get; }
        public int NumberOfSelectedPage { get; }


        public Paging(int numberOfPages, int numberOfSelectedPage)
        {
            if (numberOfSelectedPage < 1) throw new ArgumentOutOfRangeException(nameof(numberOfSelectedPage));
            if (numberOfPages < 1) throw new ArgumentOutOfRangeException(nameof(numberOfPages));
            if (numberOfPages < numberOfSelectedPage) throw new ArgumentException($"{nameof(numberOfSelectedPage)} can not be greater than the {nameof(numberOfPages)}!");

            NumberOfPages = numberOfPages;
            NumberOfSelectedPage = numberOfSelectedPage;
        }

    }
}