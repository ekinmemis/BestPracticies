using System.Text;

namespace Builder1
{
    class Bmw:Araba
    {
        public string Model { get; set; }
        public Bmw():base()
        {

        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            stringBuilder.AppendFormat("BMW {0} \n\r", Model);

            for (int i = 0; i < OpsiyonelParcalar.Count-1; i++)
                stringBuilder.AppendLine(OpsiyonelParcalar[i] + "\n\r");

            for (int i = 0; i < _zorunluParcalar.Count - 1; i++)
                stringBuilder.AppendLine(_zorunluParcalar[i] + "\n\r");
            
            return stringBuilder.ToString();
        }
    }
}
