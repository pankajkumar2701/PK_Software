using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PKSoftware.Model
{
    /// <summary> 
    /// Represents a sales entity with essential details
    /// </summary>
    public class Sales
    {
        /// <summary>
        /// Primary key for the Sales 
        /// </summary>
        [Key]
        public Guid SalesId { get; set; }
        /// <summary>
        /// Name of the Sales 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ProductId of the Sales 
        /// </summary>
        public Guid ProductId { get; set; }
        /// <summary>
        /// CustomerId of the Sales 
        /// </summary>
        public string CustomerId { get; set; }
    }
}