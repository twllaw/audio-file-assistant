using System;
using System.IO;
using AudioFileAssistant.Models;

namespace AudioFileAssistant.Helpers
{
    public static class FileHelper
    {
        public static readonly string[] ValidAudioFileExtensions = { ".mp3", ".flac", ".wav" };

        internal static RenameResult RemoveStringsWithinFileNames(string directory, string toRemove, string replacementStr = "")
        {
            bool validFilesExist = false;

            try
            {
                DirectoryInfo d = new DirectoryInfo(@directory);
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    if (f.Name.Contains(toRemove))
                    {
                        validFilesExist = true;
                        RenameIndividualFile(f, toRemove, replacementStr);
                    }
                }
                RenameResult result = new RenameResult
                {
                    Success = true,
                    Message = "Success!(?) Go check the files..."
                };

                if (!validFilesExist)
                {
                    result.Success = false;
                    result.Message = "No files were found to have file names that has that string, dude";
                }

                return result;
            }
            catch (DirectoryNotFoundException)
            {
                RenameResult result = new RenameResult
                {
                    Success = false,
                    Message = "ERROR: Dude, are you sure this is the right folder?"
                };
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
                    if (f.Extension == ".mp3")
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
            string newFileName, oldFileName;

            oldFileName = f.Name;
            newFileName = f.Name.Replace(toBeReplacedStr, replacementStr);
            File.Move(f.FullName, f.FullName.ToString().Replace(oldFileName, newFileName));
        }
    }
}
