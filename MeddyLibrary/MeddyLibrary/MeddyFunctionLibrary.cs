namespace MeddyExplorerLibrary
{
    /// <summary>
    /// Collection of functions for using Meddy.
    /// </summary>
    public static class MeddyFunctionLibrary
    {
        /// <summary>
        /// File extension used for meddydata files.
        /// </summary>
        public const string MeddydataFileExtension = ".xmp";

        /// <summary>
        /// Given a path to a file or directory, get the path to its corresponding meddydata sidecar file.
        /// </summary>
        public static string GetMeddydataSidecarPathFromFilePath(string inFilePath, bool inIsDirectory)
        {
            if (inIsDirectory == false)
            {
                return (inFilePath + MeddydataFileExtension);
            }
            else
            {
                return (inFilePath + Path.DirectorySeparatorChar + MeddydataFileExtension);
            }
        }

        /// <summary>
        /// Given a path to a meddydata sidecar file, get the path to its corresponding file or directory.
        /// This may be null.
        /// </summary>
        public static string? GetFilePathFromMeddydataSidecarPath(string inMeddydataSidecarPath)
        {
            if (inMeddydataSidecarPath.EndsWith(MeddydataFileExtension) == false)
            {
                return null;
            }

            return Path.TrimEndingDirectorySeparator(inMeddydataSidecarPath.Remove(inMeddydataSidecarPath.LastIndexOf(MeddydataFileExtension)));
        }

        /// <summary>
        /// Safely compares whether two given paths lead to the same location.
        /// </summary>
        public static bool FilePathsAreEqual(string inPathA, string inPathB)
        {
            return string.Equals(
                Path.TrimEndingDirectorySeparator(Path.GetFullPath(inPathA)),
                Path.TrimEndingDirectorySeparator(Path.GetFullPath(inPathB)),
                StringComparison.InvariantCultureIgnoreCase
            );
        }
    }
}
