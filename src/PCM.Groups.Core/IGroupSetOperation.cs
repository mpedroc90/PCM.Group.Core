using System;

namespace PCM.Groups.Core
{
    /// <summary>
    /// Operations betweens groups
    /// </summary>
    public interface IGroupSetOperation<T>
    {
        /// <summary>
        /// Union of the groups
        /// </summary>
        IGroup<T> Union(IGroup<T> _group1, IGroup<T> _group2);

        /// <summary>
        /// Transform groups elements to another group
        /// </summary>
        /// <typeparam name="Target">Target Type group</typeparam>
        /// <param name="group1">source group</param>
        /// <param name="transfromFunction">Function to convert to source item to target</param>
        /// <param name="belongRuleFunction">Belongs Rule Function for the new Target Rule</param>
        /// <returns>Return a new Target Rule</returns>
        IGroup<Target> Transform<Target>(IGroup<T> group1, Func<T, Target> transfromFunction,
            Func<Target, T> belongRuleFunction);
    }

    /// <inheritdoc />
    public class GroupSetOperation<T> : IGroupSetOperation<T>
    {
        /// <inheritdoc />
        public virtual IGroup<T> Union(IGroup<T> _group1, IGroup<T> _group2)
        {
            return new MixedGroup<T>(_group1, _group2);
        }


        public virtual IGroup<Target> Transform<Target>( IGroup<T> group1, Func<T, Target> transfromFunction, Func<Target, T> backWard)
        {
            var group = new GenericGroup<Target>(nameof(Target), t => group1.IsBelong(backWard(t)));


            foreach (var item in group1.Items)
                group.Add(transfromFunction(item));
            return group;
        }

    }
}