
using System;
using System.IO;
using System.Collections.Generic;

namespace Lesson01.FileExamples
{
    public class FileExample
    {
        /// <summary>
        /// Constructor for the File Example object.
        /// This is the first function that gets called when an object is created.
        /// </summary>
        public FileExample()
        {
            // TODO: Print out "FileExample Construction"
        }

        public int ReadWordsDotText_ReturnNumberOf(string startsWithString)
        {
            // TODO: Read in the words.txt file.
            
            // TODO: Count the number of words that begin with the parameter passed in.

            // TODO: Return the count above.
            return -1;
        }

        public string SaveSimpleTextFile()
        {
            // Save a text file named "mytext.txt"
            // Where does it get saved?  Find it!
            // What if you named it "thesetexts/mytext.txt"
            // Where does it save it then?
            
            // TODO: Return the name of the file you created.
            return "";
        }

        public string FileAppending()
        {
            var fileName = "NameMeSomethingBetter.txt";
            // Save using the method below
            // using( var stream = System.IO.File.AppendText($"{fileName}"))
            // {

            // }
            return fileName;
        }
    }
}