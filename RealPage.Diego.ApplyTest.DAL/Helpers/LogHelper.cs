namespace RealPage.Diego.ApplyTest.BL.Utils
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using RealPage.Diego.ApplyTest.Core.Constants;
    using System;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Log Helper
    /// </summary>
    internal static class LogHelper
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="entity">The entity.</param>
        internal static void Add(EntityEntry entity)
        {
            var path = CreateDirectory();
            var logString = GetLogString(entity);
            var sw = new StreamWriter(Path.Combine(path, StaticValues.LogFileName), true);
            sw.WriteLine(logString);
            sw.Close();
        }

        #region Logger
        /// <summary>
        /// Creates the directory.
        /// </summary>
        /// <returns>Directory</returns>
        /// <exception cref="Exception">ex.Message</exception>
        private static string CreateDirectory()
        {
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Logs");
            try
            {
                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }

                return basePath;
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Gets the log string.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>Log String</returns>
        private static string GetLogString(EntityEntry entity)
        {
            var tableName = entity.Metadata.GetTableName();
            var pkField = entity.Properties.First(x => x.Metadata.IsPrimaryKey());
            return $"LogId: {Guid.NewGuid()} Registred On: {DateTime.Now:MM/dd/yyyy hh:mm:ss tt} Info: {tableName.ToUpper()} has been {entity.State.ToString().ToUpper()} PK: {pkField.Metadata.Name} {entity.CurrentValues[pkField.Metadata.Name]}";
        }
        #endregion
    }
}