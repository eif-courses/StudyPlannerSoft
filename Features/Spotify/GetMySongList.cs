using FastEndpoints;

namespace StudyPlannerSoft.Features.Spotify;

public class PlaylistRequest
{
    public string? Name { get; set; } = string.Empty;
}

public class SongResponse
{
    public string Title { get; set; } = string.Empty;
    public string Artist { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;

    public string PlaylistName { get; set; } = string.Empty;
}

public class GetMySongList : Endpoint<PlaylistRequest, List<SongResponse>>
{
    public override void Configure()
    {
        Get("/spotify/playlist");
        AllowAnonymous();
    }

    public override async Task HandleAsync(PlaylistRequest req, CancellationToken ct)
    {
        List<SongResponse> songs = new()
        {
            new SongResponse()
            {
                Title = "My Song",
                Artist = "Michael",
                Url = "https://spotify.com/track",
                PlaylistName = "Old good"
            },
            new SongResponse()
            {
                Title = "My Song",
                Artist = "Michael",
                Url = "https://spotify.com/track2",
                PlaylistName = "Top Hits"
            }
        };

        
        if (req.Name is not null)
        {
            await SendAsync(songs, 200, ct);
            return;
        }
        
        var filteredSongs = songs.Where(x =>
            x.PlaylistName == req.Name).ToList();
        
        await SendAsync(filteredSongs, 200, ct);
    }
}