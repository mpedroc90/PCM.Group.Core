using System.Linq;
using Xunit;

namespace PCM.Groups.Core.Test
{
    public class GroupOperator_Should
    {
        [Fact]
        public void Union_The_Elements_Of_the_Group()
        {
            var group1  = new GroupFake();
            group1.Add(new object());
            var group2 = new GroupFake();
            group2.Add(new object());


            IGroup<object> group = group1.Union(group2);

            Assert.Equal(2, group.Items.Count());

        }


        [Fact]
        public void Transform_The_Elements_Of_the_Group()
        {
            var group1 = new GenericGroup<object>("string", t=> t is string);

            group1.Add("1");
            

            IGroup<int> group = group1.Transform((t)=> int.Parse(t.ToString()), t=> t.ToString());

            Assert.Equal(1, group.Items.First());

        }

    }
}
