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
    }


    /// <inheritdoc />
    public class GroupSetOperation<T> : IGroupSetOperation<T>
    {
        /// <inheritdoc />
        public virtual IGroup<T> Union(IGroup<T> _group1, IGroup<T> _group2)
        {
            return new MixedGroup<T>(_group1, _group2);
        }
    }
}