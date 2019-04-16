using System.Globalization;
using System;
using Xunit;
using System.IO;
using Lesson01.FileExamples;

namespace Lesson01.Test
{
    public class file_io_test
    {
        public Lesson01.FileExamples.FileExample ExampleObj;

        public file_io_test()
        {
            ExampleObj = new Lesson01.FileExamples.FileExample();
        }

        [Fact]
        public void Test_SaveSimpleTextFile()
        {
            var fileName = ExampleObj.SaveSimpleTextFile();
            var text = File.ReadAllText(fileName);
        }

        [Fact]
        public void Test_ReadWordsDotText_ReturnNumberOf()
        {
            var words = System.IO.File.ReadAllLines("assets/words.txt");
            var pattern = "Ad";
            var count = 0;
            foreach(var w in words)
            {
                if( w.StartsWith(pattern, false, CultureInfo.CurrentCulture)) ++count;
            }
            var result = ExampleObj.ReadWordsDotText_ReturnNumberOf("wo");
            Assert.Equal(count, result);
        }
    }
}
