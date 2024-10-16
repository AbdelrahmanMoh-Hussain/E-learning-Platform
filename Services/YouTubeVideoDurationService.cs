using E_learning_Platform.Services.Interfaces;
using System.Web;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Threading.Tasks;
using System.Xml;

namespace E_learning_Platform.Services
{
    public class YouTubeVideoDurationService : IYouTubeVideoDurationService
    {
        public string GetVideoId(string videoUrl)
        {
            var uri = new Uri(videoUrl);
            var query = HttpUtility.ParseQueryString(uri.Query);
            return query["v"];
        }

        public async Task<string> GetYouTubeVideoDuration(string videoUrl)
        {
            string videoId = GetVideoId(videoUrl);
            string apiKey = "AIzaSyCTXiKeyFGPAVoNQiP9HjwwXNmeArmY0N8";  // Replace with your YouTube Data API key

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = apiKey,
                ApplicationName = "Youtube"
            });

            var videoRequest = youtubeService.Videos.List("contentDetails");
            videoRequest.Id = videoId;

            var videoResponse = await videoRequest.ExecuteAsync();
            var video = videoResponse.Items[0];
            var duration = video.ContentDetails.Duration;

            return duration;
        }

        public TimeSpan ParseYouTubeDuration(string isoDuration)
        {
            return XmlConvert.ToTimeSpan(isoDuration); // Converts to TimeSpan
        }

        public async Task<string> GetYouTubeVideoWithPrograss(string videoUrl, int progress)
        {
            var durationIso = await GetYouTubeVideoDuration(videoUrl); // Get duration in ISO 8601 format (PT2M30S)
            TimeSpan totalDuration = ParseYouTubeDuration(durationIso); // Convert to TimeSpan

            // Step 2: Calculate the start time based on the user's progress
            double totalSeconds = totalDuration.TotalSeconds; // Get total duration in seconds
            double startTime = (totalSeconds * progress) / 100; // Calculate the starting point based on progress

            // Step 3: Modify the YouTube URL to include the start time (in seconds)
            string videoId = GetVideoId(videoUrl); // Extract the video ID from the URL
            string modifiedUrl = $"https://www.youtube.com/watch?v={videoId}&t={(int)startTime}";
            return modifiedUrl;
        }

    }
}
