using Newtonsoft.Json;

namespace ApiProblems.Models
{
    public class TodoItem
    {

        [JsonIgnore]
        public long Id { get; private set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

}