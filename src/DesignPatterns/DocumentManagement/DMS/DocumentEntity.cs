using System;

namespace DMS
{
    [Serializable]
    public class DocumentEntity
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
