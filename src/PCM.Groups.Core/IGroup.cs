using System.Collections.Generic;

namespace PCM.Groups.Core
{

    /// <summary>
    /// Group of the items.
    /// </summary>
    public interface IGroup<T> 
    {
        /// <summary>
        /// Name of the Group
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Check if the item belongs to the group
        /// </summary>
        /// <param name="item">File to check</param>
        bool IsBelong(T item);

        /// <summary>
        /// Add the item to the group
        /// </summary>
        /// <param name="item">item to add</param>
        void Add(T item);
        
        /// <summary>
        /// Get the item on the group
        /// </summary>
        IEnumerable<T> Items { get; }

    }


   


    /// <inheritdoc />
    public abstract class Group<T> : IGroup<T>
    {
       
        /// <summary>
        /// List where are store the items
        /// </summary>
        protected readonly IList<T> items = new List<T>();

        /// <inheritdoc />
        public abstract string Name { get; set; }

        /// <inheritdoc />
        public abstract bool IsBelong(T item);

        /// <inheritdoc />
        /// <exception cref="ItemNotBelongsToTheGroupException">If the Items does not belongs to the group</exception>>
        public virtual void Add(T item)
        {
            if (!IsBelong(item))
                throw new ItemNotBelongsToTheGroupException();

            items.Add(item);
        }

        /// <inheritdoc />
        public virtual IEnumerable<T> Items => items;

       
    }

    
}