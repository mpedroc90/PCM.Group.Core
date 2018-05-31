namespace PCM.Groups
{
    ///<inheritdoc/>
    /// <summary>
    /// Represents an Empty group
    /// </summary>
    
    public class EmptyGroup<T> : Group<T>
    {
        ///<inheritdoc/>
        public override string Name { get; set; } = "";

        ///<inheritdoc/>
        public override bool IsBelong(T item)
        {
            return false;
        }
    }
}
