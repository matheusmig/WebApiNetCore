using System;

namespace Repositories
{
    public interface ISearchFilter
    {
        /// <summary>
        /// This field represents the maximum count of itens that could be returned
        /// </summary>
        int? Top { get; set; }
        /// <summary>
        /// This field represents the count of itens that should be skiped
        /// </summary>
        int? Skip { get; set; }
        /// <summary>
        /// This field represents the minimum creation date of the searched entities
        /// </summary>
        DateTime? CreateBegin { get; set; }
        /// <summary>
        /// This field represents the maximum creation date of the searched entites
        /// </summary>
        DateTime? CreateEnd { get; set; }
    }
}
