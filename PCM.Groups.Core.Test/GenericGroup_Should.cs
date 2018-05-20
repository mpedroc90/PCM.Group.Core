using System;
using Xunit;

namespace PCM.Groups.Core.Test
{
    public class GenericGroup_Should
    {
        [Theory]
        [InlineData(5,5, true)]
        [InlineData(5, 6, false)]
        public void Returns_expectedResult_with_when_verify_an_item_with_rule(int item, int rule, bool expectedResult)
        {
            var genericGroup =  new GenericGroup<int>("integer group", t => t== rule );

            Assert.True(genericGroup.IsBelong(item) == expectedResult);
        }


        [Fact]
        public void Add_to_Group()
        {

            var _group = new GenericGroup<object>("FakeName", t => true);
            _group.Add(new object());
            Assert.Single(_group.Items);
        }


        [Fact(DisplayName = "Throw ItemNotBelongsToTheGroupException if isnta Xml")]

        public void Throw_FileNotBelongsToTheGroupException_if_isnt_a_Xml()
        {

            var _group = new GenericGroup<object>("FakeName", t => false);
            Assert.Throws<ItemNotBelongsToTheGroupException>(() => _group.Add(new object()));
        }
    }


    public class GroupFake : Group<object>
    {
        private readonly Func<bool> _belongsFunc;

        public GroupFake(Func<bool> belongsFunc = null)
        {
            _belongsFunc = belongsFunc ?? (() => true);
        }

        public override string Name { get; set; } = "Fake Name";

        public override bool IsBelong(object item)
        {
            return _belongsFunc();
        }
    }

}

