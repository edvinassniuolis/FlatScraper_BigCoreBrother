namespace FlatScraper_BigCoreBrother.Model.Interface
{
    public interface IFlatRental
    {
        string Name { get; set; }
        string City { get; set; }
        string Category { get; set; }
        string RoomFrom { get; set; }
        string RoomTo { get; set; }
        string PriceFrom { get; set; }
        string PriceTo { get; set; }
        string Address { get; set; }
    }
}
