
using Exam1Modul.Services.DTOs;

namespace Exam1Modul.Services;

public interface IMusicService
{
    List<MusicDto> GetAllMusicAuthorName(string name);
    MusicDto GetAllMostLikedMusik();
    List<MusicDto> GetAllMusicAbovieSize(double minSize);
    List<MusicDto> GetTopMostLikedMusik(int count);
    List<MusicDto> GetMusikByDiscriptionKeyword(string keyword);
    List<MusicDto> GetMusicWithLikesInRange(int maxLikes, int minLikes);
    List<string> GetAllUniqueAuthors();
    double GetTotalMusikSizeAuthor(string authorName);
    MusicDto GetMusikById(Guid musikId);


}