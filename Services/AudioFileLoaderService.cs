namespace AudioFileLoader.Services;
public class AudioFileLoaderService: IAudioFileLoaderService
{
	public AudioFileLoaderService()
	{
		Console.WriteLine("Constructor of AudioFileLoaderService");
	}
	public Task LoadAudioFileAsync(string filePath)
	{
		throw new NotImplementedException();
	}
}