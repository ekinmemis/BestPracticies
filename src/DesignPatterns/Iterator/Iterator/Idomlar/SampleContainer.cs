using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Idomlar
{
    class SampleContainer : IEnumerable
    {
        public SampleObject[] Items { get; }

        public SampleContainer()
        {
            Items = new SampleObject[5]
            {
                new SampleObject(){Value=1},
                new SampleObject(){Value=2},
                new SampleObject(){Value=3},
                new SampleObject(){Value=4},
                new SampleObject(){Value=5}
            };
        }

        public IEnumerator GetEnumerator()
        {
            return new SampleIterator(this);
        }
    }
}
