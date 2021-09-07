using System.Collections.Generic;
using System.Linq;
using XOG.AppCode.DAL;

namespace XOG.AppCode.Transformers
{
    public static class AddressTransformer
    {
        public static string GetAddress(this Address address)
        {
            string addressText = "NA";
            if (address != null)
            { 
                string temp = address.Locality.Trim() + "," + address.CityTown.Trim() + "," + address.StateProvinces.Trim() + ","
                                     + address.Country.Trim() + ".";
                addressText = temp.Replace(",,,,", ",").Replace(",,,", ",").Replace(",,", ",").Replace(",.", ".").Replace(",", ", ");
                  
            }
            return addressText;
        }
         
        public static List<string> TransformToStringList(this ICollection<Address> collection, object obj = null)
        {
            return collection == null ? null : collection.Select(model => model.GetAddress()).ToList();
        }
    }
}