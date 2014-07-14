namespace TomorrowSoft.Model
{
    public class ContralDataModel
    {
        public  int Id { get; set; }
        public string Name { get; set; }

        public ContralDataModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}