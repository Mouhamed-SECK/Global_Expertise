using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using GlobalExpertise.Utils;
namespace GlobalExpertise.models
{
    public class Product : EntityValidator
    {
        public Product()
        {
            this.Code = GlobalExpertise.Utils.Utils.RandomString(10);
        }

        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        
        public int CategoryId  { get; set; }

        [Required]
        public byte[] ProductImage { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }


     /*   [NotMapped]
        public Image  ConvertedImage 
        {
            set
            {
                 ByteArrayToImage(this.ProductImage);
            }
            get
            {
                return ConvertedImage;
            }
        } */
    

    public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {

                return Image.FromStream(ms);
            }
        }



    }
}
