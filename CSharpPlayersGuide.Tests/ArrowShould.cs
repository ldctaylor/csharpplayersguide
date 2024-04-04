

using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using System.IO;
using ArrowMaker;

namespace CSharpPlayersGuide.Tests
{
    public class ArrowShould
    {
        [Fact]
        public void BeCreatedAsPerUserChoices()
        {

            string sut_input = "steel\nplastic\n160\n";
            using (StringReader stringReader = new StringReader(sut_input))
            {
                Console.SetIn(stringReader);

                Arrow arrow = Program.MakeArrow();

                //Assert
                Assert.NotNull(arrow);
                Assert.Equal(Arrowhead.Steel, arrow._arrowhead);
                Assert.Equal(Fletching.Plastic, arrow._fletching);
                Assert.Equal(60f, arrow._length);
            }
        }

        [Fact]
        public void HandleInvalidUserInput()
        {

            string sut_input = "\nsgs\n10\n";
            using (StringReader stringReader = new StringReader(sut_input))
            {
                Console.SetIn(stringReader);

                Arrow arrow = Program.MakeArrow();

                //Assert
                Assert.NotNull(arrow);
                Assert.Equal(Arrowhead.Steel, arrow._arrowhead);
                Assert.Equal(Fletching.Plastic, arrow._fletching);
                Assert.Equal(60f, arrow._length);
            }
        }

        //[Fact]
        //public void NotAllowInvalidLengths()
        //{
        //    float sut = Utility.ChooseLength();
        //}
    }
}