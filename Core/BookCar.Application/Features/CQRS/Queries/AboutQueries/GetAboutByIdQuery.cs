namespace BookCar.Application.Features.CQRS.Queries.AboutQueries
{
    public class GetAboutByIdQuery
    {
        //Diğer taraftan bir nesne üzerinden bu Id yi çağıracağımız için Yapıcı methodu çağırmış olduk.
        public GetAboutByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
