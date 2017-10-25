using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Boxvolume
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);
 

        [OperationContract]
        double GetVolume(double Length, double Width, double Height);


        [OperationContract]
        double GetSide(double Volume, double side1, double side2);
       
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class box
    {
         

        [DataMember]
        public string request { get; set; }

        [DataMember]
        public double Volume { get; set; }

        [DataMember]
        public double Height { get; set; }

        [DataMember]
        public double Length { get; set; }

        [DataMember]
        public string Width { get; set; }
    }
}
