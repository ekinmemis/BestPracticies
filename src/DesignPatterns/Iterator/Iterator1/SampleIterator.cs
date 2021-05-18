using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator1
{
    class SampleIterator : IEnumerator
    {
        private int p = -1;
        private SampleContainer _container;

        public SampleIterator(SampleContainer sampleContainer)
        {
            _container = sampleContainer;
        }

        public object Current
        {
            get
            {
                return _container.Items[p];
            }
        }

        public bool MoveNext()
        {
            if (p<_container.Items.Length-1)
            {
                ++p;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            p = 0;
        }
    }
}
