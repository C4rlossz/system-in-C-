using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[Category]")]
        public class Category
        {

            public int Id { get; set; }
            public required string Name { get; set; }
            public required string Slug { get; set; }
        }
}