//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentbuddy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            this.OrderMs = new HashSet<OrderM>();
        }
    
        public int Vehicle_ID { get; set; }

        [Required(ErrorMessage = "Please enter category name!")]
        [Display(Name = "Category Name")]
        public int Category_ID { get; set; }

        [Required(ErrorMessage = "Please enter vehicle name!")]
        [Display(Name = "Vehicle Name")]
        public string Vehicle_Name { get; set; }

        [Required(ErrorMessage = "Please enter vehicle license no!")]
        [Display(Name = "License No")]
        public int Vehicle_LicenseNO { get; set; }

        [Required(ErrorMessage = "Please enter vehicle Status!")]
        [Display(Name = "Vehicle Status")]
        public string Vehicle_Status { get; set; }

        [Display(Name = "Vehicle Image")]
        public string Vehicle_Image { get; set; }

        [Required(ErrorMessage = "Please enter vehicle engine name!")]
        [Display(Name = "Vehicle Engine")]
        public string Vehicle_Engine { get; set; }

        [Display(Name = "Rent Price")]
        public Nullable<double> Vehicle_Price { get; set; }

        public HttpPostedFileBase VehicleImageFile { get; set; }


        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderM> OrderMs { get; set; }
    }
}
