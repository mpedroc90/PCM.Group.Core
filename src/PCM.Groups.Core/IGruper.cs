using System.Collections.Generic;

namespace PCM.Groups.Core
{
    /// <summary>
    /// Gruper of items
    /// </summary>
    public interface IGruper<T>
    {
        /// <summary>
        /// Gruper items 
        /// </summary>
        /// <param name="items"></param>
        IEnumerable<IGroup<T>> Group(IEnumerable<T> items);

    }
}