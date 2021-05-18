
namespace Iterator
{
    class ListIterator : Iterator
    {
        private AdkDepartmani adk = new AdkDepartmani();
        int index = 0;


        public object GetItem()
        {
            Calisan calisan = adk.GetCalisanlar()[index];
            ++index;
            return calisan;
        }

        public bool Next()
        {
            if (index < adk.GetCalisanlar().Count)
                return true;
            else
                return false;
        }
    }
}
