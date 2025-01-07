using Exam1Modul.DataAcces.Entities;
using System.Text.Json;
using System.Threading.Tasks;

namespace Exam1Modul.Repositories;

public class RepositoryService : IRepositoryService
{
    private List<Music> _musicList;
    private string _path;

    public RepositoryService()
    {
        _musicList = new List<Music>();
        _path = "../../../DataAccess/Data/Music.json";
        if (File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }
        _musicList = GetAll();
    }

    public void DeleteMusik(Guid id)
    {
        var musik = GetByMusikId(id);
        _musicList.Remove(musik);
        SaveDada();
    }

    private void SaveDada()
    {
        var musicJson = JsonSerializer.Serialize(_musicList);
        File.WriteAllText(_path, musicJson);
    }

    public List<Music> GetAll()
    {
        var jsonMusik = File.ReadAllText(_path);
        List<Music> musiks = JsonSerializer.Deserialize<List<Music>>(jsonMusik);
        return musiks;
    }

    public Music GetByMusikId(Guid musikId)
    {
        foreach (Music music in _musicList)
        {
            if (music.Id == musikId)
            {
                return music;
            }
        }
        throw new Exception($"Xatolik Bor Bunday Id topilmadi {musikId}");
    }

    public Guid Read(Music music)
    {
        _musicList.Add(music);
        SaveDada();
        return music.Id;
    }

    public void UpdateMusik(Guid id)
    {
        var musicFromDb = GetByMusikId(id);
        var index = _musicList.IndexOf(musicFromDb);
        _musicList[index] = musicFromDb;
        SaveDada() ;
    }
}
