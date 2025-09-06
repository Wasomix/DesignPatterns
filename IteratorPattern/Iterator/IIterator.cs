namespace IteratorPattern.Iterator
{
    /// <summary>
    /// This is responsible for traversing the collection
    /// </summary>
    public interface IIterator
    {
        /// <summary>
        /// Get the first element in the collection
        /// </summary>
        /// <returns></returns>
        object First();

        /// <summary>
        /// Move to the next element in the collection
        /// </summary>
        /// <returns></returns>
        object? Next();

        /// <summary>
        /// Gets current element in the collection
        /// </summary>
        /// <returns></returns>
        object CurrentItem();

        /// <summary>
        /// Indicates if we reach the end of the collection
        /// </summary>
        bool IsDone();
    }
}
