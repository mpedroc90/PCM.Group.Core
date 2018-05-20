using System;


namespace PCM.Groups.Core
{
    ///<inheritdoc/>
    public sealed class GenericGroup<T> : Group<T>
    {
        private readonly Func<T, bool> _isBelongsFunction;


        /// <summary>
        /// Create a generic group
        /// </summary>
        /// <param name="name">Name of the group</param>
        /// <param name="isBelongsFunction">Function to check if an item belongs to the group</param>
        public GenericGroup(string name,  Func<T,bool> isBelongsFunction)
        {
             Name = name;
            _isBelongsFunction = isBelongsFunction;
        }

        ///<inheritdoc/>
        public override string Name { get; set; }

        ///<inheritdoc/>
        public override bool IsBelong(T item)
        {
            return _isBelongsFunction(item);
        }
    }
}
