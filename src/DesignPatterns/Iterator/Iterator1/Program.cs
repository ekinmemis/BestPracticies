using System;

namespace Iterator1
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleContainer sampleContainer = new SampleContainer();

            /*
             foreach(SampleObject s in sampleContainer)
                Console.WriteLine(s.Value);
             */

            SampleIterator sampleIterator = (SampleIterator)sampleContainer.GetEnumerator();

            while (sampleIterator.MoveNext())
                Console.WriteLine(((SampleObject)sampleIterator.Current).Value);

        }
    }
}
