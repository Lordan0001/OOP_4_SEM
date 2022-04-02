using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LAB_2
{
    [Serializable]
    public  class Student : HumanFactory,IFigure
    {
        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }
        public object DeepCopy()
        {
            object figure = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                figure = binFormatter.Deserialize(tempStream);
            }
            return figure;
        }
        [StringLength(50, MinimumLength = 1),Required]
        public string SecondName { get; set; }
        [StringLength(50, MinimumLength = 1), Required]
        public string FirstName { get; set; }
        [StringLength(50, MinimumLength = 1), Required]
        public string ThirdName { get; set; }
        [StringLength(50, MinimumLength = 1), Required]
        public string Age { get; set; }
        [StringLength(50, MinimumLength = 1), Required]
        public string Specialinost{ get; set; }
        [StringLength(50, MinimumLength = 1), Required]
        public string BirthDate { get; set; }
        [StringLength(50, MinimumLength = 1), Required]
        public string Curs { get; set; }
        [StringLength(50, MinimumLength = 1), Required]
        public string Group { get; set; }
        [StringLength(50, MinimumLength = 1), Required]
        public string Ocenka { get; set; }
        [StringLength(50, MinimumLength = 1), Required]
        public string Sex { get; set; }
        public override Status createStatus()
        {
            return new StStatus();
        }

        public override Wanna createWanna()
        {
            return new StWanna();
        }

    }
}
