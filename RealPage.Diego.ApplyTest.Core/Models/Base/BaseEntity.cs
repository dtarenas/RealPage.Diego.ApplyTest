namespace RealPage.Diego.ApplyTest.Core.Models.Base
{
    using RealPage.Diego.ApplyTest.Core.Enums;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Base Entity
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets the record status.
        /// </summary>
        /// <value>
        /// The record status.
        /// </value>
        [Display(Name = "Record Status")]
        public RecordStatus RecordStatus { get; set; } = RecordStatus.Enable;
    }
}