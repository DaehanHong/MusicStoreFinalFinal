namespace MusicStore.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Album")]
    // To store variables such as albumId, genre Id, Artist Id, Title, price, and albumArtUrl, etc.
    public partial class Album
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            Carts = new HashSet<Cart>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int AlbumId { get; set; }

        public int GenreId { get; set; }

        public int ArtistId { get; set; }

        [Required]
        [StringLength(160)]
        public string Title { get; set; }

        [Column(TypeName = "numeric")]
        [Range(0, 100000, ErrorMessage = "Not a valid price")]
        [DataType(DataType.Currency )]
        public decimal Price { get; set; }

        [StringLength(1024)]
        [Display(Name = "Artist cover")]
        public string AlbumArtUrl { get; set; }

        [JsonIgnore]
        public virtual Artist Artist { get; set; }

        [JsonIgnore]
        public virtual Genre Genre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
