using System.IO;
using System.Linq;
using AudioFileAssistant.Models;
using TagLib;
using System.Collections.Generic;
using System;

namespace AudioFileAssistant.Helpers
{
    public static class DirectoryHelper
    {
        public static bool IsValidDirectory(string path)
        {
            if (string.IsNullOrEmpty(path) || !Directory.Exists(path))
            {
                return false;
            }
            return true;
        }

        public static List<string> GetAudioFiles(string folderPath)
        {
            var files = Directory.GetFiles(folderPath)
                .Where(file => FileHelper.ValidAudioFileExtensions.Contains((new FileInfo(file)).Extension.ToLower()));

            return files.ToList();
        }

        public static void CopyAudioTags(List<string> sourceFiles, List<string> targetFiles)
        {
            var sourceFilesWithTags = sourceFiles.Select(file => TagLib.File.Create(file));
            sourceFilesWithTags.OrderBy(file => file.Tag.Track);
            var targetFilesWithTags = targetFiles.Select(file => TagLib.File.Create(file));
            targetFilesWithTags.OrderBy(file => file.Tag.Track);

            var skipCounter = 0;

            foreach (var file in sourceFilesWithTags)
            {
                var target = targetFilesWithTags.Skip(skipCounter).FirstOrDefault();
                var tags = GetTags(target);

                CopyTags(file.Tag, ref tags);
                target.Save();

                skipCounter++;
            }
        }

        private static void CopyTags(Tag sourceTags, ref Tag targetTags)
        {
            targetTags.AlbumArtists = sourceTags.AlbumArtists;
            targetTags.Album = sourceTags.Album;
            targetTags.Track = sourceTags.Track;
            targetTags.Year = sourceTags.Year;
            targetTags.Title = sourceTags.Title;
            targetTags.Performers = sourceTags.Performers;
            targetTags.Composers = sourceTags.Composers;
            targetTags.Genres = sourceTags.Genres;
            targetTags.Conductor = sourceTags.Conductor;
            targetTags.Disc = sourceTags.Disc;
            targetTags.Comment = sourceTags.Comment;
        }

        private static Tag GetTags(TagLib.File target)
        {
            if (target.MimeType.Contains("mp3") || target.MimeType.Contains("wav"))
            {
                return target.GetTag(TagTypes.Id3v2);
            }
            else if (target.MimeType.Contains("flac"))
            {
                return target.GetTag(TagTypes.FlacMetadata);
            }

            return target.GetTag(TagTypes.None);
        }
    }
}
