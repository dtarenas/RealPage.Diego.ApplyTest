namespace RealPage.Diego.ApplyTest.Core.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Roles Enum
    /// </summary>
    public enum Roles
    {
        /// <summary>
        /// The admin
        /// </summary>
        [Display(Name = "Administrator")]
        Admin = 1,

        /// <summary>
        /// The user
        /// </summary>
        [Display(Name =  "User Standard")]
        User = 2
    }

    /// <summary>
    /// Record Status Enum
    /// </summary>
    public enum RecordStatus
    {
        /// <summary>
        /// The disable
        /// </summary>
        [Display(Name = "Disable")]
        Disable = 0,

        /// <summary>
        /// The enable
        /// </summary>
        [Display(Name = "Enable")]
        Enable = 1
    }

    /// <summary>
    /// Additional Filters
    /// </summary>
    public enum AdditionalFilters
    {
        /// <summary>
        /// The by language
        /// </summary>
        [Display(Name = "By Language")]
        ByLanguage = 1,

        /// <summary>
        /// The by genre
        /// </summary>
        [Display(Name = "By Genre")]
        ByGenre = 2,

        /// <summary>
        /// The by channel
        /// </summary>
        [Display(Name = "By Channel")]
        ByChannel = 3
    }
}
