using NzbDrone.Core.Music;

namespace NzbDrone.Core.MetadataSource
{
    public interface IProvideArtistInfo
    {
        Artist GetArtistInfo(string lidarrId, int metadataProfileId);
    }
}
