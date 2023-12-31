namespace otpTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataAccount")]
    public partial class DataAccount
    {
        public DataAccount() { }

        public DataAccount(string uid,string email,string password,string name) 
        {
            UID = uid;
            Email = email;
            MatKhau=password;
            TenNguoiDung=name;
        }

        [Key]
        [StringLength(10)]
        public string UID { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNguoiDung { get; set; }
    }
}
