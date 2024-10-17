namespace CrudRestApi
{
    public class DogModel : DogModelUpdate
    {
        public Guid Id { get; init; } = Guid.NewGuid();

    }

    public class DogModelUpdate
    {
     
        public string Name { get; init; } = "";

        public int Age { get; init; }

    }
}
