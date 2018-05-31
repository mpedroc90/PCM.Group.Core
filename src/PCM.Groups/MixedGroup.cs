using System.Collections.Generic;
using System.Linq;

namespace PCM.Groups
{
    /// <inheritdoc />
    /// <summary>
    ///  Group which mixed for  groups
    /// </summary>
    internal sealed class MixedGroup<T> : Group<T>
    {
        private readonly IList<IGroup<T>> groups;

        /// <summary>
        /// Create a mixed group
        /// </summary>
        /// <param name="groups">Set of group to mix</param>
        public MixedGroup(params IGroup<T> [] groups)
        {
            this.groups = groups.ToList();
            AddItemsToList();
            DefineName(groups);
        }


        /// <inheritdoc/>
        public override string Name { get; set; }
        
        /// <inheritdoc/>
        public override bool IsBelong(T item)
        {
            return groups.Any(t => t.IsBelong(item));
        }

        private void DefineName(IReadOnlyList<IGroup<T>> @group)
        {
            Name += $"{@group[0].Name}";
            for (int i = 1; i < @group.Count; i++)
                Name += $" + {@group[i].Name}";
        }

        private void AddItemsToList()
        {
            foreach (var item in groups.SelectMany(t => t.Items))
                Add(item);
        }
    }
}