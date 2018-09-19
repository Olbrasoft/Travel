namespace Olbrasoft.Travel.Data.Transfer.Objects
{
    public interface IAccommodationItem
    {
        int Id { get; set; }

        string Name { get; set; }

        string Address { get; set; }

        string Location { get; set; }
    }
}