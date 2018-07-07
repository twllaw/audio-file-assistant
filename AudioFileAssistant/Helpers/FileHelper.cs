using System;
using System.IO;
using AudioFileAssistant.Models;
using System.Linq;

namespace AudioFileAssistant.Helpers
{
    public static class FileHelper
    {
        public static readonly string[] ValidAudioFileExtensions = { ".mp3", ".flac", ".wav", ".m4a" };

        internal static RenameResult RemoveStringsWithinFileNames(string directory, string toRemove, string replacementStr = "")
        {
            try
            {
                var fileInfoList = (new DirectoryInfo(@directory)).GetFiles();
                var matchingFilesExist = fileInfoList != null && fileInfoList.Any(f => f.Name.Contains(toRemove));

                foreach (var fileInfo in fileInfoList)
                {
                    Console.WriteLine($"Current file is {fileInfo.Name}");

                    if (string.IsNullOrEmpty(toRemove))
                    {
                        RenameIndividualFile(fileInfo, GetPreTrackNumberString(fileInfo.FullName, fileInfo.Name, fileInfo.Extension), 
                            replacementStr);
                    }
                    else if (fileInfo.Name.Contains(toRemove))
                    {
                        RenameIndividualFile(fileInfo, toRemove, replacementStr);
                    }
                }

                if (!string.IsNullOrEmpty(toRemove) && !matchingFilesExist)
                {
                    return new RenameResult
                    {
                        Success = false,
                        Message = "No files were found to have file names that has that string, dude"
                    };
                }

                return new RenameResult
                {
                    Success = true,
                    Message = "Success!(?) Go check the files..."
                };
            }
            catch (DirectoryNotFoundException)
            {
                return new RenameResult
                {
                    Success = false,
                    Message = "ERROR: Dude, are you sure this is the right folder?"
                };
            }
            catch (Exception e)
            {
                return new RenameResult
                {
                    Success = false,
                    Message = $"ERROR: Ugh, something went wrong - {e.Message}" 
                };
            }
        }

        private static string GetPreTrackNumberString(string filePath, string fileName, string fileExtension)
        {
            try
            {
                if (!ValidAudioFileExtensions.Contains(fileExtension.ToLower()))
                {
                    return string.Empty;
                }

                var trackNumber = TagLib.File.Create(filePath).Tag.Track.ToString();
                if (trackNumber.Length == 1)
                {
                    trackNumber = $"0{trackNumber}";
                }

                return fileName.Split(new string[] { trackNumber }, StringSplitOptions.None).FirstOrDefault();
            }
            catch
            {
                return string.Empty;
            }
        }

        internal static RenameResult AddTrackNumsToFileNames(string directory)
        {
            bool validFilesExist = false;
            TagLib.File tagFile;

            try
            {
                DirectoryInfo d = new DirectoryInfo(@directory);
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    if (ValidAudioFileExtensions.Contains(f.Extension))
                    {
                        validFilesExist = true;
                        tagFile = TagLib.File.Create(@directory + "\\" + f.Name);
                        AddTrackNumToFileName(f, tagFile.Tag.Track);
                    }                  
                }
                RenameResult result = new RenameResult
                {
                    Success = true,
                    Message = "Success!!!"
                };

                if (!validFilesExist)
                {
                    result.Success = false;
                    result.Message = "Umm, no mp3 files can be found...";
                }

                return result;
            }
            catch (Exception e)
            {
                RenameResult result = new RenameResult
                {
                    Success = false,
                    Message = "ERROR: Ugh, something went wrong - {0}" + e.Message
                };

                return result;
            }
        }

        private static void AddTrackNumToFileName(FileInfo f, uint num)
        {
            File.Move(f.FullName, f.FullName.ToString().Replace(f.Name, 
                (num < 10) ? 
                "0" + num.ToString() + " " + f.Name : 
                num.ToString() + " " + f.Name));
        }

        private static void RenameIndividualFile(FileInfo f, string toBeReplacedStr, string replacementStr)
        {
            if (string.IsNullOrEmpty(toBeReplacedStr))
            {
                return;
            }

            var oldFileName = f.Name;
            var newFileName = f.Name.Replace(toBeReplacedStr, replacementStr);
            File.Move(f.FullName, f.FullName.ToString().Replace(oldFileName, newFileName));
        }
    }
}
