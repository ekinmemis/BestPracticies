namespace DMS
{
    public interface IDocumentSystem
    {
        string GetDocument();
        void AddDocument(string path);
    }
}
