namespace Iterator
{
    class ArrayIterator : Iterator
    {
        private IkDepartmani ik = new IkDepartmani();
        int index = 0;
        public object GetItem()
        {
            Calisan calisan = ik.GetCalisanlar()[index];
            ++index;
            return calisan;
        }

        public bool Next()
        {
            if (index < ik.GetCalisanlar().Length)
                return true;
            else
                return false;
        }
    }
}
