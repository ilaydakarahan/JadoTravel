namespace JadoTravel.Features.CQRS.Results.DestinationResults
{
    public class GetDestinationByIdQueryResult
    {
        public int DestinationId { get; set; }
        public string Image { get; set; }
        public string City { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }

    }
}
