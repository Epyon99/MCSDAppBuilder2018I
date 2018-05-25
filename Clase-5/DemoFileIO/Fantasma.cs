using System;
using System.Runtime.Serialization;

namespace DemoFileIO
{
    [Serializable]
    public class Fantasma : ISerializable
    {
        public Fantasma()
        {

        }
        public Fantasma(SerializationInfo info, StreamingContext ctx)
        {
            Nombre = (string) info.GetValue("Nombre", typeof(string));
            NumeroDeSustos = (int) info.GetValue("NumeroDeSustos", typeof(int));
        }

        public string Nombre { get; set; }
        public int NumeroDeSustos {get;set;}
        public void Asustar()
        {
            NumeroDeSustos++;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if(info == null)
            {
                throw new System.ArgumentNullException("info");
            }

            info.AddValue("Nombre", Nombre);
            info.AddValue("NumeroDeSustos", NumeroDeSustos);
        }

        public override string ToString()
        {
            return $"{Nombre} - ha asustado {NumeroDeSustos} veces";
        }
    }
}
