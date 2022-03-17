namespace Calc
{
    public enum StatusEnum { Healthy, Unhealthy, Recovering }
    public class Pets
    {
        
        public List<Object> Pet { get; set; }
        public int Count { get; set; } = 0;

        public Guid PetID { get; set; }

        public string Breed { get; set; }

        public string AnimalType { get; set; }

        public int Price { get; set; }
        public int Cost { get; set; }


        public Pets()
        {

        }        
    }
    public class PetStatus // 8elw na epistrefei boolean, me true gia healthy/recovering kai false gia Unhealthy
    {
        public StatusEnum Status { get; set; }
        public PetStatus()
        {
            StatusEnum? Healthy = StatusEnum.Healthy;
            StatusEnum? Unhealthy = StatusEnum.Unhealthy;
            StatusEnum? Recovering = StatusEnum.Recovering;
        }
    }
}