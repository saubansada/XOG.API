//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XOG.AppCode.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderVW
    {
        public Nullable<long> ViewInfoId { get; set; }
        public long OrderId { get; set; }
        public long Id { get; set; }
        public Nullable<long> ReturnDetailId { get; set; }
        public Nullable<long> ReturnId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public byte OrderState { get; set; }
        public Nullable<System.DateTime> DeliveredDate { get; set; }
        public Nullable<System.DateTime> DispatchedDate { get; set; }
        public Nullable<int> IsReturn { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AreaCode { get; set; }
        public string FullName { get; set; }
        public string GPS { get; set; }
        public string OrderedPhoneNumber { get; set; }
        public string ProductName { get; set; }
        public long ProductId { get; set; }
        public long ProductVariantId { get; set; }
        public string QuantityMeasureName { get; set; }
        public string Acronym { get; set; }
        public short QuantityMeasureId { get; set; }
        public long OrderToAddressId { get; set; }
        public string ImageUrl { get; set; }
        public long ImageId { get; set; }
        public double Price { get; set; }
        public double DiscPrice { get; set; }
        public double Discount { get; set; }
        public int OrderedQuantity { get; set; }
        public Nullable<int> ReturnOrderStatus { get; set; }
        public Nullable<int> TotalQuantity { get; set; }
        public Nullable<int> ReturnedQuantity { get; set; }
        public Nullable<int> TotalReturnedQuantity { get; set; }
        public short Gst { get; set; }
        public double OrderedTotal { get; set; }
        public Nullable<double> ReturnTotal { get; set; }
        public Nullable<double> ReturnTotalSum { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<System.DateTime> ReturnOrderDate { get; set; }
    }
}
