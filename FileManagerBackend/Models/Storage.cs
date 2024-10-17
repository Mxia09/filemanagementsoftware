using System.Collections.Generic;

namespace FileManagerBackend.Models {
    public class Storage {
            public int StorageID { get; set; }
            public string StorageType { get; set; }
            public List<File> Files { get; set; }
    
            public Storage () {
                Files = new List<File>();
            }
    }
}