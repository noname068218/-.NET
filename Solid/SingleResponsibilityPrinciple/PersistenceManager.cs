public class PersistenceManager
{

    private void verify(string fileName, bool overwrite = false)
    {
        if (File.Exists(fileName))
        {
            if (overwrite)
            {
                File.Delete(fileName);
            }
        }
        else
        {
            File.Create(fileName).Close();
        }
    }
    public void Save(Journal journal, string fileName)
    {
        verify(fileName);
        File.WriteAllText(fileName, journal.ToString());
    }
}