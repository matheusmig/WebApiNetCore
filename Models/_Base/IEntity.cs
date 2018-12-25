using System;

namespace Models
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime CreatedOn { get; set; }

        DateTime UpdatedOn { get; set; }
    }
}
