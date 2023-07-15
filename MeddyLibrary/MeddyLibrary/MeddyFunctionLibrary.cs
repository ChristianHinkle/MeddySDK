namespace MeddyLibrary
{
    /// <summary>
    /// Collection of functions for using Meddy.
    /// </summary>
    public static class MeddyFunctionLibrary
    {
        /// <summary>
        /// Meddy-project-relative pathname to the project's meddydata directory.
        /// </summary>
        public const string MeddydataDirectoryPathname = ".meddydata";

        /// <summary>
        /// Given a pathname to a file or directory, get the pathname to its corresponding meddydata.
        /// </summary>
        /// <param name="inFilePathname">Meddy-project-relative pathname to the file or directory.</param>
        public static string GetMeddydataPathnameFromFilePathname(string inFilePathname)
        {
            return (MeddydataDirectoryPathname + Path.DirectorySeparatorChar + inFilePathname);
        }

        /// <summary>
        /// Given a pathname to meddydata, get the pathname to its corresponding file or directory.
        /// </summary>
        /// <param name="inMeddydataPathname">Meddy-project-relative pathname to meddydata.</param>
        public static string GetFilePathnameFromMeddydataPathname(string inMeddydataPathname)
        {
            return inMeddydataPathname.Substring((MeddydataDirectoryPathname.Length - 1) + 2);
        }

        /// <summary>
        /// Safely compare whether two given pathnames lead to the same location.
        /// </summary>
        public static bool PathnamesAreEqual(string inPathnameA, string inPathnameB)
        {
            return string.Equals(
                    Path.TrimEndingDirectorySeparator(Path.GetFullPath(inPathnameA)),
                    Path.TrimEndingDirectorySeparator(Path.GetFullPath(inPathnameB)),
                    StringComparison.InvariantCultureIgnoreCase
                );
        }
    }
}
