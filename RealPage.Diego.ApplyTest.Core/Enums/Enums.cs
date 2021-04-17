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
}
