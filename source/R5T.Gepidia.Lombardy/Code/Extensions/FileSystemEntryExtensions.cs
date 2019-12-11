using System;

using R5T.Lombardy;


namespace R5T.Gepidia.Lombardy.Extensions
{
    public static class FileSystemEntryExtensions
    {
        public static FileSystemEntry GetStandardPathFormatEntry(this FileSystemEntry fileSystemEntry, IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            var standardPath = stringlyTypedPathOperator.EnsureWindowsPath(fileSystemEntry.Path);

            var standardPathFileSystemEntry = new FileSystemEntry(standardPath, fileSystemEntry.Type, fileSystemEntry.LastModifiedUTC);
            return standardPathFileSystemEntry;
        }
    }
}
