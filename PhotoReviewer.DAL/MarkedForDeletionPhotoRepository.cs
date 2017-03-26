using Common.Logging;
using JetBrains.Annotations;
using PhotoReviewer.DAL.Model;

namespace PhotoReviewer.DAL
{
    internal class MarkedForDeletionPhotoRepository : PhotoInfoRepository<MarkedForDeletionPhoto>
    {
        public MarkedForDeletionPhotoRepository([NotNull] ILog logger) : base(logger)
        {
        }

        protected override MarkedForDeletionPhoto CreatePhotoInfo(string filePath)
        {
            return new MarkedForDeletionPhoto(filePath);
        }
    }
}