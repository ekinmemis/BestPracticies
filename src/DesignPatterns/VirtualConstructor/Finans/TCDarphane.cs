namespace Finans
{
    public class TCDarphane:Darphane
    {
        //Factory Method
        //ConcreateCreator
        public override Para ParaBas(int nominalDeger)
        {
            return new Tl(nominalDeger);
        }
    }
}
