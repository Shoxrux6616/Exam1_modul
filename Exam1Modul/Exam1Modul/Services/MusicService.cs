using Exam1Modul.DataAcces.Entities;
using Exam1Modul.Repositories;
using Exam1Modul.Services.DTOs;

namespace Exam1Modul.Services;

public class MusicService : IMusicService
{
    private readonly IRepositoryService _repositoryService;

    public MusicService()
    {
        _repositoryService = new RepositoryService();
    }

    public MusicDto GetAllMostLikedMusik()
    {

    }

    public List<MusicDto> GetAllMusicAbovieSize(double minSize)
    {
        throw new NotImplementedException();
    }

    private List<MusicDto> GetAllMusicAuthorName(string name)
    {
        throw new NotImplementedException();
    }

    public List<string> GetAllUniqueAuthors()
    {
        throw new NotImplementedException();
    }

    public List<MusicDto> GetMusicWithLikesInRange(int maxLikes, int minLikes)
    {
        throw new NotImplementedException();
    }

    public List<MusicDto> GetMusikByDiscriptionKeyword(string keyword)
    {
        throw new NotImplementedException();
    }

    public List<MusicDto> GetTopMostLikedMusik(int count)
    {
        throw new NotImplementedException();
    }

    public double GetTotalMusikSizeAuthor(string authorName)
    {
        throw new NotImplementedException();
    }

    private Music ConvertToEntitiy(MusicDto dto)
    {
        return new Music()
        {
            Id = dto.Id,
            Name = dto.Name,
            AuthorName = dto.AuthorName,
            Description = dto.Description,
            MB = dto.MB,
            QuentityLike = dto.QuentityLike,
        };
    }

    private Music ConvertToEntitiy(CreadMusicDto dto)
    {
        return new Music()
        {
            Id = Guid.NewGuid(),
            Name = dto.Name,
            AuthorName = dto.AuthorName,
            Description = dto.Description,
            MB = dto.MB,
            QuentityLike = dto.QuentityLike,
        };
    }

    private MusicDto ConvertToDto(Music dto)
    {
        return new MusicDto()
        {
            Id = dto.Id,
            Name = dto.Name,
            AuthorName = dto.AuthorName,
            Description = dto.Description,
            MB = dto.MB,
            QuentityLike = dto.QuentityLike,
        };
    }

    public MusicDto GetMusikById(Guid musikId)
    {
        var entity = _repositoryService.GetByMusikId(musikId);
        var dto = ConvertToDto(entity);
        return dto;
    }

    List<MusicDto> IMusicService.GetAllMusicAuthorName(string name)
    {
        throw new NotImplementedException();
    }
}
