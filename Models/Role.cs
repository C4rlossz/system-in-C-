using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[Role]")]
        public class Role
        {

            public int Id { get; set; }
            public required string Name { get; set; }
            public required string Slug { get; set; }
        }
}