using System;

namespace FileManagerBackend.Models {
    public class File {
        public int FileID {get; set;}
        public required string FileName {get; set;}
        public required string FilePath {get; set;}
        public DateTime DateCreated {get; set;}
        public DateTime DateModified {get; set;}
    }
}