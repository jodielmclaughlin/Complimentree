namespace Complimentree.Models
{
    public class Tree
    {
        public int TreeId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Size { get; set; }
        public string Species { get; set; }
        public List<Compliment> Compliments { get; set; }
    }
}
