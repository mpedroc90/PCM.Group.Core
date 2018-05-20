using System.Linq;
using Xunit;

namespace PCM.Groups.Core.Test
{
    public class EmptyGroup_Should
    {
        [Fact]
        public void Has_not_items()
        {
            var empty = new EmptyGroup<object>();
            Assert.False(empty.Items.Any());
        }


        [Fact]
        public void Throw_items_doesnt_not_belongs_to_group()
        {
            var empty = new EmptyGroup<object>();
            Assert.Throws<ItemNotBelongsToTheGroupException>(()=> empty.Add(new object()));
        }


        [Fact]
        public void Returns_false_to_any_objects_when_ask_for_belogings()
        {
            var empty = new EmptyGroup<object>();
            Assert.False(empty.IsBelong(new object()));
        }
    }
}
