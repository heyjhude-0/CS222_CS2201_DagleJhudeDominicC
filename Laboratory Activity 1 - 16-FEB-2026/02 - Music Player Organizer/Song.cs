using System.Globalization;


Console.Write("Songs to add: ");
int n = Convert.ToInt32(Console.ReadLine());

Song[] songs = new Song[n];


for (int i = 0; i < n; i++)
{
    Song song = new Song();
    Console.WriteLine($"\nSong #{i + 1}");
    Console.Write("Title: ");
    string titleInput = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(titleInput))
        song.title = titleInput;

    Console.Write("Artist: ");
    string artistInput = Console.ReadLine()!;
    if (!string.IsNullOrWhiteSpace(artistInput))
        song.artist = artistInput;


    Console.Write("Duration (minutes): ");
    string durationInput = Console.ReadLine()!;
    if (!string.IsNullOrWhiteSpace(durationInput))
        double.TryParse(durationInput, NumberStyles.Float, CultureInfo.InvariantCulture, out song.duration);

    songs[i] = song;
}

Console.WriteLine("\n======= || MY PLAYLIST || =======");
Console.WriteLine($"{"Title",-15} {"Artist",20} {"Duration",15}");
Console.WriteLine(new string('-', 60));
for (int i = 0; i < songs.Length; i++)
{
    songs[i].DisplaySong();
}
public class Song
{
    public string title;
    public string artist;
    public double duration;

    public Song()
    {
        this.title = "Unknown";
        this.artist = "Unknown";
        this.duration = 0.0;
    }

    public Song(string title, string artist, double duration)
    {
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }

    public Song(string title, string artist)
    {
        this.title = title;
        this.artist = artist;
        this.duration = 0.0;
    }

    public Song(string title) : this(title, "Undeclared", 0.0)
    {

    }

    public void DisplaySong()
    {
        Console.WriteLine($"{title,-15} {artist,20} {duration,15}");
  
    }
}
