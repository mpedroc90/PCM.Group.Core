using System.Collections.Generic;

namespace PCM.Groups
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