using System;

namespace PCM.Groups.Core
{
    /// <summary>
    /// Set opertaions
    /// </summary>
    public static class GroupOperationExtentions
    {
        /// <summary>
        /// Union both group in one
        /// </summary>
        public static IGroup<T> Union<T>(this IGroup<T> group1, IGroup<T> group2)
        {
            var operationSet = new GroupSetOperation<T>();
            return operationSet.Union(group1, group2);
        }


        public static IGroup<Target> Transform<Source,Target>(this IGroup<Source> group1, Func<Source, Target> transfromFunction, Func<Target , Source> backWard)
        {


            var operationSet = new GroupSetOperation<Source>();

            return operationSet.Transform(group1, transfromFunction, backWard);

          
        }
    }
}