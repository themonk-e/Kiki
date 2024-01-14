using System.Text.RegularExpressions;

namespace Models
{
    public class Restaurant
    {
        public Restaurant()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Cuisine { get; set; }
        public TimeSpan? OpenTime { get; set; }
        public TimeSpan? CloseTime { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string ZipCode { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {OpenTime.ToString()}-{CloseTime.ToString()}, {Email}, {Phone}, {Website}, {ZipCode} ";
        }
    }
}