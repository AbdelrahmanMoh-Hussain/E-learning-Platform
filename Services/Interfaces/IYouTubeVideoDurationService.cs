namespace E_learning_Platform.Services.Interfaces
{
    public interface IYouTubeVideoDurationService
    {
        public string GetVideoId(string videoUrl);
        public Task<string> GetYouTubeVideoDuration(string videoUrl);
        public TimeSpan ParseYouTubeDuration(string isoDuration);
        public Task<string> GetYouTubeVideoWithPrograss(string videoUrl, int progress);


    }
}
