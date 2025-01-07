using Exam1Modul.DataAcces.Entities;

namespace Exam1Modul.Repositories;

public interface IRepositoryService
{
    Guid Read(Music music);
    void DeleteMusik(Guid id);
    void UpdateMusik(Guid id);
    List<Music> GetAll();
    Music GetByMusikId(Guid musikId);

}